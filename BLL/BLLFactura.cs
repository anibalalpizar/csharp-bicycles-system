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
    public class BLLFactura : IBLLFactura
    {
     
        public FacturaDTO GuardarFactura(FacturaDTO factura, List<decimal> montoIndividualC, List<decimal> montoIndividualD)
        {
            IDALFactura facturaDAL = new DALFactura();

             return facturaDAL.GuardarFactura(factura, montoIndividualC, montoIndividualD);
        


        }

        public FacturaDTO ObtenerFacturaPorId(int idFactura)
        {
            IDALFactura facturaDAL = new DALFactura();
            return facturaDAL.ObtenerFacturaPorId(idFactura);
        }

        public List<FacturaDTO> ObtenerFacturas()
        {
            throw new NotImplementedException();
        }
    }
}
