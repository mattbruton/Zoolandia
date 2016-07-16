using System;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Animal animal = new Animal("Steve");
            string response = animal.Eat(5);
            Console.WriteLine(animal.Name + " says " + response);

            AilurusFulgens pandaMan = new AilurusFulgens("Red Panda");
            pandaMan.Name = "Mr. Pand A. Redd";
            Console.WriteLine(pandaMan.Name + " exclaimed " + pandaMan.Eat(12));
            Console.WriteLine(pandaMan.Name + " said " + pandaMan.Eat());
            Console.WriteLine("My name is now " + pandaMan.Welcome("Bob Sagat"));


        }
    }
}
