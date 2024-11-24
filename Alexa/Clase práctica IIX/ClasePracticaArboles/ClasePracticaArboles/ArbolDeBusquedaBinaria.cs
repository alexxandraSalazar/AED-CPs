using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePracticaArboles
{
    public class ArbolDeBusquedaBinaria<TValue> : ArbolBase<TValue> where TValue : IComparable<TValue>
    {
        public override void Insertar(TValue valor)
        {
            _raiz = Insertar(_raiz, valor);
        }

        public override void Remover(TValue valor)
        {
            _raiz = Remover(_raiz, valor);
        }

        private Nodo<TValue> Insertar(Nodo<TValue> raiz, TValue valor) 
        {
            if (raiz == null)
                raiz = new Nodo<TValue>(valor);
            else if (raiz.Valor.CompareTo(valor) > 0)
                raiz.Izquierda = Insertar(raiz.Izquierda, valor);
            else
                raiz.Derecha = Insertar(raiz.Derecha, valor);
            return raiz;
        }

        private Nodo<TValue> Remover(Nodo<TValue> raiz, TValue valor) 
        {
            if (_raiz == null)
                return raiz;

            if (raiz.Valor.CompareTo(valor) > 0)
                raiz.Izquierda = Remover(raiz.Izquierda, valor);
            else if (raiz.Valor.CompareTo(valor) < 0)
                raiz.Derecha = Remover(raiz.Derecha, valor);
            else 
            {
                if(raiz.Izquierda == null && raiz.Derecha == null)
                    raiz = null;
                else if(raiz.Izquierda == null && raiz.Derecha != null)
                    raiz = raiz.Derecha;
                else if(raiz.Izquierda != null && raiz.Derecha == null)
                    raiz = raiz.Izquierda;
                else 
                {
                    Nodo<TValue> minValueNode = ObtenerNodoConValorMenor(raiz.Derecha);
                    raiz.Valor = minValueNode.Valor;
                    raiz.Derecha = Remover(raiz.Derecha, minValueNode.Valor);
                }
            }
            return raiz;

        }

        public override IEnumerable<InfoNodo> ObtenerNodos(int tipoDeRecorrido)
        {
            var coleccionDeNodos = new List<Nodo<TValue>>();

            ObtenerNodos(_raiz, coleccionDeNodos, tipoDeRecorrido);

            var infoNodos = coleccionDeNodos.ToDictionary
                (
                    x => x,
                    y => new InfoNodo
                    {
                        Valor = y.Valor.ToString(),
                        EsHoja = y.Izquierda == null && y.Derecha == null
                    }
                );

            return infoNodos.Values;
        }
    }
}
