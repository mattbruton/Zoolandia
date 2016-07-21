using Zoolandia.Genera;

namespace Zoolandia.Species
{
    public class GuloGulo : Gulo, IAmbulatory
    {
        public GuloGulo(string name) : base(name)
        {   
            this.CommonName = "Wolverine";
            this.ScientificName = "Gulo gulo";
            this.PrimaryDiet = "Small mammals";
            this.AverageWeight = 35;
            this.AverageHeight = 15.0;
        }
        public override string Eat(int numberOfFoods) 
        {
            return this.Name + " eats your gift and growls at you " + numberOfFoods + " times.";
        }
        public string Eat()
        {
            return this.Name + " says: '" + base.Eat(1) + " Where's the cream filling?'";
        }
        public string MarkTerritory()
        {
            return this.Name + " really stank this place up!";
        }
        public override string Speak() 
        {
            return this.Name + " makes a string of unintelligible, demon noises.";
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