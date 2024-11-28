using ProyectoProgramadolll.DTO;

namespace ProyectoProgramadolll.Interfaces
{
    public interface IBLLPadron
    {
        PadronDTO GetPersonaById(string IdCliente);
    }
}
