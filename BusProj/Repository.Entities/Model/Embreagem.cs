using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusProj.Repository.Entities.Model
{
    public class Embreagem
    {
        [Key]
        public int EmbreagemID { get; set; }

        public double RPNEmbreagemCalculado { get; set; }
        public double RPNParadaCalculado { get; set; }
        public double RPNSemaforoCalculado { get; set; }
        public double RPNRedutoresCalculado { get; set; }
        public double KmEmbreagemCalculado { get; set; }
        [ForeignKey("LinhaID")]
        public virtual Linha Linha { get; set; }
        public DateTime DataHora { get; set; }
    }
}
