namespace BusCore.Model
{
    public class LinhaDto
    {
        public int Id { get; set; }
        public int LinhaID { get; set; }
        public int NumeroLinha { get; set; }
        public string NomeLinha { get; set; }
        public int NumParadas { get; set; }
        public int NumBuracos { get; set; }
        public int NumLombadas { get; set; }
        public int NumSemaforo { get; set; }
        public int TipoOnibusId { get; set; }
    }
}
