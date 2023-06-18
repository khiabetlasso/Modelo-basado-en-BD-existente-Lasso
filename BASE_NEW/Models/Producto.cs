using System.ComponentModel.DataAnnotations;

namespace BASE_NEW.Models
{
    public class Producto
    {
        public int id { get; set; }
        [Required]
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public double precio_compra { get; set; }
        public double precio_venta { get; set; }
        public int cantidad { get; set; }
        public int categoriaid { get; set; }
    }
}
