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
        /// An enumeration of possible statuses for a transaction request. Transaction is posted. Transaction is pending. Transaction was denied. Transaction was Voided. Transaction is on hold. See Hold message for additional information on the hold. Other transaction status, see 
        /// </summary>
        /// <value>An enumeration of possible statuses for a transaction request. Transaction is posted. Transaction is pending. Transaction was denied. Transaction was Voided. Transaction is on hold. See Hold message for additional information on the hold. Other transaction status, see </value>
        [TypeConverter(typeof(CustomEnumConverter<TransactionStatus>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TransactionStatus
        {
            
            /// <summary>
            /// Enum PostedEnum for Posted
            /// </summary>
            [EnumMember(Value = "Posted")]
            PostedEnum = 1,
            
            /// <summary>
            /// Enum PendingEnum for Pending
            /// </summary>
            [EnumMember(Value = "Pending")]
            PendingEnum = 2,
            
            /// <summary>
            /// Enum DeniedEnum for Denied
            /// </summary>
            [EnumMember(Value = "Denied")]
            DeniedEnum = 3,
            
            /// <summary>
            /// Enum VoidEnum for Void
            /// </summary>
            [EnumMember(Value = "Void")]
            VoidEnum = 4,
            
            /// <summary>
            /// Enum HoldEnum for Hold
            /// </summary>
            [EnumMember(Value = "Hold")]
            HoldEnum = 5,
            
            /// <summary>
            /// Enum OtherEnum for Other
            /// </summary>
            [EnumMember(Value = "Other")]
            OtherEnum = 6
        }
}