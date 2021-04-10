using System.Threading.Tasks;

namespace Data.Repository.Interface
{
    public interface IRepository<T> where T : class
    {
        Task<T> AddAsync(T newEntity);
    }
}