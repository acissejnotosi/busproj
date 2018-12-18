using BusProj.Repository.Entities.Model;
using System;

namespace BusCore.Repository.Entities.Model
{
    public class HistoricoLinha
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int NumBuracos { get; set; }
        public int NumLombadas { get; set; }
        public int NumSemaforos { get; set; }
        public int NumParadas { get; set; }
        public virtual Linha Linha { get; set; }
    }
}
