using ExoticIslands_api.Data;
using ExoticIslands_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class IslandsController : ControllerBase
    {
        private readonly IslandContext _context;

        public IslandsController(IslandContext context)
        {
            _context = context;
        }

        // GET: api/<IslandsController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Island>>> Get()
        {
            if (_context.Islands == null)
            {
                return NotFound();
            }
            return await _context.Islands.ToListAsync();
        }

        // GET api/<IslandsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<IslandsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<IslandsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<IslandsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
