using ProyectoProgramadolll.DAL;
using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Entities.DTO;
using ProyectoProgramadolll.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.BLL
{
    public class BLLProductoServicio : IBLLProductoServicio
    {
        public Task<bool> EliminarProductoServicio(string codigoProductoServicio)
        {
            IDALProductoServicio productoServicioDAL = new DALProductoServicio();
            return productoServicioDAL.EliminarProductoServicio(codigoProductoServicio);
        }

        public ProductoServicio GuardarProductoServicio(ProductoServicio productoServicio)
        {
            IDALProductoServicio productoServicioDAL = new DALProductoServicio();
            ProductoServicio oProductoServicio = null;

            if(productoServicioDAL.ObtenerProductoServicioPorId(productoServicio.CodigoProductoServicio) == null)
                oProductoServicio = productoServicioDAL.GuardarProductoServicio(productoServicio);
            else
                oProductoServicio = productoServicioDAL.ActualizarProductoServicio(productoServicio);
            return oProductoServicio;
        }

        public IEnumerable<ProductoServicioDTO> ObtenerProductoServicios()
        {
            IDALProductoServicio productoServicioDAL = new DALProductoServicio();
            return productoServicioDAL.ObtenerProductoServicios();
        }
    }
}
