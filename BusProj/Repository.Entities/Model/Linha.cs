using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusProj.Repository.Entities.Model
{
    public class Linha
    {
        [Key]
        public int LinhaID { get; set; }
        public string NomeLinha { get; set; }
        public int NumParadas { get; set; }
        public int NumBuracos { get; set; }
        public int NumLomnbadas { get; set; }
        public int NumSemnaforo { get; set; }
        public double Peso { get; set; }
        public double RPNFabrica { get; set; }
        public double RPNCalculado { get; set; }

    }
}
