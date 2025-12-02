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

        private PayegahRepository<Users> _UsersRepository;
        public PayegahRepository<Users> UserRepository
        {
            get
            {
                if (_UsersRepository == null)
                {
                    _UsersRepository=new PayegahRepository<Users>(db);
                }
                return _UsersRepository;
            }
        }

        private PayegahRepository<DecriptionOperation> _OPDescriptionRepository;
        public PayegahRepository<DecriptionOperation> OPDescriptionRepository
        {
            get
            {
                if (_OPDescriptionRepository == null)
                {
                    _OPDescriptionRepository = new PayegahRepository<DecriptionOperation>(db);
                }
                return _OPDescriptionRepository;
            }
        }
        private PayegahRepository<AmadMembers> _AmadMemberRepository;
        public PayegahRepository<AmadMembers> AmadMemberRepository
        {
            get
            {
                if (_AmadMemberRepository == null)
                {
                    _AmadMemberRepository = new PayegahRepository<AmadMembers>(db);
                }
                return _AmadMemberRepository;
            }
        }
        private PayegahRepository<Amad> _AmadRepository;
        public PayegahRepository<Amad> AmadRepository
        {
            get
            {
                if (_AmadRepository == null)
                {
                    _AmadRepository = new PayegahRepository<Amad>(db);
                }
                return _AmadRepository;
            }
        }
        private PayegahRepository<AmadType> _AmadTypeRepository;
        public PayegahRepository<AmadType> AmadTypeRepository
        {
            get
            {
                if (_AmadTypeRepository == null)
                {
                    _AmadTypeRepository = new PayegahRepository<AmadType>(db);
                }
                return _AmadTypeRepository;
            }
        }
        private PayegahRepository<Operations> _OperationsRepository;
        public PayegahRepository<Operations> OperationsRepository
        {
            get
            {
                if (_OperationsRepository == null)
                {
                    _OperationsRepository = new PayegahRepository<Operations>(db);
                }
                return _OperationsRepository;
            }
        }
        private PayegahRepository<OperationMembers> _OperationMembersRepository;
        public PayegahRepository<OperationMembers> OperationMembersRepository
        {
            get
            {
                if (_OperationMembersRepository == null)
                {
                    _OperationMembersRepository = new PayegahRepository<OperationMembers>(db);
                }
                return _OperationMembersRepository;
            }
        }
        private PayegahRepository<OperationDgree> _OperationDgreeRepository;
        public PayegahRepository<OperationDgree> OperationDgreeRepository
        {
            get
            {
                if (_OperationDgreeRepository == null)
                {
                    _OperationDgreeRepository = new PayegahRepository<OperationDgree>(db);
                }
                return _OperationDgreeRepository;
            }
        }
        private PayegahRepository<OperationType> _OperationTypeRepository;
        public PayegahRepository<OperationType> OperationTypeRepository
        {
            get
            {
                if (_OperationTypeRepository == null)
                {
                    _OperationTypeRepository = new PayegahRepository<OperationType>(db);
                }
                return _OperationTypeRepository;
            }
        }
        private PayegahRepository<EventMembers> _MemberEventRepository;
        public PayegahRepository<EventMembers> MemberEventRepository
        {
            get
            {
                if (_MemberEventRepository == null)
                {
                    _MemberEventRepository = new PayegahRepository<EventMembers>(db);
                }
                return _MemberEventRepository;
            }

        }
        private PayegahRepository<EventType> _EventTypeRopsitory;
        public PayegahRepository<EventType> EventTypeRopsitory
        {
            get
            {
                if (_EventTypeRopsitory == null)
                {
                    _EventTypeRopsitory = new PayegahRepository<EventType>(db);
                }
                return _EventTypeRopsitory;
            }

        }
        private PayegahRepository<Events> _EventsRepository;
        public PayegahRepository<Events> EventsRepository
        {
            get
            {
                if (_EventsRepository == null)
                {
                    _EventsRepository = new PayegahRepository<Events>(db);
                }
                return _EventsRepository;
            }

        }
        private PayegahRepository<MemberRole> _MemberRoleRepository;
        public PayegahRepository<MemberRole> MemberRoleRepository
        {
            get
            {
                if (_MemberRoleRepository == null)
                {
                    _MemberRoleRepository = new PayegahRepository<MemberRole>(db);
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
