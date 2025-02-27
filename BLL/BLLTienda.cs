﻿using ProyectoProgramadolll.DAL;
using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.BLL
{
    public class BLLTienda : IBLLTienda

    {
        public Task<bool> EliminarTienda(string idTienda)
        {
            IDALTienda tiendaDAL = new DALTienda();
            return tiendaDAL.EliminarTienda(idTienda);

        }

        public bool ValidarTienda(string idTienda)
        {
            IDALTienda tiendaDAL = new DALTienda();
            return tiendaDAL.ValidarTienda(idTienda);
        }

        public Task<Tienda> GuardarTienda(Tienda tienda)
        {
            IDALTienda tiendaDAL = new DALTienda();
            Task<Tienda> tiendaTask = null;
            if (tiendaDAL.ObtenerTiendaPorId(tienda.CedulaJuridica.ToString()) == null)
                tiendaTask = tiendaDAL.GuardarTienda(tienda);

            else
                tiendaTask = tiendaDAL.ActualizarTienda(tienda);


            return tiendaTask;

        }

        public Task<IEnumerable<Tienda>> ObtenerTodasLasTiendas()
        {
            IDALTienda tiendaDAL = new DALTienda();
            return tiendaDAL.ObtenerTodasLasTiendas();

        }
    }
}
