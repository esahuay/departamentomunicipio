using departamentomunicipio.Models;
using departamentomunicipio.Utils;
using Microsoft.EntityFrameworkCore;

namespace departamentomunicipio.BLL
{
    public class MunicipioService : IMunicipioService
    {
        private readonly paisContext _context;
        public MunicipioService(paisContext context) 
        {
            _context = context;
        }
        public async Task<Municipio> GetMunicipio(int id)
        {
            var municipio = await _context.Set<Municipio>().AsNoTracking().FirstOrDefaultAsync(x => x.Id==id);
            return municipio ?? new Municipio();
        }

        public async Task<List<Municipio>> GetMunicipioPorDepartamento(int id)
        {
            var municipios = await _context.Set<Municipio>().Where(x => x.DepartamentoId == id).AsNoTracking().ToListAsync();
            return municipios ?? new List<Municipio>();
        }

        public async Task<List<Municipio>> GetMunicipios()
        {
            var municipios = await _context.Set<Municipio>().ToListAsync();
            return municipios ?? new List<Municipio>();
        }

        public async Task<Municipio> PostMunicipio(Municipio municipio)
        {
            await _context.AddAsync(municipio);
            await _context.SaveChangesAsync();
            return municipio ?? new Municipio();
        }

        public async Task<Municipio> PutMunicipio(int id, Municipio municipio)
        {
            var model = await GetMunicipio(id);
            if(model == null || model.Id==0)
            {
                return new Municipio();
            }
            var entity = _context.Set<Municipio>().Update(municipio);
            entity.Property(x => x.Id).IsModified = false;
            entity.Property(x => x.DepartamentoId).IsModified = false;
            await _context.SaveChangesAsync();
            return municipio;
        }
    }
}
