using System.Linq;
using System.Threading.Tasks;
using fruit_api.Models;

namespace fruit_api
{
    public interface IRepository<TEntity> where TEntity : class, IEntity
    {
        FruitContext Context { get; set; }
        IUnitOfWork UnitOfWork { get; set; }
        IQueryable<TEntity> GetAll();
        Task<TEntity> GetById(int id);
        Task Create(TEntity entity);
        Task Update(int id, TEntity entity);
        Task Delete(int id);
    }
}