using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePracticaArboles
{
    public class InfoNodo
    {
        public string Valor { get; set; }
        public int Altura { get; set; }
        public bool EsHoja { get; set; }
        public bool EsHijoIzquierdo { get; set; }
        public bool EsHijoDerecho{get;set;}
    }
}
