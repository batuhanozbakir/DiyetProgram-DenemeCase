using DAL_DiyetProgrami.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DiyetProgrami.Repositories.Abstract
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {

        private protected DbContext _dbContext;
        private protected DbSet<TEntity> _entities;

        protected Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _entities = _dbContext.Set<TEntity>();
        }

        public virtual void Add(TEntity entity)
        {
            _entities.Add(entity);
        }

        public void Update(TEntity entity)
        {
            _entities.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            _entities.Remove(entity);
        }

        public void Delete(int id)
        {
            TEntity entity = _entities.Where(d=>d.Id==id).ToList().SingleOrDefault();
            _entities.Remove(entity);
        }

        public TEntity Get(int id)
        {
            return _entities.Find(id);
        }

        public ICollection<TEntity> GetAll()
        {
            return _entities.ToList();
        }

        
    }
}
