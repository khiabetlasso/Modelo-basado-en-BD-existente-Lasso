namespace BASE_NEW.Models
{
    public class Cliente
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string correo_electronico { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public DateTime fecha_registro { get; set; }
        public Boolean estado { get; set; }
    }
}
