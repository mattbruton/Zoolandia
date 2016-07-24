using System.Collections.Generic;


namespace Zoolandia.Habitats
{
    public class Habitat
    {
        public List<Animal> inhabitants = new List<Animal>();
        public string public_name { get; }
    }
}