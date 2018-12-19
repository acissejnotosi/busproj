using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusProj.Repository.Entities.Model
{
    public class Suspensao
    {
        [Key]
        public int SuspensaoID { get; set; }
    
        public double RPNSuspensaoCalculado { get; set; }
        public double RPNBuracoCalculado { get; set; }
        public double RPNRedutorCalculado { get; set; }
        public double RPNCargaCalculado { get; set; }
        public double KmSuspensaoCalculado { get; set; }
        public int LinhaId { get; set; }
        public virtual Linha Linha { get; set; }
        public DateTime DataHora { get; set; }
    }
}
