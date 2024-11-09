using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.BLL
{
    public class BLLClientes : IBLLClientes
    {
        public List<Cliente> ObtenerClientes()
        {
            IDALClientes dalClientes = new DAL.DALClientes();
            return dalClientes.ObtenerClientes();
        }
    }
}
