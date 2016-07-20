namespace Zoolandia.Species
{
    public class MarmotaMonax : Animal, IAmbulatory, IMarmota
    {
        public MarmotaMonax(string name, double height, double weight) : base(name, height, weight)
        {
            this.Genus = "Marmota";
            this.CommonName = "Groundhog";
            this.ScientificName = "Marmota monax";
            this.PrimaryDiet = "Air conditioning units";
        }
        public override string Eat(int numberOfFoods)
        {
            return this.Name + " devours " + numberOfFoods.ToString() + " local pets.";
        }
        public string Eat()
        {
            return this.Name + " eats everything you love.";
        }
        public override string Speak()
        {
            return this.Name + " makes a whistling noise.";
        }
        public bool BelongsToMarmota()
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