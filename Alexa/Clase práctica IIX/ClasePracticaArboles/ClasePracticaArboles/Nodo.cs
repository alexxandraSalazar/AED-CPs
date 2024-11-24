using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePracticaArboles
{
    public class Nodo<TValue> where TValue : IComparable<TValue>
    {

        public Nodo(TValue valor) 
        {
            Valor  = valor;
        }

        public Nodo<TValue> Izquierda { get; set; }
        public Nodo<TValue> Derecha{ get; set; }
        public TValue Valor { get; set; }

    }
}
