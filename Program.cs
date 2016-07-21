using System;
using System.Collections.Generic;
using Zoolandia.Species;
using Zoolandia.Genera;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            GiraffaCamelopardalis giraffe = new GiraffaCamelopardalis("Mr. Giraffe");
            GuloGulo meanbutt = new GuloGulo("Marvin");
            MarmotaMonax groundhog = new MarmotaMonax("Cpt. Whiskers");
            giraffe.displayInfo();
            List<Gulo> GuloList = new List<Gulo>();
            GuloList.Add(meanbutt);
            Console.WriteLine(GuloList.Count);
            Console.WriteLine(groundhog.Murder());
        }
    }
}
