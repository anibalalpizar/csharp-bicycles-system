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
        public Task<bool> EliminarOrdenTrabajo(string idOrdenTrabajo)
        {
            throw new NotImplementedException();
        }

        public OrdenTrabajoDTO GuardarOrdenTrabajo(OrdenTrabajoDTO orden)
        {
            IDALOrdenTrabajo ordenDAL = new DALOrdenTrabajo();
            OrdenTrabajoDTO oOrden = null;
            OrdenTrabajoDTO ordenPorId = ordenDAL.ObtenerOrdenPorId(orden.IdOrdenTrabajo.ToString());

            if (ordenPorId == null)
                oOrden = ordenDAL.GuardarOrdenTrabajo(orden);
            else
                oOrden = ordenDAL.ActualizarOrdenTrabajo(orden);
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
    }
}
