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
    /// 
    /// </summary>
    [DataContract]
    public partial class BillPayee 
    {
        /// <summary>
        /// The bill payee ID is a persistent and unique identifier for the bill payee of the consumer. 
        /// </summary>
        /// <value>The bill payee ID is a persistent and unique identifier for the bill payee of the consumer. </value>
        [DataMember(Name="billPayeeId", EmitDefaultValue=false)]
        public string BillPayeeId { get; set; }

        /// <summary>
        /// The bill payee global ID is a persistent and unique identifier for the bill payee in the bill pay system. This bill payee global ID does not change from consumer to consumer. 
        /// </summary>
        /// <value>The bill payee global ID is a persistent and unique identifier for the bill payee in the bill pay system. This bill payee global ID does not change from consumer to consumer. </value>
        [DataMember(Name="billPayeeGlobalId", EmitDefaultValue=false)]
        public string BillPayeeGlobalId { get; set; }

        /// <summary>
        /// If a person, the first and last name of the person. If a business or trust, will include the business or trust name. 
        /// </summary>
        /// <value>If a person, the first and last name of the person. If a business or trust, will include the business or trust name. </value>
        [DataMember(Name="payeeName", EmitDefaultValue=false)]
        public string PayeeName { get; set; }

        /// <summary>
        /// Gets or Sets PayeeAddress
        /// </summary>
        [DataMember(Name="payeeAddress", EmitDefaultValue=false)]
        public BillPayeePayeeAddress PayeeAddress { get; set; }

        /// <summary>
        /// Gets or Sets PayeePhone
        /// </summary>
        [DataMember(Name="payeePhone", EmitDefaultValue=false)]
        public BillPayeePayeePhone PayeePhone { get; set; }

        /// <summary>
        /// Gets or Sets PayeeEmail
        /// </summary>
        [DataMember(Name="payeeEmail", EmitDefaultValue=false)]
        public BillPayeePayeeEmail PayeeEmail { get; set; }

        /// <summary>
        /// A name that uniquely identifies the processor of the bill payee. 
        /// </summary>
        /// <value>A name that uniquely identifies the processor of the bill payee. </value>
        [DataMember(Name="processorName", EmitDefaultValue=false)]
        public string ProcessorName { get; set; }

        /// <summary>
        /// The ACH routing number for the payee.  Usually used when the funds are transfered electronically. 
        /// </summary>
        /// <value>The ACH routing number for the payee.  Usually used when the funds are transfered electronically. </value>
        [DataMember(Name="payeeACHRoutingNumber", EmitDefaultValue=false)]
        public string PayeeACHRoutingNumber { get; set; }

        /// <summary>
        /// The ACH account number for the payee.  Usually used when the funds are transfered electronically. 
        /// </summary>
        /// <value>The ACH account number for the payee.  Usually used when the funds are transfered electronically. </value>
        [DataMember(Name="payeeACHAccountNumber", EmitDefaultValue=false)]
        public string PayeeACHAccountNumber { get; set; }

        /// <summary>
        /// True for electronic processing of payments. False for sending a paper check. 
        /// </summary>
        /// <value>True for electronic processing of payments. False for sending a paper check. </value>
        [DataMember(Name="isElectronic", EmitDefaultValue=true)]
        public bool IsElectronic { get; set; }

        /// <summary>
        /// True for payees that are providing ebills. False for payees that send a paper bill. 
        /// </summary>
        /// <value>True for payees that are providing ebills. False for payees that send a paper bill. </value>
        [DataMember(Name="isEBillProvider", EmitDefaultValue=true)]
        public bool IsEBillProvider { get; set; }

        /// <summary>
        /// True for parties that are signed up for ebills for this payee. False if the party is not enrolled for ebill processing. Element deprecated in favor of eBillEnrollmentStatus. 
        /// </summary>
        /// <value>True for parties that are signed up for ebills for this payee. False if the party is not enrolled for ebill processing. Element deprecated in favor of eBillEnrollmentStatus. </value>
        [DataMember(Name="isEBillEnrolled", EmitDefaultValue=true)]
        public bool IsEBillEnrolled { get; set; }

        /// <summary>
        /// The Date Added is the date that the Bill Payee was added to the system by the member. The date/time should be ISO 8601 UTC format.  yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported. The time is assumed to be 00:00Z if omitted. 
        /// </summary>
        /// <value>The Date Added is the date that the Bill Payee was added to the system by the member. The date/time should be ISO 8601 UTC format.  yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported. The time is assumed to be 00:00Z if omitted. </value>
        [DataMember(Name="addedDateTime", EmitDefaultValue=false)]
        public string AddedDateTime { get; set; }

        /// <summary>
        /// The Date Updated is the date that the Bill Payee was last updated by the member. The date/time should be ISO 8601 UTC format.  yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported. The time is assumed to be 00:00Z if omitted. 
        /// </summary>
        /// <value>The Date Updated is the date that the Bill Payee was last updated by the member. The date/time should be ISO 8601 UTC format.  yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported. The time is assumed to be 00:00Z if omitted. </value>
        [DataMember(Name="updatedDateTime", EmitDefaultValue=false)]
        public string UpdatedDateTime { get; set; }

        /// <summary>
        /// This is the minimum number of business days a payment must be scheduled in advance for the payee to receive payment in time. 
        /// </summary>
        /// <value>This is the minimum number of business days a payment must be scheduled in advance for the payee to receive payment in time. </value>
        [DataMember(Name="minimumDaysToPay", EmitDefaultValue=true)]
        public int MinimumDaysToPay { get; set; }

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

        /// <summary>
        /// The user-defined name for payee.  Could be a nickname. 
        /// </summary>
        /// <value>The user-defined name for payee.  Could be a nickname. </value>
        [DataMember(Name="userDefinedName", EmitDefaultValue=false)]
        public string UserDefinedName { get; set; }

        /// <summary>
        /// The payee assigned account number associated with a member.  The number could be printed on a check or included in a memo. 
        /// </summary>
        /// <value>The payee assigned account number associated with a member.  The number could be printed on a check or included in a memo. </value>
        [DataMember(Name="payeeAccountNumber", EmitDefaultValue=false)]
        public string PayeeAccountNumber { get; set; }

        /// <summary>
        /// The name of the person for which the bill is being paid.  Typically this is the party name, however you may want to specify which party is paying the bill.  Or you may want to pay on behalf of someone else who is not on the account. 
        /// </summary>
        /// <value>The name of the person for which the bill is being paid.  Typically this is the party name, however you may want to specify which party is paying the bill.  Or you may want to pay on behalf of someone else who is not on the account. </value>
        [DataMember(Name="accountHolderName", EmitDefaultValue=false)]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// A member defined category that can be used for reporting purposes. 
        /// </summary>
        /// <value>A member defined category that can be used for reporting purposes. </value>
        [DataMember(Name="payeeCategory", EmitDefaultValue=false)]
        public string PayeeCategory { get; set; }


        /// <summary>
        /// This is enumeration of statuses for the bill payee. This value indicates that the payee is active and visible to the member. This value indicates that the payee is inactive and visible to the member. This value indicates that the payee is inactive and invisible to the member; the payee cannot be re-activated. Some type of error has occured in the process of paying this payee and payments are not successfully received, please re-verify this payee. 
        /// </summary>
        /// <value>This is enumeration of statuses for the bill payee. This value indicates that the payee is active and visible to the member. This value indicates that the payee is inactive and visible to the member. This value indicates that the payee is inactive and invisible to the member; the payee cannot be re-activated. Some type of error has occured in the process of paying this payee and payments are not successfully received, please re-verify this payee. </value>
        [TypeConverter(typeof(CustomEnumConverter<PayeeStatusEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum PayeeStatusEnum
        {
            
            /// <summary>
            /// Enum ActiveEnum for Active
            /// </summary>
            [EnumMember(Value = "Active")]
            ActiveEnum = 1,
            
            /// <summary>
            /// Enum InactiveEnum for Inactive
            /// </summary>
            [EnumMember(Value = "Inactive")]
            InactiveEnum = 2,
            
            /// <summary>
            /// Enum DeletedEnum for Deleted
            /// </summary>
            [EnumMember(Value = "Deleted")]
            DeletedEnum = 3,
            
            /// <summary>
            /// Enum InvalidEnum for Invalid
            /// </summary>
            [EnumMember(Value = "Invalid")]
            InvalidEnum = 4
        }

        /// <summary>
        /// This is enumeration of statuses for the bill payee. This value indicates that the payee is active and visible to the member. This value indicates that the payee is inactive and visible to the member. This value indicates that the payee is inactive and invisible to the member; the payee cannot be re-activated. Some type of error has occured in the process of paying this payee and payments are not successfully received, please re-verify this payee. 
        /// </summary>
        /// <value>This is enumeration of statuses for the bill payee. This value indicates that the payee is active and visible to the member. This value indicates that the payee is inactive and visible to the member. This value indicates that the payee is inactive and invisible to the member; the payee cannot be re-activated. Some type of error has occured in the process of paying this payee and payments are not successfully received, please re-verify this payee. </value>
        [DataMember(Name="payeeStatus", EmitDefaultValue=true)]
        public PayeeStatusEnum PayeeStatus { get; set; }

        /// <summary>
        /// The account ID is a persistent and unique identifier for the account. It must be unique for all users across the institution and remain the same over the life of the account. 
        /// </summary>
        /// <value>The account ID is a persistent and unique identifier for the account. It must be unique for all users across the institution and remain the same over the life of the account. </value>
        [DataMember(Name="defaultPaymentFromAccountId", EmitDefaultValue=false)]
        public string DefaultPaymentFromAccountId { get; set; }

        /// <summary>
        /// The earliest possible payment date for the Payee (if any). The date/time should be ISO 8601 UTC format.  yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported. The time is assumed to be 00:00Z if omitted. 
        /// </summary>
        /// <value>The earliest possible payment date for the Payee (if any). The date/time should be ISO 8601 UTC format.  yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported. The time is assumed to be 00:00Z if omitted. </value>
        [DataMember(Name="earlyPaymentDateTime", EmitDefaultValue=false)]
        public string EarlyPaymentDateTime { get; set; }

        /// <summary>
        /// The next payment date for the Payee in a recurring payment scenario. The date/time should be ISO 8601 UTC format.  yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported. The time is assumed to be 00:00Z if omitted. 
        /// </summary>
        /// <value>The next payment date for the Payee in a recurring payment scenario. The date/time should be ISO 8601 UTC format.  yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported. The time is assumed to be 00:00Z if omitted. </value>
        [DataMember(Name="nextPaymentDateTime", EmitDefaultValue=false)]
        public string NextPaymentDateTime { get; set; }

        /// <summary>
        /// True if Payee is setup for recurring payments. 
        /// </summary>
        /// <value>True if Payee is setup for recurring payments. </value>
        [DataMember(Name="isRecurringPaymentEnabled", EmitDefaultValue=true)]
        public bool IsRecurringPaymentEnabled { get; set; }

        /// <summary>
        /// Gets or Sets CustomData
        /// </summary>
        [DataMember(Name="customData", EmitDefaultValue=false)]
        public AccessProfileCustomData CustomData { get; set; }


        /// <summary>
        /// This is enumeration of statuses for the ebill Enrollment. The user is ineligible to enroll in ebills The user is currently enrolled in ebills The user is currently not enrolled in ebills The user has a pending enrollment in progress for ebills The user has a pending unenrollment in progress for ebills The user has an unspecified error with their ebill enrollment This value can be used when no other statuses relate to the ebill enrollment 
        /// </summary>
        /// <value>This is enumeration of statuses for the ebill Enrollment. The user is ineligible to enroll in ebills The user is currently enrolled in ebills The user is currently not enrolled in ebills The user has a pending enrollment in progress for ebills The user has a pending unenrollment in progress for ebills The user has an unspecified error with their ebill enrollment This value can be used when no other statuses relate to the ebill enrollment </value>
        [TypeConverter(typeof(CustomEnumConverter<EBillEnrollmentStatusEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum EBillEnrollmentStatusEnum
        {
            
            /// <summary>
            /// Enum IneligibleEnum for Ineligible
            /// </summary>
            [EnumMember(Value = "Ineligible")]
            IneligibleEnum = 1,
            
            /// <summary>
            /// Enum EnrolledEnum for Enrolled
            /// </summary>
            [EnumMember(Value = "Enrolled")]
            EnrolledEnum = 2,
            
            /// <summary>
            /// Enum NotEnrolledEnum for NotEnrolled
            /// </summary>
            [EnumMember(Value = "NotEnrolled")]
            NotEnrolledEnum = 3,
            
            /// <summary>
            /// Enum PendingEnrollmentEnum for PendingEnrollment
            /// </summary>
            [EnumMember(Value = "PendingEnrollment")]
            PendingEnrollmentEnum = 4,
            
            /// <summary>
            /// Enum PendingUnenrollmentEnum for PendingUnenrollment
            /// </summary>
            [EnumMember(Value = "PendingUnenrollment")]
            PendingUnenrollmentEnum = 5,
            
            /// <summary>
            /// Enum ErrorEnum for Error
            /// </summary>
            [EnumMember(Value = "Error")]
            ErrorEnum = 6,
            
            /// <summary>
            /// Enum OtherEnum for Other
            /// </summary>
            [EnumMember(Value = "Other")]
            OtherEnum = 7
        }

        /// <summary>
        /// This is enumeration of statuses for the ebill Enrollment. The user is ineligible to enroll in ebills The user is currently enrolled in ebills The user is currently not enrolled in ebills The user has a pending enrollment in progress for ebills The user has a pending unenrollment in progress for ebills The user has an unspecified error with their ebill enrollment This value can be used when no other statuses relate to the ebill enrollment 
        /// </summary>
        /// <value>This is enumeration of statuses for the ebill Enrollment. The user is ineligible to enroll in ebills The user is currently enrolled in ebills The user is currently not enrolled in ebills The user has a pending enrollment in progress for ebills The user has a pending unenrollment in progress for ebills The user has an unspecified error with their ebill enrollment This value can be used when no other statuses relate to the ebill enrollment </value>
        [DataMember(Name="eBillEnrollmentStatus", EmitDefaultValue=true)]
        public EBillEnrollmentStatusEnum EBillEnrollmentStatus { get; set; }

        /// <summary>
        /// Free form text that describes the EBillEnrollmentStatus type \&quot;Other\&quot; when it is set in the eBillEnrollmentStatus element. 
        /// </summary>
        /// <value>Free form text that describes the EBillEnrollmentStatus type \&quot;Other\&quot; when it is set in the eBillEnrollmentStatus element. </value>
        [DataMember(Name="otherEBillEnrollmentStatus", EmitDefaultValue=false)]
        public string OtherEBillEnrollmentStatus { get; set; }

    }
}