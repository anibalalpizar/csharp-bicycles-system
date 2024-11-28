
namespace ProyectoProgramadolll.Entities
{
    public class DetalleOrdenTrabajo
    {
        public int IdDetalleOrdenTrabajo { get; set; }
        public int IdOrdenTrabajo { get; set; }
        public string NumeroSerie { get; set; }
        public int IdProductoServicio { get; set; }
        public string Descripcion { get; set; }
        public string NombreProducto { get; set; }
    }
}
