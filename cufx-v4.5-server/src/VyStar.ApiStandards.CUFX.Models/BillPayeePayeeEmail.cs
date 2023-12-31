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
    public partial class BillPayeePayeeEmail 
    {

        /// <summary>
        /// The members classification of the email. 
        /// </summary>
        /// <value>The members classification of the email. </value>
        [TypeConverter(typeof(CustomEnumConverter<EmailTypeEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum EmailTypeEnum
        {
            
            /// <summary>
            /// Enum HomeEnum for Home
            /// </summary>
            [EnumMember(Value = "Home")]
            HomeEnum = 1,
            
            /// <summary>
            /// Enum WorkEnum for Work
            /// </summary>
            [EnumMember(Value = "Work")]
            WorkEnum = 2,
            
            /// <summary>
            /// Enum OtherEnum for Other
            /// </summary>
            [EnumMember(Value = "Other")]
            OtherEnum = 3
        }

        /// <summary>
        /// The members classification of the email. 
        /// </summary>
        /// <value>The members classification of the email. </value>
        [DataMember(Name="emailType", EmitDefaultValue=true)]
        public EmailTypeEnum EmailType { get; set; }

        /// <summary>
        /// Contact Email Address. 
        /// </summary>
        /// <value>Contact Email Address. </value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Description of email type when emailType is set to other. 
        /// </summary>
        /// <value>Description of email type when emailType is set to other. </value>
        [DataMember(Name="otherEmailType", EmitDefaultValue=false)]
        public string OtherEmailType { get; set; }

    }
}
