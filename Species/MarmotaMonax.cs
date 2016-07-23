using Zoolandia.Genera;

namespace Zoolandia.Species
{
    public class MarmotaMonax : Marmota, IAmbulatory
    {
        public MarmotaMonax(string name)
            : base(name)
        {
            SetMarmotaMonaxInfo();
        }
        public MarmotaMonax(int age)
            : base(age)
        {
            SetMarmotaMonaxInfo();
        }
        public MarmotaMonax(string name, int age)
            : base(name, age)
        {
            SetMarmotaMonaxInfo();
        }
        private void SetMarmotaMonaxInfo()
        {
            this.CommonName = "Groundhog";
            this.ScientificName = "Marmota monax";
            this.PrimaryDiet = "Air conditioning units";
            this.AverageWeight = 9;
            this.AverageHeight = 9.5;
        }
        public override string Eat(int numberOfFoods)
        {
            return base.Eat(numberOfFoods) + " " + this.Name + " devours " + numberOfFoods.ToString() + " local pets.";
        }
        public string Eat()
        {
            return this.Name + " eats everything you love.";
        }
        public override string Speak()
        {
            return this.Name + " makes a whistling noise.";
        }
        public string Walk()
        {
            return this.Name + " is walking.";
        }
        public string Run()
        {
            return this.Name + " is running!";
        }
        public string Murder()
        {
            return this.Name + " murders the nearest neighborhood pet.";
        }
    }
}