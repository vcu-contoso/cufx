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
    public partial class Wire 
    {
        /// <summary>
        /// The occurrence ID to uniquely identify the occurrence of a payment or transfer. 
        /// </summary>
        /// <value>The occurrence ID to uniquely identify the occurrence of a payment or transfer. </value>
        [DataMember(Name="occurrenceId", EmitDefaultValue=false)]
        public string OccurrenceId { get; set; }

        /// <summary>
        /// ID to uniquely identify a recurring payment or transfer request. 
        /// </summary>
        /// <value>ID to uniquely identify a recurring payment or transfer request. </value>
        [DataMember(Name="recurringId", EmitDefaultValue=false)]
        public string RecurringId { get; set; }

        /// <summary>
        /// Gets or Sets OccurrenceAmount
        /// </summary>
        [DataMember(Name="occurrenceAmount", EmitDefaultValue=false)]
        public AccountAccountEscheatAmount OccurrenceAmount { get; set; }

        /// <summary>
        /// Gets or Sets OccurrenceAmountDetailList
        /// </summary>
        [DataMember(Name="occurrenceAmountDetailList", EmitDefaultValue=false)]
        public BillPaymentOccurrenceOccurrenceAmountDetailList OccurrenceAmountDetailList { get; set; }

        /// <summary>
        /// Gets or Sets OccurrenceFromAccount
        /// </summary>
        [DataMember(Name="occurrenceFromAccount", EmitDefaultValue=false)]
        public BillPaymentOccurrenceOccurrenceFromAccount OccurrenceFromAccount { get; set; }

        /// <summary>
        /// Gets or Sets OccurrenceToAccount
        /// </summary>
        [DataMember(Name="occurrenceToAccount", EmitDefaultValue=false)]
        public BillPaymentOccurrenceOccurrenceFromAccount OccurrenceToAccount { get; set; }


        /// <summary>
        /// This is the enumeration of statuses for payments or transfers. The payment or transfer is in the process for immediate or future payment and is cancellable by the party since its not InProcess yet. The payment or transfer is in process and is no longer cancellable, but it has not been sent. A payment or transfer was requested to be cancelled by the party but has not yet been cancelled. A payment or transfer has been cancelled at the request of the originating partys financial institution. A payment or transfer has been cancelled at the request of the processor. Example is case of bill pay this would be the bill payment processor. A payment or transfer has been cancelled. Payment or transfer has been sent to the payee but has not been received yet. The payment or transfer transaction has been cleared/completed by the financial institution. The payment or transfer was declined (for instance, in the case that a debit or card was used as the funding source). The funds have been transferred to the payment processor but have not yet arrived at the payment processor. The funds for the payment or transfer have been received by the payment processor but the actual payment hasnt cleared at the payee. The payment or transfer has been held by the payment processor and has not been sent to the payee. The payment or transfer has attempted to clear the financial institution account but there was not enough funds available. Payment or transfer was returned by the payee and not cleared. Payment or transfer was scheduled for recurring payment but has been suspended until taken out of suspended status. 
        /// </summary>
        /// <value>This is the enumeration of statuses for payments or transfers. The payment or transfer is in the process for immediate or future payment and is cancellable by the party since its not InProcess yet. The payment or transfer is in process and is no longer cancellable, but it has not been sent. A payment or transfer was requested to be cancelled by the party but has not yet been cancelled. A payment or transfer has been cancelled at the request of the originating partys financial institution. A payment or transfer has been cancelled at the request of the processor. Example is case of bill pay this would be the bill payment processor. A payment or transfer has been cancelled. Payment or transfer has been sent to the payee but has not been received yet. The payment or transfer transaction has been cleared/completed by the financial institution. The payment or transfer was declined (for instance, in the case that a debit or card was used as the funding source). The funds have been transferred to the payment processor but have not yet arrived at the payment processor. The funds for the payment or transfer have been received by the payment processor but the actual payment hasnt cleared at the payee. The payment or transfer has been held by the payment processor and has not been sent to the payee. The payment or transfer has attempted to clear the financial institution account but there was not enough funds available. Payment or transfer was returned by the payee and not cleared. Payment or transfer was scheduled for recurring payment but has been suspended until taken out of suspended status. </value>
        [TypeConverter(typeof(CustomEnumConverter<OccurrenceStatusEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum OccurrenceStatusEnum
        {
            
            /// <summary>
            /// Enum ScheduledEnum for Scheduled
            /// </summary>
            [EnumMember(Value = "Scheduled")]
            ScheduledEnum = 1,
            
            /// <summary>
            /// Enum InProcessEnum for InProcess
            /// </summary>
            [EnumMember(Value = "InProcess")]
            InProcessEnum = 2,
            
            /// <summary>
            /// Enum CancelRequestedByPartyEnum for CancelRequestedByParty
            /// </summary>
            [EnumMember(Value = "CancelRequestedByParty")]
            CancelRequestedByPartyEnum = 3,
            
            /// <summary>
            /// Enum CancelRequestedByFinancialInstitutionEnum for CancelRequestedByFinancialInstitution
            /// </summary>
            [EnumMember(Value = "CancelRequestedByFinancialInstitution")]
            CancelRequestedByFinancialInstitutionEnum = 4,
            
            /// <summary>
            /// Enum CancelRequestedByProcessorEnum for CancelRequestedByProcessor
            /// </summary>
            [EnumMember(Value = "CancelRequestedByProcessor")]
            CancelRequestedByProcessorEnum = 5,
            
            /// <summary>
            /// Enum CancelledEnum for Cancelled
            /// </summary>
            [EnumMember(Value = "Cancelled")]
            CancelledEnum = 6,
            
            /// <summary>
            /// Enum SentEnum for Sent
            /// </summary>
            [EnumMember(Value = "Sent")]
            SentEnum = 7,
            
            /// <summary>
            /// Enum CompletedEnum for Completed
            /// </summary>
            [EnumMember(Value = "Completed")]
            CompletedEnum = 8,
            
            /// <summary>
            /// Enum DeclinedEnum for Declined
            /// </summary>
            [EnumMember(Value = "Declined")]
            DeclinedEnum = 9,
            
            /// <summary>
            /// Enum FundsOutboundEnum for FundsOutbound
            /// </summary>
            [EnumMember(Value = "FundsOutbound")]
            FundsOutboundEnum = 10,
            
            /// <summary>
            /// Enum FundsClearedEnum for FundsCleared
            /// </summary>
            [EnumMember(Value = "FundsCleared")]
            FundsClearedEnum = 11,
            
            /// <summary>
            /// Enum HeldEnum for Held
            /// </summary>
            [EnumMember(Value = "Held")]
            HeldEnum = 12,
            
            /// <summary>
            /// Enum InsufficientFundsEnum for InsufficientFunds
            /// </summary>
            [EnumMember(Value = "InsufficientFunds")]
            InsufficientFundsEnum = 13,
            
            /// <summary>
            /// Enum ReturnedEnum for Returned
            /// </summary>
            [EnumMember(Value = "Returned")]
            ReturnedEnum = 14,
            
            /// <summary>
            /// Enum SuspendedEnum for Suspended
            /// </summary>
            [EnumMember(Value = "Suspended")]
            SuspendedEnum = 15
        }

        /// <summary>
        /// This is the enumeration of statuses for payments or transfers. The payment or transfer is in the process for immediate or future payment and is cancellable by the party since its not InProcess yet. The payment or transfer is in process and is no longer cancellable, but it has not been sent. A payment or transfer was requested to be cancelled by the party but has not yet been cancelled. A payment or transfer has been cancelled at the request of the originating partys financial institution. A payment or transfer has been cancelled at the request of the processor. Example is case of bill pay this would be the bill payment processor. A payment or transfer has been cancelled. Payment or transfer has been sent to the payee but has not been received yet. The payment or transfer transaction has been cleared/completed by the financial institution. The payment or transfer was declined (for instance, in the case that a debit or card was used as the funding source). The funds have been transferred to the payment processor but have not yet arrived at the payment processor. The funds for the payment or transfer have been received by the payment processor but the actual payment hasnt cleared at the payee. The payment or transfer has been held by the payment processor and has not been sent to the payee. The payment or transfer has attempted to clear the financial institution account but there was not enough funds available. Payment or transfer was returned by the payee and not cleared. Payment or transfer was scheduled for recurring payment but has been suspended until taken out of suspended status. 
        /// </summary>
        /// <value>This is the enumeration of statuses for payments or transfers. The payment or transfer is in the process for immediate or future payment and is cancellable by the party since its not InProcess yet. The payment or transfer is in process and is no longer cancellable, but it has not been sent. A payment or transfer was requested to be cancelled by the party but has not yet been cancelled. A payment or transfer has been cancelled at the request of the originating partys financial institution. A payment or transfer has been cancelled at the request of the processor. Example is case of bill pay this would be the bill payment processor. A payment or transfer has been cancelled. Payment or transfer has been sent to the payee but has not been received yet. The payment or transfer transaction has been cleared/completed by the financial institution. The payment or transfer was declined (for instance, in the case that a debit or card was used as the funding source). The funds have been transferred to the payment processor but have not yet arrived at the payment processor. The funds for the payment or transfer have been received by the payment processor but the actual payment hasnt cleared at the payee. The payment or transfer has been held by the payment processor and has not been sent to the payee. The payment or transfer has attempted to clear the financial institution account but there was not enough funds available. Payment or transfer was returned by the payee and not cleared. Payment or transfer was scheduled for recurring payment but has been suspended until taken out of suspended status. </value>
        [DataMember(Name="occurrenceStatus", EmitDefaultValue=true)]
        public OccurrenceStatusEnum OccurrenceStatus { get; set; }


        /// <summary>
        /// This is the enumeration of statuses for a recurring payment or transfer request . The funds will be pulled out of the account at the time that the payment or transfer request is made each time that the occurrence happens.  For example in a good funds model in bill payment. The funds will be pulled out of the account at the time that the payment or transfer clears the account each time that the occurrence happens.  For example a check. 
        /// </summary>
        /// <value>This is the enumeration of statuses for a recurring payment or transfer request . The funds will be pulled out of the account at the time that the payment or transfer request is made each time that the occurrence happens.  For example in a good funds model in bill payment. The funds will be pulled out of the account at the time that the payment or transfer clears the account each time that the occurrence happens.  For example a check. </value>
        [TypeConverter(typeof(CustomEnumConverter<FundsWithdrawalTypeEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum FundsWithdrawalTypeEnum
        {
            
            /// <summary>
            /// Enum WhenRequestedEnum for WhenRequested
            /// </summary>
            [EnumMember(Value = "WhenRequested")]
            WhenRequestedEnum = 1,
            
            /// <summary>
            /// Enum WhenClearedEnum for WhenCleared
            /// </summary>
            [EnumMember(Value = "WhenCleared")]
            WhenClearedEnum = 2
        }

        /// <summary>
        /// This is the enumeration of statuses for a recurring payment or transfer request . The funds will be pulled out of the account at the time that the payment or transfer request is made each time that the occurrence happens.  For example in a good funds model in bill payment. The funds will be pulled out of the account at the time that the payment or transfer clears the account each time that the occurrence happens.  For example a check. 
        /// </summary>
        /// <value>This is the enumeration of statuses for a recurring payment or transfer request . The funds will be pulled out of the account at the time that the payment or transfer request is made each time that the occurrence happens.  For example in a good funds model in bill payment. The funds will be pulled out of the account at the time that the payment or transfer clears the account each time that the occurrence happens.  For example a check. </value>
        [DataMember(Name="fundsWithdrawalType", EmitDefaultValue=true)]
        public FundsWithdrawalTypeEnum FundsWithdrawalType { get; set; }

        /// <summary>
        /// The memo represents a short description that can be applied to the comment of the transaction or printed on a check. 
        /// </summary>
        /// <value>The memo represents a short description that can be applied to the comment of the transaction or printed on a check. </value>
        [DataMember(Name="occurrenceMemo", EmitDefaultValue=false)]
        public string OccurrenceMemo { get; set; }

        /// <summary>
        /// The date on which to process the payment or transfer.  This date can be in the future. The date/time should be ISO 8601 UTC format.  yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. 
        /// </summary>
        /// <value>The date on which to process the payment or transfer.  This date can be in the future. The date/time should be ISO 8601 UTC format.  yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. </value>
        [DataMember(Name="estimatedProcessDateTime", EmitDefaultValue=false)]
        public string EstimatedProcessDateTime { get; set; }

        /// <summary>
        /// The date that the user submitted the payment or transfer. The date/time should be ISO 8601 UTC format.  yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. 
        /// </summary>
        /// <value>The date that the user submitted the payment or transfer. The date/time should be ISO 8601 UTC format.  yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. </value>
        [DataMember(Name="createdDateTime", EmitDefaultValue=false)]
        public string CreatedDateTime { get; set; }

        /// <summary>
        /// The date on which the payment or transfer processing started. The date/time should be ISO 8601 UTC format.  yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. 
        /// </summary>
        /// <value>The date on which the payment or transfer processing started. The date/time should be ISO 8601 UTC format.  yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. </value>
        [DataMember(Name="processingStartedDateTime", EmitDefaultValue=false)]
        public string ProcessingStartedDateTime { get; set; }

        /// <summary>
        /// The date on which the payment or transfer was actually processed by the system. The date/time should be ISO 8601 UTC format.  yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. 
        /// </summary>
        /// <value>The date on which the payment or transfer was actually processed by the system. The date/time should be ISO 8601 UTC format.  yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. </value>
        [DataMember(Name="processedDateTime", EmitDefaultValue=false)]
        public string ProcessedDateTime { get; set; }

        /// <summary>
        /// Date on which the core completed the payment or transfer. The date/time should be ISO 8601 UTC format.  yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. 
        /// </summary>
        /// <value>Date on which the core completed the payment or transfer. The date/time should be ISO 8601 UTC format.  yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. </value>
        [DataMember(Name="completedDateTime", EmitDefaultValue=false)]
        public string CompletedDateTime { get; set; }

        /// <summary>
        /// Date of the last known status of the payment or transfer. The date/time should be ISO 8601 UTC format.  yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. 
        /// </summary>
        /// <value>Date of the last known status of the payment or transfer. The date/time should be ISO 8601 UTC format.  yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. </value>
        [DataMember(Name="lastUpdatedDateTime", EmitDefaultValue=false)]
        public string LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Unique confirmation code for the requested payment or transfer. 
        /// </summary>
        /// <value>Unique confirmation code for the requested payment or transfer. </value>
        [DataMember(Name="occurrenceConfirmationCode", EmitDefaultValue=false)]
        public string OccurrenceConfirmationCode { get; set; }

        /// <summary>
        /// Indicates whether the payment or transfer is pending for posting until system is on-line. 
        /// </summary>
        /// <value>Indicates whether the payment or transfer is pending for posting until system is on-line. </value>
        [DataMember(Name="queuedForPosting", EmitDefaultValue=true)]
        public bool QueuedForPosting { get; set; }

        /// <summary>
        /// A users \&quot;note to self.\&quot; 
        /// </summary>
        /// <value>A users \&quot;note to self.\&quot; </value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }

        /// <summary>
        /// The BatchId is a persistent and unique identifier for a group of payments or transfers processed at the same time. 
        /// </summary>
        /// <value>The BatchId is a persistent and unique identifier for a group of payments or transfers processed at the same time. </value>
        [DataMember(Name="batchId", EmitDefaultValue=false)]
        public string BatchId { get; set; }


        /// <summary>
        /// This is the enumeration of transfer occurrence types for a payment or transfer request . Transfer funds between accounts generally an intra-instiution transfer. Transfer funds to a check. For example, member requests a check payable to the member to be mailed to the members home address. Transfer funds to an account at another financial institution for purposes of validating the external account. For example, use with account micro deposits via ACH. 
        /// </summary>
        /// <value>This is the enumeration of transfer occurrence types for a payment or transfer request . Transfer funds between accounts generally an intra-instiution transfer. Transfer funds to a check. For example, member requests a check payable to the member to be mailed to the members home address. Transfer funds to an account at another financial institution for purposes of validating the external account. For example, use with account micro deposits via ACH. </value>
        [TypeConverter(typeof(CustomEnumConverter<OccurrenceTypeEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum OccurrenceTypeEnum
        {
            
            /// <summary>
            /// Enum AccountToAccountEnum for AccountToAccount
            /// </summary>
            [EnumMember(Value = "AccountToAccount")]
            AccountToAccountEnum = 1,
            
            /// <summary>
            /// Enum CheckWithdrawalEnum for CheckWithdrawal
            /// </summary>
            [EnumMember(Value = "CheckWithdrawal")]
            CheckWithdrawalEnum = 2,
            
            /// <summary>
            /// Enum AccountValidationEnum for AccountValidation
            /// </summary>
            [EnumMember(Value = "AccountValidation")]
            AccountValidationEnum = 3
        }

        /// <summary>
        /// This is the enumeration of transfer occurrence types for a payment or transfer request . Transfer funds between accounts generally an intra-instiution transfer. Transfer funds to a check. For example, member requests a check payable to the member to be mailed to the members home address. Transfer funds to an account at another financial institution for purposes of validating the external account. For example, use with account micro deposits via ACH. 
        /// </summary>
        /// <value>This is the enumeration of transfer occurrence types for a payment or transfer request . Transfer funds between accounts generally an intra-instiution transfer. Transfer funds to a check. For example, member requests a check payable to the member to be mailed to the members home address. Transfer funds to an account at another financial institution for purposes of validating the external account. For example, use with account micro deposits via ACH. </value>
        [DataMember(Name="occurrenceType", EmitDefaultValue=true)]
        public OccurrenceTypeEnum OccurrenceType { get; set; }

        /// <summary>
        /// Gets or Sets CustomData
        /// </summary>
        [DataMember(Name="customData", EmitDefaultValue=false)]
        public AccessProfileCustomData CustomData { get; set; }


        /// <summary>
        /// Acknowledgment Entry. Financial EDI Acknowledgment. Accounts Receivable Entry. Back Office Conversion Entry. Corporate Credit Debit Entry. Customer-Initiated Entry. Notification of Change or Refused Notification of Change. Corporate Trade Exchange. Death Notification Entry. Automated Enrollment Entry. International ACH Transaction. Machine Transfer Entry. Point of Purchase Entry. Prearranged Payment and Deposit Entry. Re-Presented Check Entry. Telephone Initiated Entry. Truncated Entry. Truncated Entries Exchange. Internet Initiated Entry. Destroyed Check Entry. 
        /// </summary>
        /// <value>Acknowledgment Entry. Financial EDI Acknowledgment. Accounts Receivable Entry. Back Office Conversion Entry. Corporate Credit Debit Entry. Customer-Initiated Entry. Notification of Change or Refused Notification of Change. Corporate Trade Exchange. Death Notification Entry. Automated Enrollment Entry. International ACH Transaction. Machine Transfer Entry. Point of Purchase Entry. Prearranged Payment and Deposit Entry. Re-Presented Check Entry. Telephone Initiated Entry. Truncated Entry. Truncated Entries Exchange. Internet Initiated Entry. Destroyed Check Entry. </value>
        [TypeConverter(typeof(CustomEnumConverter<AchStandardEntryClassEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum AchStandardEntryClassEnum
        {
            
            /// <summary>
            /// Enum ACKEnum for ACK
            /// </summary>
            [EnumMember(Value = "ACK")]
            ACKEnum = 1,
            
            /// <summary>
            /// Enum ATXEnum for ATX
            /// </summary>
            [EnumMember(Value = "ATX")]
            ATXEnum = 2,
            
            /// <summary>
            /// Enum ARCEnum for ARC
            /// </summary>
            [EnumMember(Value = "ARC")]
            ARCEnum = 3,
            
            /// <summary>
            /// Enum BOCEnum for BOC
            /// </summary>
            [EnumMember(Value = "BOC")]
            BOCEnum = 4,
            
            /// <summary>
            /// Enum CCDEnum for CCD
            /// </summary>
            [EnumMember(Value = "CCD")]
            CCDEnum = 5,
            
            /// <summary>
            /// Enum CIEEnum for CIE
            /// </summary>
            [EnumMember(Value = "CIE")]
            CIEEnum = 6,
            
            /// <summary>
            /// Enum COREnum for COR
            /// </summary>
            [EnumMember(Value = "COR")]
            COREnum = 7,
            
            /// <summary>
            /// Enum CTXEnum for CTX
            /// </summary>
            [EnumMember(Value = "CTX")]
            CTXEnum = 8,
            
            /// <summary>
            /// Enum DNEEnum for DNE
            /// </summary>
            [EnumMember(Value = "DNE")]
            DNEEnum = 9,
            
            /// <summary>
            /// Enum ENREnum for ENR
            /// </summary>
            [EnumMember(Value = "ENR")]
            ENREnum = 10,
            
            /// <summary>
            /// Enum IATEnum for IAT
            /// </summary>
            [EnumMember(Value = "IAT")]
            IATEnum = 11,
            
            /// <summary>
            /// Enum MTEEnum for MTE
            /// </summary>
            [EnumMember(Value = "MTE")]
            MTEEnum = 12,
            
            /// <summary>
            /// Enum POPEnum for POP
            /// </summary>
            [EnumMember(Value = "POP")]
            POPEnum = 13,
            
            /// <summary>
            /// Enum PPDEnum for PPD
            /// </summary>
            [EnumMember(Value = "PPD")]
            PPDEnum = 14,
            
            /// <summary>
            /// Enum RCKEnum for RCK
            /// </summary>
            [EnumMember(Value = "RCK")]
            RCKEnum = 15,
            
            /// <summary>
            /// Enum TELEnum for TEL
            /// </summary>
            [EnumMember(Value = "TEL")]
            TELEnum = 16,
            
            /// <summary>
            /// Enum TRCEnum for TRC
            /// </summary>
            [EnumMember(Value = "TRC")]
            TRCEnum = 17,
            
            /// <summary>
            /// Enum TRXEnum for TRX
            /// </summary>
            [EnumMember(Value = "TRX")]
            TRXEnum = 18,
            
            /// <summary>
            /// Enum WEBEnum for WEB
            /// </summary>
            [EnumMember(Value = "WEB")]
            WEBEnum = 19,
            
            /// <summary>
            /// Enum XCKEnum for XCK
            /// </summary>
            [EnumMember(Value = "XCK")]
            XCKEnum = 20
        }

        /// <summary>
        /// Acknowledgment Entry. Financial EDI Acknowledgment. Accounts Receivable Entry. Back Office Conversion Entry. Corporate Credit Debit Entry. Customer-Initiated Entry. Notification of Change or Refused Notification of Change. Corporate Trade Exchange. Death Notification Entry. Automated Enrollment Entry. International ACH Transaction. Machine Transfer Entry. Point of Purchase Entry. Prearranged Payment and Deposit Entry. Re-Presented Check Entry. Telephone Initiated Entry. Truncated Entry. Truncated Entries Exchange. Internet Initiated Entry. Destroyed Check Entry. 
        /// </summary>
        /// <value>Acknowledgment Entry. Financial EDI Acknowledgment. Accounts Receivable Entry. Back Office Conversion Entry. Corporate Credit Debit Entry. Customer-Initiated Entry. Notification of Change or Refused Notification of Change. Corporate Trade Exchange. Death Notification Entry. Automated Enrollment Entry. International ACH Transaction. Machine Transfer Entry. Point of Purchase Entry. Prearranged Payment and Deposit Entry. Re-Presented Check Entry. Telephone Initiated Entry. Truncated Entry. Truncated Entries Exchange. Internet Initiated Entry. Destroyed Check Entry. </value>
        [DataMember(Name="achStandardEntryClass", EmitDefaultValue=true)]
        public AchStandardEntryClassEnum AchStandardEntryClass { get; set; }


        /// <summary>
        /// Wire transfer type. 
        /// </summary>
        /// <value>Wire transfer type. </value>
        [TypeConverter(typeof(CustomEnumConverter<WireTransferTypeEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum WireTransferTypeEnum
        {
            
            /// <summary>
            /// Enum DomesticEnum for Domestic
            /// </summary>
            [EnumMember(Value = "Domestic")]
            DomesticEnum = 1,
            
            /// <summary>
            /// Enum ForeignEnum for Foreign
            /// </summary>
            [EnumMember(Value = "Foreign")]
            ForeignEnum = 2,
            
            /// <summary>
            /// Enum InvestmentEnum for Investment
            /// </summary>
            [EnumMember(Value = "Investment")]
            InvestmentEnum = 3,
            
            /// <summary>
            /// Enum EscrowEnum for Escrow
            /// </summary>
            [EnumMember(Value = "Escrow")]
            EscrowEnum = 4
        }

        /// <summary>
        /// Wire transfer type. 
        /// </summary>
        /// <value>Wire transfer type. </value>
        [DataMember(Name="wireTransferType", EmitDefaultValue=true)]
        public WireTransferTypeEnum WireTransferType { get; set; }

        /// <summary>
        /// Special instructions for wire transfer.  This field, while optional, is required when the wire transfer is of International type and destined for certain foreign nations, according to federal regulations. 
        /// </summary>
        /// <value>Special instructions for wire transfer.  This field, while optional, is required when the wire transfer is of International type and destined for certain foreign nations, according to federal regulations. </value>
        [DataMember(Name="wireTransferSpecialInstructions", EmitDefaultValue=false)]
        public string WireTransferSpecialInstructions { get; set; }

        /// <summary>
        /// Escrow number for wire transfer type escrow. 
        /// </summary>
        /// <value>Escrow number for wire transfer type escrow. </value>
        [DataMember(Name="escrowNumber", EmitDefaultValue=false)]
        public string EscrowNumber { get; set; }

        /// <summary>
        /// Escrow officer name for wire transfer type escrow. 
        /// </summary>
        /// <value>Escrow officer name for wire transfer type escrow. </value>
        [DataMember(Name="escrowOfficerName", EmitDefaultValue=false)]
        public string EscrowOfficerName { get; set; }

        /// <summary>
        /// Any and all disclosures, terms and conditions, etc., have been provided and consented to by the initiator of the wire.  Consent is required by federal regulation for wire transfer type International. 
        /// </summary>
        /// <value>Any and all disclosures, terms and conditions, etc., have been provided and consented to by the initiator of the wire.  Consent is required by federal regulation for wire transfer type International. </value>
        [DataMember(Name="disclosuresConsented", EmitDefaultValue=true)]
        public bool DisclosuresConsented { get; set; }

        /// <summary>
        /// Gets or Sets BeneficiaryName
        /// </summary>
        [DataMember(Name="beneficiaryName", EmitDefaultValue=false)]
        public ContactContactPersonName BeneficiaryName { get; set; }

        /// <summary>
        /// Gets or Sets BeneficiaryAddress
        /// </summary>
        [DataMember(Name="beneficiaryAddress", EmitDefaultValue=false)]
        public AccountExternalAccountBankAddress BeneficiaryAddress { get; set; }

    }
}
