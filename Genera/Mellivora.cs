namespace Zoolandia.Genera
{
    public abstract class Mellivora : Animal, IAmbulatory
    {
        public Mellivora (string name, double height, double weight) : base(name, height, weight) 
        {
            this.Genus = "Mellivora";
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