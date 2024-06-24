using departamentomunicipio.Models;

namespace departamentomunicipio.Utils
{
    public interface IMunicipioService
    {
        Task<List<Municipio>> GetMunicipios();
        Task<List<Municipio>> GetMunicipioPorDepartamento(int id);
        Task<Municipio> GetMunicipio(int id);
        Task<Municipio> PostMunicipio(Municipio municipio);
        Task<Municipio> PutMunicipio(int id, Municipio municipio);
    }
}
