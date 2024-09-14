using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_IV_Redim
{
    public class Persona
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Telefono { get; set; }
        public int Año { get; set; }

        public int Edad(int AñoNacimiento)
        {
            return DateTime.Now.Year - AñoNacimiento;
        }
    }
}
