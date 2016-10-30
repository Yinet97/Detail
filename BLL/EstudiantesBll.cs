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
        
        public static List<Estudiantes> GetLista()
        {
            List<Estudiantes> lista = new List<Estudiantes>();
            CursoDb db = new CursoDb();

            lista = db.Estudiante.ToList();
            return lista;
        }
    }
}
