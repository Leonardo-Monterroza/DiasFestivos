using DiasFestivos.Dominio.Entidades;

namespace DiasFestivos.Core.Interfaces.Repositorios
{
    public interface IFestivoRepositorio
    {
        Task<IEnumerable<TBFestivos>> ObtenerTodos();
        Task<TBFestivos> Obtener(int Id);
        Task<TBFestivos> ObtenerPorYear(int Year);
    }
}
