namespace Zoolandia.Animals.Genera
{
    public abstract class Megachasma : Animal
    {
        public Megachasma(string name)
            : base(name)
        {
            SetMegachasmaInfo();
        }
        public Megachasma(int age)
            : base(age)
        {
            SetMegachasmaInfo();
        }
        public Megachasma(string name, int age)
            : base(name, age)
        {
            SetMegachasmaInfo();
        }
        private void SetMegachasmaInfo()
        {
            this.Genus = "Megachasma";
        }
    }
}