namespace RepasoAPI.Estudiante.Interfaces.REST.Resources;

public record CreateEstudianteResource(string NombreUsuario, string IdSede, string IdCarrera, string NombreEstudiante, string Edad, string Dni, string Correo, string Celular);