using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusProj.Repository.Entities;
using BusProj.Repository.Entities.Model;

namespace BusCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeveridadeController : ControllerBase
    {
        private readonly BusCoreContext _context;

        public SeveridadeController(BusCoreContext context)
        {
            _context = context;
        }

        // GET: api/Severidade
        [HttpGet]
        public IEnumerable<Severidade> GetSeveridade()
        {
            return _context.Severidade;
        }

        // GET: api/Severidade/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSeveridade([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var severidade = await _context.Severidade.FindAsync(id);

            if (severidade == null)
            {
                return NotFound();
            }

            return Ok(severidade);
        }

        // PUT: api/Severidade/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSeveridade([FromRoute] int id, [FromBody] Severidade severidade)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != severidade.SeveridadeId)
            {
                return BadRequest();
            }

            _context.Entry(severidade).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SeveridadeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Severidade
        [HttpPost]
        public async Task<IActionResult> PostSeveridade([FromBody] Severidade severidade)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Severidade.Add(severidade);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSeveridade", new { id = severidade.SeveridadeId }, severidade);
        }

        // DELETE: api/Severidade/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSeveridade([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var severidade = await _context.Severidade.FindAsync(id);
            if (severidade == null)
            {
                return NotFound();
            }

            _context.Severidade.Remove(severidade);
            await _context.SaveChangesAsync();

            return Ok(severidade);
        }

        private bool SeveridadeExists(int id)
        {
            return _context.Severidade.Any(e => e.SeveridadeId == id);
        }
    }
}