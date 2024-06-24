using departamentomunicipio.Models;

namespace departamentomunicipio.Utils
{
    public interface ITablapais
    {
        Task<List<Tablapai>> GetTablapais();
        Task<Tablapai> GetTablapaisPorId(int id);
        Task<Tablapai> PostTablapais(Tablapai tablapai);
        Task<Tablapai> PutTablapais(int id, Tablapai tablapai);
    }
}
