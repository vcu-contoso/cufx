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
    /// Delete definition for ConfigurationMessage
    /// </summary>
    [DataContract]
    public partial class ConfigurationMessageDelete 
    {
        /// <summary>
        /// Gets or Sets MessageContext
        /// </summary>
        [DataMember(Name="messageContext", EmitDefaultValue=false)]
        public MessageContext MessageContext { get; set; }

        /// <summary>
        /// Gets or Sets ConfigurationFilter
        /// </summary>
        [DataMember(Name="configurationFilter", EmitDefaultValue=false)]
        public ConfigurationFilter ConfigurationFilter { get; set; }

        /// <summary>
        /// Gets or Sets ConfigurationList
        /// </summary>
        [DataMember(Name="configurationList", EmitDefaultValue=false)]
        public ConfigurationList ConfigurationList { get; set; }

    }
}
