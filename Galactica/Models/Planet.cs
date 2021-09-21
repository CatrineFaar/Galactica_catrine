using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica.Models
{
    public enum PlanetType { Terrestial, Giant, Dwarf, Gas_Giant }

    class Planet : SpaceObjects
    {
        public PlanetType PlanetType { get; set; }
        public double DiameterMeters { get; set; }
        public double RotationPeriodHours { get; set; }
        public double RevolutionPeriodDays { get; set; }

        public List<Moon> MoonList { get; set; } 

    }
}
