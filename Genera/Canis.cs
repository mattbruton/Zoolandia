namespace Zoolandia.Genera
{
    public class Canis : Animal, IAmbulatory
    {
        public Canis (string name, double height, double weight) : base(name, height, weight) 
        {
            this.Genus = "Canis";
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