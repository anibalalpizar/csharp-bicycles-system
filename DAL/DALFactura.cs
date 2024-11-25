using ProyectoProgramadolll.Entities.DTO;
using ProyectoProgramadolll.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.DAL
{
    public class DALFactura : IDALFactura
    {
        public FacturaDTO ActualizarFactura(FacturaDTO factura)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarFactura(int factura)
        {
            throw new NotImplementedException();
        }

        public FacturaDTO GuardarFactura(FacturaDTO factura)
        {
            throw new NotImplementedException();
        }

        public FacturaDTO ObtenerFacturaPorId(string idFactura)
        {
            throw new NotImplementedException();
        }

        public List<FacturaDTO> ObtenerFacturas()
        {
            throw new NotImplementedException();
        }

        public FacturaDTO VerificarFacturaPorId(string idFactura)
        {
            throw new NotImplementedException();
        }
    }
}
