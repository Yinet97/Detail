using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Entidades;

namespace BLL
{
    public class GruposBll
    {
        public static bool Guardar(Grupos std)
        {
            bool retorno = false;
            try
            {
                CursoDb db = new CursoDb();
                db.Grupos.Add(std);
                db.SaveChanges();
                retorno = true;
            }
            catch (Exception)
            {

                throw;
            }
            return retorno;
        }

        public static Grupos Buscar(int id )
        {
            var grupo = new Grupos();
            using (var conexion = new CursoDb())
            {
                try
                {
                    grupo = conexion.Grupos.Find(id);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return grupo;
        }

        public static bool Eliminar(int id)
        {
            bool retorno = false;

            try
            {
                using (CursoDb db = new CursoDb())
                {
                    Grupos user = (from c in db.Grupos where c.GrupoId == id select c).FirstOrDefault();
                    db.Grupos.Remove(user);
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

    }
}
