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
        /// This is the enumeration of statuses for payments or transfers. The payment or transfer is in the process for immediate or future payment and is cancellable by the party since its not InProcess yet. The payment or transfer is in process and is no longer cancellable, but it has not been sent. A payment or transfer was requested to be cancelled by the party but has not yet been cancelled. A payment or transfer has been cancelled at the request of the originating partys financial institution. A payment or transfer has been cancelled at the request of the processor. Example is case of bill pay this would be the bill payment processor. A payment or transfer has been cancelled. Payment or transfer has been sent to the payee but has not been received yet. The payment or transfer transaction has been cleared/completed by the financial institution. The payment or transfer was declined (for instance, in the case that a debit or card was used as the funding source). The funds have been transferred to the payment processor but have not yet arrived at the payment processor. The funds for the payment or transfer have been received by the payment processor but the actual payment hasnt cleared at the payee. The payment or transfer has been held by the payment processor and has not been sent to the payee. The payment or transfer has attempted to clear the financial institution account but there was not enough funds available. Payment or transfer was returned by the payee and not cleared. Payment or transfer was scheduled for recurring payment but has been suspended until taken out of suspended status. 
        /// </summary>
        /// <value>This is the enumeration of statuses for payments or transfers. The payment or transfer is in the process for immediate or future payment and is cancellable by the party since its not InProcess yet. The payment or transfer is in process and is no longer cancellable, but it has not been sent. A payment or transfer was requested to be cancelled by the party but has not yet been cancelled. A payment or transfer has been cancelled at the request of the originating partys financial institution. A payment or transfer has been cancelled at the request of the processor. Example is case of bill pay this would be the bill payment processor. A payment or transfer has been cancelled. Payment or transfer has been sent to the payee but has not been received yet. The payment or transfer transaction has been cleared/completed by the financial institution. The payment or transfer was declined (for instance, in the case that a debit or card was used as the funding source). The funds have been transferred to the payment processor but have not yet arrived at the payment processor. The funds for the payment or transfer have been received by the payment processor but the actual payment hasnt cleared at the payee. The payment or transfer has been held by the payment processor and has not been sent to the payee. The payment or transfer has attempted to clear the financial institution account but there was not enough funds available. Payment or transfer was returned by the payee and not cleared. Payment or transfer was scheduled for recurring payment but has been suspended until taken out of suspended status. </value>
        [TypeConverter(typeof(CustomEnumConverter<OccurrenceStatus>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum OccurrenceStatus
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
}
