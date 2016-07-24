namespace Zoolandia.Habitats
{
    public class Ocean : Habitat
    {
        public Ocean(string name)
            : base(name)
        {
            this.HasExtremeClimate = true;
            this.IsWetter = true;
            this.IsBetter = false;
        }
        private bool IsWetter { get; set; }
        private bool IsBetter { get; set; }
        public void WetterCheck()
        {
            if (IsWetter == true)
            {
                this.IsBetter = true;
            }
        }
        public string BetterCheck()
        {
            if (IsBetter == true)
            {
                return "Under da sea! -lobster music intensifies-";
            }
            else
            {
                return "Check the conditions again, darling.";
            }
        }
    }
}