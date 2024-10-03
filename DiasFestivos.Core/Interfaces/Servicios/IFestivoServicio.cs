using DiasFestivos.Dominio.Entidades;

namespace DiasFestivos.Core.Interfaces.Servicios
{
    public interface IFestivoServicio
    {
        Task<IEnumerable<TBFestivos>> ObtenerTodos();
        Task<TBFestivos> Obtener(int Id);
        Task<TBFestivos> ObtenerPorYear(int Year);
    }
}
