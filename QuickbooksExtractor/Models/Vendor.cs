using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickbooksExtractor.Models
{
    public class Vendor
    {
        public int VendorID { get; set; }
        public string QBFile { get; set; }
        public string ListID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsTaxAgency { get; set; }
        public string CompanyName { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string Addr3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string AltPhone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string NameOnCheck { get; set; }
        public string AccountNumber { get; set; }
        public string Notes { get; set; }
        public string TermsRefListID { get; set; }
        public string TermsRefFullName { get; set; }
        public decimal CreditLimit { get; set; }
        public string VendorTaxIdent { get; set; }
        public bool is1099 { get; set; }
        public bool isT4A { get; set; }
    }
}
