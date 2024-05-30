using RepasoAPI.Estudiante.Domain.Model.Aggregates;
using RepasoAPI.Estudiante.Domain.Model.Commands;

namespace RepasoAPI.Estudiante.Domain.Services;

public interface IEstudianteCommandService
{
    Task<Estudiantes> Handle(CreateEstudianteCommand command);
}