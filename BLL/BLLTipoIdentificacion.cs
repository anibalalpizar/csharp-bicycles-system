using ProyectoProgramadolll.DAL;
using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
