namespace Zoolandia.Genera
{
    public class Marmota : Animal, IAmbulatory
    {
        public Marmota (string name, double height, double weight) : base(name, height, weight) 
        {
            this.Genus = "Marmota";
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