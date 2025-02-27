﻿using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Entities.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Interfaces
{
    public interface IDALBicicleta
    {
        Task<Bicicleta> GuardarBicicleta(Bicicleta bicicleta);
        Task<IEnumerable<BicicletaDTO>> ObtenerBicicletas();
        Task<bool> EliminarBiicleta(string idBicicleta);
        Bicicleta ObtenerBicicletaPorSerie(string numeroSerie);
        Task<Bicicleta> ActualizarBicicleta(Bicicleta bicicleta);
        Task<IEnumerable<BicicletaDTO>> ObtenerBicicletasPorVendedor(int idVendedor);

    }
}
