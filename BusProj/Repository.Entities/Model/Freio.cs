using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusProj.Repository.Entities.Model
{
    public class Freio
    {
        [Key]
        public int FreioID { get; set; }
        [ForeignKey("OcorrenciaID")]
        public virtual Ocorrencia Ocorrencia { get; set; }
        [ForeignKey("SeveridadeID")]
        public virtual Severidade Severidade { get; set; }
        [ForeignKey("DeteccaoID")]
        public virtual Deteccao Deteccao { get; set; }
        //Buracos, redutores, carga media
        [ForeignKey("TipoDescricaoID")]
        public virtual TipoDescricao DescricaoTipo { get; set; }
        //ocorrecia* severidade * deteccao
        public int RPNFreioCalculado{ get; set; }
        [ForeignKey("LinhaID")]
        public virtual Linha LinhaIDCE { get; set; }
        public DateTime dataHora { get; set; }
    }
}
