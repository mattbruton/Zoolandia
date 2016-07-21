using Zoolandia.Genera;

namespace Zoolandia.Species
{
    public class CanisLupusFamiliaris : Canis, IAmbulatory
    {
        public CanisLupusFamiliaris(string name) : base(name)
        {
            this.CommonName = "Domestic dog";
            this.ScientificName = "Canis lupus familiaris";
            this.PrimaryDiet = "Dog Chow";
            this.AverageWeight = 40;
            this.AverageHeight = 23.4;
        }
        
        public override string Eat(int numberOfFoods)
        {
            return base.Eat(numberOfFoods) + " " + this.Name + " eats " + numberOfFoods + " dog treats.";
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
        public bool IsMansBestFriend()
        {
            return true;
        }
    }
}