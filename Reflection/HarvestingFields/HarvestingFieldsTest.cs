namespace OOP.Reflection.HarvestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public class HarvestingFieldsTest
    {
        private Type classType;
        private FieldInfo[] allHarvestingFields;
        private FieldInfo[] currentFields;

        public HarvestingFieldsTest()
        {
            this.classType = typeof(HarvestingFieldsTest)
                .Assembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == "HarvestingFields");

            this.allHarvestingFields = this.classType
                .GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
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
                    throw new ArgumentException("Invalid command!");
            }

            Console.WriteLine(this.PrintFields());
        }

        private void GetPrivateFields()
        {
            this.currentFields = this.allHarvestingFields
                .Where(f => f.IsPrivate)
                .ToArray();
        }

        private void GetProtectedFields()
        {
            this.currentFields = this.allHarvestingFields
                .Where(f => f.IsFamily)
                .ToArray();
        }

        private void GetPublicFields()
        {
            this.currentFields = this.allHarvestingFields
                .Where(f => f.IsPublic)
                .ToArray();
        }

        private void GetAllFields()
        {
            this.currentFields = this.allHarvestingFields;
        }

        private string PrintFields()
        {
            var sb = new StringBuilder();

            foreach (var field in this.currentFields)
            {
                if (field.IsFamily)
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
