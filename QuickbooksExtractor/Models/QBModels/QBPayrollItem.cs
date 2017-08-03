using System;
using System.Collections.Generic;
//------------------------------------------------------------------------------

namespace QuickbooksExtractor.Models
{
    public class QBPayrollItem
    {
        public string ListID { get; set; }
        public Nullable<System.DateTime> TimeCreated { get; set; }
        public Nullable<System.DateTime> TimeModified { get; set; }
        public string EditSequence { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string WageType { get; set; }
        public string ExpenseAccountRefListID { get; set; }
        public string ExpenseAccountRefFullName { get; set; }
    }
}
