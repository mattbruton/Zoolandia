using Zoolandia.Animals.Genera;

namespace Zoolandia.Animals.Species
{
    public class PuffinusNativitatis : Puffinus, IFlying
    {
        public PuffinusNativitatis(string name)
            : base(name)
        {
            SetPuffinusNativitatisInfo();
        }
        public PuffinusNativitatis(int age)
            : base(age)
        {
            SetPuffinusNativitatisInfo();
        } 
        public PuffinusNativitatis(string name, int age)
            : base(name, age)
        {
            SetPuffinusNativitatisInfo();
        }    
        private void SetPuffinusNativitatisInfo()
        {
            this.CommonName = "Christmas shearwater";
            this.ScientificName = "Puffinus nativitatis";
            this.PrimaryDiet = "Fish";
            this.AverageWeight = 1;
            this.AverageHeight = 13.5;
        }
        public string Eat()
        {
            return this.Name + " snatches a fish out of the sea.";
        }
        public override string Eat(int numberOfFoods)
        {
            return this.Name + " says: '" + base.Eat(numberOfFoods) + " I appreciate the squid feast, human. " + this.Speak() + "'";
        }
        public override string Speak() 
        {
            return "CAWWWW.";
        }
        public string Fly()
        {
            return this.Name + " flies across the sky!";
        }
        public string Land()
        {
            return this.Name + " is tired and stops flying.";
        }
    }
}
