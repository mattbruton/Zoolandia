using Zoolandia.Genera;

namespace Zoolandia.Species
{
    public class MellivoraCapensis : Mellivora, IAmbulatory
    {
        public MellivoraCapensis(string name) : base(name)
        {
            this.CommonName = "Honey badger";
            this.ScientificName = "Mellivora capensis";
            this.PrimaryDiet = "Bee honey";
            this.AverageWeight = 20;
            this.AverageHeight = 11.0;
        }
        public string Eat()
        {
            return this.Name + " munches on something after recovering from a snake attack.";
        }
        public override string Eat(int numberOfFoods)
        {
            return this.Name + " says: '" + base.Eat(1) + " Thanks, I guess.'";
        }
        public override string Speak() 
        {
            return "Khrya-ya-ya-ya";
        }
        public string Walk()
        {
            return this.Name + " is walking.";
        }
        public string Run()
        {
            return this.Name + " is running!";
        }
        public string Care()
        {
            return this.Name + ", the " + this.CommonName + " don't care.";
        }
    }
}