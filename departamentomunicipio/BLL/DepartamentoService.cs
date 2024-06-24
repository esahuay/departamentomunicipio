using departamentomunicipio.Models;
using departamentomunicipio.Utils;
using Microsoft.EntityFrameworkCore;

namespace departamentomunicipio.BLL
{
    public class DepartamentoService : IDepartamentoService
    {   
        private readonly paisContext _context;
        public DepartamentoService(paisContext context) {
            _context = context;
        }

        public async Task<Departamento> GetDepartamento(int id)
        {
            var departamento = await _context.Set<Departamento>().AsNoTracking().FirstOrDefaultAsync( x => x.Id == id);
            return departamento ?? new Departamento();
        }

        public async Task<List<Departamento>> GetDepartamentos()
        {
            var departamentos = await _context.Set<Departamento>().ToListAsync();
            return departamentos ?? new List<Departamento>();
        }

        public async Task<Departamento> PostDepartamento(Departamento departamento)
        {
            await _context.AddAsync(departamento);
            await _context.SaveChangesAsync();
            return departamento ?? new Departamento();
        }

        public async Task<Departamento> PutDepartamento(int id, Departamento departamento)
        {
            var model = await GetDepartamento(id);
            if (model == null || id == 0 || id != departamento.Id)
            {
                return new Departamento();
            }
            var entity = _context.Set<Departamento>().Update(departamento);
            entity.Property(x => x.Id).IsModified = false;
            await _context.SaveChangesAsync();
            return departamento;
        }
    }
}
