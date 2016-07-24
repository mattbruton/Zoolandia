namespace Zoolandia.Genera
{
    public abstract class Puffinus : Animal
    {
        public Puffinus(string name)
            : base(name)
        {
            SetPuffinusInfo();
        }
        public Puffinus(int age)
            : base(age)
        {
            SetPuffinusInfo();
        }
        public Puffinus(string name, int age)
            : base(name, age)
        {
            SetPuffinusInfo();
        }
        private void SetPuffinusInfo()
        {
            this.Genus = "Puffinus";
        }
    }
}