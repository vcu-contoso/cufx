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
    /// Intended choice - Due to cross language serialization issues the choice construct has been removed. It is the responsibility of the implementer to add programmatic logic for this complex type to detect, handle and or error when population of more than one element is present. 
    /// </summary>
    [DataContract]
    public partial class PartyCharacteristics 
    {
        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [DataMember(Name="organization", EmitDefaultValue=false)]
        public PartyCharacteristicsOrganization Organization { get; set; }

        /// <summary>
        /// Gets or Sets Individual
        /// </summary>
        [DataMember(Name="individual", EmitDefaultValue=false)]
        public PartyCharacteristicsIndividual Individual { get; set; }

        /// <summary>
        /// Gets or Sets Trust
        /// </summary>
        [DataMember(Name="trust", EmitDefaultValue=false)]
        public PartyCharacteristicsTrust Trust { get; set; }

        /// <summary>
        /// Gets or Sets Estate
        /// </summary>
        [DataMember(Name="estate", EmitDefaultValue=false)]
        public PartyCharacteristicsEstate Estate { get; set; }

    }
}
