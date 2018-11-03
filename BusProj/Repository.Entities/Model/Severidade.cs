using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace BusProj.Repository.Entities.Model
{
    public class Severidade
    {
        [Key]
        public int SeveridadeId { get; set; }
        public string SeveridadeTipo { get; set; }
        public string EfeitoDaSeveridade { get; set; }
        public int IndiceSeveridade { get; set; }
    }
}
