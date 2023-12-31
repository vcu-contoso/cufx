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
    /// 
    /// </summary>
    [DataContract]
    public partial class ServiceMethodListMethod 
    {
        /// <summary>
        /// Unique id for the method. 
        /// </summary>
        /// <value>Unique id for the method. </value>
        [DataMember(Name="methodId", EmitDefaultValue=false)]
        public string MethodId { get; set; }


        /// <summary>
        /// Generic name for the method. 
        /// </summary>
        /// <value>Generic name for the method. </value>
        [TypeConverter(typeof(CustomEnumConverter<MethodNameEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum MethodNameEnum
        {
            
            /// <summary>
            /// Enum CreateEnum for Create
            /// </summary>
            [EnumMember(Value = "Create")]
            CreateEnum = 1,
            
            /// <summary>
            /// Enum ReadEnum for Read
            /// </summary>
            [EnumMember(Value = "Read")]
            ReadEnum = 2,
            
            /// <summary>
            /// Enum UpdateEnum for Update
            /// </summary>
            [EnumMember(Value = "Update")]
            UpdateEnum = 3,
            
            /// <summary>
            /// Enum DeleteEnum for Delete
            /// </summary>
            [EnumMember(Value = "Delete")]
            DeleteEnum = 4
        }

        /// <summary>
        /// Generic name for the method. 
        /// </summary>
        /// <value>Generic name for the method. </value>
        [DataMember(Name="methodName", EmitDefaultValue=true)]
        public MethodNameEnum MethodName { get; set; }

        /// <summary>
        /// The base URI for the method.  For example: POST https://api.dataprovider.com/deposit?subMethod&#x3D;GET This could also be a relative URI. For example: POST https://../deposit?subMethod&#x3D;GET 
        /// </summary>
        /// <value>The base URI for the method.  For example: POST https://api.dataprovider.com/deposit?subMethod&#x3D;GET This could also be a relative URI. For example: POST https://../deposit?subMethod&#x3D;GET </value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or Sets MethodDependencyList
        /// </summary>
        [DataMember(Name="methodDependencyList", EmitDefaultValue=false)]
        public ServiceMethodListMethodMethodDependencyList MethodDependencyList { get; set; }

        /// <summary>
        /// Gets or Sets CustomData
        /// </summary>
        [DataMember(Name="customData", EmitDefaultValue=false)]
        public AccessProfileCustomData CustomData { get; set; }

    }
}
