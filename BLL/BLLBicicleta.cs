using ProyectoProgramadolll.DAL;
using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Entities.DTO;
using ProyectoProgramadolll.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.BLL
{
    public class BLLBicicleta : IBLLBicicleta
    {
        public Task<bool> EliminarBicicleta(string idBicicleta)
        {
            IDALBicicleta dalBicicleta = new DALBicicleta();
            return dalBicicleta.EliminarBiicleta(idBicicleta);
        }

        public Task<Bicicleta> GuardarBicicleta(Bicicleta bicicleta)
        {
            IDALBicicleta dalBicicleta = new DALBicicleta();
            Task<Bicicleta> oBicicleta = null;

            if (dalBicicleta.ObtenerBicicletaPorSerie(bicicleta.NumeroSerie.ToString()) == null)
                oBicicleta = dalBicicleta.GuardarBicicleta(bicicleta);
            else
                oBicicleta = dalBicicleta.ActualizarBicicleta(bicicleta);

            return oBicicleta;
        }

        public Task<IEnumerable<BicicletaDTO>> ObtenerBicicletas()
        {
            IDALBicicleta dalBicicleta = new DALBicicleta();
            return dalBicicleta.ObtenerBicicletas();
        }
    }
}
