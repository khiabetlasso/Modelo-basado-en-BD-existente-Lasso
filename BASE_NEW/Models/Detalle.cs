using System.ComponentModel.DataAnnotations;

namespace BASE_NEW.Models
{
    public class Detalle
    {
        public int id { get; set; }
        [Required]
        public int cantidad { get; set; }
        public double precio { get; set; }

        public int compra_encabezadoid { get; set; }

        public int productoid { get; set; }
        public Producto Producto { get; set; }
    }
}
