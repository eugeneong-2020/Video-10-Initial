using System.Threading.Tasks;
using Data.Repository.Interface;

namespace Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DataContext _dataContext;
        public Repository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<T> AddAsync(T newEntity)
        {
            _dataContext.Set<T>().Add(newEntity);
            await _dataContext.SaveChangesAsync();
            return newEntity;
        }
    }
}