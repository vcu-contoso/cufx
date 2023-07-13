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
    public partial class Service 
    {
        /// <summary>
        /// Unique identification for the combination of Service name, Protocol, and cufxVersion by configuration. 
        /// </summary>
        /// <value>Unique identification for the combination of Service name, Protocol, and cufxVersion by configuration. </value>
        [DataMember(Name="serviceId", EmitDefaultValue=false)]
        public string ServiceId { get; set; }


        /// <summary>
        /// Generic name for the service. (Key value) 
        /// </summary>
        /// <value>Generic name for the service. (Key value) </value>
        [TypeConverter(typeof(CustomEnumConverter<ServiceNameEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ServiceNameEnum
        {
            
            /// <summary>
            /// Enum AccessProfileEnum for AccessProfile
            /// </summary>
            [EnumMember(Value = "AccessProfile")]
            AccessProfileEnum = 1,
            
            /// <summary>
            /// Enum AccountEnum for Account
            /// </summary>
            [EnumMember(Value = "Account")]
            AccountEnum = 2,
            
            /// <summary>
            /// Enum ActivityEnum for Activity
            /// </summary>
            [EnumMember(Value = "Activity")]
            ActivityEnum = 3,
            
            /// <summary>
            /// Enum AppEnum for App
            /// </summary>
            [EnumMember(Value = "App")]
            AppEnum = 4,
            
            /// <summary>
            /// Enum ApplicationEnum for Application
            /// </summary>
            [EnumMember(Value = "Application")]
            ApplicationEnum = 5,
            
            /// <summary>
            /// Enum ArtifactEnum for Artifact
            /// </summary>
            [EnumMember(Value = "Artifact")]
            ArtifactEnum = 6,
            
            /// <summary>
            /// Enum BillEnum for Bill
            /// </summary>
            [EnumMember(Value = "Bill")]
            BillEnum = 7,
            
            /// <summary>
            /// Enum BillPayeeEnum for BillPayee
            /// </summary>
            [EnumMember(Value = "BillPayee")]
            BillPayeeEnum = 8,
            
            /// <summary>
            /// Enum BillPaymentOccurrenceEnum for BillPaymentOccurrence
            /// </summary>
            [EnumMember(Value = "BillPaymentOccurrence")]
            BillPaymentOccurrenceEnum = 9,
            
            /// <summary>
            /// Enum BillPaymentReoccurringEnum for BillPaymentReoccurring
            /// </summary>
            [EnumMember(Value = "BillPaymentReoccurring")]
            BillPaymentReoccurringEnum = 10,
            
            /// <summary>
            /// Enum CardEnum for Card
            /// </summary>
            [EnumMember(Value = "Card")]
            CardEnum = 11,
            
            /// <summary>
            /// Enum CategoryEnum for Category
            /// </summary>
            [EnumMember(Value = "Category")]
            CategoryEnum = 12,
            
            /// <summary>
            /// Enum CollateralEnum for Collateral
            /// </summary>
            [EnumMember(Value = "Collateral")]
            CollateralEnum = 13,
            
            /// <summary>
            /// Enum ConfigurationEnum for Configuration
            /// </summary>
            [EnumMember(Value = "Configuration")]
            ConfigurationEnum = 14,
            
            /// <summary>
            /// Enum ContactEnum for Contact
            /// </summary>
            [EnumMember(Value = "Contact")]
            ContactEnum = 15,
            
            /// <summary>
            /// Enum CredentialGroupEnum for CredentialGroup
            /// </summary>
            [EnumMember(Value = "CredentialGroup")]
            CredentialGroupEnum = 16,
            
            /// <summary>
            /// Enum CreditReportEnum for CreditReport
            /// </summary>
            [EnumMember(Value = "CreditReport")]
            CreditReportEnum = 17,
            
            /// <summary>
            /// Enum DepositFundingEnum for DepositFunding
            /// </summary>
            [EnumMember(Value = "DepositFunding")]
            DepositFundingEnum = 18,
            
            /// <summary>
            /// Enum DepositEnum for Deposit
            /// </summary>
            [EnumMember(Value = "Deposit")]
            DepositEnum = 19,
            
            /// <summary>
            /// Enum DocumentEnum for Document
            /// </summary>
            [EnumMember(Value = "Document")]
            DocumentEnum = 20,
            
            /// <summary>
            /// Enum EligibilityRequirementEnum for EligibilityRequirement
            /// </summary>
            [EnumMember(Value = "EligibilityRequirement")]
            EligibilityRequirementEnum = 21,
            
            /// <summary>
            /// Enum FeeScheduleEnum for FeeSchedule
            /// </summary>
            [EnumMember(Value = "FeeSchedule")]
            FeeScheduleEnum = 22,
            
            /// <summary>
            /// Enum FieldEnum for Field
            /// </summary>
            [EnumMember(Value = "Field")]
            FieldEnum = 23,
            
            /// <summary>
            /// Enum HoldEnum for Hold
            /// </summary>
            [EnumMember(Value = "Hold")]
            HoldEnum = 24,
            
            /// <summary>
            /// Enum InvestmentHoldingEnum for InvestmentHolding
            /// </summary>
            [EnumMember(Value = "InvestmentHolding")]
            InvestmentHoldingEnum = 25,
            
            /// <summary>
            /// Enum InvestmentEnum for Investment
            /// </summary>
            [EnumMember(Value = "Investment")]
            InvestmentEnum = 26,
            
            /// <summary>
            /// Enum LoanDisbursementEnum for LoanDisbursement
            /// </summary>
            [EnumMember(Value = "LoanDisbursement")]
            LoanDisbursementEnum = 27,
            
            /// <summary>
            /// Enum LoanEnum for Loan
            /// </summary>
            [EnumMember(Value = "Loan")]
            LoanEnum = 28,
            
            /// <summary>
            /// Enum LocationEnum for Location
            /// </summary>
            [EnumMember(Value = "Location")]
            LocationEnum = 29,
            
            /// <summary>
            /// Enum MicroDepositFundingEnum for MicroDepositFunding
            /// </summary>
            [EnumMember(Value = "MicroDepositFunding")]
            MicroDepositFundingEnum = 30,
            
            /// <summary>
            /// Enum NetworkNodeEnum for NetworkNode
            /// </summary>
            [EnumMember(Value = "NetworkNode")]
            NetworkNodeEnum = 31,
            
            /// <summary>
            /// Enum NotesEnum for Notes
            /// </summary>
            [EnumMember(Value = "Notes")]
            NotesEnum = 32,
            
            /// <summary>
            /// Enum OverdraftPriorityEnum for OverdraftPriority
            /// </summary>
            [EnumMember(Value = "OverdraftPriority")]
            OverdraftPriorityEnum = 33,
            
            /// <summary>
            /// Enum PartyAssociationEnum for PartyAssociation
            /// </summary>
            [EnumMember(Value = "PartyAssociation")]
            PartyAssociationEnum = 34,
            
            /// <summary>
            /// Enum PartyEnum for Party
            /// </summary>
            [EnumMember(Value = "Party")]
            PartyEnum = 35,
            
            /// <summary>
            /// Enum PermissionListEnum for PermissionList
            /// </summary>
            [EnumMember(Value = "PermissionList")]
            PermissionListEnum = 36,
            
            /// <summary>
            /// Enum PreferenceEnum for Preference
            /// </summary>
            [EnumMember(Value = "Preference")]
            PreferenceEnum = 37,
            
            /// <summary>
            /// Enum ProductOfferingEnum for ProductOffering
            /// </summary>
            [EnumMember(Value = "ProductOffering")]
            ProductOfferingEnum = 38,
            
            /// <summary>
            /// Enum ProductServiceEnrollmentEnum for ProductServiceEnrollment
            /// </summary>
            [EnumMember(Value = "ProductServiceEnrollment")]
            ProductServiceEnrollmentEnum = 39,
            
            /// <summary>
            /// Enum ProductServiceRequestEnum for ProductServiceRequest
            /// </summary>
            [EnumMember(Value = "ProductServiceRequest")]
            ProductServiceRequestEnum = 40,
            
            /// <summary>
            /// Enum RegisteredDeviceEnum for RegisteredDevice
            /// </summary>
            [EnumMember(Value = "RegisteredDevice")]
            RegisteredDeviceEnum = 41,
            
            /// <summary>
            /// Enum RelationshipEnum for Relationship
            /// </summary>
            [EnumMember(Value = "Relationship")]
            RelationshipEnum = 42,
            
            /// <summary>
            /// Enum RemoteDepositEnum for RemoteDeposit
            /// </summary>
            [EnumMember(Value = "RemoteDeposit")]
            RemoteDepositEnum = 43,
            
            /// <summary>
            /// Enum SecureMessageEnum for SecureMessage
            /// </summary>
            [EnumMember(Value = "SecureMessage")]
            SecureMessageEnum = 44,
            
            /// <summary>
            /// Enum SimpleValidationRequestEnum for SimpleValidationRequest
            /// </summary>
            [EnumMember(Value = "SimpleValidationRequest")]
            SimpleValidationRequestEnum = 45,
            
            /// <summary>
            /// Enum SystemStatusEnum for SystemStatus
            /// </summary>
            [EnumMember(Value = "SystemStatus")]
            SystemStatusEnum = 46,
            
            /// <summary>
            /// Enum TransactionEnum for Transaction
            /// </summary>
            [EnumMember(Value = "Transaction")]
            TransactionEnum = 47,
            
            /// <summary>
            /// Enum TransferOccurrenceEnum for TransferOccurrence
            /// </summary>
            [EnumMember(Value = "TransferOccurrence")]
            TransferOccurrenceEnum = 48,
            
            /// <summary>
            /// Enum TransferRecurringEnum for TransferRecurring
            /// </summary>
            [EnumMember(Value = "TransferRecurring")]
            TransferRecurringEnum = 49,
            
            /// <summary>
            /// Enum UserEnum for User
            /// </summary>
            [EnumMember(Value = "User")]
            UserEnum = 50,
            
            /// <summary>
            /// Enum WireEnum for Wire
            /// </summary>
            [EnumMember(Value = "Wire")]
            WireEnum = 51
        }

        /// <summary>
        /// Generic name for the service. (Key value) 
        /// </summary>
        /// <value>Generic name for the service. (Key value) </value>
        [DataMember(Name="serviceName", EmitDefaultValue=true)]
        public ServiceNameEnum ServiceName { get; set; }


        /// <summary>
        /// Technology web service protocol available. (Key value) 
        /// </summary>
        /// <value>Technology web service protocol available. (Key value) </value>
        [TypeConverter(typeof(CustomEnumConverter<ProtocolEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ProtocolEnum
        {
            
            /// <summary>
            /// Enum RESTXMLEnum for REST-XML
            /// </summary>
            [EnumMember(Value = "REST-XML")]
            RESTXMLEnum = 1,
            
            /// <summary>
            /// Enum RESTJSONEnum for REST-JSON
            /// </summary>
            [EnumMember(Value = "REST-JSON")]
            RESTJSONEnum = 2,
            
            /// <summary>
            /// Enum SOAP11Enum for SOAP1.1
            /// </summary>
            [EnumMember(Value = "SOAP1.1")]
            SOAP11Enum = 3,
            
            /// <summary>
            /// Enum SOAP12Enum for SOAP1.2
            /// </summary>
            [EnumMember(Value = "SOAP1.2")]
            SOAP12Enum = 4
        }

        /// <summary>
        /// Technology web service protocol available. (Key value) 
        /// </summary>
        /// <value>Technology web service protocol available. (Key value) </value>
        [DataMember(Name="protocol", EmitDefaultValue=true)]
        public ProtocolEnum Protocol { get; set; }


        /// <summary>
        /// The version for the service. (Key value) 
        /// </summary>
        /// <value>The version for the service. (Key value) </value>
        [TypeConverter(typeof(CustomEnumConverter<CufxVersionEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum CufxVersionEnum
        {
            
            /// <summary>
            /// Enum _103Enum for 1.0.3
            /// </summary>
            [EnumMember(Value = "1.0.3")]
            _103Enum = 1,
            
            /// <summary>
            /// Enum _106Enum for 1.0.6
            /// </summary>
            [EnumMember(Value = "1.0.6")]
            _106Enum = 2,
            
            /// <summary>
            /// Enum _200Enum for 2.0.0
            /// </summary>
            [EnumMember(Value = "2.0.0")]
            _200Enum = 3,
            
            /// <summary>
            /// Enum _310Enum for 3.1.0
            /// </summary>
            [EnumMember(Value = "3.1.0")]
            _310Enum = 4,
            
            /// <summary>
            /// Enum _320Enum for 3.2.0
            /// </summary>
            [EnumMember(Value = "3.2.0")]
            _320Enum = 5,
            
            /// <summary>
            /// Enum _330Enum for 3.3.0
            /// </summary>
            [EnumMember(Value = "3.3.0")]
            _330Enum = 6,
            
            /// <summary>
            /// Enum _400Enum for 4.0.0
            /// </summary>
            [EnumMember(Value = "4.0.0")]
            _400Enum = 7,
            
            /// <summary>
            /// Enum _410Enum for 4.1.0
            /// </summary>
            [EnumMember(Value = "4.1.0")]
            _410Enum = 8,
            
            /// <summary>
            /// Enum _420Enum for 4.2.0
            /// </summary>
            [EnumMember(Value = "4.2.0")]
            _420Enum = 9,
            
            /// <summary>
            /// Enum _430Enum for 4.3.0
            /// </summary>
            [EnumMember(Value = "4.3.0")]
            _430Enum = 10,
            
            /// <summary>
            /// Enum _440Enum for 4.4.0
            /// </summary>
            [EnumMember(Value = "4.4.0")]
            _440Enum = 11,
            
            /// <summary>
            /// Enum _450Enum for 4.5.0
            /// </summary>
            [EnumMember(Value = "4.5.0")]
            _450Enum = 12
        }

        /// <summary>
        /// The version for the service. (Key value) 
        /// </summary>
        /// <value>The version for the service. (Key value) </value>
        [DataMember(Name="cufxVersion", EmitDefaultValue=true)]
        public CufxVersionEnum CufxVersion { get; set; }

        /// <summary>
        /// If the protocol is SOAP 1.1 or 1.2 provide the WSDL URL. 
        /// </summary>
        /// <value>If the protocol is SOAP 1.1 or 1.2 provide the WSDL URL. </value>
        [DataMember(Name="wsdlUri", EmitDefaultValue=false)]
        public string WsdlUri { get; set; }

        /// <summary>
        /// Gets or Sets CurrencySupportList
        /// </summary>
        [DataMember(Name="currencySupportList", EmitDefaultValue=false)]
        public ServiceCurrencySupportList CurrencySupportList { get; set; }

        /// <summary>
        /// Gets or Sets AcceptLanguageList
        /// </summary>
        [DataMember(Name="acceptLanguageList", EmitDefaultValue=false)]
        public ServiceAcceptLanguageList AcceptLanguageList { get; set; }

        /// <summary>
        /// Gets or Sets FieldNotSupportedList
        /// </summary>
        [DataMember(Name="fieldNotSupportedList", EmitDefaultValue=false)]
        public ServiceFieldNotSupportedList FieldNotSupportedList { get; set; }

        /// <summary>
        /// The offset of the time zone from Universal Time from the reference point. For example Format : [+|-]HH:MM If the location observes daylight savings time, this value may need to be updated. 
        /// </summary>
        /// <value>The offset of the time zone from Universal Time from the reference point. For example Format : [+|-]HH:MM If the location observes daylight savings time, this value may need to be updated. </value>
        [DataMember(Name="serviceTimeZoneUTCOffset", EmitDefaultValue=false)]
        public string ServiceTimeZoneUTCOffset { get; set; }


        /// <summary>
        /// The status allows the requesting system to determine if the requested system is available for subsequent requests. A recommended use includes this service upon initial interaction as well as during exception handling. During a sequence of calls, an exception may be generated because the requested system has become unavailable. \"Online\" implies the system is available for subsequent requests. \"Offline\" implies the system is not available for subsequent requests. \"MemoPost\" implies that a subset of features is available. For example, the host system may be in MemoPost mode and accept transactions that are processed at a later time. Examples of such features are: intra-CU transfers and stop pay. Examples of features that may not be available during MemoPost are: loan application and change security settings. These examples are provided for demonstration purposes only, the exact feature list will vary depending on each implementation. 
        /// </summary>
        /// <value>The status allows the requesting system to determine if the requested system is available for subsequent requests. A recommended use includes this service upon initial interaction as well as during exception handling. During a sequence of calls, an exception may be generated because the requested system has become unavailable. \"Online\" implies the system is available for subsequent requests. \"Offline\" implies the system is not available for subsequent requests. \"MemoPost\" implies that a subset of features is available. For example, the host system may be in MemoPost mode and accept transactions that are processed at a later time. Examples of such features are: intra-CU transfers and stop pay. Examples of features that may not be available during MemoPost are: loan application and change security settings. These examples are provided for demonstration purposes only, the exact feature list will vary depending on each implementation. </value>
        [TypeConverter(typeof(CustomEnumConverter<StatusEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum OnlineEnum for Online
            /// </summary>
            [EnumMember(Value = "Online")]
            OnlineEnum = 1,
            
            /// <summary>
            /// Enum OffLineEnum for OffLine
            /// </summary>
            [EnumMember(Value = "OffLine")]
            OffLineEnum = 2,
            
            /// <summary>
            /// Enum MemoPostEnum for MemoPost
            /// </summary>
            [EnumMember(Value = "MemoPost")]
            MemoPostEnum = 3
        }

        /// <summary>
        /// The status allows the requesting system to determine if the requested system is available for subsequent requests. A recommended use includes this service upon initial interaction as well as during exception handling. During a sequence of calls, an exception may be generated because the requested system has become unavailable. \&quot;Online\&quot; implies the system is available for subsequent requests. \&quot;Offline\&quot; implies the system is not available for subsequent requests. \&quot;MemoPost\&quot; implies that a subset of features is available. For example, the host system may be in MemoPost mode and accept transactions that are processed at a later time. Examples of such features are: intra-CU transfers and stop pay. Examples of features that may not be available during MemoPost are: loan application and change security settings. These examples are provided for demonstration purposes only, the exact feature list will vary depending on each implementation. 
        /// </summary>
        /// <value>The status allows the requesting system to determine if the requested system is available for subsequent requests. A recommended use includes this service upon initial interaction as well as during exception handling. During a sequence of calls, an exception may be generated because the requested system has become unavailable. \&quot;Online\&quot; implies the system is available for subsequent requests. \&quot;Offline\&quot; implies the system is not available for subsequent requests. \&quot;MemoPost\&quot; implies that a subset of features is available. For example, the host system may be in MemoPost mode and accept transactions that are processed at a later time. Examples of such features are: intra-CU transfers and stop pay. Examples of features that may not be available during MemoPost are: loan application and change security settings. These examples are provided for demonstration purposes only, the exact feature list will vary depending on each implementation. </value>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public StatusEnum Status { get; set; }

        /// <summary>
        /// Gets or Sets CustomDataUseList
        /// </summary>
        [DataMember(Name="customDataUseList", EmitDefaultValue=false)]
        public ServiceCustomDataUseList CustomDataUseList { get; set; }

        /// <summary>
        /// Gets or Sets MethodList
        /// </summary>
        [DataMember(Name="methodList", EmitDefaultValue=false)]
        public ServiceMethodList MethodList { get; set; }

        /// <summary>
        /// Gets or Sets CustomData
        /// </summary>
        [DataMember(Name="customData", EmitDefaultValue=false)]
        public AccessProfileCustomData CustomData { get; set; }

    }
}
