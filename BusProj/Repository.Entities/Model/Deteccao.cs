﻿using System.ComponentModel.DataAnnotations;

namespace BusProj.Repository.Entities.Model
{
    public class Deteccao
    {
        [Key]
        public int DetecaoTipoId { get; set; }
        public string ProbabilidadeDeteccao { get; set; }
        public string FaixasCriteriosDeteccao { get; set; }
        public int IndiceDeteccao { get; set; }
    }
}
