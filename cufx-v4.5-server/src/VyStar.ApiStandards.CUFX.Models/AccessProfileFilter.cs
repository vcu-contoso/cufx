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
    /// The list of access profile IDs that should have their associated access profiles either returned or affected by a read, update or delete account request. 
    /// </summary>
    [DataContract]
    public partial class AccessProfileFilter 
    {
        /// <summary>
        /// Gets or Sets AccessProfileIdList
        /// </summary>
        [DataMember(Name="accessProfileIdList", EmitDefaultValue=false)]
        public AccessProfileFilterAccessProfileIdList AccessProfileIdList { get; set; }

        /// <summary>
        /// Gets or Sets CreateAccessDateRange
        /// </summary>
        [DataMember(Name="createAccessDateRange", EmitDefaultValue=false)]
        public AccessProfileFilterCreateAccessDateRange CreateAccessDateRange { get; set; }

        /// <summary>
        /// Gets or Sets ActorList
        /// </summary>
        [DataMember(Name="actorList", EmitDefaultValue=false)]
        public AccessProfileFilterActorList ActorList { get; set; }

        /// <summary>
        /// Gets or Sets CustomData
        /// </summary>
        [DataMember(Name="customData", EmitDefaultValue=false)]
        public AccessProfileCustomData CustomData { get; set; }

    }
}