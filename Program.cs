using System;
using System.Collections.Generic;
using Zoolandia.Animals;
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
            Animal[] PacificAnimals = {shark, birdgirl, birdman};
            pacific.inhabitants.AddRange(PacificAnimals);

            // Add animals to Jungle inhabitants list.
            Animal[] WildassAnimals = {giraffe, pandaman, meanbutt, starfox};
            wildass.inhabitants.AddRange(WildassAnimals);

            // Add animals to Forest inhabitants list.
            Animal[] SherwoodAnimals = {groundhog, honeyBadger, dog, snek, foxwoman};
            sherwood.inhabitants.AddRange(SherwoodAnimals);

            // Add animals to Mountain inhabitants list.
            Animal[] OlympusAnimals = {ribbitlady, ribbitman, sonOfRibbit};
            olympus.inhabitants.AddRange(OlympusAnimals);

            // Add all instantiated habitats to a list.
            List<Habitat> places = new List<Habitat>();
            Habitat[] ZoolandiaPlaces = {sherwood, olympus, pacific, wildass};
            places.AddRange(ZoolandiaPlaces);

            // Loop through each Habitat in the List "places"
            foreach (Habitat place in places)
            {   
                // Write Habitat name in format requested in exercise.
                Console.WriteLine("Habitat : {0}", place.Name);
                // Loop through each Animal in current Habitat and log their name and common name.
                foreach (var inhabitant in place.inhabitants)
                {
                    Console.WriteLine("    {0}, the {1}", inhabitant.Name.ToString(), inhabitant.CommonName.ToString().ToLower());
                }
                //Add an empty line to give spacing in Console.
                Console.WriteLine();
            }
        }
    }
}
