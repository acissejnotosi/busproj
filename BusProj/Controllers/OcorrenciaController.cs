﻿using System;
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
    public class OcorrenciaController : ControllerBase
    {
        private readonly BusCoreContext _context;

        public OcorrenciaController(BusCoreContext context)
        {
            _context = context;
        }

        // GET: api/Ocorrencias
        [HttpGet]
        public IEnumerable<Ocorrencia> GetOcorrencia()
        {
            return _context.Ocorrencia;
        }

        // GET: api/Ocorrencias/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOcorrencia([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ocorrencia = await _context.Ocorrencia.FindAsync(id);

            if (ocorrencia == null)
            {
                return NotFound();
            }

            return Ok(ocorrencia);
        }

        // PUT: api/Ocorrencias/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOcorrencia([FromRoute] int id, [FromBody] Ocorrencia ocorrencia)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ocorrencia.OcorrenciaId)
            {
                return BadRequest();
            }

            _context.Entry(ocorrencia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OcorrenciaExists(id))
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

        // POST: api/Ocorrencias
        [HttpPost]
        public async Task<IActionResult> PostOcorrencia([FromBody] Ocorrencia ocorrencia)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Ocorrencia.Add(ocorrencia);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOcorrencia", new { id = ocorrencia.OcorrenciaId }, ocorrencia);
        }

        // DELETE: api/Ocorrencias/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOcorrencia([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ocorrencia = await _context.Ocorrencia.FindAsync(id);
            if (ocorrencia == null)
            {
                return NotFound();
            }

            _context.Ocorrencia.Remove(ocorrencia);
            await _context.SaveChangesAsync();

            return Ok(ocorrencia);
        }

        private bool OcorrenciaExists(int id)
        {
            return _context.Ocorrencia.Any(e => e.OcorrenciaId == id);
        }
    }
}