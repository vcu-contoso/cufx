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
    public partial class Hold 
    {
        /// <summary>
        /// The hold ID is a persistent and unique identifier for the hold. 
        /// </summary>
        /// <value>The hold ID is a persistent and unique identifier for the hold. </value>
        [DataMember(Name="holdId", EmitDefaultValue=false)]
        public string HoldId { get; set; }

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
        /// The transaction ID is a persistent and unique identifier for the transaction related to the hold. 
        /// </summary>
        /// <value>The transaction ID is a persistent and unique identifier for the transaction related to the hold. </value>
        [DataMember(Name="transactionId", EmitDefaultValue=false)]
        public string TransactionId { get; set; }


        /// <summary>
        /// Hold any amount for any purpose. Hold the entire amount of a check or a partial amount until the check clears. Hold the entire amount of a certified draft or a partial amount until the certified draft clears. Stop payment on a draft/check (written authorization from the member). Reserve funds for a preauthorized credit card purchase or for an ATM point of sale transaction. Hold funds pledged against a hold. Prevent posting an automated clearing house transaction (written authorization from the member). Stop payment on a draft (verbal authorization from the member). Prevent posting an automated clearing house transaction (verbal authorization from the member). Prevent posting an automated clearing house transaction for as long as the hold remains in the account. Hold funds when a merchant calls to verify that funds are available to cover a members check. Hold when fees cannot be collected due to insufficient funds. Hold on a preapproved hold draft for a zero-balance preapproved hold. Hold on a member draft used for bill payment until the draft posts to the account, or until the hold expires. Hold for unauthorized ACH transactions. Hold on an account that is being used for ACH origination. Hold on account when a Death Notification Entry (DNE) has been received. Hold on PIN-based transactions. Prevent posting ACH debits for member business shares. Place the entire amount of a wire transfer on hold until the outgoing wire is posted. The transaction or account is in a disputed status. 
        /// </summary>
        /// <value>Hold any amount for any purpose. Hold the entire amount of a check or a partial amount until the check clears. Hold the entire amount of a certified draft or a partial amount until the certified draft clears. Stop payment on a draft/check (written authorization from the member). Reserve funds for a preauthorized credit card purchase or for an ATM point of sale transaction. Hold funds pledged against a hold. Prevent posting an automated clearing house transaction (written authorization from the member). Stop payment on a draft (verbal authorization from the member). Prevent posting an automated clearing house transaction (verbal authorization from the member). Prevent posting an automated clearing house transaction for as long as the hold remains in the account. Hold funds when a merchant calls to verify that funds are available to cover a members check. Hold when fees cannot be collected due to insufficient funds. Hold on a preapproved hold draft for a zero-balance preapproved hold. Hold on a member draft used for bill payment until the draft posts to the account, or until the hold expires. Hold for unauthorized ACH transactions. Hold on an account that is being used for ACH origination. Hold on account when a Death Notification Entry (DNE) has been received. Hold on PIN-based transactions. Prevent posting ACH debits for member business shares. Place the entire amount of a wire transfer on hold until the outgoing wire is posted. The transaction or account is in a disputed status. </value>
        [TypeConverter(typeof(CustomEnumConverter<HoldTypeEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum HoldTypeEnum
        {
            
            /// <summary>
            /// Enum GeneralPurposeEnum for GeneralPurpose
            /// </summary>
            [EnumMember(Value = "GeneralPurpose")]
            GeneralPurposeEnum = 1,
            
            /// <summary>
            /// Enum CheckHoldEnum for CheckHold
            /// </summary>
            [EnumMember(Value = "CheckHold")]
            CheckHoldEnum = 2,
            
            /// <summary>
            /// Enum CertifiedDraftEnum for CertifiedDraft
            /// </summary>
            [EnumMember(Value = "CertifiedDraft")]
            CertifiedDraftEnum = 3,
            
            /// <summary>
            /// Enum StopDraftEnum for StopDraft
            /// </summary>
            [EnumMember(Value = "StopDraft")]
            StopDraftEnum = 4,
            
            /// <summary>
            /// Enum SignatureAuthEnum for SignatureAuth
            /// </summary>
            [EnumMember(Value = "SignatureAuth")]
            SignatureAuthEnum = 5,
            
            /// <summary>
            /// Enum PledgeHoldEnum for PledgeHold
            /// </summary>
            [EnumMember(Value = "PledgeHold")]
            PledgeHoldEnum = 6,
            
            /// <summary>
            /// Enum StopACHEnum for StopACH
            /// </summary>
            [EnumMember(Value = "StopACH")]
            StopACHEnum = 7,
            
            /// <summary>
            /// Enum StopDraftVerbalEnum for StopDraftVerbal
            /// </summary>
            [EnumMember(Value = "StopDraftVerbal")]
            StopDraftVerbalEnum = 8,
            
            /// <summary>
            /// Enum StopACHVerbalEnum for StopACHVerbal
            /// </summary>
            [EnumMember(Value = "StopACHVerbal")]
            StopACHVerbalEnum = 9,
            
            /// <summary>
            /// Enum RevokeACHEnum for RevokeACH
            /// </summary>
            [EnumMember(Value = "RevokeACH")]
            RevokeACHEnum = 10,
            
            /// <summary>
            /// Enum MerchantVerificationEnum for MerchantVerification
            /// </summary>
            [EnumMember(Value = "MerchantVerification")]
            MerchantVerificationEnum = 11,
            
            /// <summary>
            /// Enum UncollectedFeeEnum for UncollectedFee
            /// </summary>
            [EnumMember(Value = "UncollectedFee")]
            UncollectedFeeEnum = 12,
            
            /// <summary>
            /// Enum HoldDraftEnum for HoldDraft
            /// </summary>
            [EnumMember(Value = "HoldDraft")]
            HoldDraftEnum = 13,
            
            /// <summary>
            /// Enum BillPaymentEnum for BillPayment
            /// </summary>
            [EnumMember(Value = "BillPayment")]
            BillPaymentEnum = 14,
            
            /// <summary>
            /// Enum UnauthorizedACHStopEnum for UnauthorizedACHStop
            /// </summary>
            [EnumMember(Value = "UnauthorizedACHStop")]
            UnauthorizedACHStopEnum = 15,
            
            /// <summary>
            /// Enum ACHOriginationEnum for ACHOrigination
            /// </summary>
            [EnumMember(Value = "ACHOrigination")]
            ACHOriginationEnum = 16,
            
            /// <summary>
            /// Enum ACHDNEEnum for ACHDNE
            /// </summary>
            [EnumMember(Value = "ACHDNE")]
            ACHDNEEnum = 17,
            
            /// <summary>
            /// Enum PinAuthEnum for PinAuth
            /// </summary>
            [EnumMember(Value = "PinAuth")]
            PinAuthEnum = 18,
            
            /// <summary>
            /// Enum BusinessBlockACHDebitEnum for BusinessBlockACHDebit
            /// </summary>
            [EnumMember(Value = "BusinessBlockACHDebit")]
            BusinessBlockACHDebitEnum = 19,
            
            /// <summary>
            /// Enum WireHoldEnum for WireHold
            /// </summary>
            [EnumMember(Value = "WireHold")]
            WireHoldEnum = 20,
            
            /// <summary>
            /// Enum DisputedEnum for Disputed
            /// </summary>
            [EnumMember(Value = "Disputed")]
            DisputedEnum = 21
        }

        /// <summary>
        /// Hold any amount for any purpose. Hold the entire amount of a check or a partial amount until the check clears. Hold the entire amount of a certified draft or a partial amount until the certified draft clears. Stop payment on a draft/check (written authorization from the member). Reserve funds for a preauthorized credit card purchase or for an ATM point of sale transaction. Hold funds pledged against a hold. Prevent posting an automated clearing house transaction (written authorization from the member). Stop payment on a draft (verbal authorization from the member). Prevent posting an automated clearing house transaction (verbal authorization from the member). Prevent posting an automated clearing house transaction for as long as the hold remains in the account. Hold funds when a merchant calls to verify that funds are available to cover a members check. Hold when fees cannot be collected due to insufficient funds. Hold on a preapproved hold draft for a zero-balance preapproved hold. Hold on a member draft used for bill payment until the draft posts to the account, or until the hold expires. Hold for unauthorized ACH transactions. Hold on an account that is being used for ACH origination. Hold on account when a Death Notification Entry (DNE) has been received. Hold on PIN-based transactions. Prevent posting ACH debits for member business shares. Place the entire amount of a wire transfer on hold until the outgoing wire is posted. The transaction or account is in a disputed status. 
        /// </summary>
        /// <value>Hold any amount for any purpose. Hold the entire amount of a check or a partial amount until the check clears. Hold the entire amount of a certified draft or a partial amount until the certified draft clears. Stop payment on a draft/check (written authorization from the member). Reserve funds for a preauthorized credit card purchase or for an ATM point of sale transaction. Hold funds pledged against a hold. Prevent posting an automated clearing house transaction (written authorization from the member). Stop payment on a draft (verbal authorization from the member). Prevent posting an automated clearing house transaction (verbal authorization from the member). Prevent posting an automated clearing house transaction for as long as the hold remains in the account. Hold funds when a merchant calls to verify that funds are available to cover a members check. Hold when fees cannot be collected due to insufficient funds. Hold on a preapproved hold draft for a zero-balance preapproved hold. Hold on a member draft used for bill payment until the draft posts to the account, or until the hold expires. Hold for unauthorized ACH transactions. Hold on an account that is being used for ACH origination. Hold on account when a Death Notification Entry (DNE) has been received. Hold on PIN-based transactions. Prevent posting ACH debits for member business shares. Place the entire amount of a wire transfer on hold until the outgoing wire is posted. The transaction or account is in a disputed status. </value>
        [DataMember(Name="holdType", EmitDefaultValue=true)]
        public HoldTypeEnum HoldType { get; set; }

        /// <summary>
        /// Date/time that the hold was created or should take effect. The date/time should be ISO 8601 UTC format.  yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. 
        /// </summary>
        /// <value>Date/time that the hold was created or should take effect. The date/time should be ISO 8601 UTC format.  yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. </value>
        [DataMember(Name="effectiveDate", EmitDefaultValue=false)]
        public string EffectiveDate { get; set; }

        /// <summary>
        /// Date/time that the hold should be released. The date/time should be ISO 8601 UTC format.  yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. 
        /// </summary>
        /// <value>Date/time that the hold should be released. The date/time should be ISO 8601 UTC format.  yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. </value>
        [DataMember(Name="expirationDate", EmitDefaultValue=false)]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// Date/time that the hold was actually released. The date/time should be ISO 8601 UTC format.  yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. 
        /// </summary>
        /// <value>Date/time that the hold was actually released. The date/time should be ISO 8601 UTC format.  yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. </value>
        [DataMember(Name="actualReleaseDate", EmitDefaultValue=false)]
        public string ActualReleaseDate { get; set; }


        /// <summary>
        /// This is the enumeration of statuses for holds. The hold is active. The hold is Inactive. 
        /// </summary>
        /// <value>This is the enumeration of statuses for holds. The hold is active. The hold is Inactive. </value>
        [TypeConverter(typeof(CustomEnumConverter<HoldStatusEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum HoldStatusEnum
        {
            
            /// <summary>
            /// Enum ActiveEnum for Active
            /// </summary>
            [EnumMember(Value = "Active")]
            ActiveEnum = 1,
            
            /// <summary>
            /// Enum InActiveEnum for InActive
            /// </summary>
            [EnumMember(Value = "InActive")]
            InActiveEnum = 2
        }

        /// <summary>
        /// This is the enumeration of statuses for holds. The hold is active. The hold is Inactive. 
        /// </summary>
        /// <value>This is the enumeration of statuses for holds. The hold is active. The hold is Inactive. </value>
        [DataMember(Name="holdStatus", EmitDefaultValue=true)]
        public HoldStatusEnum HoldStatus { get; set; }

        /// <summary>
        /// Description of the hold and/or a note attached to the hold. 
        /// </summary>
        /// <value>Description of the hold and/or a note attached to the hold. </value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public AccountAccountEscheatAmount Amount { get; set; }

        /// <summary>
        /// For stop payment holds, name of the draft or ACH payee. 
        /// </summary>
        /// <value>For stop payment holds, name of the draft or ACH payee. </value>
        [DataMember(Name="payee", EmitDefaultValue=false)]
        public string Payee { get; set; }


        /// <summary>
        /// Reason for the stop/hold. This value is visible to the user and must be human-readable. 
        /// </summary>
        /// <value>Reason for the stop/hold. This value is visible to the user and must be human-readable. </value>
        [TypeConverter(typeof(CustomEnumConverter<ReasonEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ReasonEnum
        {
            
            /// <summary>
            /// Enum UnknownEnum for Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            UnknownEnum = 1,
            
            /// <summary>
            /// Enum LostEnum for Lost
            /// </summary>
            [EnumMember(Value = "Lost")]
            LostEnum = 2,
            
            /// <summary>
            /// Enum StolenEnum for Stolen
            /// </summary>
            [EnumMember(Value = "Stolen")]
            StolenEnum = 3,
            
            /// <summary>
            /// Enum DestroyedEnum for Destroyed
            /// </summary>
            [EnumMember(Value = "Destroyed")]
            DestroyedEnum = 4,
            
            /// <summary>
            /// Enum NotEndorsedEnum for NotEndorsed
            /// </summary>
            [EnumMember(Value = "NotEndorsed")]
            NotEndorsedEnum = 5,
            
            /// <summary>
            /// Enum CertifiedEnum for Certified
            /// </summary>
            [EnumMember(Value = "Certified")]
            CertifiedEnum = 6,
            
            /// <summary>
            /// Enum DisputedEnum for Disputed
            /// </summary>
            [EnumMember(Value = "Disputed")]
            DisputedEnum = 7,
            
            /// <summary>
            /// Enum ReturnedMerchandiseEnum for ReturnedMerchandise
            /// </summary>
            [EnumMember(Value = "ReturnedMerchandise")]
            ReturnedMerchandiseEnum = 8,
            
            /// <summary>
            /// Enum StoppedServiceEnum for StoppedService
            /// </summary>
            [EnumMember(Value = "StoppedService")]
            StoppedServiceEnum = 9,
            
            /// <summary>
            /// Enum OtherEnum for Other
            /// </summary>
            [EnumMember(Value = "Other")]
            OtherEnum = 10
        }

        /// <summary>
        /// Reason for the stop/hold. This value is visible to the user and must be human-readable. 
        /// </summary>
        /// <value>Reason for the stop/hold. This value is visible to the user and must be human-readable. </value>
        [DataMember(Name="reason", EmitDefaultValue=true)]
        public ReasonEnum Reason { get; set; }

        /// <summary>
        /// The fee ID is a persistent and unique identifier for the fee. It must be unique for all users across the institution and remain the same over the life of the fee. 
        /// </summary>
        /// <value>The fee ID is a persistent and unique identifier for the fee. It must be unique for all users across the institution and remain the same over the life of the fee. </value>
        [DataMember(Name="feeId", EmitDefaultValue=false)]
        public string FeeId { get; set; }

        /// <summary>
        /// The number on the face of the check indicating the id of that check in a series. 
        /// </summary>
        /// <value>The number on the face of the check indicating the id of that check in a series. </value>
        [DataMember(Name="startCheckNumber", EmitDefaultValue=false)]
        public string StartCheckNumber { get; set; }

        /// <summary>
        /// The number on the face of the check indicating the id of that check in a series. 
        /// </summary>
        /// <value>The number on the face of the check indicating the id of that check in a series. </value>
        [DataMember(Name="endCheckNumber", EmitDefaultValue=false)]
        public string EndCheckNumber { get; set; }

        /// <summary>
        /// Gets or Sets CustomData
        /// </summary>
        [DataMember(Name="customData", EmitDefaultValue=false)]
        public AccessProfileCustomData CustomData { get; set; }

    }
}
