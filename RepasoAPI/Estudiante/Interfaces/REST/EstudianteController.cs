using System.Net.Mime;
using RepasoAPI.Estudiante.Domain.Model.Queries;
using RepasoAPI.Estudiante.Domain.Services;
using RepasoAPI.Estudiante.Interfaces.REST.Resources;
using RepasoAPI.Estudiante.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;
using RepasoAPI.Estudiante.Domain.Model.Commands;
using Swashbuckle.AspNetCore.Annotations;

namespace RepasoAPI.Estudiante.Interfaces.REST;

  [ApiController]
    [Route("api/v1/[controller]")]
    [Produces(MediaTypeNames.Application.Json)]
    public class EstudianteController : ControllerBase
    {
        private readonly IEstudianteCommandService _estudianteCommandService;
        private readonly IEstudianteQueryService _estudianteQueryService;

        public EstudianteController(IEstudianteCommandService estudianteCommandService, IEstudianteQueryService estudianteQueryService)
        {
            _estudianteCommandService = estudianteCommandService;
            _estudianteQueryService = estudianteQueryService;
        }

        [HttpPost]
        public async Task<ActionResult> CreateEstudiante([FromBody] CreateEstudianteResource resource)
        {
            var createEstudianteCommand = new CreateEstudianteCommand(resource.NombreUsuario, resource.IdSede, resource.IdCarrera, resource.NombreEstudiante, resource.Edad, resource.Dni, resource.Correo, resource.Celular);
            var result = await _estudianteCommandService.Handle(createEstudianteCommand);
            var estudianteResource = EstudianteByEntityAssembler.ToResourceFromEntity(result);
            return CreatedAtAction(nameof(GetEstudianteById), new { id = estudianteResource.Id }, estudianteResource);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstudianteResource>>> GetAllEstudiantes()
        {
            var query = new GetAllEstudianteQuery();
            var result = await _estudianteQueryService.Handle(query);
            var resources = result.Select(EstudianteByEntityAssembler.ToResourceFromEntity);
            return Ok(resources);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetEstudianteById(int id)
        {
            var query = new GetEstudianteByIdQuery(id);
            var result = await _estudianteQueryService.Handle(query);
            if (result == null) return NotFound();
            var resource = EstudianteByEntityAssembler.ToResourceFromEntity(result);
            return Ok(resource);
        }
    }