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
    /// An XSD path and comment related to how the custom data section is being used. This is information only and not processed by the system. 
    /// </summary>
    [DataContract]
    public partial class CustomDataUse 
    {
        /// <summary>
        /// An XSD filename in the CUFX library that is the parent of the node that holds the custom data. For example: Party.xsd 
        /// </summary>
        /// <value>An XSD filename in the CUFX library that is the parent of the node that holds the custom data. For example: Party.xsd </value>
        [DataMember(Name="xsdFile", EmitDefaultValue=false)]
        public string XsdFile { get; set; }

        /// <summary>
        /// An XPath statement that identifies the XSD node of the custom data.  For example: /partyList/party/customData/_* 
        /// </summary>
        /// <value>An XPath statement that identifies the XSD node of the custom data.  For example: /partyList/party/customData/_* </value>
        [DataMember(Name="xsdXPath", EmitDefaultValue=false)]
        public string XsdXPath { get; set; }

        /// <summary>
        /// The name that will show up in the value pair within the custom data.  For instance, eye color. 
        /// </summary>
        /// <value>The name that will show up in the value pair within the custom data.  For instance, eye color. </value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Comment as to what is stored in the custom data. For example: Will hold the partys eye color in a value pair. name&#x3D;eyecolor and value&#x3D;blue 
        /// </summary>
        /// <value>Comment as to what is stored in the custom data. For example: Will hold the partys eye color in a value pair. name&#x3D;eyecolor and value&#x3D;blue </value>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

    }
}