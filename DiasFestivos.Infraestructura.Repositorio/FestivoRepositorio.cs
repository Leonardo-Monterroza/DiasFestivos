using DiasFestivos.Core.Interfaces.Repositorios;
using DiasFestivos.Dominio.Entidades;
using DiasFestivos.Infraestructura.Persistencia.Context;
using Microsoft.EntityFrameworkCore;

namespace DiasFestivos.Infraestructura.Repositorio
{
    public class FestivoRepositorio : IFestivoRepositorio
    {
        private readonly DiasFestivoContext context;
        public FestivoRepositorio(DiasFestivoContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<TBFestivos>> ObtenerTodos()
        {
            return await context.festivos.ToArrayAsync();
        }

        public async Task<TBFestivos> Obtener(int Id)
        {
            return await context.festivos.FindAsync(Id);
        }

        public async Task<TBFestivos> ObtenerPorYear(int Year)
        {
            return await context.festivos.FindAsync(Year);
        }
    }
}
