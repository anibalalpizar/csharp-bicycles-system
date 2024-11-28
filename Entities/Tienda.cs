

namespace ProyectoProgramadolll.Entities
{
    public class Tienda
    {
        public int IdTienda { get; set; }
        public string CedulaJuridica { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public decimal ImpuestoVenta { get; set; }
        public override string ToString() => $"Tienda: {Nombre}, Cedula Juridica: {CedulaJuridica}";
    }
}
