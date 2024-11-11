using ProyectoProgramadolll.Entities.DTO;
using ProyectoProgramadolll.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Interfaces
{
    public interface IBLLProductoServicio
    {
        ProductoServicio GuardarProductoServicio(ProductoServicio productoServicio);
        IEnumerable<ProductoServicioDTO> ObtenerProductoServicios();
        Task<bool> EliminarProductoServicio(string codigoProductoServicio);
    }
}
