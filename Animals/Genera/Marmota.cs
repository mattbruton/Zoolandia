namespace Zoolandia.Animals.Genera
{
    public abstract class Marmota : Animal
    {
        public Marmota (string name) 
            : base(name) 
        {
            SetMarmotaInfo();
        }
        public Marmota(int age)
            : base(age) 
        {
            SetMarmotaInfo();
        }
        public Marmota(string name, int age) 
            : base(name, age) 
        {
            SetMarmotaInfo();
        }
        private void SetMarmotaInfo()
        {
            this.Genus = "Marmota";
        }
    }
}