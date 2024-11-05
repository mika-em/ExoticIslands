using ExoticIslands_api.Data;
using ExoticIslands_api.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("IslandPolicy")]
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
        public async Task<ActionResult<Island>> Get(int id)
        {
            if (_context.Islands == null)
            {
                return NotFound();
            }
            var island = await _context.Islands
                .FirstOrDefaultAsync(i => i.Id == id);

            if (island == null)
            {
                return NotFound();
            }

            return island;
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
