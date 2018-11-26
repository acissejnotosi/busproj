using BusCore.Repository.Entities.Model;
using System;
using System.ComponentModel.DataAnnotations;

namespace BusProj.Repository.Entities.Model
{
    public class Linha
    {
        [Key]
        public int LinhaID { get; set; }
        public DateTime DataCadastro { get; set; }
        public int NumeroLinha { get; set; }
        public string NomeLinha { get; set; }
        public int NumParadas { get; set; }
        public int NumBuracos { get; set; }
        public int NumLombadas { get; set; }
        public int NumSemaforo { get; set; }
        public double TotalRPNFreiosFabrica { get; set; }
        public double TotalRPNEmbreagemFabrica { get; set; }
        public double TotalRPNSuspensaoFabrica { get; set; }
        public double TotalKmFreiosFabrica { get; set; }
        public double TotalKmEmbreagemFabrica { get; set; }
        public double TotalKmSuspensaoFabrica { get; set; }
        public int TipoOnibusId { get; set; }
        public virtual TipoOnibus TipoOnibus { get; set; }
        public virtual Suspensao Suspensao { get; set; }
    }
}
