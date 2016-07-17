using Zoolandia.Genera;

namespace Zoolandia.Species
{
    public class AilurusFulgens : Ailurus, IAmbulatory
    {
        public AilurusFulgens (string name, double height, double weight) : base(name, height, weight) 
        {
            this.CommonName = "Red panda";
            this.ScientificName = "Ailurus fulgens";
            this.PrimaryDiet = "Bamboo";
        }
        public override string Eat(int numberOfFoods) 
        {
            string animalEat = base.Eat(numberOfFoods);
            if (numberOfFoods <= 0)
            {
                return "'What kind of game are you trying to play, human? Give moar " + this.CommonName.ToLower() + " foods.'";
            }
            else if (numberOfFoods == 1)
            {
                return "'Just " + numberOfFoods + " bite of panda food? I could die from hunger!'";
            }
            else 
            {
            return animalEat + "'Thanks for the " + numberOfFoods + " bites of panda food!'";
            }
        }
        public string Eat() 
        {
            return this.Name + " chews on some " + this.PrimaryDiet.ToLower() + " ... or maybe a small bird.";
        }
        public override string Speak() 
        {
            return "Yiff! Yiff!";
        }
    }
}