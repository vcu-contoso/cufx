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
    public partial class DepositPartyDepositPartyRelationshipTypeBeneficiary 
    {
        /// <summary>
        /// Specifies whether the party has a relationship status of beneficiary on the account. 
        /// </summary>
        /// <value>Specifies whether the party has a relationship status of beneficiary on the account. </value>
        [DataMember(Name="isBeneficiary", EmitDefaultValue=true)]
        public bool IsBeneficiary { get; set; }


        /// <summary>
        /// Beneficiary does not have access to deposit funds unless all holders are deceased.  If specified at the relationship level, the beneficiary receives funds across all deposits in the relationship. Student is the funds beneficiary in the event of a Coverdell ESA when funds are distributed. 
        /// </summary>
        /// <value>Beneficiary does not have access to deposit funds unless all holders are deceased.  If specified at the relationship level, the beneficiary receives funds across all deposits in the relationship. Student is the funds beneficiary in the event of a Coverdell ESA when funds are distributed. </value>
        [TypeConverter(typeof(CustomEnumConverter<QualifierEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum QualifierEnum
        {
            
            /// <summary>
            /// Enum StandardEnum for Standard
            /// </summary>
            [EnumMember(Value = "Standard")]
            StandardEnum = 1,
            
            /// <summary>
            /// Enum EducationEnum for Education
            /// </summary>
            [EnumMember(Value = "Education")]
            EducationEnum = 2
        }

        /// <summary>
        /// Beneficiary does not have access to deposit funds unless all holders are deceased.  If specified at the relationship level, the beneficiary receives funds across all deposits in the relationship. Student is the funds beneficiary in the event of a Coverdell ESA when funds are distributed. 
        /// </summary>
        /// <value>Beneficiary does not have access to deposit funds unless all holders are deceased.  If specified at the relationship level, the beneficiary receives funds across all deposits in the relationship. Student is the funds beneficiary in the event of a Coverdell ESA when funds are distributed. </value>
        [DataMember(Name="qualifier", EmitDefaultValue=true)]
        public QualifierEnum Qualifier { get; set; }


        /// <summary>
        /// Has access to funds and can perform transactions. Does not have access to funds and cannot perform transactions. Has access to only to dividend funds and can perform dividend only transactions. 
        /// </summary>
        /// <value>Has access to funds and can perform transactions. Does not have access to funds and cannot perform transactions. Has access to only to dividend funds and can perform dividend only transactions. </value>
        [TypeConverter(typeof(CustomEnumConverter<AuthorityEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum AuthorityEnum
        {
            
            /// <summary>
            /// Enum AuthorizedEnum for Authorized
            /// </summary>
            [EnumMember(Value = "Authorized")]
            AuthorizedEnum = 1,
            
            /// <summary>
            /// Enum UnauthorizedEnum for Unauthorized
            /// </summary>
            [EnumMember(Value = "Unauthorized")]
            UnauthorizedEnum = 2,
            
            /// <summary>
            /// Enum DividendOnlyEnum for DividendOnly
            /// </summary>
            [EnumMember(Value = "DividendOnly")]
            DividendOnlyEnum = 3
        }

        /// <summary>
        /// Has access to funds and can perform transactions. Does not have access to funds and cannot perform transactions. Has access to only to dividend funds and can perform dividend only transactions. 
        /// </summary>
        /// <value>Has access to funds and can perform transactions. Does not have access to funds and cannot perform transactions. Has access to only to dividend funds and can perform dividend only transactions. </value>
        [DataMember(Name="authority", EmitDefaultValue=true)]
        public AuthorityEnum Authority { get; set; }

        /// <summary>
        /// Default to 100%.  If there is more than one beneficiary on the relationship, then beneficiary percent should total to 100%. 
        /// </summary>
        /// <value>Default to 100%.  If there is more than one beneficiary on the relationship, then beneficiary percent should total to 100%. </value>
        [DataMember(Name="beneficiaryPercent", EmitDefaultValue=true)]
        public decimal BeneficiaryPercent { get; set; }


        /// <summary>
        /// If the primary passes away, then the contingent beneficiary receives the benefits. 
        /// </summary>
        /// <value>If the primary passes away, then the contingent beneficiary receives the benefits. </value>
        [TypeConverter(typeof(CustomEnumConverter<BeneficiaryTypesEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum BeneficiaryTypesEnum
        {
            
            /// <summary>
            /// Enum PrimaryEnum for Primary
            /// </summary>
            [EnumMember(Value = "Primary")]
            PrimaryEnum = 1,
            
            /// <summary>
            /// Enum ContingentEnum for Contingent
            /// </summary>
            [EnumMember(Value = "Contingent")]
            ContingentEnum = 2
        }

        /// <summary>
        /// If the primary passes away, then the contingent beneficiary receives the benefits. 
        /// </summary>
        /// <value>If the primary passes away, then the contingent beneficiary receives the benefits. </value>
        [DataMember(Name="beneficiaryTypes", EmitDefaultValue=true)]
        public BeneficiaryTypesEnum BeneficiaryTypes { get; set; }

    }
}
