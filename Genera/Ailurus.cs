namespace Zoolandia.Genera
{
    public abstract class Ailurus : Animal, IAmbulatory
    {
        public Ailurus (string name, double height, double weight) : base(name, height, weight) 
        {
            this.Genus = "Ailurus";
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