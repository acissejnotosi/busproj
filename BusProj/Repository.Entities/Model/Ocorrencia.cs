using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace BusProj.Repository.Entities.Model
{
    public class Ocorrencia
    {
        [Key]
        public int OcorrenciaId { get; set; }
        public string Probabilidade { get; set; }
        public string TaxasFalhasPossiveis { get; set; }
        public int IndiceOcorrencia { get; set; }
    }
}
