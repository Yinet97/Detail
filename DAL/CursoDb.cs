using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAL
{
    public class CursoDb : DbContext
    {
        public CursoDb() : base("name= conStr")
        {

        }

        public virtual DbSet<Estudiantes> Estudiante { get; set; }
        public virtual DbSet<Grupos> Grupos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grupos>()
                .HasMany<Estudiantes>(g => g.Estudiantes)
                .WithMany(p => p.Grupo)
                .Map(gp =>
                {
                    gp.MapLeftKey("GrupoId");
                    gp.MapRightKey("EstudianteId");
                    gp.ToTable("GruposEstudiantes");
                });
        }
    }
}
