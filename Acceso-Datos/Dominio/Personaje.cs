using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Personaje
    {

        public string Nombre { get; set; }
        public string Debilidad { get; set; }
        public bool UsaCapa { get; set; }
        public bool Volador { get; set; }
        public Universo Universo { get; set; }

    }
}
