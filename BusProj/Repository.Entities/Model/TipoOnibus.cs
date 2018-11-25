using System.ComponentModel.DataAnnotations;

namespace BusCore.Repository.Entities.Model
{
    public class TipoOnibus
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Peso { get; set; }
    }
}
