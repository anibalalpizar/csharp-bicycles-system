

namespace ProyectoProgramadolll.Entities
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Identificacion { get; set; }
        public int IdTipoIdentificacion { get; set; }
        public string Nombre { get; set; }
        public bool Sexo { get; set; }
        public string CorreoElectronico { get; set; }
        public int IdDireccion { get; set; }
        public string Contrasegna { get; set; }

        public int IdRol { get; set; }

        public bool Estado { get; set; }
        public Direccion Direccion { get; set; }
        public override string ToString() => $"{Nombre}";

    }
}
