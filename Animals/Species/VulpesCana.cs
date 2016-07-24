using Zoolandia.Animals.Genera;

namespace Zoolandia.Animals.Species
{
    public class VulpesCana : Vulpes, IAmbulatory, IJumping
    {
        public VulpesCana(string name)
            : base(name)
        {
            SetVulpesCanaInfo();
        }
        public VulpesCana(int age)
            : base(age)
        {
            SetVulpesCanaInfo();
        }
        public VulpesCana(string name, int age)
            : base(name, age)
        {
            SetVulpesCanaInfo();
        }
        public void SetVulpesCanaInfo()
        {
            this.CommonName = "Blanford's fox";
            this.ScientificName = "Vulpes cana";
            this.PrimaryDiet = "Seedless grapes";
            this.AverageWeight = 3;
            this.AverageHeight = 12;
        }
        public string Eat()
        {
            return this.Name + " chews on a small grape.";
        }
        public override string Eat(int numberOfFoods)
        {
            return this.Name + " says: '" + base.Eat(numberOfFoods) + " Rat meat!'";
        }
        public override string Speak() 
        {
            return "-crazy banshee wails-";
        }
        public string Hop()
        {
            return this.Name + " hops forward!";
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