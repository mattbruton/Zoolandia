namespace Zoolandia
{
    public class Animal 
    {
        public Animal (string name, double height, double weight) 
        {
            this.Name = name;
            this.Height = height;
            this.Weight = weight;
        }
        protected string PrimaryDiet;
        public string Genus = null;
        public string ScientificName = "Latin Words";
        public string CommonName = "Animal";
        public string Name {get; set;}
        public double Weight {get; set;}
        public double Height {get; set;}
        public virtual string Speak()
        {
            return null;
        }
        public virtual string Eat(int numberOfFoods)
        {
            return "'Yum!'";
        }
    }
}