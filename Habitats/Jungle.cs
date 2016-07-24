namespace Zoolandia.Habitats
{
    public class Jungle : Habitat
    {
        public Jungle(string name)
            : base(name)
        {
            this.HasExtremeClimate = true;
        }
        public string Welcome()
        {
            return "Welcome to the " + this.Name + ".";
        }
    }
}