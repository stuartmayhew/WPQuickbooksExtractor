using System;
using System.Collections.Generic;

namespace QuickbooksExtractor.Models
{

    public  class QBAccount
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
        public string AccountType { get; set; }
        public string SpecialAccountType { get; set; }
        public bool IsTaxAccount { get; set; }
        public string AccountNumber { get; set; }
        public string BankNumber { get; set; }
        public string Desc { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public Nullable<decimal> TotalBalance { get; set; }
        public Nullable<decimal> OpenBalance { get; set; }
        public Nullable<System.DateTime> OpenBalanceDate { get; set; }
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
