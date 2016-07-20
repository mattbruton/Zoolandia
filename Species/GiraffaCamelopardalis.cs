namespace Zoolandia.Species
{
    public class GiraffaCamelopardalis : Animal, IAmbulatory, IGiraffa
    {
        public GiraffaCamelopardalis(string name, double height, double weight) : base(name, height, weight)
        {
            this.Genus = "Giraffa";
            this.CommonName = "Giraffe";
            this.ScientificName = "Giraffa camelopardalis";
            this.PrimaryDiet = "Acacia leaves";
        }

        public override string Eat(int numberOfFoods)
        {
            return "";
        }
        public string Eat()
        {
            return "";
        }
        public override string Speak()
        {
            return "";
        }
        public bool BelongsToGiraffa()
        {
            return true;
        }
        public string Walk()
        {
            return this.Name + " is walking.";
        }
        public string Run()
        {
            return this.Name + " is running!";
        }
    }
}