using Zoolandia.Animals.Genera;

namespace Zoolandia.Animals.Species
{
    public class BombinaLichuanensis : Bombina, IAquatic, IJumping
    {
        public BombinaLichuanensis(string name)
            : base(name)
        {
            SetBombinaLichuanensisInfo();
        }
        public BombinaLichuanensis(int age)
            : base(age)
        {
            SetBombinaLichuanensisInfo();
        }
        public BombinaLichuanensis(string name, int age)
            : base(name, age)
        {
            SetBombinaLichuanensisInfo();
        }
        private void SetBombinaLichuanensisInfo()
        {
            this.CommonName = "Lichuan bell toad";
            this.ScientificName = "Bombina lichuanensis";
            this.PrimaryDiet = "Insects";
            this.AverageWeight = 1;
            this.AverageHeight = 1.0;
        }
        public string Eat()
        {
            return this.Name + " munches on some insects";
        }
        public override string Eat(int numberOfFoods)
        {
            return this.Name + " says: '" + base.Eat(numberOfFoods) + " Thank you, human. " + this.Speak() + "'";
        }
        public override string Speak() 
        {
            return "Ribbit ribbit.";
        }
        public string Hop()
        {
            return this.Name + " hops forward.";
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