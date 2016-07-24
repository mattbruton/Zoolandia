using System.Collections.Generic;


namespace Zoolandia.Habitats
{
    public abstract class Habitat
    {
        public Habitat(string name) 
        {
            this.Name = name;
        }
        public List<Animal> inhabitants = new List<Animal>();
        public string Name { get; set; }
        public bool HasExtremeClimate  { get; set; }
    }
}