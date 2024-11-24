using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePracticaArboles
{
    public interface InterfazArbol
    {
        IEnumerable<InfoNodo> ObtenerNodos(int tipoDeRecorrido);
    }

    public interface InterfazArbol<TValue> : InterfazArbol where TValue : IComparable<TValue>
    {
        void Insertar(TValue value);
        void Remover(TValue value);
    }
}
