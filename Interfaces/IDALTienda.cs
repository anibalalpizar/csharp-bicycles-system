using ProyectoProgramadolll.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
