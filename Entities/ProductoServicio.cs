

namespace ProyectoProgramadolll.Entities
{
    public class ProductoServicio
    {
        public int IdProductoServicio { get; set; }
        public string CodigoProductoServicio { get; set; }
        public int IdTienda { get; set; }
        public string Descripcion { get; set; }
        public int CantidadInventario { get; set; }
        public decimal PrecioColones { get; set; }
        public decimal Venta { get; set; }
        public bool Estado { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
