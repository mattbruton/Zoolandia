using Zoolandia.Genera;

namespace Zoolandia.Species
{
    public class MegachasmaPelagios : Megachasma, IAquatic
    {
        public MegachasmaPelagios(string name)
            : base(name)
        {
            SetMegachasmaPelagiosInfo();
        }
        public MegachasmaPelagios(int age)
            : base(age)
        {
            SetMegachasmaPelagiosInfo();
        }
        public MegachasmaPelagios(string name, int age)
            : base(name, age)
        {
            SetMegachasmaPelagiosInfo();
        }
        private void SetMegachasmaPelagiosInfo()
        {
            this.CommonName = "Megamouth shark";
            this.ScientificName = "Megachasma pelagios";
            this.PrimaryDiet = "Plankton";
            this.AverageWeight = 2279;
            this.AverageHeight = 177;
        }
        public string Eat()
        {
            return this.Name + " swims around, collecting plankton and jellyfish.";
        }
        public override string Eat(int numberOfFoods)
        {
            return this.Name + " says: '" + base.Eat(numberOfFoods) + " My favorite!'";
        }
        public override string Speak() 
        {
            return "I'm a shark, I'm a shark!";
        }
        public string Swim()
        {
            return this.Name + " is swimming.";
        }
        public string Float()
        {
            return this.Name + " is floating!";
        }
    }
}