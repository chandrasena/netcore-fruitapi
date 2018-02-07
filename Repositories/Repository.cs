using System.Linq;
using System.Threading.Tasks;
using fruit_api.Models;
using Microsoft.EntityFrameworkCore;

namespace fruit_api
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class,IEntity
    {
        public FruitContext Context { get; set; }
        public IUnitOfWork UnitOfWork { get; set; }

        public Task Create(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        // public Repository(FruitContext dbContext)
        // {
        //     _dbContext = dbContext;
        // }

        public IQueryable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().AsNoTracking();
        }

        public Task<TEntity> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(int id, TEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
    
}