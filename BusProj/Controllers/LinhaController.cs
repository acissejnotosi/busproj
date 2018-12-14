﻿using System;
using System.Collections.Generic;
using System.Linq;
using BusCore.Model;
using BusCore.ViewModel;
using BusProj.Repository.Entities;
using BusProj.Repository.Entities.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BusCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinhaController : ControllerBase
    {
        BusCoreContext _ctx;

        public LinhaController(BusCoreContext context)
        {
            _ctx = context;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Linha> Get()
        {
            var result = _ctx.Linha
                             .ToList();

            return result;
        }

        [HttpGet]
        [Route("pesquisa")]
        public IEnumerable<Linha> Get(string search)
        {
            var numeroLinhaConvertido = 0;

            try
            {
                numeroLinhaConvertido = Convert.ToInt32(search);
            }
            catch (Exception) { }

            var result = _ctx.Linha
                             .Where(x => x.NomeLinha.ToLower().Contains(search) || (numeroLinhaConvertido > 0 ? x.NumeroLinha == numeroLinhaConvertido : true))
                             .ToList();

            return result;
        }

        [HttpPost]
        public ActionResult Post([FromBody] LinhaViewModel linha)
        {
            if (!IsLinhaValid(linha))
                return BadRequest("Já existe uma linha com esse nome ou número. Por favor verifique e tente novamente");

            var linhaEntity = new Linha()
            {
                NumeroLinha = linha.NumeroLinha,
                NomeLinha = linha.NomeLinha,
                DataCadastro = DateTime.Now,
                NumBuracos = linha.NumBuracos,
                NumLombadas = linha.NumLombadas,
                NumParadas = linha.NumParadas,
                NumSemaforo = linha.NumSemaforo,
                TipoOnibusId = linha.TipoOnibusId
            };

            _ctx.Linha.Add(linhaEntity);
            _ctx.SaveChanges();

            return CreatedAtAction("Linha", new { id = linhaEntity.LinhaID }, linhaEntity);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Linha linhaUpdate)
        {
            var linha = _ctx.Linha.Find(id);

            if (linha == null)
            {
                throw new Exception("Linha não encontrada.");
            }

            linha = linhaUpdate;
            _ctx.Linha.Attach(linha);
            _ctx.Entry(linha).State = EntityState.Modified;

            _ctx.SaveChanges();
        }
        
        [Route("CadastroLinha")]
        [HttpPost]
        public void Post([FromBody] LinhaDto linhaDto)
        {
            var linha = new Linha
            {
                NumeroLinha = linhaDto.NumeroLinha,
                NomeLinha = linhaDto.NomeLinha,
                NumParadas = linhaDto.NumParadas,
                NumBuracos = linhaDto.NumBuracos,
                NumLombadas = linhaDto.NumLombadas,
                NumSemaforo = linhaDto.NumSemaforo,
                TipoOnibusId = linhaDto.TipoOnibusId
            };

            _ctx.Add(linha);
            _ctx.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var linha = _ctx.Linha.Find(id);

            if (linha == null)
            {
                throw new Exception("Linha não encontrada.");
            }

            _ctx.Linha.Remove(linha);
            _ctx.SaveChanges();
        }

        private bool IsLinhaValid(LinhaViewModel linha)
        {
            var results = _ctx.Linha
                               .Where(
                                        x => 
                                        x.NomeLinha.ToLower().Contains(linha.NomeLinha.ToLower()) || 
                                        x.NumeroLinha == linha.NumeroLinha).ToList();

            return results.Count == 0;
        }
    }
}
