/*
 * Credit Union Financial eXchange
 *
 * Credit Union Industry Standard. The following API examples are producedz using scripting methods to create a swagger representation of the XML/XSDs. In the event of any noted deviations, the published XSDs on www.cufxstandards.com are the basis of intended content and behavior. Please see https://bonifii.com/cufx-terms-of-use for the terms of use applicable for CUFX.
 *
 * The version of the OpenAPI document: 4.5
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using VyStar.ApiStandards.CUFX.Converters;

namespace VyStar.ApiStandards.CUFX.Models
{ 
    /// <summary>
    /// Party, relationship, or account related to the Fee.  Intended choice - Due to cross language serialization issues the choice construct has been removed. It is the responsibility of the implementer to add programmatic logic for this complex type to detect, handle and or error when population of more than one element is present. 
    /// </summary>
    [DataContract]
    public partial class FeeRelatedTo 
    {
        /// <summary>
        /// The party ID is a persistent and unique identifier for the party not related to the accounts they own but tied to that person or organization. It should be unique for all parties across the institution and remain the same over the life of the relationship with the financial institution. 
        /// </summary>
        /// <value>The party ID is a persistent and unique identifier for the party not related to the accounts they own but tied to that person or organization. It should be unique for all parties across the institution and remain the same over the life of the relationship with the financial institution. </value>
        [DataMember(Name="partyId", EmitDefaultValue=false)]
        public string PartyId { get; set; }

        /// <summary>
        /// The relationship ID is a persistent and unique identifier for the relationship. It should be unique for all relationships across the institution and remain the same over the life of the relationship with the financial institution. 
        /// </summary>
        /// <value>The relationship ID is a persistent and unique identifier for the relationship. It should be unique for all relationships across the institution and remain the same over the life of the relationship with the financial institution. </value>
        [DataMember(Name="relationshipId", EmitDefaultValue=false)]
        public string RelationshipId { get; set; }

        /// <summary>
        /// The account ID is a persistent and unique identifier for the account. It must be unique for all users across the institution and remain the same over the life of the account. 
        /// </summary>
        /// <value>The account ID is a persistent and unique identifier for the account. It must be unique for all users across the institution and remain the same over the life of the account. </value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public string AccountId { get; set; }


        /// <summary>
        /// Checking account, i.e., checks can be written against the account. Money market accounts can be included here or in money markets.  Its up to the institution. Savings and club accounts.  This can optionally include CDs, but its up to the institution. Auto loans, etc. Loans that are NOT lines of credit or credit cards. Loan behind the credit card.  Note the actual card information in the card object. Loan that is a line of credit but NOT a credit card. Loan that is made in exchange for taking title of property. Investment accounts such as brokerage and this can optionally include CDs and/or money markets, but its up to the institution. This account is a special type of checking account connected to a pre-paid card. Other account type. Loan that is made in installments. Loan is typically unsecured. This enumeration is considered deprecated. Recommend using account type Loan and subAccount of Installment. Loan that is a made to a business organization. This enumeration is considered deprecated. Recommend using account type Loan and subAccount of Commercial. Line of Credit that is a made to a business organization. This enumeration is considered deprecated. Recommend using account type Loan and subAccount of CommercialLineOfCredit. A general ledger account of the financial institution. A loan account type that has not been prevously defined. This enumeration is considered deprecated. Recommend using account type loan and subAccount of OtherLoan. 
        /// </summary>
        /// <value>Checking account, i.e., checks can be written against the account. Money market accounts can be included here or in money markets.  Its up to the institution. Savings and club accounts.  This can optionally include CDs, but its up to the institution. Auto loans, etc. Loans that are NOT lines of credit or credit cards. Loan behind the credit card.  Note the actual card information in the card object. Loan that is a line of credit but NOT a credit card. Loan that is made in exchange for taking title of property. Investment accounts such as brokerage and this can optionally include CDs and/or money markets, but its up to the institution. This account is a special type of checking account connected to a pre-paid card. Other account type. Loan that is made in installments. Loan is typically unsecured. This enumeration is considered deprecated. Recommend using account type Loan and subAccount of Installment. Loan that is a made to a business organization. This enumeration is considered deprecated. Recommend using account type Loan and subAccount of Commercial. Line of Credit that is a made to a business organization. This enumeration is considered deprecated. Recommend using account type Loan and subAccount of CommercialLineOfCredit. A general ledger account of the financial institution. A loan account type that has not been prevously defined. This enumeration is considered deprecated. Recommend using account type loan and subAccount of OtherLoan. </value>
        [TypeConverter(typeof(CustomEnumConverter<AccountTypeEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum AccountTypeEnum
        {
            
            /// <summary>
            /// Enum CheckingEnum for Checking
            /// </summary>
            [EnumMember(Value = "Checking")]
            CheckingEnum = 1,
            
            /// <summary>
            /// Enum SavingsEnum for Savings
            /// </summary>
            [EnumMember(Value = "Savings")]
            SavingsEnum = 2,
            
            /// <summary>
            /// Enum LoanEnum for Loan
            /// </summary>
            [EnumMember(Value = "Loan")]
            LoanEnum = 3,
            
            /// <summary>
            /// Enum CreditCardEnum for CreditCard
            /// </summary>
            [EnumMember(Value = "CreditCard")]
            CreditCardEnum = 4,
            
            /// <summary>
            /// Enum LineOfCreditEnum for LineOfCredit
            /// </summary>
            [EnumMember(Value = "LineOfCredit")]
            LineOfCreditEnum = 5,
            
            /// <summary>
            /// Enum MortgageEnum for Mortgage
            /// </summary>
            [EnumMember(Value = "Mortgage")]
            MortgageEnum = 6,
            
            /// <summary>
            /// Enum InvestmentEnum for Investment
            /// </summary>
            [EnumMember(Value = "Investment")]
            InvestmentEnum = 7,
            
            /// <summary>
            /// Enum PrePaidCardEnum for PrePaidCard
            /// </summary>
            [EnumMember(Value = "PrePaidCard")]
            PrePaidCardEnum = 8,
            
            /// <summary>
            /// Enum OtherEnum for Other
            /// </summary>
            [EnumMember(Value = "Other")]
            OtherEnum = 9,
            
            /// <summary>
            /// Enum InstallmentEnum for Installment
            /// </summary>
            [EnumMember(Value = "Installment")]
            InstallmentEnum = 10,
            
            /// <summary>
            /// Enum CommercialLoanEnum for CommercialLoan
            /// </summary>
            [EnumMember(Value = "CommercialLoan")]
            CommercialLoanEnum = 11,
            
            /// <summary>
            /// Enum CommercialLineOfCreditEnum for CommercialLineOfCredit
            /// </summary>
            [EnumMember(Value = "CommercialLineOfCredit")]
            CommercialLineOfCreditEnum = 12,
            
            /// <summary>
            /// Enum GeneralLedgerEnum for GeneralLedger
            /// </summary>
            [EnumMember(Value = "GeneralLedger")]
            GeneralLedgerEnum = 13,
            
            /// <summary>
            /// Enum OtherLoanEnum for OtherLoan
            /// </summary>
            [EnumMember(Value = "OtherLoan")]
            OtherLoanEnum = 14
        }

        /// <summary>
        /// Checking account, i.e., checks can be written against the account. Money market accounts can be included here or in money markets.  Its up to the institution. Savings and club accounts.  This can optionally include CDs, but its up to the institution. Auto loans, etc. Loans that are NOT lines of credit or credit cards. Loan behind the credit card.  Note the actual card information in the card object. Loan that is a line of credit but NOT a credit card. Loan that is made in exchange for taking title of property. Investment accounts such as brokerage and this can optionally include CDs and/or money markets, but its up to the institution. This account is a special type of checking account connected to a pre-paid card. Other account type. Loan that is made in installments. Loan is typically unsecured. This enumeration is considered deprecated. Recommend using account type Loan and subAccount of Installment. Loan that is a made to a business organization. This enumeration is considered deprecated. Recommend using account type Loan and subAccount of Commercial. Line of Credit that is a made to a business organization. This enumeration is considered deprecated. Recommend using account type Loan and subAccount of CommercialLineOfCredit. A general ledger account of the financial institution. A loan account type that has not been prevously defined. This enumeration is considered deprecated. Recommend using account type loan and subAccount of OtherLoan. 
        /// </summary>
        /// <value>Checking account, i.e., checks can be written against the account. Money market accounts can be included here or in money markets.  Its up to the institution. Savings and club accounts.  This can optionally include CDs, but its up to the institution. Auto loans, etc. Loans that are NOT lines of credit or credit cards. Loan behind the credit card.  Note the actual card information in the card object. Loan that is a line of credit but NOT a credit card. Loan that is made in exchange for taking title of property. Investment accounts such as brokerage and this can optionally include CDs and/or money markets, but its up to the institution. This account is a special type of checking account connected to a pre-paid card. Other account type. Loan that is made in installments. Loan is typically unsecured. This enumeration is considered deprecated. Recommend using account type Loan and subAccount of Installment. Loan that is a made to a business organization. This enumeration is considered deprecated. Recommend using account type Loan and subAccount of Commercial. Line of Credit that is a made to a business organization. This enumeration is considered deprecated. Recommend using account type Loan and subAccount of CommercialLineOfCredit. A general ledger account of the financial institution. A loan account type that has not been prevously defined. This enumeration is considered deprecated. Recommend using account type loan and subAccount of OtherLoan. </value>
        [DataMember(Name="accountType", EmitDefaultValue=true)]
        public AccountTypeEnum AccountType { get; set; }

        /// <summary>
        /// The account subtype identifies the specific account type that the back end system will recognize. 
        /// </summary>
        /// <value>The account subtype identifies the specific account type that the back end system will recognize. </value>
        [DataMember(Name="accountSubType", EmitDefaultValue=false)]
        public string AccountSubType { get; set; }

    }
}
