using System;
using System.Linq;
using Galactica.Methods; // mine mapper
using Galactica.Models; // mine mapper


namespace Galactica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" *** Hello GALACTICA ***   ");

            // nyt objekt ud fra skabelonen Methods-class
            Methods.Methods methods = new Methods.Methods(); // instans (methods) af klassen Methods i mappen Methods!
            AddData addData = new AddData(); // nyt objekt ud fra skabelonen AddData: nu kender filen her mit data

            addData.InsertPlanetData(); // udfylder her
            addData.InsertMoonData(); // udfylder her

            foreach (Planet currentPlanet in addData.Sun.PlanetList) // peger på en planet i planetList
            {
                methods.ShowAllPlanets(currentPlanet);

                // for at se alle måner for pågældende planet
                foreach (Moon currentMoon in currentPlanet.MoonList)
                {
                    // antallet af params gør, at metoden ved hvilken overload jeg kalder her
                    methods.Distance(currentMoon, currentPlanet);

                }

                methods.Distance(currentPlanet); // kører metoden ud fra given planet
            }
        }

        
    }
}

