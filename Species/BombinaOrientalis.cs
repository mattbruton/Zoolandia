using Zoolandia.Genera;

namespace Zoolandia.Species
{
    public class BombinaOrientalis : Bombina, IAmphibious
    {
        public BombinaOrientalis(string name)
            : base(name)
        {
            SetBombinaOrientalisInfo();
        }
        public BombinaOrientalis(int age)
            : base(age)
        {
            SetBombinaOrientalisInfo();
        }
        public BombinaOrientalis(string name, int age)
            : base(name, age)
        {
            SetBombinaOrientalisInfo();
        }
        private void SetBombinaOrientalisInfo()
        {
            this.CommonName = "Oriental fire-bellied toad";
            this.ScientificName = "Bombina orientalis";
            this.PrimaryDiet = "Insects";
            this.AverageWeight = 1;
            this.AverageHeight = 1.0;
        }
        public string Eat()
        {
            return this.Name + " munches on some insects, but not mealworms. He has a hard time digesting those!";
        }
        public override string Eat(int numberOfFoods)
        {
            return this.Name + " says: '" + base.Eat(numberOfFoods) + " Thank you, human. " + this.Speak() + "'";
        }
        public override string Speak() 
        {
            return "Ribbit ribbit.";
        }
        public string Walk()
        {
            return this.Name + " is walking.";
        }
        public string Run()
        {
            return this.Name + " is running!";
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