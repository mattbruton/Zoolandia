using System;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal animal = new Animal("Steve", 3.2, 4.5);
            string response = animal.Eat(5);
            Console.WriteLine(animal.Name + " says " + response);
            AilurusFulgens pandaMan = new AilurusFulgens("Red Panda", 11, 2.3);
            CanisLupusFamiliaris animal_One = new CanisLupusFamiliaris("Lunchbox", 35.5, 15.2);
            Console.WriteLine(animal_One.Eat(4));
            Console.WriteLine(pandaMan.Run());
        }
    }
}
