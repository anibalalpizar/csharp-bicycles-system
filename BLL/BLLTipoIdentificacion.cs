using ProyectoProgramadolll.DAL;
using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Interfaces;
using System.Collections.Generic;

namespace ProyectoProgramadolll.BLL
{
    public class BLLTipoIdentificacion : IBLLTipoIdentificacion
    {
        public List<TipoIdentificacion> ObtenerTipoIdentificacion()
        {
            IDALTipoIdentificacion tipoIdentificacionDAL = new DALTipoIdentificacion();
            return tipoIdentificacionDAL.ObtenerTipoIdentificacion();
        }
    }
}
