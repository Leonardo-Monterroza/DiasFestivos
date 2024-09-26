using DiasFestivos.Core.Interfaces.Repositorios;
using DiasFestivos.Core.Interfaces.Servicios;
using DiasFestivos.Dominio.Entidades;

namespace DiasFestivos.Aplicacion
{
    public class FestivoServicio : IFestivoServicio
    {
        private readonly IFestivoRepositorio repositorio;

        public FestivoServicio(IFestivoRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public Task<IEnumerable<TBFestivos>> ObtenerTodos()
        {
            return repositorio.ObtenerTodos();
        }
    }
}
