using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class EstudianteMCN
    {
        private readonly EstudianteMCD _metodos;

        public EstudianteMCN()
        {
            _metodos = new EstudianteMCD();
        }

        public bool Insertar(EstudianteCN est)
        {
            Estudiante est2 = new Estudiante
            {
                Carnet = est.Carnet,
                Nombres = est.Nombres,
                Apellidos = est.Apellidos,
                FechaNacimiento = est.FechaNacimiento,
                Nota = est.Nota
            };


            return _metodos.Insertar(est2);
        }

        public List<EstudianteCN> Imprimir()
        {
            var consultas = _metodos.Imprimir()
                .Select(x => new EstudianteCN
                {
                    Carnet = x.Carnet,
                    Nombres = x.Nombres,
                    Apellidos = x.Apellidos,
                    FechaNacimiento = x.FechaNacimiento,
                    Nota = x.Nota
                }).ToList();

            return consultas;
        }

        public EstudianteCN Mostrar(int carnet)
        {
            Estudiante est = _metodos.Mostrar(carnet);

            EstudianteCN estudiante = new EstudianteCN
            {
                Carnet = est.Carnet,
                Nombres = est.Nombres,
                Apellidos = est.Apellidos,
                FechaNacimiento = est.FechaNacimiento,
                Nota = est.Nota
            };

            return estudiante;
        }

        public bool Modificar(EstudianteCN est)
        {
            Estudiante est2 = new Estudiante
            {
                Carnet = est.Carnet,
                Nombres = est.Nombres,
                Apellidos = est.Apellidos,
                FechaNacimiento = est.FechaNacimiento,
                Nota = est.Nota
            };

            return _metodos.Modificar(est2);
        }

        public bool Eliminar(int carnet)
        {
            return _metodos.Eliminar(carnet);
        }
    }
}
