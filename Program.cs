using System;
using System.Collections.Generic;
using Zoolandia.Animals.Species;
using Zoolandia.Habitats;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            // Instantiating one of each animal species.
            GiraffaCamelopardalis giraffe = new GiraffaCamelopardalis("Mr. Giraffe");
            MarmotaMonax groundhog = new MarmotaMonax("Cpt. Whiskers");
            CanisLupusFamiliaris dog = new CanisLupusFamiliaris("Lunchbox");
            MellivoraCapensis honeyBadger = new MellivoraCapensis("Facemuncher");
            GuloGulo meanbutt = new GuloGulo("Marvin");
            AilurusFulgens pandaman = new AilurusFulgens("Red");
            VulpesCana starfox = new VulpesCana("Star Fox");
            BombinaBombina ribbitman = new BombinaBombina("Froggy");
            BombinaLichuanensis ribbitlady = new BombinaLichuanensis("Ribbette");
            BombinaOrientalis sonOfRibbit = new BombinaOrientalis("Froggy Jr.");
            LachesisMelanocephala snek = new LachesisMelanocephala("Hissyfit");
            MegachasmaPelagios shark = new MegachasmaPelagios("Dr. Shark");
            PuffinusLherminieri birdman = new PuffinusLherminieri("Birdo");
            PuffinusNativitatis birdgirl = new PuffinusNativitatis("Birdie");
            VulpesVulpes foxwoman = new VulpesVulpes("She-fox");

            // Instantiating each habitat class.
            Forest sherwood =  new Forest("Sherwood Forest");
            Ocean pacific = new Ocean("Pacific Ocean");
            Jungle wildass = new Jungle("Wildass Jungle");
            Mountain olympus = new Mountain("Mt. Olympus");

            // Add animals to Ocean inhabitants list.
            pacific.inhabitants.Add(shark);
            pacific.inhabitants.Add(birdgirl);
            pacific.inhabitants.Add(birdman);

            // Add animals to Jungle inhabitants list.
            wildass.inhabitants.Add(giraffe);
            wildass.inhabitants.Add(pandaman);
            wildass.inhabitants.Add(meanbutt);
            wildass.inhabitants.Add(starfox);

            // Add animals to Forest inhabitants list.
            sherwood.inhabitants.Add(groundhog);
            sherwood.inhabitants.Add(honeyBadger);
            sherwood.inhabitants.Add(dog);
            sherwood.inhabitants.Add(snek);
            sherwood.inhabitants.Add(foxwoman);

            // Add animals to Mountain inhabitants list.
            olympus.inhabitants.Add(ribbitlady);
            olympus.inhabitants.Add(ribbitman);
            olympus.inhabitants.Add(sonOfRibbit);

            // Add all instantiated habitats to a list.
            List<Habitat> places = new List<Habitat>();
            places.Add(sherwood);
            places.Add(olympus);
            places.Add(pacific);
            places.Add(wildass);

            

            // Console.WriteLine("Habitat : {0}", sherwood.Name);
            // foreach (var animal in sherwood.inhabitants)
            // {
            //     Console.WriteLine("   {0} the {1}", animal.Name.ToString(), animal.CommonName.ToString());
            // }
            // Console.WriteLine();

            // Console.WriteLine("Habitat : {0}", olympus.Name);
            // foreach (var animal in olympus.inhabitants)
            // {
            //     Console.WriteLine("   {0} the {1}", animal.Name.ToString(), animal.CommonName.ToString());
            // }
            // Console.WriteLine();

            // Console.WriteLine("Habitat : {0}", wildass.Name);
            // foreach (var animal in wildass.inhabitants)
            // {
            //     Console.WriteLine("   {0} the {1}", animal.Name.ToString(), animal.CommonName.ToString());
            // }
            // Console.WriteLine();

            // Console.WriteLine("Habitat : {0}", pacific.Name);
            // foreach (var animal in pacific.inhabitants)
            // {
            //     Console.WriteLine("   {0} the {1}", animal.Name.ToString(), animal.CommonName.ToString());
            // }
            // Console.WriteLine();
        }
    }
}
