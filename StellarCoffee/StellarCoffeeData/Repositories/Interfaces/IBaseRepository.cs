using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StellarCoffeeData.Repositories.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        TEntity Get(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
        int Create(TEntity entity);
        void Update();
        void Delete(int id);
    }
}
