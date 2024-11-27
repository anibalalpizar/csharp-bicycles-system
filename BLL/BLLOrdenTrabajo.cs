using ProyectoProgramadolll.DAL;
using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Entities.DTO;
using ProyectoProgramadolll.Interfaces;
using ProyectoProgramadolll.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.BLL
{
    public class BLLOrdenTrabajo : IBLLOrdenTrabajo
    {
        public Task<bool> EliminarOrdenTrabajo(int idOrdenTrabajo)
        {
            IDALOrdenTrabajo ordenDAL = new DALOrdenTrabajo();
            return ordenDAL.EliminarOrdenTrabajo(idOrdenTrabajo);
        }

        public OrdenTrabajoDTO GuardarOrdenTrabajo(OrdenTrabajoDTO orden, List<FotografiaOrden> fotografias)
        {
            IDALOrdenTrabajo ordenDAL = new DALOrdenTrabajo();
            OrdenTrabajoDTO oOrden = null;

            if (ordenDAL.VerificarOrdenPorId(orden.IdOrdenTrabajo.ToString()) == null)
                oOrden = ordenDAL.GuardarOrdenTrabajo(orden);
            else
                oOrden = ordenDAL.ActualizarOrdenTrabajo(orden, fotografias);
            return oOrden;
        }

        public List<OrdenTrabajoDTO> ObtenerOrdenesTrabajo()
        {
            IDALOrdenTrabajo ordenDAL = new DALOrdenTrabajo();
            return ordenDAL.ObtenerOrdenesTrabajo();
        }

        public OrdenTrabajoDTO ObtenerOrdenPorId(string idOrdenTrabajo)
        {
            IDALOrdenTrabajo oOrdenDAL = new DALOrdenTrabajo();
            return oOrdenDAL.ObtenerOrdenPorId(idOrdenTrabajo);
        }

        public Task<IEnumerable<OrdenTrabajoDTO>> ObtenerOrdenPorIdCliente(string idCliente)
        {
            IDALOrdenTrabajo oOrdenDAL = new DALOrdenTrabajo();
            return oOrdenDAL.ObtenerOrdenPorIdCliente(idCliente);
        }

        public Task<IEnumerable<OrdenTrabajoDTO>> ObtenerPrecioProductoPorIdOrden(string idOrdenTrabajo)
        {
            IDALOrdenTrabajo oOrdenDAL = new DALOrdenTrabajo();
            return oOrdenDAL.ObtenerPrecioProductoPorIdOrden(idOrdenTrabajo);
        }
    }
}
