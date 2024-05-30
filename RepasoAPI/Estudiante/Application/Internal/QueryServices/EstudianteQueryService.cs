using RepasoAPI.Estudiante.Domain.Model.Aggregates;
using RepasoAPI.Estudiante.Domain.Model.Queries;
using RepasoAPI.Estudiante.Domain.Repositories;
using RepasoAPI.Estudiante.Domain.Services;


namespace RepasoAPI.Estudiante.Application.Internal.QueryService;

public class EstudianteQueryService(IEstudianteRepository estudianteRepository) :IEstudianteQueryService
{
    public async Task<Estudiantes?> Handle(GetEstudianteByIdQuery query)
    {
        return await estudianteRepository.FindByIdAsync(query.ID);
    }
    
    public async Task<IEnumerable<Estudiantes>> Handle(GetAllEstudianteQuery query)
    {
        return await estudianteRepository.ListAsync();
    }
}