using Zoolandia.Genera;

namespace Zoolandia.Species
{
    public class MarmotaMonax : Marmota, IAmbulatory
    {
        public MarmotaMonax(string name) : base(name)
        {
            this.CommonName = "Groundhog";
            this.ScientificName = "Marmota monax";
            this.PrimaryDiet = "Air conditioning units";
            this.AverageWeight = 9;
            this.AverageHeight = 9.5;
        }
        public override string Eat(int numberOfFoods)
        {
            return this.Name + " devours " + numberOfFoods.ToString() + " local pets.";
        }
        public string Eat()
        {
            return this.Name + " eats everything you love.";
        }
        public override string Speak()
        {
            return this.Name + " makes a whistling noise.";
        }
        public string Walk()
        {
            return this.Name + " is walking.";
        }
        public string Run()
        {
            return this.Name + " is running!";
        }
        public string Murder()
        {
            return this.Name + " murders the nearest neighborhood pet.";
        }
    }
}