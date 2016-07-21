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
            
            GuloGulo meanbutt = new GuloGulo("Marvin");
            meanbutt.displayInfo();
            List<Gulo> GuloList = new List<Gulo>();
            GuloList.Add(meanbutt);
            Console.WriteLine(GuloList.Count);
        }
    }
}
