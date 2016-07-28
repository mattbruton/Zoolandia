using System;

namespace Zoolandia.Animals
{
    public abstract class Animal 
    {
        public Animal (string name) 
        {
            this.Name = name;
        }
        public Animal (int age)
        {
            this.Age = age;
        }
        public Animal (string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set;}
        public int Age {get; set;}
        public string CommonName {get; set;}
        protected string ScientificName {get; set;}
        protected string Genus {get; set;}
        public int AverageWeight {get; set;}
        public double AverageHeight {get; set;}
        protected string PrimaryDiet {get; set;}
        public virtual string Speak()
        {
            return null;
        }
        public virtual string Eat(int numberOfFoods)
        {
            return "Yum!";
        }
        public void displayInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Common Name: " + this.CommonName);
            Console.WriteLine("Scientific Name: " + this.ScientificName);
            Console.WriteLine("Genus: " + this.Genus);
            Console.WriteLine("Height: " + this.AverageHeight + "in");
            Console.WriteLine("Weight: " + this.AverageWeight + "lbs");
            Console.WriteLine("Primary Diet: " + this.PrimaryDiet);
            Console.WriteLine("Sounds Like: " + this.Speak());
            Console.WriteLine();
        }
    }
}