namespace Zoolandia.Genera
{
    public abstract class Giraffa : Animal, IAmbulatory
    {
        public Giraffa (string name, double height, double weight) : base(name, height, weight) 
        {
            this.Genus = "Giraffe";
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