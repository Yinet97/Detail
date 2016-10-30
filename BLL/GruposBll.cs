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
    }
}
