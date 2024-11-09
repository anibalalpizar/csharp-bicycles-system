using ProyectoProgramadolll.DAL;
using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Entities.DTO;
using ProyectoProgramadolll.Interfaces;
using ProyectoProgramadolll.Util;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.BLL
{
    public class BLLVendedor : IBLLVendedor
    {
        public Vendedor GuardarVendedor(Vendedor vendedor)
        {
            IDALVendedor vendedorDAL = new DALVendedor();
            string mensaje = "";
            Vendedor oVendedor = null;


            if (!EsUnaContrasegnaValida(vendedor.Contrasegna, ref mensaje))
            {
                Log.LogException(new Exception(mensaje));
                return null;
            }
            
            vendedor.Contrasegna = Cryptography.EncrypthAES(vendedor.Contrasegna);

            if ( vendedorDAL.ObtenerVendedorPorId(vendedor.CodigoVendedor.ToString()) == null)
                oVendedor =  vendedorDAL.GuardarVendedor(vendedor);
            else
                oVendedor =  vendedorDAL.ActualizarVendedor(vendedor);
            return oVendedor;
           
        }


        private bool EsUnaContrasegnaValida(string contrasegna, ref string mensaje)
        {

            if (contrasegna.Length < 8)
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
            IDALVendedor vendedorDAL = new DALVendedor();
            string contrasegnaEncriptada = Cryptography.EncrypthAES(contrasegna);
            return vendedorDAL.Login(codigoVendedor, contrasegnaEncriptada);
        }

        public IEnumerable<VendedorDTO> ObtenerVendedores()
        {
            IDALVendedor vendedorDAL = new DALVendedor();
            return vendedorDAL.ObtenerVendedores();
        }


        public Task<bool> EliminarVendedor(string codigoVendedor)
        {
            IDALVendedor vendedorDAL = new DALVendedor();
            return vendedorDAL.EliminarVendedor(codigoVendedor);
        }
    }
}
