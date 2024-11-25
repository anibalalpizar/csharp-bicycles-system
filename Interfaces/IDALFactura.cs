using ProyectoProgramadolll.Entities.DTO;
using ProyectoProgramadolll.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Interfaces
{
    public interface IDALFactura
    {
        FacturaDTO GuardarFactura(FacturaDTO factura);
        FacturaDTO ObtenerFacturaPorId(string idFactura);

        FacturaDTO ActualizarFactura(FacturaDTO factura);

        Task<bool> EliminarFactura(int factura);

        List<FacturaDTO> ObtenerFacturas();
        FacturaDTO VerificarFacturaPorId(string idFactura);
    }
}
