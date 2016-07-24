namespace Zoolandia.Habitats
{
    public class Forest : Habitat
    {
        public Forest(string name)
            : base(name)
        {
            this.HasExtremeClimate = false;
        }
        public void SetForestFire()
        {
            this.HasExtremeClimate = true;
        }
        public void ExtinguishForestFire()
        {
            this.HasExtremeClimate = false;
        }
    }
}