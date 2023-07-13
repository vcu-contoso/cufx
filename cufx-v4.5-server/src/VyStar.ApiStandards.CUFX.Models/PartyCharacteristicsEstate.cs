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
    /// Fields related to when the party is an estate. 
    /// </summary>
    [DataContract]
    public partial class PartyCharacteristicsEstate 
    {
        /// <summary>
        /// Legal name of the estate. 
        /// </summary>
        /// <value>Legal name of the estate. </value>
        [DataMember(Name="estateName", EmitDefaultValue=false)]
        public string EstateName { get; set; }

        /// <summary>
        /// Further defines the type of estate. Freehold, Leasehold, Life, Non-Freehold, Concurrent 
        /// </summary>
        /// <value>Further defines the type of estate. Freehold, Leasehold, Life, Non-Freehold, Concurrent </value>
        [DataMember(Name="estateType", EmitDefaultValue=false)]
        public string EstateType { get; set; }

    }
}