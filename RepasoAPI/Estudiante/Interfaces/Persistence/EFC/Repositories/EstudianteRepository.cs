using RepasoAPI.Estudiante.Domain.Model.Aggregates;
using RepasoAPI.Estudiante.Domain.Repositories;
using RepasoAPI.Shared.Infrastructure.Persistence.EFC.Configuration;
using RepasoAPI.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace RepasoAPI.Estudiante.Infrastructure.Persistence.EFC.Repositories;

public class EstudianteRepository(AppDbContext context):BaseRepository<Estudiantes>(context),IEstudianteRepository;