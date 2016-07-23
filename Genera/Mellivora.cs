namespace Zoolandia.Genera
{
    public abstract class Mellivora : Animal
    {
        public Mellivora (string name) 
            : base(name) 
        {
            SetMellivoraInfo();
        }
        public Mellivora(int age)
            : base(age) 
        {
            SetMellivoraInfo();
        }
        public Mellivora(string name, int age) 
            : base(name, age) 
        {
            SetMellivoraInfo();
        }
        private void SetMellivoraInfo()
        {
            this.Genus = "Mellivora";
        }
    }
}