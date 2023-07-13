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
        /// The user ID is an employee ID for logging into the network. The user ID is a vendor employee ID for logging into the network. The user ID is essentially unknown, i.e. no credentials are required. Business rules will have been applied to either prevent or allow anonymous access to the service in question. The credential group identifier of a Financial Institution party that was used to access the service.  See credential group schema. The system user identifier of a system account that was used to access the service. A security token which was created from an identity provider. The user identification was not one of the above formats. 
        /// </summary>
        /// <value>The user ID is an employee ID for logging into the network. The user ID is a vendor employee ID for logging into the network. The user ID is essentially unknown, i.e. no credentials are required. Business rules will have been applied to either prevent or allow anonymous access to the service in question. The credential group identifier of a Financial Institution party that was used to access the service.  See credential group schema. The system user identifier of a system account that was used to access the service. A security token which was created from an identity provider. The user identification was not one of the above formats. </value>
        [TypeConverter(typeof(CustomEnumConverter<UserIdType>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum UserIdType
        {
            
            /// <summary>
            /// Enum EmployeeIdEnum for EmployeeId
            /// </summary>
            [EnumMember(Value = "EmployeeId")]
            EmployeeIdEnum = 1,
            
            /// <summary>
            /// Enum VendorEmployeeIdEnum for VendorEmployeeId
            /// </summary>
            [EnumMember(Value = "VendorEmployeeId")]
            VendorEmployeeIdEnum = 2,
            
            /// <summary>
            /// Enum AnonymousEnum for Anonymous
            /// </summary>
            [EnumMember(Value = "Anonymous")]
            AnonymousEnum = 3,
            
            /// <summary>
            /// Enum FIUserIdEnum for FIUserId
            /// </summary>
            [EnumMember(Value = "FIUserId")]
            FIUserIdEnum = 4,
            
            /// <summary>
            /// Enum SystemAccountIdEnum for SystemAccountId
            /// </summary>
            [EnumMember(Value = "SystemAccountId")]
            SystemAccountIdEnum = 5,
            
            /// <summary>
            /// Enum SecurityTokenEnum for SecurityToken
            /// </summary>
            [EnumMember(Value = "SecurityToken")]
            SecurityTokenEnum = 6,
            
            /// <summary>
            /// Enum CustomEnum for Custom
            /// </summary>
            [EnumMember(Value = "Custom")]
            CustomEnum = 7
        }
}