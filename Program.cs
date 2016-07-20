using System;
using System.Collections.Generic;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GuloGulo meanbutt = new GuloGulo("Marvin", 12.3, 12.3);
            // meanbutt.displayInfo();
            Console.WriteLine(meanbutt.Eat(5));
            MarmotaMonax asshole = new MarmotaMonax("Nacho", 8.9, 15.4);
            // asshole.displayInfo();
            CanisLupusFamiliaris lunchbox = new CanisLupusFamiliaris("Lunchbox", 15.2, 18.3);
            Console.WriteLine(lunchbox.Eat());
            lunchbox.displayInfo();
        }
    }
}
