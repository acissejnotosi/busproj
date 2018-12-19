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

        public double RPNFreioCalculado { get; set; }
        public double RPNPontosParadaCalculado { get; set; }
        public double RPNSemaforoCalculado { get; set; }
        public double RPNRedutoresCalculado { get; set; }
        public double KmFreioCalculado { get; set; }
        [ForeignKey("LinhaID")]
        public virtual Linha Linha { get; set; }
        public DateTime DataHora { get; set; }
    }
}
