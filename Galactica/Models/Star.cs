using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica.Models
{
    // enum oprettes udenfor selve klassen
    public enum StarType { YellowDwarf, White, BlueNeutron, RedGiant } 

    class Star : SpaceObjects
    {
        public StarType StarType { get; set; }
        public double Temperature { get; set; }

        public List<Planet> PlanetList { get; set; }
    }
}
