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
        /// Gets or Sets ContactType
        /// </summary>
        [TypeConverter(typeof(CustomEnumConverter<ContactType>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContactType
        {
            
            /// <summary>
            /// Enum AddressEnum for Address
            /// </summary>
            [EnumMember(Value = "Address")]
            AddressEnum = 1,
            
            /// <summary>
            /// Enum PhoneEnum for Phone
            /// </summary>
            [EnumMember(Value = "Phone")]
            PhoneEnum = 2,
            
            /// <summary>
            /// Enum EmailEnum for Email
            /// </summary>
            [EnumMember(Value = "Email")]
            EmailEnum = 3,
            
            /// <summary>
            /// Enum InstantMessagingEnum for InstantMessaging
            /// </summary>
            [EnumMember(Value = "InstantMessaging")]
            InstantMessagingEnum = 4,
            
            /// <summary>
            /// Enum SocialEnum for Social
            /// </summary>
            [EnumMember(Value = "Social")]
            SocialEnum = 5,
            
            /// <summary>
            /// Enum WebsiteEnum for Website
            /// </summary>
            [EnumMember(Value = "Website")]
            WebsiteEnum = 6,
            
            /// <summary>
            /// Enum OtherEnum for Other
            /// </summary>
            [EnumMember(Value = "Other")]
            OtherEnum = 7,
            
            /// <summary>
            /// Enum SMSEnum for SMS
            /// </summary>
            [EnumMember(Value = "SMS")]
            SMSEnum = 8
        }
}
