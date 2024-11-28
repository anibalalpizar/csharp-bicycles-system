using System;


namespace ProyectoProgramadolll.Entities
{
    public class Pagos
    {
        public int IdPago { get; set; }
        public string TipoTarjeta { get; set; }
        public string NumeroTarjeta { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal MontoPago { get; set; }
    }
}
