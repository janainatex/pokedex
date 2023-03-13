using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex.Models
{
    public class DetailstDto
    {
        public Pokemon Prior { get; set; }
        public Pokemon Current{ get; set; }
        public Pokemon Next{ get; set; }
        public List <Tipo> Tipos { get; set; }
    }
}