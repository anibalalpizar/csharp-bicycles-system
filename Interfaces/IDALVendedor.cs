using ProyectoProgramadolll.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Interfaces
{
    public interface IDALVendedor
    {
        Vendedor Login(string codigoVendedor, string contrasegna);
        Vendedor GuardarVendedor(Vendedor vendedor);
        IEnumerable<Vendedor> ObtenerVendedores();
    }
}
