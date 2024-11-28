using Newtonsoft.Json;
using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.DAL
{
    internal class ProvinciaDAL : IProvinciaService
    {
        public async Task<List<Provincia>> ObtenerProvincias()
        {
            using (HttpClient client = new HttpClient())
            {
                var json = await client.GetStringAsync("https://raw.githubusercontent.com/lateraluz/Datos/master/provincias.json");
                var provincias = JsonConvert.DeserializeObject<List<Provincia>>(json);

                return provincias;
            }
        }
        public async Task<List<Canton>> ObtenerCantones()
        {
            using (HttpClient client = new HttpClient())
            {
                var json = await client.GetStringAsync("https://raw.githubusercontent.com/lateraluz/Datos/master/cantones.json");
                return JsonConvert.DeserializeObject<List<Canton>>(json);
            }
        }

        public async Task<List<Distrito>> ObtenerDistritos()
        {
            using (HttpClient client = new HttpClient())
            {
                var json = await client.GetStringAsync("https://raw.githubusercontent.com/lateraluz/Datos/master/distritos.json");
                return JsonConvert.DeserializeObject<List<Distrito>>(json);
            }
        }

    }
}
