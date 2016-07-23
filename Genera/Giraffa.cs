namespace Zoolandia.Genera
{
    public abstract class Giraffa : Animal
    {
        public Giraffa (string name) 
            : base(name) 
        {
            SetGiraffaInfo();
        }
        public Giraffa(int age)
            : base(age) 
        {
            SetGiraffaInfo();
        }
        public Giraffa(string name, int age) 
            : base(name, age) 
        {
            SetGiraffaInfo();
        }
        private void SetGiraffaInfo()
        {
            this.Genus = "Giraffa";
        }
    }
}