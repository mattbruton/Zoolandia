using Zoolandia.Genera;

namespace Zoolandia.Species
{
    public class GiraffaCamelopardalis : Giraffa, IAmbulatory
    {
        public GiraffaCamelopardalis(string name) : base(name)
        {
            this.CommonName = "Giraffe";
            this.ScientificName = "Giraffa camelopardalis";
            this.PrimaryDiet = "Acacia leaves";
            this.AverageWeight = 2200;
            this.AverageHeight = 204.0;
        }

        public override string Eat(int numberOfFoods)
        {
            return "";
        }
        public string Eat()
        {
            return "";
        }
        public override string Speak()
        {
            return "";
        }
        public string Walk()
        {
            return this.Name + " is walking.";
        }
        public string Run()
        {
            return this.Name + " is running!";
        }
    }
}