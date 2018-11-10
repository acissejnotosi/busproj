namespace BusCore.ViewModel
{
    public class LinhaViewModel
    {
        public int LinhaId { get; set; }
        public int NumeroLinha { get; set; }
        public string NomeLinha { get; set; }
        public int NumParadas { get; set; }
        public int NumBuracos { get; set; }
        public int NumLomnbadas { get; set; }
        public int NumSemnaforo { get; set; }
        public double Peso { get; set; }
        public double TotalRPNFabrica { get; set; }
        public double RPNCalculado { get; set; }
    }
}
