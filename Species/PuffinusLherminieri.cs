using Zoolandia.Genera;

namespace Zoolandia.Species
{
    public class PuffinusLherminieri : Puffinus, IFlying
    {
        public PuffinusLherminieri(string name)
            : base(name)
        {
            SetPuffinusLherminieriInfo();
        }
        public PuffinusLherminieri(int age)
            : base(age)
        {
            SetPuffinusLherminieriInfo();
        } 
        public PuffinusLherminieri(string name, int age)
            : base(name, age)
        {
            SetPuffinusLherminieriInfo();
        }    
        private void SetPuffinusLherminieriInfo()
        {
            this.CommonName = "Audubon's shearwater";
            this.ScientificName = "Puffinus lherminieri";
            this.PrimaryDiet = "Fish";
            this.AverageWeight = 1;
            this.AverageHeight = 6;
        }
        public string Eat()
        {
            return this.Name + " snatches a fish out of the sea.";
        }
        public override string Eat(int numberOfFoods)
        {
            return this.Name + " says: '" + base.Eat(numberOfFoods) + " I love this plankton, human. " + this.Speak() + "'";
        }
        public override string Speak() 
        {
            return "CAwww.";
        }
        public string Fly()
        {
            return this.Name + " flies across the sky!";
        }
        public string Land()
        {
            return this.Name + " is tired and stops flying.";
        }
    }
}
