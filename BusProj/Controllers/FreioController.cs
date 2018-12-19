using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusProj.Repository.Entities;
using BusProj.Repository.Entities.Model;
using BusCore.Model;

namespace BusCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FreioController : ControllerBase
    {
        private readonly BusCoreContext _context;

        public FreioController(BusCoreContext context)
        {
            _context = context;
        }

        // GET: api/Freio
        [HttpGet]
        public IEnumerable<Freio> GetFreio()
        {
            return _context.Freio;
        }

        // GET: api/Freio/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFreio([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var freio = await _context.Freio.FindAsync(id);

            if (freio == null)
            {
                return NotFound();
            }

            return Ok(freio);
        }

        // PUT: api/Freio/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFreio([FromRoute] int id, [FromBody] FreioDto freioDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var freio = await _context.Freio.FirstOrDefaultAsync(x => x.Linha.LinhaID == id);

            if (freio == null)
            {
                return BadRequest();
            }

            freio.RPNFreioCalculado = freioDto.RPNFreioCalculado;
            freio.RPNPontosParadaCalculado = freioDto.RPNPontosParada;
            freio.RPNSemaforoCalculado = freioDto.RPNSemaforo;
            freio.RPNRedutoresCalculado = freioDto.RPNRedutores;
            freio.KmFreioCalculado = freioDto.KmFreioCalculado;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FreioExists(id))
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

        // POST: api/Freio
        [HttpPost]
        public async Task<IActionResult> PostFreio([FromBody] FreioDto freio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var entityFreio = new Freio()
            {
                DataHora = System.DateTime.Now,
                KmFreioCalculado = freio.KmFreioCalculado,
                LinhaId = freio.LinhaID,
                RPNFreioCalculado = freio.RPNFreioCalculado,
                RPNPontosParadaCalculado = freio.RPNPontosParada,
                 RPNRedutoresCalculado = freio.RPNRedutores,
                 RPNSemaforoCalculado = freio.RPNSemaforo
            };
            _context.Freio.Add(entityFreio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFreio", new { id = entityFreio.FreioID }, entityFreio);
        }

        // DELETE: api/Freio/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFreio([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var freio = await _context.Freio.FindAsync(id);
            if (freio == null)
            {
                return NotFound();
            }

            _context.Freio.Remove(freio);
            await _context.SaveChangesAsync();

            return Ok(freio);
        }

        private bool FreioExists(int id)
        {
            return _context.Freio.Any(e => e.FreioID == id);
        }
    }
}