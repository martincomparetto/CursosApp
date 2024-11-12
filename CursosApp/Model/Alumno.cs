namespace CursosApp.Model
{
    public class Alumno
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public long DNI { get; set; } = 0;
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public DateOnly? FechaNacimiento { get; set; }
        public bool Trabaja { get; set; } = false;
    }
}
