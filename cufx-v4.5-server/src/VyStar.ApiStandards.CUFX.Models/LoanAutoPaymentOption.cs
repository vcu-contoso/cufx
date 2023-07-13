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
    /// Details related to auto payment options. Note: this is in the request; long-term may be added to inquiry response for maintenance. 
    /// </summary>
    [DataContract]
    public partial class LoanAutoPaymentOption 
    {

        /// <summary>
        /// Can be used to set payment option for credit cards and LOC (minimum due, balance, set payment, principal, other). 
        /// </summary>
        /// <value>Can be used to set payment option for credit cards and LOC (minimum due, balance, set payment, principal, other). </value>
        [TypeConverter(typeof(CustomEnumConverter<AutoPaymentOptionEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum AutoPaymentOptionEnum
        {
            
            /// <summary>
            /// Enum BalanceEnum for Balance
            /// </summary>
            [EnumMember(Value = "Balance")]
            BalanceEnum = 1,
            
            /// <summary>
            /// Enum MinimumDueEnum for MinimumDue
            /// </summary>
            [EnumMember(Value = "MinimumDue")]
            MinimumDueEnum = 2,
            
            /// <summary>
            /// Enum OtherEnum for Other
            /// </summary>
            [EnumMember(Value = "Other")]
            OtherEnum = 3,
            
            /// <summary>
            /// Enum PrincipalEnum for Principal
            /// </summary>
            [EnumMember(Value = "Principal")]
            PrincipalEnum = 4,
            
            /// <summary>
            /// Enum SetPaymentEnum for SetPayment
            /// </summary>
            [EnumMember(Value = "SetPayment")]
            SetPaymentEnum = 5
        }

        /// <summary>
        /// Can be used to set payment option for credit cards and LOC (minimum due, balance, set payment, principal, other). 
        /// </summary>
        /// <value>Can be used to set payment option for credit cards and LOC (minimum due, balance, set payment, principal, other). </value>
        [DataMember(Name="autoPaymentOption", EmitDefaultValue=true)]
        public AutoPaymentOptionEnum AutoPaymentOption { get; set; }

        /// <summary>
        /// Used when the AutoPaymentOption element value is Other. 
        /// </summary>
        /// <value>Used when the AutoPaymentOption element value is Other. </value>
        [DataMember(Name="otherAutoPaymentOption", EmitDefaultValue=false)]
        public string OtherAutoPaymentOption { get; set; }


        /// <summary>
        /// The payment frequency of the auto payment. 
        /// </summary>
        /// <value>The payment frequency of the auto payment. </value>
        [TypeConverter(typeof(CustomEnumConverter<AutoPaymentFrequencyEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum AutoPaymentFrequencyEnum
        {
            
            /// <summary>
            /// Enum BimonthlyEnum for Bimonthly
            /// </summary>
            [EnumMember(Value = "Bimonthly")]
            BimonthlyEnum = 1,
            
            /// <summary>
            /// Enum BiweeklyEnum for Biweekly
            /// </summary>
            [EnumMember(Value = "Biweekly")]
            BiweeklyEnum = 2,
            
            /// <summary>
            /// Enum MonthlyEnum for Monthly
            /// </summary>
            [EnumMember(Value = "Monthly")]
            MonthlyEnum = 3,
            
            /// <summary>
            /// Enum OneTimeEnum for OneTime
            /// </summary>
            [EnumMember(Value = "OneTime")]
            OneTimeEnum = 4,
            
            /// <summary>
            /// Enum OtherEnum for Other
            /// </summary>
            [EnumMember(Value = "Other")]
            OtherEnum = 5,
            
            /// <summary>
            /// Enum WeeklyEnum for Weekly
            /// </summary>
            [EnumMember(Value = "Weekly")]
            WeeklyEnum = 6,
            
            /// <summary>
            /// Enum YearlyEnum for Yearly
            /// </summary>
            [EnumMember(Value = "Yearly")]
            YearlyEnum = 7
        }

        /// <summary>
        /// The payment frequency of the auto payment. 
        /// </summary>
        /// <value>The payment frequency of the auto payment. </value>
        [DataMember(Name="autoPaymentFrequency", EmitDefaultValue=true)]
        public AutoPaymentFrequencyEnum AutoPaymentFrequency { get; set; }


        /// <summary>
        /// A specific day of the month on a monthly basis, or a specific day of the week on a weekly basis, or bi-weekly, or yearly.  If you have this, you would not send AutoPaymentDayOfTheMonth. 
        /// </summary>
        /// <value>A specific day of the month on a monthly basis, or a specific day of the week on a weekly basis, or bi-weekly, or yearly.  If you have this, you would not send AutoPaymentDayOfTheMonth. </value>
        [TypeConverter(typeof(CustomEnumConverter<AutoPaymentDayOfTheWeekEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum AutoPaymentDayOfTheWeekEnum
        {
            
            /// <summary>
            /// Enum MondayEnum for Monday
            /// </summary>
            [EnumMember(Value = "Monday")]
            MondayEnum = 1,
            
            /// <summary>
            /// Enum TuesdayEnum for Tuesday
            /// </summary>
            [EnumMember(Value = "Tuesday")]
            TuesdayEnum = 2,
            
            /// <summary>
            /// Enum WednesdayEnum for Wednesday
            /// </summary>
            [EnumMember(Value = "Wednesday")]
            WednesdayEnum = 3,
            
            /// <summary>
            /// Enum ThursdayEnum for Thursday
            /// </summary>
            [EnumMember(Value = "Thursday")]
            ThursdayEnum = 4,
            
            /// <summary>
            /// Enum FridayEnum for Friday
            /// </summary>
            [EnumMember(Value = "Friday")]
            FridayEnum = 5,
            
            /// <summary>
            /// Enum SaturdayEnum for Saturday
            /// </summary>
            [EnumMember(Value = "Saturday")]
            SaturdayEnum = 6,
            
            /// <summary>
            /// Enum SundayEnum for Sunday
            /// </summary>
            [EnumMember(Value = "Sunday")]
            SundayEnum = 7
        }

        /// <summary>
        /// A specific day of the month on a monthly basis, or a specific day of the week on a weekly basis, or bi-weekly, or yearly.  If you have this, you would not send AutoPaymentDayOfTheMonth. 
        /// </summary>
        /// <value>A specific day of the month on a monthly basis, or a specific day of the week on a weekly basis, or bi-weekly, or yearly.  If you have this, you would not send AutoPaymentDayOfTheMonth. </value>
        [DataMember(Name="autoPaymentDayOfTheWeek", EmitDefaultValue=true)]
        public AutoPaymentDayOfTheWeekEnum AutoPaymentDayOfTheWeek { get; set; }

        /// <summary>
        /// A specific day of the month (typically a subset of 1-31). If you have this, you would not send AutoPaymentDayOfTheWeek. 
        /// </summary>
        /// <value>A specific day of the month (typically a subset of 1-31). If you have this, you would not send AutoPaymentDayOfTheWeek. </value>
        [DataMember(Name="autoPaymentDayOfTheMonth", EmitDefaultValue=true)]
        public int AutoPaymentDayOfTheMonth { get; set; }

        /// <summary>
        /// Gets or Sets AutoPaymentAmount
        /// </summary>
        [DataMember(Name="autoPaymentAmount", EmitDefaultValue=false)]
        public AccountAccountEscheatAmount AutoPaymentAmount { get; set; }

        /// <summary>
        /// The account ID is a persistent and unique identifier for the account. It must be unique for all users across the institution and remain the same over the life of the account. 
        /// </summary>
        /// <value>The account ID is a persistent and unique identifier for the account. It must be unique for all users across the institution and remain the same over the life of the account. </value>
        [DataMember(Name="fromAccountId", EmitDefaultValue=false)]
        public string FromAccountId { get; set; }


        /// <summary>
        /// Checking account, i.e., checks can be written against the account. Money market accounts can be included here or in money markets.  Its up to the institution. Savings and club accounts.  This can optionally include CDs, but its up to the institution. Auto loans, etc. Loans that are NOT lines of credit or credit cards. Loan behind the credit card.  Note the actual card information in the card object. Loan that is a line of credit but NOT a credit card. Loan that is made in exchange for taking title of property. Investment accounts such as brokerage and this can optionally include CDs and/or money markets, but its up to the institution. This account is a special type of checking account connected to a pre-paid card. Other account type. Loan that is made in installments. Loan is typically unsecured. This enumeration is considered deprecated. Recommend using account type Loan and subAccount of Installment. Loan that is a made to a business organization. This enumeration is considered deprecated. Recommend using account type Loan and subAccount of Commercial. Line of Credit that is a made to a business organization. This enumeration is considered deprecated. Recommend using account type Loan and subAccount of CommercialLineOfCredit. A general ledger account of the financial institution. A loan account type that has not been prevously defined. This enumeration is considered deprecated. Recommend using account type loan and subAccount of OtherLoan. 
        /// </summary>
        /// <value>Checking account, i.e., checks can be written against the account. Money market accounts can be included here or in money markets.  Its up to the institution. Savings and club accounts.  This can optionally include CDs, but its up to the institution. Auto loans, etc. Loans that are NOT lines of credit or credit cards. Loan behind the credit card.  Note the actual card information in the card object. Loan that is a line of credit but NOT a credit card. Loan that is made in exchange for taking title of property. Investment accounts such as brokerage and this can optionally include CDs and/or money markets, but its up to the institution. This account is a special type of checking account connected to a pre-paid card. Other account type. Loan that is made in installments. Loan is typically unsecured. This enumeration is considered deprecated. Recommend using account type Loan and subAccount of Installment. Loan that is a made to a business organization. This enumeration is considered deprecated. Recommend using account type Loan and subAccount of Commercial. Line of Credit that is a made to a business organization. This enumeration is considered deprecated. Recommend using account type Loan and subAccount of CommercialLineOfCredit. A general ledger account of the financial institution. A loan account type that has not been prevously defined. This enumeration is considered deprecated. Recommend using account type loan and subAccount of OtherLoan. </value>
        [TypeConverter(typeof(CustomEnumConverter<FromAccountTypeEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum FromAccountTypeEnum
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
        [DataMember(Name="fromAccountType", EmitDefaultValue=true)]
        public FromAccountTypeEnum FromAccountType { get; set; }

        /// <summary>
        /// The account subtype identifies the specific account type that the back end system will recognize. 
        /// </summary>
        /// <value>The account subtype identifies the specific account type that the back end system will recognize. </value>
        [DataMember(Name="fromAccountSubType", EmitDefaultValue=false)]
        public string FromAccountSubType { get; set; }

    }
}