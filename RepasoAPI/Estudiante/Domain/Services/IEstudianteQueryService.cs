using RepasoAPI.Estudiante.Domain.Model.Aggregates;
using RepasoAPI.Estudiante.Domain.Model.Queries;

namespace RepasoAPI.Estudiante.Domain.Services;

public interface IEstudianteQueryService
{
    Task<IEnumerable<Estudiantes>> Handle(GetAllEstudianteQuery query);
    Task<Estudiantes> Handle(GetEstudianteByIdQuery query);
    
}