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
    /// The list of filter options for services requesting product service request data.  The options can be used in combination or by themselves.  It is up to the data source to either return or affect the data requested or return a standard error identifying why the request was rejected. 
    /// </summary>
    [DataContract]
    public partial class ProductServiceRequestFilter 
    {
        /// <summary>
        /// Gets or Sets ProductServiceRequestIdList
        /// </summary>
        [DataMember(Name="productServiceRequestIdList", EmitDefaultValue=false)]
        public FieldFilterProductServiceRequestIdList ProductServiceRequestIdList { get; set; }

        /// <summary>
        /// Gets or Sets RelationshipIdList
        /// </summary>
        [DataMember(Name="relationshipIdList", EmitDefaultValue=false)]
        public AccountFilterRelationshipIdList RelationshipIdList { get; set; }

        /// <summary>
        /// Gets or Sets AccountIdList
        /// </summary>
        [DataMember(Name="accountIdList", EmitDefaultValue=false)]
        public AccountFilterAccountIdList AccountIdList { get; set; }

        /// <summary>
        /// Gets or Sets AccountStatusList
        /// </summary>
        [DataMember(Name="accountStatusList", EmitDefaultValue=false)]
        public AccountFilterAccountStatusList AccountStatusList { get; set; }

        /// <summary>
        /// Gets or Sets PartyIdList
        /// </summary>
        [DataMember(Name="partyIdList", EmitDefaultValue=false)]
        public AccountPartyIdList PartyIdList { get; set; }

        /// <summary>
        /// Gets or Sets ContactIdList
        /// </summary>
        [DataMember(Name="contactIdList", EmitDefaultValue=false)]
        public ActivityActivityRelatedToContactIdList ContactIdList { get; set; }

        /// <summary>
        /// Gets or Sets SecureMessageIdList
        /// </summary>
        [DataMember(Name="secureMessageIdList", EmitDefaultValue=false)]
        public ProductServiceRequestFilterSecureMessageIdList SecureMessageIdList { get; set; }

        /// <summary>
        /// Gets or Sets ProductServiceRequestStatusList
        /// </summary>
        [DataMember(Name="productServiceRequestStatusList", EmitDefaultValue=false)]
        public ProductServiceRequestFilterProductServiceRequestStatusList ProductServiceRequestStatusList { get; set; }

        /// <summary>
        /// Gets or Sets CustomData
        /// </summary>
        [DataMember(Name="customData", EmitDefaultValue=false)]
        public AccessProfileCustomData CustomData { get; set; }

        /// <summary>
        /// Gets or Sets AccountIdentificationList
        /// </summary>
        [DataMember(Name="accountIdentificationList", EmitDefaultValue=false)]
        public AccountFilterAccountIdentificationList AccountIdentificationList { get; set; }

    }
}
