namespace Zoolandia.Genera
{
    public abstract class Vulpes : Animal
    {
        public Vulpes(string name)
            : base(name)
        {
            SetVulpesInfo();
        }
        public Vulpes(int age)
            : base(age)
        {
            SetVulpesInfo();
        }
        public Vulpes(string name, int age)
            : base(name, age)
        {
            SetVulpesInfo();
        }
        private void SetVulpesInfo()
        {
            this.Genus = "Vulpes";
        }
    }
}