using BusProj.Repository.Entities.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusCore.Repository.Entities.Model
{
    public class RelatorioBuracos
    {
        [Key]
        public int RelBuracoID { get; set; }
        public int NumBuracos { get; set; }
        public DateTime DataHora { get; set; }
        [ForeignKey("LinhaID")]
        public virtual Linha LinhaIDCE { get; set; }
    }
}
