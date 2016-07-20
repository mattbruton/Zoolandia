namespace Zoolandia.Species
{
    public class CanisLupusFamiliaris : Animal, IAmbulatory, ICanis
    {
        public CanisLupusFamiliaris(string name, double height, double weight) : base(name, height, weight)
        {
            this.Genus = "Canis";
            this.CommonName = "Domestic dog";
            this.ScientificName = "Canis lupus familiaris";
            this.PrimaryDiet = "Dog Chow";
        }
        
        public override string Eat(int numberOfFoods)
        {
            return this.Name + " eats " + numberOfFoods + " dog treats.";
        }
        public string Eat()
        {
            return this.Name + " reluctantly eats from his dog bowl. :( ";
        }
        public override string Speak()
        {
            return "Bark! Bark!";
        }
        public bool BelongsToCanis()
        {
            return true;
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