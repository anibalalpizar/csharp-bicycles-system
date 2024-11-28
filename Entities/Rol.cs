

namespace ProyectoProgramadolll.Entities
{
    public class Rol
    {
        public int IdRol { get; set; }
        public string DescripcionRol { get; set; }
        public override string ToString() => $"{IdRol}-{DescripcionRol}";
    }
}
