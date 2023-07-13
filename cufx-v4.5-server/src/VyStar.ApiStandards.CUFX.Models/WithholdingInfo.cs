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
    /// Fields related to require tax withholding information. 
    /// </summary>
    [DataContract]
    public partial class WithholdingInfo 
    {

        /// <summary>
        /// Withholding type for the federal government or a national government. Withholding type for a state government or a province. Withholding type for a local government. Withholding type for US Government form W-4. Withholding type for all other forms of withholding. Further defined by element otherWithholdingType. 
        /// </summary>
        /// <value>Withholding type for the federal government or a national government. Withholding type for a state government or a province. Withholding type for a local government. Withholding type for US Government form W-4. Withholding type for all other forms of withholding. Further defined by element otherWithholdingType. </value>
        [TypeConverter(typeof(CustomEnumConverter<WithholdingTypeEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum WithholdingTypeEnum
        {
            
            /// <summary>
            /// Enum FederalEnum for Federal
            /// </summary>
            [EnumMember(Value = "Federal")]
            FederalEnum = 1,
            
            /// <summary>
            /// Enum StateEnum for State
            /// </summary>
            [EnumMember(Value = "State")]
            StateEnum = 2,
            
            /// <summary>
            /// Enum LocalEnum for Local
            /// </summary>
            [EnumMember(Value = "Local")]
            LocalEnum = 3,
            
            /// <summary>
            /// Enum W4Enum for W-4
            /// </summary>
            [EnumMember(Value = "W-4")]
            W4Enum = 4,
            
            /// <summary>
            /// Enum OtherEnum for Other
            /// </summary>
            [EnumMember(Value = "Other")]
            OtherEnum = 5
        }

        /// <summary>
        /// Withholding type for the federal government or a national government. Withholding type for a state government or a province. Withholding type for a local government. Withholding type for US Government form W-4. Withholding type for all other forms of withholding. Further defined by element otherWithholdingType. 
        /// </summary>
        /// <value>Withholding type for the federal government or a national government. Withholding type for a state government or a province. Withholding type for a local government. Withholding type for US Government form W-4. Withholding type for all other forms of withholding. Further defined by element otherWithholdingType. </value>
        [DataMember(Name="withholdingType", EmitDefaultValue=true)]
        public WithholdingTypeEnum WithholdingType { get; set; }

        /// <summary>
        /// Describes the type of withingholding when WithholdingType is set to Other. 
        /// </summary>
        /// <value>Describes the type of withingholding when WithholdingType is set to Other. </value>
        [DataMember(Name="otherWithholdingType", EmitDefaultValue=false)]
        public string OtherWithholdingType { get; set; }


        /// <summary>
        /// Single filing status or Married filing seperately. Married filing jointly or qualifying widower. Head of Household. Unmarried and pay more than half of the costs of keeping up a home for yourself and a qualifying individual. 
        /// </summary>
        /// <value>Single filing status or Married filing seperately. Married filing jointly or qualifying widower. Head of Household. Unmarried and pay more than half of the costs of keeping up a home for yourself and a qualifying individual. </value>
        [TypeConverter(typeof(CustomEnumConverter<WithholdingFilingStatusEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum WithholdingFilingStatusEnum
        {
            
            /// <summary>
            /// Enum SingleEnum for Single
            /// </summary>
            [EnumMember(Value = "Single")]
            SingleEnum = 1,
            
            /// <summary>
            /// Enum MarriedEnum for Married
            /// </summary>
            [EnumMember(Value = "Married")]
            MarriedEnum = 2,
            
            /// <summary>
            /// Enum HeadOfHouseholdEnum for HeadOfHousehold
            /// </summary>
            [EnumMember(Value = "HeadOfHousehold")]
            HeadOfHouseholdEnum = 3
        }

        /// <summary>
        /// Single filing status or Married filing seperately. Married filing jointly or qualifying widower. Head of Household. Unmarried and pay more than half of the costs of keeping up a home for yourself and a qualifying individual. 
        /// </summary>
        /// <value>Single filing status or Married filing seperately. Married filing jointly or qualifying widower. Head of Household. Unmarried and pay more than half of the costs of keeping up a home for yourself and a qualifying individual. </value>
        [DataMember(Name="withholdingFilingStatus", EmitDefaultValue=true)]
        public WithholdingFilingStatusEnum WithholdingFilingStatus { get; set; }

        /// <summary>
        /// The number of withholdings or allowances declared. Example form W-4 line 5. 
        /// </summary>
        /// <value>The number of withholdings or allowances declared. Example form W-4 line 5. </value>
        [DataMember(Name="numberOfWithholdings", EmitDefaultValue=false)]
        public string NumberOfWithholdings { get; set; }

        /// <summary>
        /// Gets or Sets WithholdingsAmount
        /// </summary>
        [DataMember(Name="withholdingsAmount", EmitDefaultValue=false)]
        public AccountAccountEscheatAmount WithholdingsAmount { get; set; }

        /// <summary>
        /// Withholdings are exempt when set to True. 
        /// </summary>
        /// <value>Withholdings are exempt when set to True. </value>
        [DataMember(Name="withholdingsExempt", EmitDefaultValue=true)]
        public bool WithholdingsExempt { get; set; }

        /// <summary>
        /// The rate of withholding to apply to a qualifying transaction. Value is formatted as a percentile. A passed value of 4.5 is equivalent to 0.045 actual. 4.500 may be displayed as 4.500% or 4.5% depending on the user interface. Decimals available: 999.999 
        /// </summary>
        /// <value>The rate of withholding to apply to a qualifying transaction. Value is formatted as a percentile. A passed value of 4.5 is equivalent to 0.045 actual. 4.500 may be displayed as 4.500% or 4.5% depending on the user interface. Decimals available: 999.999 </value>
        [DataMember(Name="withholdingsRate", EmitDefaultValue=true)]
        public decimal WithholdingsRate { get; set; }

        /// <summary>
        /// Describes the withholding option as defined by the financial institution and allows for the range of special instructions that may be applicable. 
        /// </summary>
        /// <value>Describes the withholding option as defined by the financial institution and allows for the range of special instructions that may be applicable. </value>
        [DataMember(Name="withholdingsOption", EmitDefaultValue=false)]
        public string WithholdingsOption { get; set; }

    }
}
