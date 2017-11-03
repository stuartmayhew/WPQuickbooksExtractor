using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickbooksExtractor.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string QBFile { get; set; }
        public string Branch { get; set; }
        public string ListID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public DateTime DOB { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Department { get; set; }
        public bool IsActive { get; set; }
        public string Salutation { get; set; }
        public string JobTitleID { get; set; }
        public string SupervisorID { get; set; }
        public string Phone { get; set; }
        public string Cell { get; set; }
        public string WorkCell { get; set; }
        public string WorkPhone { get; set; }
        public string Email { get; set; }
        public string WorkEmail { get; set; }
        public string EmployeeType { get; set; }
        public string BillingRateRefListID { get; set; }
        public string BillingRateRefFullName { get; set; }
        public string PayrollInfoPayPeriod { get; set; }
        public string PayrollInfoClassRefListID { get; set; }
        public string PayrollInfoClassRefFullName { get; set; }
        public string PayrollInfoUseTimeDataToCreatePaychecks { get; set; }
    }
}
