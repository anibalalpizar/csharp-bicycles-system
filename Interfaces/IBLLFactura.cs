using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Entities.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Interfaces
{
    public interface IBLLFactura
    {
        FacturaDTO GuardarFactura(FacturaDTO factura, List<decimal> montoIndividualC, List<decimal> montoIndividualD);
        FacturaDTO ObtenerFacturaPorId(int idFactura);
        Task<List<Factura>> ObtenerFacturas();

        FacturaDTO GuardarXml(string xml, int idFactura);
    }
}
