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
        /// Gets or Sets WireTransferType
        /// </summary>
        [TypeConverter(typeof(CustomEnumConverter<WireTransferType>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum WireTransferType
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
}
