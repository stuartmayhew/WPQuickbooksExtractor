using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickbooksExtractor.Models
{
    public class QBVendor
    {
      public string ListID {get;set;}
      public DateTime? TimeCreated {get;set;}
      public DateTime? TimeModified {get;set;}
      public string EditSequence {get;set;}
      public string Name {get;set;}
      public bool IsActive {get;set;}
      public string ClassRefListID {get;set;}
      public string ClassRefFullName {get;set;}
      public bool IsTaxAgency {get;set;}
      public string CompanyName {get;set;}
      public string Salutation {get;set;}
      public string FirstName {get;set;}
      public string MiddleName {get;set;}
      public string LastName {get;set;}
      public string VendorAddressAddr1 {get;set;}
      public string VendorAddressAddr2 {get;set;}
      public string VendorAddressAddr3 {get;set;}
      public string VendorAddressAddr4 {get;set;}
      public string VendorAddressAddr5 {get;set;}
      public string VendorAddressCity {get;set;}
      public string VendorAddressState {get;set;}
      public string VendorAddressProvince {get;set;}
      public string VendorAddressCounty {get;set;}
      public string VendorAddressPostalCode {get;set;}
      public string VendorAddressCountry {get;set;}
      public string VendorAddressNote {get;set;}
      public string VendorAddressBlockAddr1 {get;set;}
      public string VendorAddressBlockAddr2 {get;set;}
      public string VendorAddressBlockAddr3 {get;set;}
      public string VendorAddressBlockAddr4 {get;set;}
      public string VendorAddressBlockAddr5 {get;set;}
      public string ShipAddressAddr1 {get;set;}
      public string ShipAddressAddr2 {get;set;}
      public string ShipAddressAddr3 {get;set;}
      public string ShipAddressAddr4 {get;set;}
      public string ShipAddressAddr5 {get;set;}
      public string ShipAddressCity {get;set;}
      public string ShipAddressState {get;set;}
      public string ShipAddressPostalCode {get;set;}
      public string ShipAddressCountry {get;set;}
      public string ShipAddressNote {get;set;}
      public string Phone {get;set;}
      public string AltPhone {get;set;}
      public string Fax {get;set;}
      public string Email {get;set;}
      public string Cc {get;set;}
      public string Contact {get;set;}
      public string AltContact {get;set;}
      public string NameOnCheck {get;set;}
      public string Notes {get;set;}
      public string VendorTypeRefListID {get;set;}
      public string VendorTypeRefFullName {get;set;}
      public string TermsRefListID {get;set;}
      public string TermsRefFullName {get;set;}
      public string VendorTaxIdent {get;set;}
      public bool IsVendorEligibleFor1099 {get;set;}
      public bool IsVendorEligibleForT4A {get;set;}
      public decimal? OpenBalance {get;set;}
      public DateTime? OpenBalanceDate {get;set;}
      public decimal? Balance {get;set;}
      public string BillingRateRefListID {get;set;}
      public string BillingRateRefFullName {get;set;}
      public string PrefillAccount1RefListID {get;set;}
      public string PrefillAccount1RefFullName {get;set;}
      public string PrefillAccount2RefListID {get;set;}
      public string PrefillAccount2RefFullName {get;set;}
      public string PrefillAccount3RefListID {get;set;}
      public string PrefillAccount3RefFullName {get;set;}
      public string ExternalGUID {get;set;}
      public string BusinessNumber {get;set;}
      public string SalesTaxCodeRefListID {get;set;}
      public string SalesTaxCodeRefFullName {get;set;}
      public string SalesTaxCountry {get;set;}
      public string IsSalesTaxAgency {get;set;}
      public string SalesTaxReturnRefListID {get;set;}
      public string SalesTaxReturnRefFullName {get;set;}
      public string CurrencyRefListID {get;set;}
      public string CurrencyRefFullName {get;set;}
    }
}
