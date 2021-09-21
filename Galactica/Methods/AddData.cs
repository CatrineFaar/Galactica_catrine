using Galactica.Models;
using System.Collections.Generic;


namespace Galactica.Methods
{
    class AddData
    {
        public Star Sun = new Star()
        {
            Id = 1,
            Name = "SUPERSUN",
            StarType = StarType.YellowDwarf,
            Temperature = 335,

            PlanetList = new List<Planet>()  // solens planeter
        };

        public void InsertPlanetData()
        {
            // Al dataen for hver!
            Sun.PlanetList.Add(new Planet() // fylder info i ny instans af Planet i listen PlanetList 
            {
                Id = 1,
                Name = "Mercury",
                Position = new Position() {PosX = 55, PosY = 99 },
                PlanetType = PlanetType.Dwarf,
                DiameterMeters = 44563,
                RotationPeriodHours = 145,
                RevolutionPeriodDays = 7635,
                MoonList = new List<Moon>() // Opretter ny tom liste til planetens måner. Fylder kun i listen, hvis der tildeles
            }) ;
            Sun.PlanetList.Add(new Planet()
            {
                Id = 2,
                Name = "Venus",
                Position = new Position() { PosX = 55, PosY = 99 },
                PlanetType = PlanetType.Giant,
                DiameterMeters = 207,
                RotationPeriodHours = 11332,
                RevolutionPeriodDays = 34,
                MoonList = new List<Moon>() 
            });
            Sun.PlanetList.Add(new Planet()
            {
                Id = 3,
                Name = "Earth",
                Position = new Position() { PosX = 55, PosY = 99 },
                PlanetType = PlanetType.Terrestial,
                DiameterMeters = 443211111,
                RotationPeriodHours = 11322,
                RevolutionPeriodDays = 369,
                MoonList = new List<Moon>()
            });
            Sun.PlanetList.Add(new Planet()
            {
                Id = 4,
                Name = "Mars",
                Position = new Position() { PosX = 52, PosY = 989 },
                PlanetType = PlanetType.Gas_Giant,
                DiameterMeters = 8,
                RotationPeriodHours = 1552,
                RevolutionPeriodDays = 7075,
                MoonList = new List<Moon>()
            });
            Sun.PlanetList.Add(new Planet()
            {
                Id = 5,
                Name = "Jupiter",
                Position = new Position() { PosX = 6634, PosY = 7719 },
                PlanetType = PlanetType.Giant,
                DiameterMeters = 3877,
                RotationPeriodHours = 112,
                RevolutionPeriodDays = 722265,
                MoonList = new List<Moon>()
            });
            Sun.PlanetList.Add(new Planet()
            {
                Id = 6,
                Name = "Saturn",
                Position = new Position() { PosX = 445, PosY = 972 },
                PlanetType = PlanetType.Terrestial,
                DiameterMeters = 10969,
                RotationPeriodHours = 42,
                RevolutionPeriodDays = 76005,
                MoonList = new List<Moon>()
            });
            Sun.PlanetList.Add(new Planet()
            {
                Id = 7,
                Name = "Uranus",
                Position = new Position() { PosX = 8815, PosY = 9274 },
                PlanetType = PlanetType.Giant,
                DiameterMeters = 34459,
                RotationPeriodHours = 11592,
                RevolutionPeriodDays = 754415,
                MoonList = new List<Moon>()
            });
            Sun.PlanetList.Add(new Planet()
            {
                Id = 8,
                Name = "Neptune",
                Position = new Position() { PosX = 335, PosY = 91 },
                PlanetType = PlanetType.Gas_Giant,
                DiameterMeters = 99,
                RotationPeriodHours = 3,
                RevolutionPeriodDays = 95,
                MoonList = new List<Moon>()
            });
        }

        public List<Moon> MoonList = new List<Moon>(); // instantierer en liste over Moon-objektet

        public void InsertMoonData()
        {
            Sun.PlanetList[2].MoonList.Add(new Moon()
            {
                Id = 1,
                Name = "Luna",
                Position = new Position() { PosX = 55, PosY = 99 },
                DiameterMeters = 39,
                RotationPeriodHours = 19012,
                RevolutionPeriodDays = 7845,
                Orbiting = 6658
            }); ;

            Sun.PlanetList[5].MoonList.Add(new Moon()
            {
                Id = 2,
                Name = "Titan",
                Position = new Position() { PosX = 55, PosY = 99 },
                DiameterMeters = 3499,
                RotationPeriodHours = 112,
                RevolutionPeriodDays = 7615,
                Orbiting = 663258
            }); ;

            Sun.PlanetList[3].MoonList.Add(new Moon()
            {
                Id = 3,
                Name = "Phobos",
                Position = new Position() { PosX = 55, PosY = 99 },
                DiameterMeters = 349,
                RotationPeriodHours = 112,
                RevolutionPeriodDays = 765,
                Orbiting = 62778
            }); ;

            Sun.PlanetList[4].MoonList.Add(new Moon()
            {
                Id = 4,
                Name = "Europe",
                Position = new Position() { PosX = 55, PosY = 99 },
                DiameterMeters = 34999,
                RotationPeriodHours = 102,
                RevolutionPeriodDays = 4455,
                Orbiting = 65518
            }); ;

            Sun.PlanetList[3].MoonList.Add(new Moon()
            {
                Id = 5,
                Name = "Deimos",
                Position = new Position() { PosX = 55, PosY = 99 },
                DiameterMeters = 34599,
                RotationPeriodHours = 1412,
                RevolutionPeriodDays = 79065,
                Orbiting = 458
            }); ;

            Sun.PlanetList[4].MoonList.Add(new Moon()
            {
                Id = 6,
                Name = "Ganymedes",
                Position = new Position() { PosX = 55, PosY = 99 },
                DiameterMeters = 34239,
                RotationPeriodHours = 5543,
                RevolutionPeriodDays = 7065,
                Orbiting = 958
            }); ;

            Sun.PlanetList[4].MoonList.Add(new Moon()
            {
                Id = 7,
                Name = "Io",
                Position = new Position() { PosX = 55, PosY = 99 },
                DiameterMeters = 3499,
                RotationPeriodHours = 1142,
                RevolutionPeriodDays = 76765,
                Orbiting = 6778
            }); ;

            Sun.PlanetList[5].MoonList.Add(new Moon()
            {
                Id = 8,
                Name = "Mimas",
                Position = new Position() { PosX = 55, PosY = 99 },
                DiameterMeters = 36,
                RotationPeriodHours = 13812,
                RevolutionPeriodDays = 7658,
                Orbiting = 16258
            }); ;
        }
    }
}
