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
        /// If the document has been signed, how it was signed. The document has been been sent or viewed online, but it has not been signed. The document has been viewed online and the person agreed to it electronically. The document has been viewed online and the person agreed to it electronically with a single click. The document has been viewed and the person agreed to it in writing (handwrote signature in person). 
        /// </summary>
        /// <value>If the document has been signed, how it was signed. The document has been been sent or viewed online, but it has not been signed. The document has been viewed online and the person agreed to it electronically. The document has been viewed online and the person agreed to it electronically with a single click. The document has been viewed and the person agreed to it in writing (handwrote signature in person). </value>
        [TypeConverter(typeof(CustomEnumConverter<DocumentSignatureType>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum DocumentSignatureType
        {
            
            /// <summary>
            /// Enum UnsignedEnum for Unsigned
            /// </summary>
            [EnumMember(Value = "Unsigned")]
            UnsignedEnum = 1,
            
            /// <summary>
            /// Enum ElectronicSignatureEnum for ElectronicSignature
            /// </summary>
            [EnumMember(Value = "ElectronicSignature")]
            ElectronicSignatureEnum = 2,
            
            /// <summary>
            /// Enum SingleClickAcceptanceEnum for SingleClickAcceptance
            /// </summary>
            [EnumMember(Value = "SingleClickAcceptance")]
            SingleClickAcceptanceEnum = 3,
            
            /// <summary>
            /// Enum WetSignatureEnum for WetSignature
            /// </summary>
            [EnumMember(Value = "WetSignature")]
            WetSignatureEnum = 4
        }
}
