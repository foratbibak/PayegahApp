using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayegahDataLayer;

namespace PayegahViewModel
{
    public class PayegahList
    {
        public int ID {  get; set; }
        public Int64 PersonID { get; set; }
        public string Name { get; set; }
        public string Family { get; set; } 
        public string EntranceDate { get; set; }
        public string ExitDate { get; set; }
        public string Locked {  get; set; }
        public Persons Persons { get; set; }

    }
}
