using System;
using BusCore.Model;
using BusProj.Repository.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BusCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CadastroLinhaController : ControllerBase
    {
        BusCoreContext _ctx;

        public CadastroLinhaController(BusCoreContext context)
        {
            _ctx = context;
        }
        
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CadastroLinhaDto cadastroLinhaDto)
        {
            var linha = _ctx.Linha.Find(id);

            if (linha == null)
            {
                throw new Exception("Linha não encontrada.");
            }

            linha.TotalRPNFreiosFabrica = cadastroLinhaDto.TotalRPNFreiosFabrica;
            linha.TotalRPNEmbreagemFabrica = cadastroLinhaDto.TotalRPNEmbreagemFabrica;
            linha.TotalRPNSuspensaoFabrica = cadastroLinhaDto.TotalRPNSuspensaoFabrica;
            linha.TotalKmFreiosFabrica = cadastroLinhaDto.TotalKmFreiosFabrica;
            linha.TotalKmEmbreagemFabrica = cadastroLinhaDto.TotalKmEmbreagemFabrica;
            linha.TotalKmSuspensaoFabrica = cadastroLinhaDto.TotalKmSuspensaoFabrica;

            _ctx.Linha.Attach(linha);
            _ctx.Entry(linha).State = EntityState.Modified;

            _ctx.SaveChanges();
        }
    }
}
