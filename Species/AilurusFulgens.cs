using Zoolandia.Genera;

namespace Zoolandia.Species
{
    public class AilurusFulgens : Ailurus, IAmbulatory
    {
        public AilurusFulgens (string name)
            : base(name) 
        {
            SetAilurusFulgensInfo();
        }
        public AilurusFulgens (int age) 
            : base(age)
        {
            SetAilurusFulgensInfo();
        }
        public AilurusFulgens (string name, int age)
            : base(name, age)
        {
            SetAilurusFulgensInfo();
        }
        private void SetAilurusFulgensInfo()
        {
            this.CommonName = "Red panda";
            this.ScientificName = "Ailurus fulgens";
            this.PrimaryDiet = "Bamboo";
            this.AverageWeight = 11;
            this.AverageHeight = 10.3;
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
        public string Walk()
        {
            return this.Name + " is walking.";
        }
        public string Run()
        {
            return this.Name + " is running!";
        }
        public int RemainingPopulation()
        {
            return 10000;
        }
    }
}