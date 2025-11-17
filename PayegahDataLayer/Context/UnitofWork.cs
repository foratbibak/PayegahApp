using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using PayegahDataLayer.Services;

namespace PayegahDataLayer.Context
{
    public class UnitofWork : IDisposable
    {
        PayegahDbEntities db = new PayegahDbEntities();
        private PayegahRepository<MemberRole> _MemberRoleRepository;
        public PayegahRepository<MemberRole> MemberRoleRepository
        {
            get
            {
                if (_MemberRoleRepository == null)
                {
                    _MemberRoleRepository=new PayegahRepository<MemberRole>(db);
                }
                return _MemberRoleRepository;
            }

        }
        private PayegahRepository<Members> _MemberRepository;
        public PayegahRepository<Members> MemberRepository
        {
            get
            {
                if (_MemberRepository == null)
                {
                    _MemberRepository = new PayegahRepository<Members>(db);
                }
                return _MemberRepository;
            }
        }
        private PayegahRepository<Role> _RoleRepository;
        public PayegahRepository<Role> RoleRepository
        {
            get
            {
                if (_RoleRepository == null)
                {
                    _RoleRepository = new PayegahRepository<Role>(db);
                }
                return (_RoleRepository);
            }
        }
        private PayegahRepository<RoleType> _RoleTypeRepository;
        public PayegahRepository<RoleType> RoleTypeRepository
        {
            get
            {
                if (_RoleTypeRepository == null)
                {
                    _RoleTypeRepository = new PayegahRepository<RoleType>(db);
                }
                return _RoleTypeRepository;
            }
        }

        private PayegahRepository<Attendance_absence> _Attendance_AbsenceRepository;

        public PayegahRepository<Attendance_absence> Attendance_AbsenceRepository
        {
            get
            {
                if (_Attendance_AbsenceRepository == null)
                {
                    _Attendance_AbsenceRepository = new PayegahRepository<Attendance_absence>(db);
                }
                return _Attendance_AbsenceRepository;
            }
        }

        private PayegahRepository<Persons> _PersonsRepository;

        public PayegahRepository<Persons> PersonsRepository
        {
            get
            {
                if (_PersonsRepository == null)
                {
                    _PersonsRepository = new PayegahRepository<Persons>(db);
                }
                return _PersonsRepository;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
