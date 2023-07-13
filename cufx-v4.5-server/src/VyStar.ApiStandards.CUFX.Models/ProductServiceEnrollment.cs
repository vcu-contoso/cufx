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
    public partial class ProductServiceEnrollment 
    {
        /// <summary>
        /// Identifier of the productServiceEnrollment. 
        /// </summary>
        /// <value>Identifier of the productServiceEnrollment. </value>
        [DataMember(Name="productServiceEnrollmentId", EmitDefaultValue=false)]
        public string ProductServiceEnrollmentId { get; set; }

        /// <summary>
        /// Gets or Sets RequestItem
        /// </summary>
        [DataMember(Name="requestItem", EmitDefaultValue=false)]
        public ProductServiceEnrollmentRequestItem RequestItem { get; set; }

        /// <summary>
        /// Gets or Sets FieldList
        /// </summary>
        [DataMember(Name="fieldList", EmitDefaultValue=false)]
        public ProductServiceEnrollmentFieldList FieldList { get; set; }

        /// <summary>
        /// Gets or Sets Party
        /// </summary>
        [DataMember(Name="party", EmitDefaultValue=false)]
        public Party Party { get; set; }

        /// <summary>
        /// The date time on which the productServiceEnrollment was requested 
        /// </summary>
        /// <value>The date time on which the productServiceEnrollment was requested </value>
        [DataMember(Name="productServiceEnrollmentRequestDate", EmitDefaultValue=false)]
        public string ProductServiceEnrollmentRequestDate { get; set; }

        /// <summary>
        /// The date time on which the productServiceEnrollment was approved. 
        /// </summary>
        /// <value>The date time on which the productServiceEnrollment was approved. </value>
        [DataMember(Name="productServiceEnrollmentApprovedDate", EmitDefaultValue=false)]
        public string ProductServiceEnrollmentApprovedDate { get; set; }

        /// <summary>
        /// The product service enrollment status. 
        /// </summary>
        /// <value>The product service enrollment status. </value>
        [DataMember(Name="productServiceEnrollmentStatus", EmitDefaultValue=false)]
        public string ProductServiceEnrollmentStatus { get; set; }

        /// <summary>
        /// Gets or Sets CustomData
        /// </summary>
        [DataMember(Name="customData", EmitDefaultValue=false)]
        public AccessProfileCustomData CustomData { get; set; }

    }
}
