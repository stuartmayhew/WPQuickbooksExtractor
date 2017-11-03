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
        public string CompanyName { get; set; }
        public string VendorAddressAddr1 { get; set; }
        public string VendorAddressAddr2 { get; set; }
        public string VendorAddressAddr3 { get; set; }
        public string VendorAddressAddr4 { get; set; }
        public string VendorAddressCity { get; set; }
        public string VendorAddressState { get; set; }
        public string VendorAddressPostalCode { get; set; }
        public string VendorAddressNote { get; set; }
        public string ShipAddressAddr1 { get; set; }
        public string ShipAddressAddr2 { get; set; }
        public string ShipAddressAddr3 { get; set; }
        public string ShipAddressCity { get; set; }
        public string ShipAddressState { get; set; }
        public string ShipAddressPostalCode { get; set; }
        public string ShipAddressNote { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string NameOnCheck { get; set; }
        public string Notes { get; set; }
        public string TermsRefListID { get; set; }
        public string TermsRefFullName { get; set; }
        public string VendorTaxIdent { get; set; }
        public bool IsVendorEligibleFor1099 { get; set; }
        public bool IsVendorEligibleForT4A { get; set; }
    }
}
