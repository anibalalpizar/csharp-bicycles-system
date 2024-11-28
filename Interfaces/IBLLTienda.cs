using ProyectoProgramadolll.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Interfaces
{
    public interface IBLLTienda
    {
        Task<Tienda> GuardarTienda(Tienda tienda);
        Task<IEnumerable<Tienda>> ObtenerTodasLasTiendas();
        Task<bool> EliminarTienda(string idTienda);
        bool ValidarTienda(string idTienda);
    }
}
