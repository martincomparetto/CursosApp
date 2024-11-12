using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CursosApp.Data;
using CursosApp.Model;

namespace CursosApp.Data
{
    public class CursosAppContext : IdentityDbContext<CursosAppUser>
    {
        public CursosAppContext(DbContextOptions<CursosAppContext> options) : base(options) { }

        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
    }
}
