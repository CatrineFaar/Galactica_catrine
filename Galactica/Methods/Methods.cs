using Galactica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;  // til Math.Pow og Math.Sqrt

namespace Galactica.Methods
{
    class Methods
    {
        public void ShowAllPlanets(Planet currentPlanet)
        {
            if (currentPlanet.MoonList != null) // hvis listen ikke findes, spring loopet over
            {
                // Udskrift til hver planet 
                Console.WriteLine($"\nPlaneten {currentPlanet.Name} er af typen: {currentPlanet.PlanetType}");
                Console.Write($" -- {currentPlanet.Name} har {currentPlanet.MoonList.Count()} måne/-r: ");

                foreach (Moon actualMoon in currentPlanet.MoonList)
                {
                    Console.Write(actualMoon.Name + " ");

                    if (currentPlanet.MoonList.Count >= 2)
                    {
                        Console.Write("og "); // jeg kunne ikke finde ud af at fjerne sidste "og"...
                    }



                    //// jeg kunne ikke finde ud af at fjerne sidste "og"... men tænker noget lignende:

                    //int counter = 0;
                    //foreach (var item in currentPlanet.MoonList)
                    //{
                    //    counter++;

                    //    if (counter < currentPlanet.MoonList.Count - 1)
                    //    {
                    //        Console.Write("og");
                    //    }
                    //}

                }
                Console.WriteLine("");
            }
        }



        // Beregner afstanden fra given planet til solen: distance=√((x_2-x_1)²+(y_2-y_1)²)
        public double Distance(Planet currentPlanet)
        {
            // reference til Star for at kunne angive dens position: altid 0,0 (x2 og y2)
            Position SunPosition = new Position() { PosX = 0, PosY = 0 };

            // reference til pågældende planet, som startposition: henter x1 og y1 fra Planet-objektet
            Position PlanetPosition = currentPlanet.Position;

            double x1 = PlanetPosition.PosX;
            double y1 = PlanetPosition.PosY;
            double x2 = SunPosition.PosX;
            double y2 = SunPosition.PosY;
            double potens1 = Math.Pow((x2 - x1), 2); 
            double potens2 = Math.Pow((y2 - y1), 2);
            double planet_sun_result = Math.Sqrt((potens1 + potens2));

            Console.WriteLine($" --------- Afstanden mellem {currentPlanet.Name} og solen er: {planet_sun_result}");

            return planet_sun_result;
        }


        // Samme Distance-metode til månen: overload
        public double Distance(Moon currentMoon, Planet currentPlanet)  // to forskellige planets i metodernes params
        {
            // reference til pågældende planet, som startposition: henter x1 og y1 fra Planet-objektet
            Position PlanetPosition = currentPlanet.Position;

            // reference til pågældende måne, som startposition: henter x2 og y2 fra Moon-objektet
            Position MoonPosition = currentMoon.Position;

            double x1 = PlanetPosition.PosX;
            double y1 = PlanetPosition.PosY;
            double x2 = MoonPosition.PosX;
            double y2 = MoonPosition.PosY;
            double potens1 = Math.Pow((x2 - x1), 2);
            double potens2 = Math.Pow((y2 - y1), 2);
            double planet_moon_result = Math.Sqrt((potens1 + potens2));
            
            Console.WriteLine($" ----- Afstanden mellem {currentPlanet.Name} og {currentMoon.Name} er: {planet_moon_result}");
            return planet_moon_result;
        }
    }
}
