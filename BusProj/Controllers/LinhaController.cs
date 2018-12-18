using System;
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
        public IEnumerable<LinhaViewModel> Get()
        {
            var result = _ctx.Linha.Select(x => new LinhaViewModel()
            {
                LinhaId = x.LinhaID,
                NomeLinha = x.NomeLinha,
                NumeroLinha = x.NumeroLinha,
                TipoOnibusId = x.TipoOnibusId,
                PesoOnibus = x.TipoOnibus.Peso,
                TipoOnibusNome = x.TipoOnibus.Descricao
            }).ToList();

            return result;
        }

        [HttpGet]
        [Route("GetById")]
        public LinhaViewModel Get(int id)
        {
            var result = _ctx.Linha.Where(x => x.LinhaID == id).Select(x => new LinhaViewModel()
            {
                LinhaId = x.LinhaID,
                NomeLinha = x.NomeLinha,
                NumeroLinha = x.NumeroLinha,
                TipoOnibusId = x.TipoOnibusId,
                PesoOnibus = x.TipoOnibus.Peso,
                TipoOnibusNome = x.TipoOnibus.Descricao
            }).ToList();

            return result == null ? null : result.First();
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
                TipoOnibusId = linha.TipoOnibusId,
                TotalKmEmbreagemFabrica = linha.TotalKmEmbreagemFabrica,
                TotalKmFreiosFabrica = linha.TotalKmFreiosFabrica,
                TotalKmSuspensaoFabrica = linha.TotalKmSuspensaoFabrica,
                TotalRPNEmbreagemFabrica = linha.TotalRPNEmbreagemFabrica,
                TotalRPNFreiosFabrica = linha.TotalRPNFreiosFabrica,
                TotalRPNSuspensaoFabrica = linha.TotalRPNSuspensaoFabrica
            };

            _ctx.Linha.Add(linhaEntity);
            _ctx.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public void Put( [FromBody] Linha linhaUpdate)
        {
            var linha = _ctx.Linha.Find(linhaUpdate.LinhaID);

            if (linha == null)
            {
                throw new Exception("Linha não encontrada.");
            }

            linha.NomeLinha = linhaUpdate.NomeLinha;
            linha.NumeroLinha = linha.NumeroLinha;
            linha.TipoOnibusId = linha.TipoOnibusId;

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
