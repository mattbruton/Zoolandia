namespace Zoolandia.Animals.Genera
{
    public abstract class Ailurus : Animal
    {
        public Ailurus (string name) 
            : base(name) 
        {
            SetAilurusInfo();
        }
        public Ailurus(int age)
            : base(age) 
        {
            SetAilurusInfo();
        }
        public Ailurus(string name, int age) 
            : base(name, age) 
        {
            SetAilurusInfo();
        }
        private void SetAilurusInfo()
        {
            this.Genus = "Ailurus";
        }
    }
}