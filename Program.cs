using System;
using System.Collections.Generic;
using Zoolandia.Animals.Species;
using Zoolandia.Animals.Genera;
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
            
            List<Habitat> places = new List<Habitat>();
            Console.WriteLine(wildass.Welcome());
            sherwood.inhabitants.Add(meanbutt);
            sherwood.inhabitants.Add(ribbitman);

            Console.WriteLine("Habitat : {0}", sherwood.Name);
            foreach (var animal in sherwood.inhabitants)
            {
                Console.WriteLine("   {0} the {1}", animal.Name.ToString(), animal.CommonName.ToString());
            }
            
            Console.WriteLine(pacific.BetterCheck());
            pacific.WetterCheck();
            Console.WriteLine(pacific.BetterCheck());
        }
    }
}
