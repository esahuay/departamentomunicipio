using departamentomunicipio.Models;
using departamentomunicipio.Utils;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace departamentomunicipio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MunicipioController : ControllerBase
    {
        private IMunicipioService _municipioService;
        public MunicipioController(IMunicipioService municipioService)
        {
            _municipioService = municipioService;
        }
        // GET: api/<MunicipioController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var municipios = await _municipioService.GetMunicipios();
            return Ok(municipios);
        }

        // GET api/<MunicipioController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult>  Get(int id)
        {
            var municipio = await _municipioService.GetMunicipio(id);
            return Ok(municipio);
        }

        // GET api/<MunicipioController>/5
        [HttpGet("MunByDepto/{id}")]
        public async Task<IActionResult> GetMunicipioPorDepartamentoId(int id)
        {
            var municipio = await _municipioService.GetMunicipioPorDepartamento(id);
            return Ok(municipio);
        }

        // POST api/<MunicipioController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Municipio model)
        {
            if (model is null)
            {
                return BadRequest(ModelState);
            }
            var municipio = await _municipioService.PostMunicipio(model);
            return Ok(municipio);
        }

        // PUT api/<MunicipioController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Municipio model)
        {
            if (model is null)
            {
                return BadRequest(ModelState); 
            }
            var municipio = await _municipioService.PutMunicipio(id,model);
            return Ok(municipio);
        }

        // DELETE api/<MunicipioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
