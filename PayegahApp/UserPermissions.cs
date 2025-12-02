using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayegahApp
{
    public class UserPermissions
    {
        public bool CanPerson { get; set; } = true;
        public bool CanEntranceExit { get; set; } = true;
        public bool CanRoll { get; set; } = true;
        public bool CanMemberInsert { get; set; } = true;
        public bool CanEvent { get; set; } = true;
        public bool CanOperationMember { get; set; } = true;
        public bool CanAmat { get; set; } = true;
        public bool CanReport { get; set; } = true;
        public bool CanManageLogin { get; set; } = true;
    }
}
