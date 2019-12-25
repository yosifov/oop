namespace OOP.Reflection.HarvestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public class HarvestingFieldsTest
    {
        private Type classType;
        private FieldInfo[] harvestingFields;

        public HarvestingFieldsTest()
        {
            this.classType = typeof(HarvestingFieldsTest)
                .Assembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == "HarvestingFields");
        }

        public void Run(string command)
        {
            switch (command)
            {
                case "private":
                    this.GetPrivateFields();
                    break;
                case "protected":
                    this.GetProtectedFields();
                    break;
                case "public":
                    this.GetPublicFields();
                    break;
                case "all":
                    this.GetAllFields();
                    break;
                default:
                    break;
            }

            Console.WriteLine(this.PrintFields());
        }

        private void GetPrivateFields()
        {
            this.harvestingFields = this.classType
                .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                .Where(f => f.GetCustomAttributes(false).Length == 0 && f.Attributes.ToString().Contains("Private"))
                .ToArray();
        }

        private void GetProtectedFields()
        {
            this.harvestingFields = this.classType
                .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                .Where(f => f.Attributes.ToString().Contains("Family"))
                .ToArray();
        }

        private void GetPublicFields()
        {
            this.harvestingFields = this.classType
                .GetFields(BindingFlags.Public | BindingFlags.Instance);
        }

        private void GetAllFields()
        {
            this.harvestingFields = this.classType
                .GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        }

        private string PrintFields()
        {
            var sb = new StringBuilder();

            foreach (var field in this.harvestingFields)
            {
                if (field.Attributes.ToString().Contains("Family"))
                {
                    sb.AppendLine("protected " + field.FieldType.Name + " " + field.Name);
                }
                else
                {
                    sb.AppendLine(field.Attributes.ToString().ToLower() + " " + field.FieldType.Name + " " + field.Name);
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
