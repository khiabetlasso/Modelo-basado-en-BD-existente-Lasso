using System.ComponentModel.DataAnnotations;

namespace BASE_NEW.Models
{
    public class Factura
    {
        public int id { get; set; }
        [Required]
        public int productoid { get; set; }
        [Required]
        public Producto producto { get; set; }
        public int ventaid { get; set; }
        [Required]
        public int cantidad { get; set; }
        public double precio { get; set; }
        public double totalXproducto { get; set; }
    }
}
