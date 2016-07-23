namespace Zoolandia.Genera
{
    public abstract class Gulo : Animal
    {
        public Gulo (string name) 
            : base(name) 
        {
            SetGuloInfo();
        }
        public Gulo(int age)
            : base(age) 
        {
            SetGuloInfo();
        }
        public Gulo(string name, int age) 
            : base(name, age) 
        {
            SetGuloInfo();
        }
        private void SetGuloInfo()
        {
            this.Genus = "Gulo";
        }
    }
}