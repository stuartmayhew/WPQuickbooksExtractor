using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickbooksExtractor.Models
{
    public class Clss
    {
        public int ClassID { get; set; }
        public string QBFile { get; set; }
        public string Branch { get; set; }
        public string ListID { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public bool IsActive { get; set; }
        public string ParentRefListID { get; set; }
        public string ParentRefFullName { get; set; }
        public int Sublevel { get; set; }
    }
}
