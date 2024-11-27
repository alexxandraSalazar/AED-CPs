using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class EstudianteMCD
    {
        public bool Insertar(Estudiante est)
        {
            using (var db = new SIRAEntities())
            {
                db.Estudiante.Add(est); // Agregar estudiante en tabla Estudiante
                db.SaveChanges(); // Guardar cambios en la base de datos

                return true;
            }
        }


        public List<Estudiante> Imprimir()
        {
            using (var db = new SIRAEntities())
            {
                var consulta = (from p in db.Estudiante select p).ToList();

                return consulta;
            }
        }

        public Estudiante Mostrar(int carnet)
        {
            using (var db = new SIRAEntities())
            {
                Estudiante estudiante = (from p in db.Estudiante
                                         where p.Carnet == carnet
                                         select p).FirstOrDefault();
                return estudiante;
            } 
        }


        public bool Modificar(Estudiante Est)
        {
            using (var db = new SIRAEntities())
            {
                var consulta = db.Estudiante.Find(Est.Carnet);
                consulta.Nombres = Est.Nombres;
                consulta.Apellidos = Est.Apellidos;
                consulta.FechaNacimiento = Est.FechaNacimiento;
                consulta.Nota = Est.Nota;
                db.Entry(consulta).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }


        public bool Eliminar(int carnet)
        {
            using (var db = new SIRAEntities())
            {
                var consulta = db.Estudiante.Find(carnet);
                db.Estudiante.Remove(consulta);
                db.SaveChanges();
                return true;
            }
        }



    }
}
