using departamentomunicipio.Models;
using departamentomunicipio.Utils;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace departamentomunicipio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoController : ControllerBase
    {
        private IDepartamentoService _departamentoService;
        public DepartamentoController(IDepartamentoService departamentoService)
        {
            _departamentoService = departamentoService;
        }
        // GET: api/<DepartamentoController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var departamentos =  await _departamentoService.GetDepartamentos();
            return Ok(departamentos);
        }

        // GET api/<DepartamentoController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var departamento = await _departamentoService.GetDepartamento(id);
            return Ok(departamento);
        }

        // POST api/<DepartamentoController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Departamento model)
        {
            if (model == null)
            {
                return BadRequest(ModelState);
            }
            var departamento = await _departamentoService.PostDepartamento(model);
            return Ok(departamento);
        }

        // PUT api/<DepartamentoController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Departamento model)
        {
            if (model == null)
            {
                return BadRequest(ModelState);
            }
            var departamento = await _departamentoService.PutDepartamento(id, model);
            return Ok(departamento);
        }

        // DELETE api/<DepartamentoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
