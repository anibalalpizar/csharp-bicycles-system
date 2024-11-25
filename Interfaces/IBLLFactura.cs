using ProyectoProgramadolll.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Interfaces
{
    public interface IBLLFactura
    {
        FacturaDTO GuardarFactura(FacturaDTO factura);
        FacturaDTO ObtenerFacturaPorId(string idFactura);

        Task<bool> EliminarFactura(int idFactura);

        List<FacturaDTO> ObtenerFacturas();
    }
}
