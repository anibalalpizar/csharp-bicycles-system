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
        public Task<bool> EliminarFactura(int idFactura)
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
    }
}
