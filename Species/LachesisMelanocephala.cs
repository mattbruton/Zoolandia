using Zoolandia.Genera;

namespace Zoolandia.Species
{
    public class LachesisMelanocephala : Lachesis, ISlither
    {
        public LachesisMelanocephala(string name)
            : base(name)
        {
            SetLachesisMelanocephalaInfo();
        }
        public LachesisMelanocephala(int age)
            : base(age)
        {
            SetLachesisMelanocephalaInfo();
        }
        public LachesisMelanocephala(string name, int age)
            : base(name, age)
        {
            SetLachesisMelanocephalaInfo();
        }
        private void SetLachesisMelanocephalaInfo()
        {
            this.CommonName = "Black-headed bushmaster";
            this.ScientificName = "Lachesis melanocephala";
            this.PrimaryDiet = "Small mammals";
            this.AverageWeight = 8;
            this.AverageHeight = 66.0;
        }
        public string Eat()
        {
            return this.Name + " eats a nearby mouse.";
        }
        public override string Eat(int numberOfFoods)
        {
            return this.Name + " says: '" + base.Eat(numberOfFoods) + " Thank you for this. I will never forget your kindness. " + this.Speak() + "'";
        }
        public override string Speak() 
        {
            return "Hiss.";
        }
        public string Slither()
        {
            return this.Name + " slithers across the ground.";
        }
    }
}