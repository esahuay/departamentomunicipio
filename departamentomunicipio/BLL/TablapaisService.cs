using departamentomunicipio.Models;
using departamentomunicipio.Utils;
using Microsoft.EntityFrameworkCore;

namespace departamentomunicipio.BLL
{
    public class TablapaisService : ITablapais
    {
        private readonly paisContext _context;
        public TablapaisService(paisContext context)
        {
            _context = context;
        }

        public async Task<Tablapai> GetTablapaisPorId(int id)
        {
            var tablapai = await _context.Set<Tablapai>().AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            return tablapai ?? new Tablapai();
        }

        public async Task<List<Tablapai>> GetTablapais()
        {
            var tablapais = await _context.Set<Tablapai>().ToListAsync();
            return tablapais ?? new List<Tablapai>();
        }

        public async Task<Tablapai> PostTablapais(Tablapai model)
        {
            await _context.AddAsync(model);
            await _context.SaveChangesAsync();
            return model ?? new Tablapai();
        }

        public async Task<Tablapai> PutTablapais(int Id, Tablapai tablapais)
        {
            var model = await GetTablapaisPorId(Id);
            if(model == null || Id != model.Id)
            {
                return new Tablapai();
            }
            var entity = _context.Set<Tablapai>().Update(tablapais);
            entity.Property(x => x.Id).IsModified = false;
            await _context.SaveChangesAsync();
            return tablapais;
        }
    }
}
