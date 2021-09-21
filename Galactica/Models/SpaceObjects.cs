using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica.Models
{
    abstract class SpaceObjects // 'grandparent class' - er abstract: kan ikke instantieres.
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Position Position { get; set; }
    }
}
