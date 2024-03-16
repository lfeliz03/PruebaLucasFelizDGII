using System.ComponentModel.DataAnnotations;

namespace PruebaLucasFelizDGII.Models
{
    public class Contribuyentes
    {
        public int Id { get; set; }
        public long RNCCedula { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Estatus { get; set; }
    }
}
