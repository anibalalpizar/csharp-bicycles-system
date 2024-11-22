using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Interfaces
{
    public interface IBLLBicicleta
    {
        Task<Bicicleta> GuardarBicicleta(Bicicleta bicicleta);
        Task<IEnumerable<BicicletaDTO>> ObtenerBicicletas();
        Task<bool> EliminarBicicleta(string idBicicleta);
        Task<IEnumerable<BicicletaDTO>> ObtenerBicicletasPorVendedor(int idVendedor);

    }
}
