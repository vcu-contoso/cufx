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
    /// The list of filter options for field requirement read, update or delete request. 
    /// </summary>
    [DataContract]
    public partial class FieldFilter 
    {
        /// <summary>
        /// Gets or Sets FieldIdList
        /// </summary>
        [DataMember(Name="fieldIdList", EmitDefaultValue=false)]
        public FieldFilterFieldIdList FieldIdList { get; set; }

        /// <summary>
        /// Gets or Sets FieldRequirementIdList
        /// </summary>
        [DataMember(Name="fieldRequirementIdList", EmitDefaultValue=false)]
        public FieldFilterFieldRequirementIdList FieldRequirementIdList { get; set; }

        /// <summary>
        /// Gets or Sets FieldTypeList
        /// </summary>
        [DataMember(Name="fieldTypeList", EmitDefaultValue=false)]
        public FieldFilterFieldTypeList FieldTypeList { get; set; }

        /// <summary>
        /// Gets or Sets FieldRequirementTypeList
        /// </summary>
        [DataMember(Name="fieldRequirementTypeList", EmitDefaultValue=false)]
        public FieldFilterFieldRequirementTypeList FieldRequirementTypeList { get; set; }

        /// <summary>
        /// Gets or Sets ProductServiceRequestIdList
        /// </summary>
        [DataMember(Name="productServiceRequestIdList", EmitDefaultValue=false)]
        public FieldFilterProductServiceRequestIdList ProductServiceRequestIdList { get; set; }

        /// <summary>
        /// Gets or Sets CustomData
        /// </summary>
        [DataMember(Name="customData", EmitDefaultValue=false)]
        public AccessProfileCustomData CustomData { get; set; }

    }
}
