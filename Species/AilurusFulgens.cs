using System;

namespace Zoolandia.Species
{
    public class AilurusFulgens : Animal
    {
        public AilurusFulgens (string name) : base(name) 
        {
            
        }
        public override string Eat(int numberOfFoods) 
        {
            string animalEat = base.Eat(3);
            return animalEat + " Nom nom nom..." + "!";
        }

        public string Eat() 
        {
            return "WTF did I just eat?!";
        }

        public string Welcome (string name)
        {
            this.Name = name;
            return Welcome();
        }

        public string Welcome()
        {
            return this.Name;
        }
    }
}