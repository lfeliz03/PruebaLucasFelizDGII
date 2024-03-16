using System.ComponentModel.DataAnnotations;

namespace PruebaLucasFelizDGII.Models
{
    public class Comprobantes
    {
        public int Id { get; set; }
        public long RNCCedula { get; set; }
        public string NCF { get; set; }
        public decimal Monto { get; set; }
        public decimal Itbis18 { get; set; }
        public Contribuyentes contribuyente { get; set; }
    }
}
