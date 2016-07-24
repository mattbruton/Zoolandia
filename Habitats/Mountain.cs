namespace Zoolandia.Habitats
{
    public class Mountain : Habitat
    {
        public Mountain(string name)
            : base(name)
        {
            this.HasExtremeClimate = false;
        }
        public bool IsVolcanic { get; set; }
        public string Erupt()
        {
            if (this.IsVolcanic == true)
            {
                return this.Name + " erupts violently!";
            }
            else
            {
                return this.Name + " is not volcanic, silly.";
            }
        }
    }
}