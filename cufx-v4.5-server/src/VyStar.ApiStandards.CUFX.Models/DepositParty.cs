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
    /// This object points to the party and how it relates to the deposit. 
    /// </summary>
    [DataContract]
    public partial class DepositParty 
    {
        /// <summary>
        /// The party ID is a persistent and unique identifier for the party not related to the accounts they own but tied to that person or organization. It should be unique for all parties across the institution and remain the same over the life of the relationship with the financial institution. 
        /// </summary>
        /// <value>The party ID is a persistent and unique identifier for the party not related to the accounts they own but tied to that person or organization. It should be unique for all parties across the institution and remain the same over the life of the relationship with the financial institution. </value>
        [DataMember(Name="depositPartyId", EmitDefaultValue=false)]
        public string DepositPartyId { get; set; }

        /// <summary>
        /// Gets or Sets DepositPartyRelationshipType
        /// </summary>
        [DataMember(Name="depositPartyRelationshipType", EmitDefaultValue=false)]
        public DepositPartyDepositPartyRelationshipType DepositPartyRelationshipType { get; set; }

        /// <summary>
        /// The partyâ€™s SSN should be used rather the primaryâ€™s SSN when reporting to the IRS. Only used if party relationship type is NOT PRIMARY.  Only one of these can appear on an account if applicable. 
        /// </summary>
        /// <value>The partyâ€™s SSN should be used rather the primaryâ€™s SSN when reporting to the IRS. Only used if party relationship type is NOT PRIMARY.  Only one of these can appear on an account if applicable. </value>
        [DataMember(Name="ssnOverride", EmitDefaultValue=true)]
        public bool SsnOverride { get; set; }

        /// <summary>
        /// Gets or Sets ContactIdList
        /// </summary>
        [DataMember(Name="contactIdList", EmitDefaultValue=false)]
        public ActivityActivityRelatedToContactIdList ContactIdList { get; set; }

        /// <summary>
        /// Gets or Sets CustomData
        /// </summary>
        [DataMember(Name="customData", EmitDefaultValue=false)]
        public AccessProfileCustomData CustomData { get; set; }

    }
}