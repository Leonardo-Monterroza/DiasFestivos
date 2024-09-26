using DiasFestivos.Dominio.Entidades;

namespace DiasFestivos.Core.Interfaces.Repositorios
{
    public interface IFestivoRepositorio
    {
        Task<IEnumerable<TBFestivos>> ObtenerTodos();
    }
}
