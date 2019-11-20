namespace OOP.Inheritance.MordorsCruelPlan
{
    using System.Text;
    using OOP.Inheritance.MordorsCruelPlan.Moods;

    public class Wizard
    {
        private int happinessPoints;
        private Mood mood;
        private MoodFactory moodFactory;
        private FoodFactory foodFactory;

        public Wizard(string name)
        {
            this.Name = name;
            this.happinessPoints = 0;
            this.moodFactory = new MoodFactory();
            this.foodFactory = new FoodFactory();
        }

        public string Name { get; }

        public void Eat(string foodName)
        {
            var food = this.foodFactory.GetFood(foodName);
            this.happinessPoints += food.Points;
            this.mood = this.moodFactory.GetMood(this.happinessPoints);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.happinessPoints.ToString());
            sb.Append(this.mood.Name);
            return sb.ToString();
        }
    }
}
