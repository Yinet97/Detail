using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;

namespace BLL
{
    public class EstudiantesBll
    {
        public static bool Guardar(Estudiantes student)
        {
            bool retorno = false;
            try
            {
                CursoDb db = new CursoDb();
                db.Estudiante.Add(student);
                db.SaveChanges();

                retorno = true;
            }
            catch (Exception)
            {

                throw;
            }
            return retorno;
        }

        public static Estudiantes Buscar(int EstudianteId)
        {
            var est = new Estudiantes();
            using (var conexion = new CursoDb())
            {
                try
                {
                    est = conexion.Estudiante.Find(EstudianteId);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return est;
        }

        public static bool Eliminar(int id)
        {
            bool retorno = false;

            try
            {
                using (CursoDb db = new CursoDb())
                {
                    Estudiantes user = (from c in db.Estudiante where c.EstudianteId == id select c).FirstOrDefault();
                    db.Estudiante.Remove(user);
                    db.SaveChanges();
                    retorno = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return retorno;
        }

        public static List<Estudiantes> GetLista()
        {
            List<Estudiantes> lista = new List<Estudiantes>();
            CursoDb db = new CursoDb();

            lista = db.Estudiante.ToList();
            return lista;
        }

        public static List<Estudiantes> GetLista(int id)
        {
            List<Estudiantes> lista = new List<Estudiantes>();
            CursoDb db = new CursoDb();

            lista = db.Estudiante.Where(u => u.EstudianteId == id).ToList();
            return lista;
        }
    }
}
