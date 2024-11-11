using ProyectoProgramadolll.Entities.DTO;
using ProyectoProgramadolll.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Interfaces
{
    public interface IDALProductoServicio
    {
        ProductoServicio GuardarProductoServicio(ProductoServicio productoServicio);
        IEnumerable<ProductoServicioDTO> ObtenerProductoServicios();
        ProductoServicio ObtenerProductoServicioPorId(string codigoProductoServicio);
        ProductoServicio ActualizarProductoServicio(ProductoServicio productoServicio);
        Task<bool> EliminarProductoServicio(string codigoProductoServicio);

    }
}
