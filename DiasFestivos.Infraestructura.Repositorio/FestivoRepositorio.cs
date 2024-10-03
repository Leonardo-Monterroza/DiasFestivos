using DiasFestivos.Core.Interfaces.Repositorios;
using DiasFestivos.Dominio.Entidades;
using DiasFestivos.Infraestructura.Persistencia.Context;
using DTOs;
using Microsoft.EntityFrameworkCore;
using System;

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

        public async Task<IEnumerable<DTOsFestivos>> ObtenerPorYear(int Year)
        {
            var festivoFijo = await context.festivos.Where(f => f.IdTipo == 1).ToListAsync();
            var festivosTipo3 = await context.festivos.Where(f => f.IdTipo == 3).ToListAsync();

            DateTime domingoPascua = ObtenerDomingoDePascua(Year);

            var dtosFestivos = festivoFijo.Select(f => new DTOsFestivos
            {
                Nombre = f.Nombre,
                Fecha = ($"{Year}/{f.Mes}/{f.Dia}"),

            }).ToList();

            return dtosFestivos;
        }

        private DateTime ObtenerDomingoDePascua(int year)
        {
            int a = year % 19;
            int b = year % 4;
            int c = year % 7;
            int d = ((19*a)+24) % 30;

            int dia = d + ((2*b)+(4*c)+(6*d)+5)%7;
            dia = 15 + dia;
            int mes = 3;

            if (dia > 31)
            {
                dia = dia - 31;
                mes = 4;
            }
            return new DateTime(year, mes, dia);

        }
    }

}
