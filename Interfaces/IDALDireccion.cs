using ProyectoProgramadolll.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Interfaces
{
    public interface IDALDireccion
    {
        List<Direccion> ObtenerDirecciones();
        Direccion ObtenerDireccionPorId(string idDireccion);
    }
}
