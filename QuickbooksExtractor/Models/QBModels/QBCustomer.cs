using System;
using System.Collections.Generic;

namespace QuickbooksExtractor.Models
{
    public class QBCustomer
    {
        public string ListID { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string ParentRefListID { get; set; }
        public string ParentRefFullName { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> Sublevel { get; set; }
        public string CompanyName { get; set; }

        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string BillAddressAddr1 { get; set; }
        public string BillAddressCity { get; set; }
        public string BillAddressState { get; set; }
        public string BillAddressPostalCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Cc { get; set; }
        public string Contact { get; set; }
        public Nullable<System.DateTime> TimeCreated { get; set; }
        public Nullable<System.DateTime> TimeModified { get; set; }
        public string EditSequence { get; set; }
        public string ClassRefListID { get; set; }
        public string ClassRefFullName { get; set; }
        public string BillAddressAddr2 { get; set; }
        public string BillAddressAddr3 { get; set; }
        public string BillAddressAddr4 { get; set; }
        public string BillAddressAddr5 { get; set; }
        public string BillAddressProvince { get; set; }
        public string BillAddressCounty { get; set; }
        public string BillAddressCountry { get; set; }
        public string BillAddressNote { get; set; }
        public string BillAddressBlockAddr1 { get; set; }
        public string BillAddressBlockAddr2 { get; set; }
        public string BillAddressBlockAddr3 { get; set; }
        public string BillAddressBlockAddr4 { get; set; }
        public string BillAddressBlockAddr5 { get; set; }
        public string ShipAddressAddr1 { get; set; }
        public string ShipAddressAddr2 { get; set; }
        public string ShipAddressAddr3 { get; set; }
        public string ShipAddressAddr4 { get; set; }
        public string ShipAddressAddr5 { get; set; }
        public string ShipAddressCity { get; set; }
        public string ShipAddressState { get; set; }
        public string ShipAddressProvince { get; set; }
        public string ShipAddressCounty { get; set; }
        public string ShipAddressPostalCode { get; set; }
        public string ShipAddressCountry { get; set; }
        public string ShipAddressNote { get; set; }
        public string ShipAddressBlockAddr1 { get; set; }
        public string ShipAddressBlockAddr2 { get; set; }
        public string ShipAddressBlockAddr3 { get; set; }
        public string ShipAddressBlockAddr4 { get; set; }
        public string ShipAddressBlockAddr5 { get; set; }
        public string AltPhone { get; set; }
        public string AltContact { get; set; }
        public string CustomerTypeRefListID { get; set; }
        public string CustomerTypeRefFullName { get; set; }
        public string TermsRefListID { get; set; }
        public string TermsRefFullName { get; set; }
        public string SalesRepRefListID { get; set; }
        public string SalesRepRefFullName { get; set; }
        
        public Nullable<decimal> Balance { get; set; }
        
        public Nullable<decimal> TotalBalance { get; set; }
        
        public Nullable<decimal> OpenBalance { get; set; }
        
        public Nullable<System.DateTime> OpenBalanceDate { get; set; }
        
        public string SalesTaxCodeRefListID { get; set; }
        
        public string SalesTaxCodeRefFullName { get; set; }
        
        public string TaxCodeRefListID { get; set; }
        
        public string TaxCodeRefFullName { get; set; }
        
        public string ItemSalesTaxRefListID { get; set; }
        
        public string ItemSalesTaxRefFullName { get; set; }
        
        public string SalesTaxCountry { get; set; }
        
        public string ResaleNumber { get; set; }
        
        public string AccountNumber { get; set; }
        
        public string BusinessNumber { get; set; }
        
        public Nullable<decimal> CreditLimit { get; set; }
        
        public string PreferredPaymentMethodRefListID { get; set; }
        
        public string PreferredPaymentMethodRefFullName { get; set; }
        
        public string CreditCardInfoCreditCardNumber { get; set; }
        
        public Nullable<int> CreditCardInfoExpirationMonth { get; set; }
        
        public Nullable<int> CreditCardInfoExpirationYear { get; set; }
        
        public string CreditCardInfoNameOnCard { get; set; }
        
        public string CreditCardInfoCreditCardAddress { get; set; }
        
        public string CreditCardInfoCreditCardPostalCode { get; set; }
        
        public string JobStatus { get; set; }
        
        public Nullable<System.DateTime> JobStartDate { get; set; }
        
        public Nullable<System.DateTime> JobProjectedEndDate { get; set; }
        
        public Nullable<System.DateTime> JobEndDate { get; set; }
        
        public string JobDesc { get; set; }
        
        public string JobTypeRefListID { get; set; }
        
        public string JobTypeRefFullName { get; set; }
        
        public string Notes { get; set; }
        
        public string PreferredDeliveryMethod { get; set; }
        
        public bool IsUsingCustomerTaxCode { get; set; }
        
        public string PriceLevelRefListID { get; set; }
        
        public string PriceLevelRefFullName { get; set; }
        
        public string ExternalGUID { get; set; }
        
        public string TaxRegistrationNumber { get; set; }
        
        public string CurrencyRefListID { get; set; }
        
        public string CurrencyRefFullName { get; set; }
    }
}
