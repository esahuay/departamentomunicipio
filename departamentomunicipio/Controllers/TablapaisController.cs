using departamentomunicipio.Models;
using departamentomunicipio.Utils;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace departamentomunicipio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TablapaisController : ControllerBase
    {
        private ITablapais _tablapais;
        public TablapaisController(ITablapais tablapais)
        {
            _tablapais = tablapais;
        }

        // GET: api/<TablapaisController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var paises = await _tablapais.GetTablapais();
            return Ok(paises);
        }

        // GET api/<TablapaisController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var pais = await _tablapais.GetTablapaisPorId(id);
            return Ok(pais);
        }

        // POST api/<TablapaisController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Tablapai model)
        {
            if(model == null)
            {
                return BadRequest(ModelState);
            }
            var pais = await _tablapais.PostTablapais(model);
            return Ok(pais);
        }

        // PUT api/<TablapaisController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Tablapai model)
        {
            if (model == null)
            {
                return BadRequest(ModelState);
            }
            var pais = await _tablapais.PutTablapais(id,model);
            return Ok(pais);
        }

        // DELETE api/<TablapaisController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
