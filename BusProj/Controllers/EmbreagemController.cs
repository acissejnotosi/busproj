using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusProj.Repository.Entities;
using BusProj.Repository.Entities.Model;
using BusCore.Model;

namespace BusCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmbreagemController : ControllerBase
    {
        private readonly BusCoreContext _context;

        public EmbreagemController(BusCoreContext context)
        {
            _context = context;
        }

        // GET: api/Embreagem
        [HttpGet]
        public IEnumerable<Embreagem> GetEmbreagem()
        {
            return _context.Embreagem;
        }

        // GET: api/Embreagem/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmbreagem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var embreagem = await _context.Embreagem.FindAsync(id);

            if (embreagem == null)
            {
                return NotFound();
            }

            return Ok(embreagem);
        }

        // PUT: api/Embreagem/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmbreagem([FromRoute] int id, [FromBody] EmbreagemDto embreagemDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var embreagem = await _context.Embreagem.FirstOrDefaultAsync(x => x.Linha.LinhaID == id);

            if (embreagem == null)
            {
                return BadRequest();
            }

            embreagem.RPNEmbreagemCalculado = embreagemDto.RPNEmbreagemCalculado;
            embreagem.RPNParadaCalculado = embreagemDto.RPNParada;
            embreagem.RPNSemaforoCalculado = embreagemDto.RPNSemaforo;
            embreagem.RPNRedutoresCalculado = embreagemDto.RPNRedutor;
            embreagem.KmEmbreagemCalculado = embreagemDto.KmEmbreagemCalculado;


            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmbreagemExists(id))
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

        // POST: api/Embreagem
        [HttpPost]
        public async Task<IActionResult> PostEmbreagem([FromBody] EmbreagemDto embreagem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var entityEmbreagem = new Embreagem()
            {
                DataHora = System.DateTime.Now,
                KmEmbreagemCalculado = embreagem.KmEmbreagemCalculado,
                RPNEmbreagemCalculado = embreagem.RPNEmbreagemCalculado,
                RPNParadaCalculado = embreagem.RPNParada,
                RPNRedutoresCalculado = embreagem.RPNRedutor,
                RPNSemaforoCalculado = embreagem.RPNSemaforo,
                LinhaId = embreagem.LinhaID
            };
            _context.Embreagem.Add(entityEmbreagem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmbreagem", new { id = entityEmbreagem.EmbreagemID }, entityEmbreagem);
        }

        // DELETE: api/Embreagem/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmbreagem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var embreagem = await _context.Embreagem.FindAsync(id);
            if (embreagem == null)
            {
                return NotFound();
            }

            _context.Embreagem.Remove(embreagem);
            await _context.SaveChangesAsync();

            return Ok(embreagem);
        }

        private bool EmbreagemExists(int id)
        {
            return _context.Embreagem.Any(e => e.EmbreagemID == id);
        }
    }
}