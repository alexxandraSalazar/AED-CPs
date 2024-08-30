using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_prática
{
    internal class Persona
    {
        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public int Telefono { get; set; }

        public int Año { get; set; }

        public int Edad(int a)
        {
            return DateTime.Now.Year - a;
        }

        public string Imprimir()
        {
            return Nombres + "\t" + Apellidos + "\t" + Telefono ;
        }
    }
}
