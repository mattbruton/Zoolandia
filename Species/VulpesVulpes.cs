using Zoolandia.Genera;

namespace Zoolandia.Species
{
    public class VulpesVulpes : Vulpes, IAmbulatory
    {
        public VulpesVulpes(string name)
            : base(name)
        {
            SetVulpesVulpesInfo();
        }
        public VulpesVulpes(int age)
            : base(age)
        {
            SetVulpesVulpesInfo();
        }
        public VulpesVulpes(string name, int age)
            : base(name, age)
        {
            SetVulpesVulpesInfo();
        }
        public void SetVulpesVulpesInfo()
        {
            this.CommonName = "Red fox";
            this.ScientificName = "Vulpes vulpes";
            this.PrimaryDiet = "Small mammals";
            this.AverageWeight = 23;
            this.AverageHeight = 18;
        }
        public string Eat()
        {
            return this.Name + " chews on a small rat.";
        }
        public override string Eat(int numberOfFoods)
        {
            return this.Name + " says: '" + base.Eat(numberOfFoods) + " Rat meat!'";
        }
        public override string Speak() 
        {
            return "-crazy banshee wails-";
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