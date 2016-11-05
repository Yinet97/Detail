using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;

namespace BLL
{
    public class GruposEstudiandesBll
    {

        public static bool Guardar(GruposEstudiantes student)
        {
            bool retorno = false;
            try
            {
                CursoDb db = new CursoDb();
                db.GrpEst.Add(student);
                db.SaveChanges();

                retorno = true;
            }
            catch (Exception)
            {

                throw;
            }
            return retorno;
        }


        public static List<GruposEstudiantes> GetLis(int grupoId)
        {
            var lista = new List<GruposEstudiantes>();
            using (var conexion = new CursoDb())
            {
                try
                {
                    lista = conexion.GrpEst.Where(ge => ge.GrupoId == grupoId).ToList();
                }
                catch (Exception)
                {
                }
            }
            return lista;
        }

        public static List<GruposEstudiantes> GetLista()
        {
            List<GruposEstudiantes> lista = new List<GruposEstudiantes>();
            CursoDb db = new CursoDb();

            lista = db.GrpEst.ToList();
            return lista;
        }
    }
}
