namespace Zoolandia.Genera
{
   public abstract class Canis : Animal
    {
        public Canis (string name) 
            : base(name) 
        {
            SetCanisInfo();
        }
        public Canis(int age)
            : base(age) 
        {
            SetCanisInfo();
        }
        public Canis(string name, int age) 
            : base(name, age) 
        {
            SetCanisInfo();
        }
        private void SetCanisInfo()
        {
            this.Genus = "Canis";
        }
    }
}
