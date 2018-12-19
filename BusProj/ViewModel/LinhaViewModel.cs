using System;

namespace BusCore.ViewModel
{
    public class LinhaViewModel
    {
        public int? LinhaId { get; set; }
        
        public int NumeroLinha { get; set; }
        public string NomeLinha { get; set; }
        public int TipoOnibusId { get; set; }
        public string TipoOnibusNome { get; set; }
        public double PesoOnibus { get; set; }
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
    }
}
