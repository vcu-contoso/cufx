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
        /// This is enumeration of statuses for the bill payee. This value indicates that the bill is due and had not been paid. This value indicates that the bill payemnt date has expired and the bill has not been paid. This value indicates that the bill was cancelled. This value indicates that the bill was placed on hold pending a resolution of some type to clear This value indicates that the bill has been paid. This value indicates that the bill has been voided. This value indicates that the bill is being disputed. This value indicates that the attempt to pay the bill failed. This value indicates that the bill has been scheduled to be paid. See otherBillStatus for more detail. 
        /// </summary>
        /// <value>This is enumeration of statuses for the bill payee. This value indicates that the bill is due and had not been paid. This value indicates that the bill payemnt date has expired and the bill has not been paid. This value indicates that the bill was cancelled. This value indicates that the bill was placed on hold pending a resolution of some type to clear This value indicates that the bill has been paid. This value indicates that the bill has been voided. This value indicates that the bill is being disputed. This value indicates that the attempt to pay the bill failed. This value indicates that the bill has been scheduled to be paid. See otherBillStatus for more detail. </value>
        [TypeConverter(typeof(CustomEnumConverter<BillStatus>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum BillStatus
        {
            
            /// <summary>
            /// Enum DueEnum for Due
            /// </summary>
            [EnumMember(Value = "Due")]
            DueEnum = 1,
            
            /// <summary>
            /// Enum OverDueEnum for OverDue
            /// </summary>
            [EnumMember(Value = "OverDue")]
            OverDueEnum = 2,
            
            /// <summary>
            /// Enum CancelledEnum for Cancelled
            /// </summary>
            [EnumMember(Value = "Cancelled")]
            CancelledEnum = 3,
            
            /// <summary>
            /// Enum SuspendedEnum for Suspended
            /// </summary>
            [EnumMember(Value = "Suspended")]
            SuspendedEnum = 4,
            
            /// <summary>
            /// Enum PaidEnum for Paid
            /// </summary>
            [EnumMember(Value = "Paid")]
            PaidEnum = 5,
            
            /// <summary>
            /// Enum VoidEnum for Void
            /// </summary>
            [EnumMember(Value = "Void")]
            VoidEnum = 6,
            
            /// <summary>
            /// Enum DisputeEnum for Dispute
            /// </summary>
            [EnumMember(Value = "Dispute")]
            DisputeEnum = 7,
            
            /// <summary>
            /// Enum PaymentFailedEnum for PaymentFailed
            /// </summary>
            [EnumMember(Value = "PaymentFailed")]
            PaymentFailedEnum = 8,
            
            /// <summary>
            /// Enum ScheduledEnum for Scheduled
            /// </summary>
            [EnumMember(Value = "Scheduled")]
            ScheduledEnum = 9,
            
            /// <summary>
            /// Enum OtherEnum for Other
            /// </summary>
            [EnumMember(Value = "Other")]
            OtherEnum = 10
        }
}
