using RepasoAPI.Estudiante.Domain.Model.Commands;
using RepasoAPI.Estudiante.Domain.Model.Aggregates;
using RepasoAPI.Estudiante.Domain.Repositories;
using RepasoAPI.Estudiante.Domain.Services;
using RepasoAPI.Shared.Domain.Repositories;

namespace RepasoAPI.Estudiante.Application.Internal.CommandServices;

public class EstudianteCommandService(IEstudianteRepository estudianteRepository,IUnitOfWork unitOfWork):IEstudianteCommandService
{
    public async Task<Estudiantes?> Handle(CreateEstudianteCommand command)
    {
        var estudiantes = new Estudiantes(command);
        await estudianteRepository.AddAsync(estudiantes);
        await unitOfWork.CompleteAsync();
        return estudiantes;
    }
    
}