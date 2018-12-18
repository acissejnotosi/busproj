using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusProj.Repository.Entities.Model
{
    public class Embreagem
    {
        [Key]
        public int EmbreagemID { get; set; }
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
        public int RPNEmbreagemCalculado { get; set; }
        public int RPNParadaCalculado { get; set; }
        public int RPNSemaforoCalculado { get; set; }
        public int RPNRedutoresCalculado { get; set; }
        [ForeignKey("LinhaID")]
        public virtual Linha Linha { get; set; }
        public DateTime DataHora { get; set; }
    }
}
