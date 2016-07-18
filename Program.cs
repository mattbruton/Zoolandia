using System;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GuloGulo meanbutt = new GuloGulo("Marvin", 12.3, 12.3);
            meanbutt.displayInfo();
            Console.WriteLine(meanbutt.Eat(5));
        }
    }
}
