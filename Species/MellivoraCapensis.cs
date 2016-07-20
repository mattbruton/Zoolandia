using Zoolandia.Genera;

namespace Zoolandia.Species
{
    public class MellivoraCapensis : Mellivora, IAmbulatory, IMellivora
    {
        public MellivoraCapensis(string name, double height, double weight) : base(name, height, weight)
        {
            this.Genus = "Mellivora";
            this.CommonName = "Honey badger";
            this.ScientificName = "Mellivora capensis";
            this.PrimaryDiet = "Bee honey";
        }
        public string Eat()
        {
            return this.Name + " munches on something after recovering from a snake attack.";
        }
        public override string Eat(int numberOfFoods)
        {
            return this.Name + " says: '" + base.Eat(1) + " Thanks, I guess.'";
        }
        public string Care()
        {
            return this.Name + ", the " + this.CommonName + " don't care.";
        }
        public override string Speak() 
        {
            return "Khrya-ya-ya-ya";
        }
        public bool BelongsToMellivora()
        {
            return true;
        }
    }
}