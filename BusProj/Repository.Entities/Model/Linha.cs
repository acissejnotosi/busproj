using BusCore.Repository.Entities.Model;
using System.ComponentModel.DataAnnotations;

namespace BusProj.Repository.Entities.Model
{
    public class Linha
    {
        [Key]
        public int LinhaID { get; set; }
        public int NumeroLinha { get; set; }
        public string NomeLinha { get; set; }
        public double TotalRPNFreiosFabrica { get; set; }
        public double TotalRPNEmbreagemFabrica { get; set; }
        public double TotalRPNSuspensaoFabrica { get; set; }
        public double TotalKmFreiosFabrica { get; set; }
        public double TotalKmEmbreagemFabrica { get; set; }
        public double TotalKmSuspensaoFabrica { get; set; }
        public double RPNSuspensaoBuracoFabrica { get; set; }
        public double RPNSuspensaoRedutorFabrica { get; set; }
        public double RPNSuspensaoCargaFabrica { get; set; }
        public double RPNEmbreagemParadaFabrica { get; set; }
        public double RPNEmbreagemSemaforoFabrica { get; set; }
        public double RPNEmbreagemRedutorFabrica { get; set; }
        public double RPNFreioParadaFabrica { get; set; }
        public double RPNFreioSemaforoFabrica { get; set; }
        public double RPNFreioRedutorFabrica { get; set; }
        public int TipoOnibusId { get; set; }
        public virtual TipoOnibus TipoOnibus { get; set; }
    }
}
