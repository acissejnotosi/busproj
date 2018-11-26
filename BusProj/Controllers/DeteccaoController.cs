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
    public class DeteccaoController : ControllerBase
    {
        private readonly BusCoreContext _context;

        public DeteccaoController(BusCoreContext context)
        {
            _context = context;
        }

        // GET: api/Deteccao
        [HttpGet]
        public IEnumerable<Deteccao> GetDeteccao()
        {
            return _context.Deteccao;
        }

        // GET: api/Deteccao/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDeteccao([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var deteccao = await _context.Deteccao.FindAsync(id);

            if (deteccao == null)
            {
                return NotFound();
            }

            return Ok(deteccao);
        }

        // PUT: api/Deteccao/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDeteccao([FromRoute] int id, [FromBody] Deteccao deteccao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != deteccao.DetecaoTipoId)
            {
                return BadRequest();
            }

            _context.Entry(deteccao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeteccaoExists(id))
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

        // POST: api/Deteccao
        [HttpPost]
        public async Task<IActionResult> PostDeteccao([FromBody] Deteccao deteccao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Deteccao.Add(deteccao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDeteccao", new { id = deteccao.DetecaoTipoId }, deteccao);
        }

        // DELETE: api/Deteccao/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDeteccao([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var deteccao = await _context.Deteccao.FindAsync(id);
            if (deteccao == null)
            {
                return NotFound();
            }

            _context.Deteccao.Remove(deteccao);
            await _context.SaveChangesAsync();

            return Ok(deteccao);
        }

        private bool DeteccaoExists(int id)
        {
            return _context.Deteccao.Any(e => e.DetecaoTipoId == id);
        }
    }
}