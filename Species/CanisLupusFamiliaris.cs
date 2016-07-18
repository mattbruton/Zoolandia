using Zoolandia.Genera;

namespace Zoolandia.Species
{
    public class CanisLupusFamiliaris : Canis, IAmbulatory
    {
        public CanisLupusFamiliaris(string name, double height, double weight) : base(name, height, weight)
        {
            this.CommonName = "Domestic dog";
            this.ScientificName = "Canis lupus familiaris";
            this.PrimaryDiet = "Dog Chow";
        }
        public string Eat()
        {
            return this.Name + " reluctantly eats from his dog bowl. :( ";
        }
        public override string Speak()
        {
            return "Bark! Bark!";
        }
    }
}