using System.Collections.Generic;


namespace Zoolandia.Habitats
{
    public abstract class Habitat
    {
        public Habitat() {}
        public List<Animal> inhabitants = new List<Animal>();
        public string Name { get; set; }
        public string Climate { get; set; }
    }
}