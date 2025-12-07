using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Accounting.utility.Convertor;
using PayegahDataLayer.Context;


namespace PayegahDataLayer.Services
{
    public class PayegahRepository<TEntity> where TEntity : class
    {
        private PayegahDbEntities _db;
        private DbSet<TEntity> _dbSet;
        public PayegahRepository(PayegahDbEntities db)
        {
            _db = db;
            _dbSet = _db.Set<TEntity>();

        }
        public virtual IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> where = null)
        {
            IQueryable<TEntity> qury = _dbSet;
            if (where != null)
            {
                qury = qury.Where(where);
            }
            return qury.ToList();
        }
        public virtual TEntity GetbyID(Object Id)
        {
            return _dbSet.Find(Id);
        }
        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }
        public virtual void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Delete(TEntity entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }
        public virtual void DeletebyId(Object Id)
        {
            var entity = GetbyID(Id);
            Delete(entity);
        }
        public virtual IEnumerable<Persons> Fillter(string parameter) { return _db.Persons.Where(p => (p.PersonName + " " + p.PersonFamily).Contains(parameter) || p.PhoneNumber.Contains(parameter)).ToList(); }

        public virtual IEnumerable<object> FilterByCodeEvent(string parameter)
        {
            var data = _db.EventMembers
                .Include(e => e.Members.Persons)
                .Include(e => e.Events)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(parameter))
            {
                data = data.Where(e =>
                    e.Members.PersonID.ToString().Contains(parameter)
                    || e.EventID.ToString().Contains(parameter));
            }

            var list = data.ToList();

            return list.Select(s => new
            {
                s.ID,
                s.Members.Persons.PersonFullName,
                s.Members.PersonID,
                s.Events.EventTitle,
                s.Events.EventType.Title,
                s.IsActive,
                Date = s.DateRegestration != null ? s.DateRegestration.Value.ToShamsi() : ""
            }).ToList();
        }

        public virtual IEnumerable<object> FilterByCodeRole(string parameter)
        {
            var data = _db.MemberRole
                .Include(e => e.Members.Persons)
                .Include(e => e.Role)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(parameter))
            {
                data = data.Where(e =>
                    e.Members.PersonID.ToString().Contains(parameter)
                    || e.Role_ID.ToString().Contains(parameter));
            }

            var list = data.ToList();

            return list.Select(s => new
            {
                s.ID,
                s.Role.Role_ID,
                s.Members.Persons.PersonFullName,
                s.Members.PersonID,
                s.Role.RoleTitle,
                s.RoleType.TypeTitle,
                s.IActive,
                Date = s.DateRegestration != null ? s.DateRegestration.Value.ToShamsi() : ""
            }).ToList();
        }

        public virtual IEnumerable<object> FilterByCodeOp(string parameter)
        {
            var data = _db.OperationMembers
                .Include(e => e.Members.Persons)
                .Include(e => e.Operations)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(parameter))
            {
                data = data.Where(e =>
                    e.Members.PersonID.ToString().Contains(parameter)
                    || e.OperationID.ToString().Contains(parameter));
            }

            var list = data.ToList();

            return list.Select(s => new
            {
                s.OperationMemberID,
                s.Members.Persons.PersonFullName,
                s.Members.PersonID,
                s.Operations.OperationTitle,
                s.OperationDgree.DgTitle,
                s.IsActive,
                Date = s.DateRegstration != null ? s.DateRegstration.ToShamsi() : ""
            }).ToList();
        }

        public virtual IEnumerable<object> FilterByCodeAmad(string parameter)
        {
            var data = _db.AmadMembers
                .Include(e => e.Members.Persons)
                .Include(e => e.Amad.AmadType)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(parameter))
            {
                data = data.Where(e =>
                    e.Members.PersonID.ToString().Contains(parameter)
                    || e.Members.Persons.PersonName.Contains(parameter)
                    || e.Members.Persons.PersonFamily.Contains(parameter));
            }

            var list = data.ToList();

            return list.Select(s => new
            {
                s.ID,
                PersonFullName = s.Members.Persons.PersonName + " " + s.Members.Persons.PersonFamily,
                s.Members.PersonID,
                AmadTitle = s.Amad.AmadTitle,
                AmadTypeTitle = s.Amad.AmadType.AmadTypeTitle,
                s.IsActive,
                Date = s.AmadDateRegestration != null ? s.AmadDateRegestration.Value.ToShamsi() : ""
            }).ToList();
        }
    }
}
