using System;
using System.Collections.Generic;

namespace QuickbooksExtractor.Models
{
    public class QBClass
    {
        public string ListID { get; set; }
        public Nullable<System.DateTime> TimeCreated { get; set; }
        public Nullable<System.DateTime> TimeModified { get; set; }
        public string EditSequence { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public bool IsActive { get; set; }
        public string ParentRefListID { get; set; }
        public string ParentRefFullName { get; set; }
        public Nullable<int> Sublevel { get; set; }
    }
}
