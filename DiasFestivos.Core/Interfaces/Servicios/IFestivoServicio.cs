using DiasFestivos.Dominio.Entidades;

namespace DiasFestivos.Core.Interfaces.Servicios
{
    public interface IFestivoServicio
    {
        Task<IEnumerable<TBFestivos>> ObtenerTodos();
    }
}
