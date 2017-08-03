using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickbooksExtractor.Models
{
    public class Account
    {
        public string ListID { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public bool IsActive { get; set; }
        public string ParentRefListID { get; set; }
        public string ParentRefFullName { get; set; }
        public int Sublevel { get; set; }
        public string AccountType { get; set; }
        public string SpecialAccountType { get; set; }
        public bool IsTaxAccount { get; set; }
        public string AccountNumber { get; set; }
        public string BankNumber { get; set; }
        public string Desc { get; set; }
        public decimal Balance { get; set; }
        public decimal TotalBalance { get; set; }
        public decimal OpenBalance { get; set; }
        public System.DateTime OpenBalanceDate { get; set; }
        public string SalesTaxCodeRefListID { get; set; }
        public string SalesTaxCodeRefFullName { get; set; }
        public string TaxCodeRefListID { get; set; }
        public string TaxCodeRefFullName { get; set; }
        public Nullable<int> TaxLineInfoRetTaxLineID { get; set; }
        public string TaxLineInfoRetTaxLineName { get; set; }
        public string CashFlowClassification { get; set; }
        public string CurrencyRefListID { get; set; }
        public string CurrencyRefFullName { get; set; }
    }
}
