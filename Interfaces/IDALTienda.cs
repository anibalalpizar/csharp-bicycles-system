using ProyectoProgramadolll.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Interfaces
{
    public interface IDALTienda
    {
        Task<Tienda> GuardarTienda(Tienda tienda);
        Task<IEnumerable<Tienda>> ObtenerTodasLasTiendas();
        Tienda ObtenerTiendaPorId(string idTienda);
        Task<Tienda> ActualizarTienda(Tienda tienda);
        Task<bool> EliminarTienda(string idTienda);
        bool ValidarTienda(string idTienda);
    }
}
