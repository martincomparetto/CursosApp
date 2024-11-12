using CursosApp.Data;
using CursosApp.Model;
using Microsoft.AspNetCore.Components;

namespace CursosApp.Components.Pages.Profesores
{
    public partial class ProfesorPage
    {
        [Inject]
        private CursosAppContext context { get; set; } = default;

        private string MensajeError = "";
        private bool EstamosModificando = false;
        
        private Profesor? ProfesorModificando;

        private long DNI = 0;
        private string Nombre = "";
        private string Apellido = "";
        private DateOnly? FechaNacimiento;
        private int AñosExperiencia = 0;
        private string Materia = "";

        private List<Profesor>? ProfesoresList;

        private ProfesorModal modal = default!;

        protected override void OnInitialized()
        {
            base.OnInitialized();
            GetData();
        }

        private void GetData()
        {
            ProfesoresList = context.Profesores.ToList();
        }

        private void NuevoProfesor()
        {
            ProfesorModificando = new Profesor();
            modal.Open();
        }

        private void Guardar()
        {
            if (ProfesorModificando.DNI == 0 || ProfesorModificando.Nombre == "" || ProfesorModificando.Apellido == "" || ProfesorModificando.FechaNacimiento == null)
            {
                MensajeError = "No se ingresaron todos los datos del profesor";
            }
            else
            {
                if (!EstamosModificando)
                {
                    context.Profesores.Add(ProfesorModificando);
                    var actu = context.SaveChanges();

                    GetData();
                }
                else
                {
                    context.Entry(ProfesorModificando).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                    GetData();
                    EstamosModificando = false;
                }

                ProfesorModificando = null;
                MensajeError = "";
                modal.Close();
            }
        }

        private void Modificar(Profesor profesorModificar)
        {
            EstamosModificando = true;
            ProfesorModificando = profesorModificar;

            modal.Open();
        }

        private void Eliminar(Profesor profesorEliminar)
        {
            context.Profesores.Remove(profesorEliminar);
            context.SaveChanges();
            GetData();
        }
    }
}

