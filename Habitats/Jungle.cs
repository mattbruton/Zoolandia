namespace Zoolandia.Habitats
{
    public class Jungle : Habitat
    {
        public Jungle(string name)
            : base(name)
        {
            this.HasExtremeClimate = true;
        }
    }
}