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
    /// A unique value (or values) used to identify one and only one artifact within the repository. Some artifact systems do not have a concept of a unique key but a concept of a combined key to access values in the back end system.  Intended choice - Due to cross language serialization issues the choice construct has been removed. It is the responsibility of the implementer to add programmatic logic for this complex type to detect, handle and or error when population of more than one element is present. 
    /// </summary>
    [DataContract]
    public partial class ArtifactId 
    {
        /// <summary>
        /// A unique value (or values) used to identify one and only one artifact within the repository. 
        /// </summary>
        /// <value>A unique value (or values) used to identify one and only one artifact within the repository. </value>
        [DataMember(Name="artifactUniqueId", EmitDefaultValue=false)]
        public string ArtifactUniqueId { get; set; }

        /// <summary>
        /// Gets or Sets ArtifactIdKeyValueList
        /// </summary>
        [DataMember(Name="artifactIdKeyValueList", EmitDefaultValue=false)]
        public AccessProfileCustomData ArtifactIdKeyValueList { get; set; }

    }
}