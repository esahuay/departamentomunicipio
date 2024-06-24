using departamentomunicipio.Models;

namespace departamentomunicipio.Utils
{
    public interface IDepartamentoService
    {
        Task<List<Departamento>> GetDepartamentos();
        Task<Departamento> GetDepartamento(int id);
        Task<Departamento> PostDepartamento(Departamento departamento);
        Task<Departamento> PutDepartamento(int id, Departamento departamento);
    }
}
