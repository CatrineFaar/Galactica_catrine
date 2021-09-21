using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica.Models
{
    sealed class Moon : Planet // sealed: kan ikke nedarve til andre klasser
    {
        public double Orbiting { get; set; }

    }
}
