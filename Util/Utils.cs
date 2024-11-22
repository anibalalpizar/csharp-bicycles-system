using Newtonsoft.Json;
using ProyectoProgramadolll.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public static class Utils
{

    public static void CultureInfo()
    {
        // Colocar Cultura Estandar para Costa Rica
        // esto me permite no tener problemas con (.) de los decimales
        CultureInfo Micultura = new CultureInfo("es-CR", false);
        Micultura.NumberFormat.CurrencySymbol = "¢";
        Micultura.NumberFormat.CurrencyDecimalDigits = 2;
        Micultura.NumberFormat.CurrencyDecimalSeparator = ".";
        Micultura.NumberFormat.CurrencyGroupSeparator = ",";
        int[] grupo = new int[] { 3, 3, 3 };
        Micultura.NumberFormat.CurrencyGroupSizes = grupo;
        Micultura.NumberFormat.NumberDecimalDigits = 2;
        Micultura.NumberFormat.NumberGroupSeparator = ",";
        Micultura.NumberFormat.NumberDecimalSeparator = ".";
        Micultura.NumberFormat.NumberGroupSizes = grupo;
        //Micultura.DateTimeFormat.
        Thread.CurrentThread.CurrentCulture = Micultura;


    }
    public static async Task<List<Provincia>> ObtenerProvinciasAsync()
    {
        string url = "https://raw.githubusercontent.com/lateraluz/Datos/master/provincias.json";
        try
        {
            HttpResponseMessage response = await new HttpClient().GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var provincias = JsonConvert.DeserializeObject<List<Provincia>>(responseBody);
            return provincias ?? new List<Provincia>();
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"Error al obtener provincias: {ex.Message}");
            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al obtener provincias: {ex.Message}");
            return null;
        }
    }

    public static async Task<List<Canton>> ObtenerCantonesAsync()
    {
        string url = "https://raw.githubusercontent.com/lateraluz/Datos/master/cantones.json";
        try
        {
            HttpResponseMessage response = await new HttpClient().GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var cantones = JsonConvert.DeserializeObject<List<Canton>>(responseBody);
            return cantones ?? new List<Canton>();
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"Error al obtener cantones: {ex.Message}");
            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al obtener cantones: {ex.Message}");
            return null;
        }
    }

    public static async Task<List<Distrito>> ObtenerDistritosAsync()
    {
        string url = "https://raw.githubusercontent.com/lateraluz/Datos/master/distritos.json";
        try
        {
            HttpResponseMessage response = await new HttpClient().GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var distritos = JsonConvert.DeserializeObject<List<Distrito>>(responseBody);
            return distritos ?? new List<Distrito>();
        }
        catch (HttpRequestException ex)
        {
            return null;
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public static async Task<String> ObtenerNombreClienteHaciendaAsync(string identificacion)
    {
        string url = $"https://api.hacienda.go.cr/fe/ae?identificacion={identificacion}";
        try
        {
            HttpResponseMessage response = await new HttpClient().GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            var clienteInfo = JsonConvert.DeserializeObject<Cliente>(responseBody);

            return clienteInfo?.Nombre ?? "Sin resultados";

        }
        catch (HttpRequestException ex)
        {
            return null;
        }
        catch (Exception ex)
        {
            
            return null;
        }
    }

    public static async Task<decimal> ObtenerTipoCambioAsync()
    {
        string url = "https://tipodecambio.paginasweb.cr/api";
        try
        {
            HttpResponseMessage response = await new HttpClient().GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            var tipoCambio = JsonConvert.DeserializeObject<ProductoServicio>(responseBody);
            return tipoCambio?.Venta ?? 0m;
        }catch (HttpRequestException ex)
        {
            return 0m;
        }
        catch (Exception ex)
        {
            return 0m;
        }
    }


    public static byte[] ImageToByteArray(Image image)
    {
        using (MemoryStream ms = new MemoryStream())
        {
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }
    }

}

