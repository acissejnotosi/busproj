using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusCore.Repository.Entities.Model;
using BusProj.Repository.Entities;

namespace BusCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoOnibusController : ControllerBase
    {
        private readonly BusCoreContext _context;

        public TipoOnibusController(BusCoreContext context)
        {
            _context = context;
        }

        // GET: api/TipoOnibus
        [HttpGet]
        public IEnumerable<TipoOnibus> GetTipoOnibus()
        {
            return _context.TipoOnibus;
        }

        // GET: api/TipoOnibus/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTipoOnibus([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tipoOnibus = await _context.TipoOnibus.FindAsync(id);

            if (tipoOnibus == null)
            {
                return NotFound();
            }

            return Ok(tipoOnibus);
        }

        // PUT: api/TipoOnibus/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoOnibus([FromRoute] int id, [FromBody] TipoOnibus tipoOnibus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tipoOnibus.Id)
            {
                return BadRequest();
            }

            _context.Entry(tipoOnibus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoOnibusExists(id))
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

        // POST: api/TipoOnibus
        [HttpPost]
        public async Task<IActionResult> PostTipoOnibus([FromBody] TipoOnibus tipoOnibus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TipoOnibus.Add(tipoOnibus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoOnibus", new { id = tipoOnibus.Id }, tipoOnibus);
        }

        // DELETE: api/TipoOnibus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoOnibus([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tipoOnibus = await _context.TipoOnibus.FindAsync(id);
            if (tipoOnibus == null)
            {
                return NotFound();
            }

            _context.TipoOnibus.Remove(tipoOnibus);
            await _context.SaveChangesAsync();

            return Ok(tipoOnibus);
        }

        private bool TipoOnibusExists(int id)
        {
            return _context.TipoOnibus.Any(e => e.Id == id);
        }
    }
}