using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePracticaArboles
{
    public abstract class ArbolBase<TValue> : InterfazArbol<TValue> where TValue : IComparable<TValue>
    {
        protected Nodo<TValue> _raiz;

        public abstract void Insertar(TValue value);
        public abstract void Remover(TValue value);
        public abstract IEnumerable<InfoNodo> ObtenerNodos(int tipoDeRecorrido);

        protected void ObtenerNodos(Nodo<TValue> raiz, ICollection<Nodo<TValue>> coleccion, int tipoDeRecorrido)
        {
            if( raiz == null || tipoDeRecorrido < 1 || tipoDeRecorrido > 1)
                { return; }

            if (tipoDeRecorrido == 1)
            {
                // Recorrido en preorden
                coleccion.Add(raiz);
                ObtenerNodos(raiz.Izquierda, coleccion, tipoDeRecorrido);
                ObtenerNodos(raiz.Derecha, coleccion, tipoDeRecorrido);
            }
            else if (tipoDeRecorrido == 2)
            {
                // Recorrido en indorden
                ObtenerNodos(raiz.Izquierda, coleccion, tipoDeRecorrido);
                coleccion.Add(raiz);
                ObtenerNodos(raiz.Derecha, coleccion, tipoDeRecorrido);
            }
            else 
            {
                // Recorrido en postorden
                ObtenerNodos(raiz.Izquierda, coleccion, tipoDeRecorrido);
                ObtenerNodos(raiz.Derecha, coleccion, tipoDeRecorrido);
                coleccion.Add(raiz);
            }
        }

        protected Nodo<TValue> ObtenerNodoConValorMenor(Nodo<TValue> raiz)
        {
            Nodo<TValue> nodoActual = raiz;
            while (nodoActual != null && nodoActual.Izquierda != null)
            {
                nodoActual = nodoActual.Izquierda;
            }
            return nodoActual;
        }
        protected Nodo<TValue> ObtenerNodoConValorMaximo(Nodo<TValue> raiz)
        {
            Nodo<TValue> nodoActual = raiz;
            while (nodoActual != null && nodoActual.Derecha != null)
            {
                nodoActual = nodoActual.Derecha;
            }
            return nodoActual;
        }
    }
}
