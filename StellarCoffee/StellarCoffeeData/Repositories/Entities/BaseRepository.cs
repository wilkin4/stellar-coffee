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
        private readonly StellarCoffeeDbContext _context;

        public BaseRepository()
        {
            _context = new StellarCoffeeDbContext();
        }

        public int Create(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();

            PropertyInfo propertyInfo = entity.GetType().GetProperty("Id");
            int entityId = (int)propertyInfo.GetValue(entity);

            return entityId;
        }

        public void Delete(int id)
        {
            TEntity entity = _context.Set<TEntity>().Find(id);

            PropertyInfo propertyInfo = entity.GetType().GetProperty("Status");

            bool entityStatus = (bool)propertyInfo.GetValue(entity);

            propertyInfo.SetValue(entity, false);

            _context.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().AsNoTracking().Where(predicate).FirstOrDefault();
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().ToList();
        }

        public void Update(TEntity entity)
        {
            int id = (int)entity.GetType().GetProperty("Id").GetValue(entity);

            TEntity actualEntity = _context.Set<TEntity>().Find(id);

            _context.Entry(actualEntity).CurrentValues.SetValues(entity);
            _context.SaveChanges();
        }
    }
}
