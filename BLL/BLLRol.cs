using ProyectoProgramadolll.DAL;
using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Interfaces;
using System.Collections.Generic;

namespace ProyectoProgramadolll.BLL
{
    public class BLLRol : IBLLRol
    {
        public List<Rol> ObtenerRoles()
        {
            IDALRol dALRol = new DALRol();
            return dALRol.ObtenerRoles();
        }
    }
}
