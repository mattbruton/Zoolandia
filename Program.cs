using System;
using System.Collections.Generic;
using Zoolandia.Species;
using Zoolandia.Genera;
using Zoolandia.Habitats;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            GiraffaCamelopardalis giraffe = new GiraffaCamelopardalis("Mr. Giraffe");
            MarmotaMonax groundhog = new MarmotaMonax("Cpt. Whiskers");
            CanisLupusFamiliaris dog = new CanisLupusFamiliaris("Lunchbox");
            MellivoraCapensis honeyBadger = new MellivoraCapensis("Facemuncher");
            GuloGulo meanbutt = new GuloGulo("Marvin");
            AilurusFulgens pandaman = new AilurusFulgens("Red");
            CanisLupusFamiliaris testanimal = new CanisLupusFamiliaris("Lunchbox", 4);
            BombinaBombina ribbitman = new BombinaBombina("Froggy");
            Console.WriteLine(ribbitman.Eat(4));
            pandaman.AverageWeight = 90;
            Console.WriteLine(pandaman.Eat(12));
            Console.WriteLine(dog.Eat(4));
            ribbitman.displayInfo();
            meanbutt.displayInfo();
            Habitat Savannah =  new Habitat();
            Savannah.inhabitants.Add(meanbutt);
            Savannah.inhabitants.Add(ribbitman);

            foreach (var animal in Savannah.inhabitants)
            {
                Console.WriteLine(animal.Name.ToString());
            }
            List<Gulo> GuloList = new List<Gulo>();
            GuloList.Add(meanbutt);
            Console.WriteLine(GuloList.Count);
            Console.WriteLine(groundhog.Murder());
        }
    }
}
