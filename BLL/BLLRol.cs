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
    public class BLLRol : IBLLRol
    {
        public List<Rol> ObtenerRoles()
        {
            IDALRol dALRol = new DALRol();
            return dALRol.ObtenerRoles();
        }
    }
}
