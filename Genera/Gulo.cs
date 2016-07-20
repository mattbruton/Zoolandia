namespace Zoolandia.Genera
{
    public abstract class Gulo : Animal, IAmbulatory
    {
        public Gulo (string name, double height, double weight) : base(name, height, weight) 
        {
            this.Genus = "Gulo";
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