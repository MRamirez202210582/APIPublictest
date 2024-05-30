using RepasoAPI.Estudiante.Domain.Model.Aggregates;
using RepasoAPI.Estudiante.Interfaces.REST.Resources;

namespace RepasoAPI.Estudiante.Interfaces.REST.Transform;

public static class EstudianteByEntityAssembler
{
    public static EstudianteResource ToResourceFromEntity(Estudiantes entity)
    {
        return new EstudianteResource(
            entity.ID,
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