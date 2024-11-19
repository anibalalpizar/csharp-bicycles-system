using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Entities.DTO
{
    public class ProductoServicioDTO
    {
        public int IdProductoServicio { get; set; }
        public string CodigoProductoServicio { get; set; }
        public int IdTienda { get; set; }
        public string DescripcionTienda { get; set; }
        public string Descripcion { get; set; }
        public int CantidadInventario { get; set; }
        public decimal PrecioColones { get; set; }
        public decimal Venta { get; set; }
        public bool Estado { get; set; }
        public string DescripcionEstado { get; set; }

        public override string ToString()
        {
            return $"{IdProductoServicio} -  {Descripcion} ";
        }
    }
}
