using StellarCoffeeData.Context;
using StellarCoffeeData.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StellarCoffeeData.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly StellarCoffeeDbContext Context;

        public BaseRepository()
        {
            Context = new StellarCoffeeDbContext();
        }

        public int Create(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
            Context.SaveChanges();

            PropertyInfo propertyInfo = entity.GetType().GetProperty("Id");
            int entityId = (int)propertyInfo.GetValue(entity);

            return entityId;
        }

        public void Delete(int id)
        {
            TEntity entity = Context.Set<TEntity>().Find(id);

            PropertyInfo propertyInfo = entity.GetType().GetProperty("Status");

            bool entityStatus = (bool)propertyInfo.GetValue(entity);

            propertyInfo.SetValue(entity, false);

            Context.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().AsNoTracking().Where(predicate).FirstOrDefault();
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().ToList();
        }

        public void Update(TEntity entity)
        {
            int id = (int)entity.GetType().GetProperty("Id").GetValue(entity);

            TEntity actualEntity = Context.Set<TEntity>().Find(id);

            Context.Entry(actualEntity).CurrentValues.SetValues(entity);
            Context.SaveChanges();
        }
    }
}
