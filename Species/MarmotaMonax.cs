using Zoolandia.Genera;

namespace Zoolandia.Species
{
    public class MarmotaMonax : Marmota, IAmbulatory
    {
        public MarmotaMonax(string name, double height, double weight) : base(name, height, weight)
        {
            this.CommonName = "Groundhog";
            this.ScientificName = "Marmota monax";
            this.PrimaryDiet = "Air conditioning units";
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
    }
}