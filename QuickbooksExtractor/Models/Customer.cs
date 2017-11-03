using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickbooksExtractor.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string QBFile { get; set; }
        public string Branch { get; set; }
        public string ListID { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string ParentRefListID { get; set; }
        public string ParentRefFullName { get; set; }
        public bool IsActive { get; set; }
        public int Sublevel { get; set; }
        public string CompanyName { get; set; }
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string BillAddressAddr1 { get; set; }
        public string BillAddressAddr2 { get; set; }
        public string BillAddressCity { get; set; }
        public string BillAddressState { get; set; }
        public string BillAddressPostalCode { get; set; }
        public string BillAddressNote { get; set; }
        public string ShipAddressAddr1 { get; set; }
        public string ShipAddressAddr2 { get; set; }
        public string ShipAddressCity { get; set; }
        public string ShipAddressState { get; set; }
        public string ShipAddressPostalCode { get; set; }
        public string ShipAddressNote { get; set; }
        public string TermsRefListID { get; set; }
        public string TermsRefFullName { get; set; }
        public string SalesTaxCodeRefListID { get; set; }
        public string SalesTaxCodeRefFullName { get; set; }
        public string TaxCodeRefListID { get; set; }
        public string TaxCodeRefFullName { get; set; }
        public string ItemSalesTaxRefListID { get; set; }
        public string ItemSalesTaxRefFullName { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Cc { get; set; }
        public string Contact { get; set; }
        public bool isParent { get; set; }
    }
}
