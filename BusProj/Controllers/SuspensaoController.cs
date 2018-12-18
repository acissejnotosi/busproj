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
    public class SuspensaoController : ControllerBase
    {
        private readonly BusCoreContext _context;

        public SuspensaoController(BusCoreContext context)
        {
            _context = context;
        }

        // GET: api/Suspensao
        [HttpGet]
        public IEnumerable<Suspensao> GetSuspensao()
        {
            return _context.Suspensao;
        }

        // PUT: api/Suspensao/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSuspensao([FromRoute] int id, [FromBody] SuspensaoDto suspensaoDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var suspensao = await _context.Suspensao.FirstOrDefaultAsync(x => x.Linha.LinhaID == id);

            if(suspensao == null)
            {
                return BadRequest();
            }

            suspensao.RPNBuracoCalculado = suspensaoDto.RPNBuraco;
            suspensao.RPNSuspensaoCalculado = suspensaoDto.RPNSuspensaoCalculado;
            suspensao.RPNRedutorCalculado = suspensaoDto.RPNRedutor;
            suspensao.RPNCargaCalculado = suspensaoDto.RPNCarga;
            
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SuspensaoExists(id))
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

        // POST: api/Suspensao
        [HttpPost]
        public async Task<IActionResult> PostSuspensao([FromBody] Suspensao suspensao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Suspensao.Add(suspensao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSuspensao", new { id = suspensao.SuspensaoID }, suspensao);
        }

        // DELETE: api/Suspensao/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSuspensao([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var suspensao = await _context.Suspensao.FindAsync(id);
            if (suspensao == null)
            {
                return NotFound();
            }

            _context.Suspensao.Remove(suspensao);
            await _context.SaveChangesAsync();

            return Ok(suspensao);
        }

        private bool SuspensaoExists(int id)
        {
            return _context.Suspensao.Any(e => e.SuspensaoID == id);
        }
    }
}