namespace OOP.Interfaces.BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class BorderControl
    {
        private List<IRobot> robots;
        private List<IPerson> citizens;
        private List<IAnimal> pets;
        private List<string> detainedIds;
        private List<string> birthdates;

        public BorderControl()
        {
            this.robots = new List<IRobot>();
            this.citizens = new List<IPerson>();
            this.pets = new List<IAnimal>();
            this.detainedIds = new List<string>();
            this.birthdates = new List<string>();
        }

        public void AddCitizen(string name, int age, string id, string birthdate)
        {
            var citizen = new Citizen(name, age, id, birthdate);
            this.citizens.Add(citizen);
            this.birthdates.Add(citizen.Birthdate);
        }

        public void AddRobot(string model, string id)
        {
            var robot = new Robot(model, id);
            this.robots.Add(robot);
        }

        public void AddPet(string name, string birthdate)
        {
            var pet = new Pet(name, birthdate);
            this.pets.Add(pet);
            this.birthdates.Add(pet.Birthdate);
        }

        public void AddDetainedIds(string match)
        {
            this.detainedIds.AddRange(this.citizens
                .Where(x => x.Id.EndsWith(match))
                .Select(y => y.Id)
                .ToList());

            this.detainedIds.AddRange(this.robots
                .Where(x => x.Id.EndsWith(match))
                .Select(y => y.Id)
                .ToList());
        }

        public string GetDetainedIds(string match)
        {
            var sb = new StringBuilder();
            this.detainedIds.Where(x => x.EndsWith(match)).ToList().ForEach(x => sb.AppendLine(x));

            return sb.ToString().TrimEnd();
        }

        public string GetBirthdatesByYear(string year)
        {
            var searchedBirthdates = this.birthdates.Where(x => x.EndsWith("/" + year)).ToList();
            return string.Join(Environment.NewLine, searchedBirthdates);
        }
    }
}
