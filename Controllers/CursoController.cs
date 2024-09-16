using Doracorde.ORACLE.Models;
using Doracorde.Services;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Doracorde.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CursoController : ControllerBase
    {
        private readonly ICursoService _cursoService;

        public CursoController(ICursoService cursoService)
        {
            _cursoService = cursoService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Curso>>> GetAll()
        {
            var cursos = await _cursoService.GetAllCoursesAsync();
            return Ok(cursos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Curso>> GetById(int id)
        {
            var curso = await _cursoService.GetCourseByIdAsync(id);
            if (curso == null)
                return NotFound();
            return Ok(curso);
        }

        [HttpPost]
        public async Task<ActionResult> Create(Curso curso)
        {
            await _cursoService.AddCourseAsync(curso);
            return CreatedAtAction(nameof(GetById), new { id = curso.Id }, curso);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, Curso curso)
        {
            if (id != curso.Id)
                return BadRequest();
            await _cursoService.UpdateCourseAsync(curso);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _cursoService.DeleteCourseAsync(id);
            return NoContent();
        }
    }
}
