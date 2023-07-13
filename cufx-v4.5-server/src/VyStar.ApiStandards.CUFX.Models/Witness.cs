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
    /// Collection of document witness(es) associated with a document.  There can be multiple witnesses for a single document. 
    /// </summary>
    [DataContract]
    public partial class Witness 
    {
        /// <summary>
        /// The witness ID is a unique identifier for the witness based on the type of witness (see witnessIdType below). In the case of a notary, the witness ID may be a concatenation of the name, county, and state to ensure a unique value. 
        /// </summary>
        /// <value>The witness ID is a unique identifier for the witness based on the type of witness (see witnessIdType below). In the case of a notary, the witness ID may be a concatenation of the name, county, and state to ensure a unique value. </value>
        [DataMember(Name="witnessId", EmitDefaultValue=false)]
        public string WitnessId { get; set; }


        /// <summary>
        /// The type of witness. The witness is from a third party. The system user identifier, if an automated system witnessed the document. The witness is a notary. The user identification was not one of the above formats. 
        /// </summary>
        /// <value>The type of witness. The witness is from a third party. The system user identifier, if an automated system witnessed the document. The witness is a notary. The user identification was not one of the above formats. </value>
        [TypeConverter(typeof(CustomEnumConverter<WitnessIdTypeEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum WitnessIdTypeEnum
        {
            
            /// <summary>
            /// Enum WitnessIdEnum for WitnessId
            /// </summary>
            [EnumMember(Value = "WitnessId")]
            WitnessIdEnum = 1,
            
            /// <summary>
            /// Enum VendorEmployeeIdEnum for VendorEmployeeId
            /// </summary>
            [EnumMember(Value = "VendorEmployeeId")]
            VendorEmployeeIdEnum = 2,
            
            /// <summary>
            /// Enum SystemAccountIdEnum for SystemAccountId
            /// </summary>
            [EnumMember(Value = "SystemAccountId")]
            SystemAccountIdEnum = 3,
            
            /// <summary>
            /// Enum NotaryIdEnum for NotaryId
            /// </summary>
            [EnumMember(Value = "NotaryId")]
            NotaryIdEnum = 4,
            
            /// <summary>
            /// Enum CustomEnum for Custom
            /// </summary>
            [EnumMember(Value = "Custom")]
            CustomEnum = 5
        }

        /// <summary>
        /// The type of witness. The witness is from a third party. The system user identifier, if an automated system witnessed the document. The witness is a notary. The user identification was not one of the above formats. 
        /// </summary>
        /// <value>The type of witness. The witness is from a third party. The system user identifier, if an automated system witnessed the document. The witness is a notary. The user identification was not one of the above formats. </value>
        [DataMember(Name="witnessIdType", EmitDefaultValue=true)]
        public WitnessIdTypeEnum WitnessIdType { get; set; }

    }
}
