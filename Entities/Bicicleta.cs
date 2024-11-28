

namespace ProyectoProgramadolll.Entities
{
    public class Bicicleta
    {
        public int IdBicicleta { get; set; }
        public string NumeroSerie { get; set; }
        public int IdCliente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public override string ToString() => $"IdBicicleta: {IdBicicleta}, NumeroSerie: {NumeroSerie}, IdCliente: {IdCliente}, Marca: {Marca}, Modelo: {Modelo}, Color: {Color}";
    }
}
