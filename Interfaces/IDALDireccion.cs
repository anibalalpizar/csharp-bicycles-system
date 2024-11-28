using ProyectoProgramadolll.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Interfaces
{
    public interface IDALDireccion
    {
        List<Direccion> ObtenerDirecciones();
        Direccion ObtenerDireccionPorId(string idDireccion);
    }
}
