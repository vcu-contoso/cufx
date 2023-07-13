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
    public partial class SimpleValidationRequest 
    {
        /// <summary>
        /// Validation type specified by the service provider (Exs.: OFAC, CU Loss, etc.). 
        /// </summary>
        /// <value>Validation type specified by the service provider (Exs.: OFAC, CU Loss, etc.). </value>
        [DataMember(Name="validationType", EmitDefaultValue=false)]
        public string ValidationType { get; set; }

        /// <summary>
        /// Gets or Sets Applicant
        /// </summary>
        [DataMember(Name="applicant", EmitDefaultValue=false)]
        public SimpleValidationRequestApplicant Applicant { get; set; }


        /// <summary>
        /// An enumeration defining possible results of a simple validation. The applicant is valid. The applicant is not valid. It could not be determined if the applicant is valid or not. Validation Request is still being processed â€“ check back at a later time to find out result. There was an error in the validation process. 
        /// </summary>
        /// <value>An enumeration defining possible results of a simple validation. The applicant is valid. The applicant is not valid. It could not be determined if the applicant is valid or not. Validation Request is still being processed â€“ check back at a later time to find out result. There was an error in the validation process. </value>
        [TypeConverter(typeof(CustomEnumConverter<SimpleValidationStatusEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum SimpleValidationStatusEnum
        {
            
            /// <summary>
            /// Enum PassEnum for Pass
            /// </summary>
            [EnumMember(Value = "Pass")]
            PassEnum = 1,
            
            /// <summary>
            /// Enum FailEnum for Fail
            /// </summary>
            [EnumMember(Value = "Fail")]
            FailEnum = 2,
            
            /// <summary>
            /// Enum IndeterminateEnum for Indeterminate
            /// </summary>
            [EnumMember(Value = "Indeterminate")]
            IndeterminateEnum = 3,
            
            /// <summary>
            /// Enum InProcessEnum for InProcess
            /// </summary>
            [EnumMember(Value = "InProcess")]
            InProcessEnum = 4,
            
            /// <summary>
            /// Enum ErrorEnum for Error
            /// </summary>
            [EnumMember(Value = "Error")]
            ErrorEnum = 5
        }

        /// <summary>
        /// An enumeration defining possible results of a simple validation. The applicant is valid. The applicant is not valid. It could not be determined if the applicant is valid or not. Validation Request is still being processed â€“ check back at a later time to find out result. There was an error in the validation process. 
        /// </summary>
        /// <value>An enumeration defining possible results of a simple validation. The applicant is valid. The applicant is not valid. It could not be determined if the applicant is valid or not. Validation Request is still being processed â€“ check back at a later time to find out result. There was an error in the validation process. </value>
        [DataMember(Name="simpleValidationStatus", EmitDefaultValue=true)]
        public SimpleValidationStatusEnum SimpleValidationStatus { get; set; }

        /// <summary>
        /// The date time that the validation request was submitted. 
        /// </summary>
        /// <value>The date time that the validation request was submitted. </value>
        [DataMember(Name="validationSubmittedDateTime", EmitDefaultValue=false)]
        public string ValidationSubmittedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets CustomData
        /// </summary>
        [DataMember(Name="customData", EmitDefaultValue=false)]
        public AccessProfileCustomData CustomData { get; set; }

    }
}