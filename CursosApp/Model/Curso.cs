namespace CursosApp.Model
{
    public class Curso
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Nombre { get; set; } = string.Empty;
        public int CantidadMaximaAlumnos { get; set; } = 0;
        public Profesor ProfesorPrincipal { get; set; } = new();
        public List<Alumno> AlumnoList { get; set; } = new();
    }
}
