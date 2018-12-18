using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BusProj.Repository.Entities;
using BusCore.Repository.Entities.Model;

namespace BusCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RelatorioController : ControllerBase
    {
        //private readonly BusCoreContext _context;

        //public RelatorioController(BusCoreContext context)
        //{
        //    _context = context;
        //}

        //[Route("RelatorioBuracos")]
        //[HttpGet]
        //public IEnumerable<RelatorioDto> GetRelatorioBuraco()
        //{
        //    var buracos = _context.Linha
        //                          .Select(x => new RelatorioDto
        //                          {
        //                              NomeLinha = x.NomeLinha,
        //                              NumeroOcorrencia = x.NumBuracos,
        //                              DataRegistro = x.DataCadastro
        //                          })
        //                          .OrderBy(x => x.NomeLinha);

        //    return buracos;
        //}

        //[Route("RelatorioSemaforos")]
        //[HttpGet]
        //public IEnumerable<RelatorioDto> GetRelatorioSemaforo()
        //{
        //    var buracos = _context.Linha
        //                          .Select(x => new RelatorioDto
        //                          {
        //                              NomeLinha = x.NomeLinha,
        //                              NumeroOcorrencia = x.NumSemaforo,
        //                              DataRegistro = x.DataCadastro
        //                          })
        //                          .OrderBy(x => x.NomeLinha);

        //    return buracos;
        //}

        //[Route("RelatorioLombadas")]
        //[HttpGet]
        //public IEnumerable<RelatorioDto> GetRelatorioLombada()
        //{
        //    var buracos = _context.Linha
        //                          .Select(x => new RelatorioDto
        //                          {
        //                              NomeLinha = x.NomeLinha,
        //                              NumeroOcorrencia = x.NumLombadas,
        //                              DataRegistro = x.DataCadastro
        //                          })
        //                          .OrderBy(x => x.NomeLinha);

        //    return buracos;
        //}

        //[Route("RelatorioParadas")]
        //[HttpGet]
        //public IEnumerable<RelatorioDto> GetRelatorioParada()
        //{
        //    var buracos = _context.Linha
        //                          .Select(x => new RelatorioDto
        //                          {
        //                              NomeLinha = x.NomeLinha,
        //                              NumeroOcorrencia = x.NumParadas,
        //                              DataRegistro = x.DataCadastro
        //                          })
        //                          .OrderBy(x => x.NomeLinha);

        //    return buracos;
        //}
    }
}