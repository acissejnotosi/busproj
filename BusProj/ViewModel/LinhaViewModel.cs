using System;

namespace BusCore.ViewModel
{
    public class LinhaViewModel
    {
        public int? LinhaId { get; set; }
        public DateTime? DataCadastro { get; set; }
        public int NumeroLinha { get; set; }
        public string NomeLinha { get; set; }
        public int NumParadas { get; set; }
        public int NumBuracos { get; set; }
        public int NumLombadas { get; set; }
        public int NumSemaforo { get; set; }
        public int TipoOnibusId { get; set; }
    }
}
