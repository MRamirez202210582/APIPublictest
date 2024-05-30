using RepasoAPI.Estudiante.Domain.Model.Commands;

namespace RepasoAPI.Estudiante.Domain.Model.Aggregates;
    public class Estudiantes
    {
        public int ID { get; private set; }
        public string NombreUsuario { get; private set; }
        public string IdSede { get; private set; }
        public string IdCarrera { get; private set; }
        public string NombreEstudiante { get; private set; }
        public string Edad { get; private set; }
        public string Dni { get; private set; }
        public string Correo { get; private set; }
        public string Celular { get; private set; }

        protected Estudiantes()
        {
            IdSede = string.Empty;
            IdCarrera = string.Empty;
        }

        public Estudiantes(CreateEstudianteCommand command)
        {
            this.NombreUsuario = command.NombreUsuario;
            this.IdSede = command.IdSede;
            this.IdCarrera = command.IdCarrera ;
            this.NombreEstudiante = command.NombreEstudiante ;
            this.Edad = command.Edad ;
            this.Dni = command.Dni ;
            this.Correo = command.Correo ;
            this.Celular = command.Celular ;
        }
    }

