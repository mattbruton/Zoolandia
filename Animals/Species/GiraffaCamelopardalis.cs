using Zoolandia.Animals.Genera;

namespace Zoolandia.Animals.Species
{
    public class GiraffaCamelopardalis : Giraffa, IAmbulatory
    {
        public GiraffaCamelopardalis(string name)
            : base(name)
        {
            SetGiraffaCamelopardalisInfo();
        }
        public GiraffaCamelopardalis(int age)
            : base(age)
        {
            SetGiraffaCamelopardalisInfo();
        }
        public GiraffaCamelopardalis(string name, int age)
            : base(name, age)
        {
            SetGiraffaCamelopardalisInfo();
        }
        private void SetGiraffaCamelopardalisInfo()
        {
            this.CommonName = "Giraffe";
            this.ScientificName = "Giraffa camelopardalis";
            this.PrimaryDiet = "Acacia leaves";
            this.AverageWeight = 2200;
            this.AverageHeight = 204.0;
        }
        public override string Eat(int numberOfFoods)
        {
            return base.Eat(numberOfFoods) + " " + this.Name + " grazes for " + numberOfFoods + " minutes.";
        }
        public string Eat()
        {
            return this.Name + " eats "+ this.PrimaryDiet + " from the nearest tree.";
        }
        public override string Speak()
        {
            return "-silence-";
        }
        public string Walk()
        {
            return this.Name + " is walking.";
        }
        public string Run()
        {
            return this.Name + " is running!";
        }
        public bool HasLongNeck()
        {
            return true;
        }
    }
}