using System;

namespace Zoolandia
{
    public abstract class Animal 
    {
        public Animal (string name, double height, double weight) 
        {
            this.Name = name;
            this.Height = height;
            this.Weight = weight;
        }
        public string Name {get; set;}
        public string CommonName {get; set;}
        protected string ScientificName {get; set;}
        protected string Genus {get; set;}
        public double Weight {get; set;}
        public double Height {get; set;}
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
            Console.WriteLine("Height: " + this.Height + "in");
            Console.WriteLine("Weight: " + this.Weight + "lbs");
            Console.WriteLine("Primary Diet: " + this.PrimaryDiet);
            Console.WriteLine("Sounds Like: " + this.Speak());
            Console.WriteLine();
        }
    }
}