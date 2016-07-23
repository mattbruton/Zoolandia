namespace Zoolandia.Genera
{
    public abstract class Bombina : Animal
    {
        public Bombina(string name) 
            : base(name)
        {
            SetBombinaInfo();
        }
        public Bombina(int age) 
            : base(age)
        {
            SetBombinaInfo();
        }
        public Bombina(string name, int age) 
            : base(name, age)
        {
            SetBombinaInfo();
        }
        private void SetBombinaInfo()
        {
            this.Genus = "Bombina";
        }
    }
}