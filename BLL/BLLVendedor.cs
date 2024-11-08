using ProyectoProgramadolll.DAL;
using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.BLL
{
    public class BLLVendedor : IBLLVendedor
    {
        public Vendedor GuardarVendedor(Vendedor vendedor)
        {
            IDALVendedor dALVendedor = new DALVendedor();
            string mensaje = "";
            Vendedor oVendedor = null;

            if (!EsUnaContrasegnaValida(vendedor.Contrasegna, ref mensaje))
            {
                throw new Exception(mensaje);
            }

            vendedor.Contrasegna = Cryptography.EncrypthAES(vendedor.Contrasegna);

            vendedor = dALVendedor.GuardarVendedor(vendedor);

            return oVendedor;
        }


        private bool EsUnaContrasegnaValida(string contrasegna, ref string mensaje)
        {

            if (contrasegna.Length <= 8)
            {
                mensaje = "La contraseña debe tener al menos 8 caracteres";
                return false;
            }

            if (contrasegna.Trim().Length > 10)
            {
                mensaje = "La contraseña no puede tener más de 10 caracteres";
                return false;
            }

            return true;
        }

        public Vendedor Login(string codigoVendedor, string contrasegna)
        {
            IDALVendedor dALVendedor = new DALVendedor();
            string contrasegnaEncriptada = Cryptography.EncrypthAES(contrasegna);
            return dALVendedor.Login(codigoVendedor, contrasegnaEncriptada);
        }

        public IEnumerable<Vendedor> ObtenerVendedores()
        {
            IDALVendedor dALVendedor = new DALVendedor();
            return dALVendedor.ObtenerVendedores();
        }
    }
}
