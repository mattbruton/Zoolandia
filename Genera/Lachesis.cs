namespace Zoolandia.Genera
{
    public abstract class Lachesis : Animal
    {
        public Lachesis(string name)
            : base(name)
        {
            SetLachesisInfo();
        }
        public Lachesis(int age)
            : base(age)
        {
            SetLachesisInfo();
        }
        public Lachesis(string name, int age)
            : base(name, age)
        {
            SetLachesisInfo();
        }
        private void SetLachesisInfo()
        {
            this.Genus = "Lachesis";
        }
    }
}