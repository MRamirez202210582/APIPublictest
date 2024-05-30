using RepasoAPI.Estudiante.Domain.Model.Aggregates;
using RepasoAPI.Estudiante.Interfaces.REST.Resources;


namespace RepasoAPI.Estudiante.Interfaces.REST.Transform;

public static class CreateEstudianteCommandByResourceAssembler
{
    public static CreateEstudianteResource ToCommandFromEntity(Estudiantes entity)
    {
        return new CreateEstudianteResource(
            entity.NombreUsuario,
            entity.IdSede,
            entity.IdCarrera,
            entity.NombreEstudiante,
            entity.Edad,
            entity.Dni,
            entity.Correo,
            entity.Celular
        );
    }
}