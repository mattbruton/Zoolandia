using System;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AilurusFulgens pandaMan = new AilurusFulgens("Red Panda", 11, 2.3);
            CanisLupusFamiliaris animal_One = new CanisLupusFamiliaris("Lunchbox", 13.75, 15.2);
            Console.WriteLine(animal_One.Eat(4));
            Console.WriteLine(pandaMan.Run());
            MellivoraCapensis meanass = new MellivoraCapensis("Meanass", 30.2, 11.10);
            pandaMan.displayInfo();
            animal_One.displayInfo();
            Console.WriteLine(meanass.Eat(2));
        }
    }
}
