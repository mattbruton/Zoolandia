namespace Zoolandia.Genera
{
    public class Giraffa : Animal, IAmbulatory
    {
        public Giraffa (string name, double height, double weight) : base(name, height, weight) 
        {
            this.Genus = "Giraffa";
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