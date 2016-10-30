using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estudiantes
    {
        [Key]

        public int EstudianteId { get; set; }
        public string Nombres { get; set; }

        public virtual ICollection<Grupos> Grupo { get; set; }

        public Estudiantes()
        {
            this.Grupo = new HashSet<Grupos>();
        }

        public Estudiantes(int estudianteID, string nombre)
        {
            this.EstudianteId = estudianteID;
            this.Nombres = nombre;
            this.Grupo = new HashSet<Grupos>();
        }
    }
}
