using System;

namespace Zoolandia.Species
{
    public class CanisLupusFamiliaris : Animal, IAmbulatory
    {
        public CanisLupusFamiliaris(string name, double height, double weight) : base(name, height, weight)
        {
            this.CommonName = "Domestic dog";
            this.ScientificName = "Canis lupus familiaris";
            this.Genus = "Canis";
        }
        public string Eat()
        {
            return this.Name + " reluctantly eats from his dog bowl. :( ";
        }
        public override string Speak()
        {
            return "Bark! Bark!";
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