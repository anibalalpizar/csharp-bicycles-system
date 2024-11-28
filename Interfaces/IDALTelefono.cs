using ProyectoProgramadolll.Entities;
using System.Collections.Generic;

namespace ProyectoProgramadolll.Interfaces
{
    public interface IDALTelefono
    {
        List<Telefono> ObtenerTelefonos();
        Telefono ObtenerTelefonosPorId(string numeroTelefono);
    }
}
