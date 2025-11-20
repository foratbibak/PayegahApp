using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PayegahDataLayer.Context;


namespace PayegahDataLayer.Services
{
    public class PayegahRepository<TEntity> where TEntity : class
    {
        private PayegahDbEntites _db;
        private DbSet<TEntity> _dbSet;
        public PayegahRepository(PayegahDbEntites db)
        {
            _db = db;
            _dbSet=_db.Set<TEntity>();
            
        }
        public virtual IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> where = null)
        {
            IQueryable<TEntity> qury = _dbSet;
            if(where != null)
            {
                qury = qury.Where(where);
            }
            return qury.ToList();
        }
        public virtual TEntity GetbyID(Object Id)
        {
            return _dbSet.Find(Id);
        }
        public virtual void Insert (TEntity entity)
        {
            _dbSet.Add(entity);
        }
        public virtual void Update (TEntity entity)
        {
            _dbSet.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
        }   
        public virtual void Delete (TEntity entity)
        {
            if(_db.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }
        public virtual void DeletebyId(Object Id)
        {
            var entity =GetbyID(Id);
            Delete(entity);           
        }
        public virtual IEnumerable<Persons> Fillter(string parameter)
        {
            return _db.Persons.Where(p=> (p.PersonName + " " + p.PersonFamily).Contains(parameter)||p.PhoneNumber.Contains(parameter)).ToList();
        }
    }
}
