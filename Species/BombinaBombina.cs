using Zoolandia.Genera;

namespace Zoolandia.Species
{
    public class BombinaBombina : Bombina, IAmphibious
    {
        public BombinaBombina(string name)
            : base(name)
        {
            SetBombinaBombinaInfo();
        }
        public BombinaBombina(int age)
            : base(age)
        {
            SetBombinaBombinaInfo();
        }
        public BombinaBombina(string name, int age)
            : base(name, age)
        {
            SetBombinaBombinaInfo();
        }
        private void SetBombinaBombinaInfo()
        {
            this.CommonName = "European fire-bellied toad";
            this.ScientificName = "Bombina bombina";
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