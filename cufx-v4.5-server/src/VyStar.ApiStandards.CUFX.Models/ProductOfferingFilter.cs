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
    /// The list of filter options for services requesting data about product offerings.  The options can be used in combination or by themselves.  It is up to the data source to either return the data requested or return a standard error identifying why the request was rejected. 
    /// </summary>
    [DataContract]
    public partial class ProductOfferingFilter 
    {
        /// <summary>
        /// Gets or Sets ProductIdList
        /// </summary>
        [DataMember(Name="productIdList", EmitDefaultValue=false)]
        public PermissionListFilterResourcesProductIdList ProductIdList { get; set; }

        /// <summary>
        /// Gets or Sets ProductTypeList
        /// </summary>
        [DataMember(Name="productTypeList", EmitDefaultValue=false)]
        public ApplicationFilterProductTypeList ProductTypeList { get; set; }

        /// <summary>
        /// Gets or Sets ProductSubTypeList
        /// </summary>
        [DataMember(Name="productSubTypeList", EmitDefaultValue=false)]
        public ProductOfferingFilterProductSubTypeList ProductSubTypeList { get; set; }

        /// <summary>
        /// This filters to include rates with this introductory/promotional boolean value. Does not filter based on introductory rate if omitted. 
        /// </summary>
        /// <value>This filters to include rates with this introductory/promotional boolean value. Does not filter based on introductory rate if omitted. </value>
        [DataMember(Name="introductoryRate", EmitDefaultValue=true)]
        public bool IntroductoryRate { get; set; }

        /// <summary>
        /// This filters to include rates with this balance consolidation boolean value. Does not filter based on introductory rate if omitted. 
        /// </summary>
        /// <value>This filters to include rates with this balance consolidation boolean value. Does not filter based on introductory rate if omitted. </value>
        [DataMember(Name="balanceConsolidationRate", EmitDefaultValue=true)]
        public bool BalanceConsolidationRate { get; set; }

        /// <summary>
        /// This filters to include rates with this risk-based boolean value. Does not filter based on introductory rate if omitted. 
        /// </summary>
        /// <value>This filters to include rates with this risk-based boolean value. Does not filter based on introductory rate if omitted. </value>
        [DataMember(Name="riskRate", EmitDefaultValue=true)]
        public bool RiskRate { get; set; }

        /// <summary>
        /// Gets or Sets InterestRateEffectiveDateRange
        /// </summary>
        [DataMember(Name="interestRateEffectiveDateRange", EmitDefaultValue=false)]
        public AccessProfileFilterCreateAccessDateRange InterestRateEffectiveDateRange { get; set; }

        /// <summary>
        /// Gets or Sets InterestRateExpirationDateRange
        /// </summary>
        [DataMember(Name="interestRateExpirationDateRange", EmitDefaultValue=false)]
        public AccessProfileFilterCreateAccessDateRange InterestRateExpirationDateRange { get; set; }

        /// <summary>
        /// The minimum term that should be used when filtering for a term, using ISO 8601 duration format: P3M is three months, P90D is ninety days.  The value is assumed to be P0D (zero days) if omitted. 
        /// </summary>
        /// <value>The minimum term that should be used when filtering for a term, using ISO 8601 duration format: P3M is three months, P90D is ninety days.  The value is assumed to be P0D (zero days) if omitted. </value>
        [DataMember(Name="minTerm", EmitDefaultValue=false)]
        public string MinTerm { get; set; }

        /// <summary>
        /// The maximum term that should be used when filtering for a term, using ISO 8601 duration format: P3M is three months, P90D is ninety days.  The value is assumed to be P0D (zero days) if omitted. 
        /// </summary>
        /// <value>The maximum term that should be used when filtering for a term, using ISO 8601 duration format: P3M is three months, P90D is ninety days.  The value is assumed to be P0D (zero days) if omitted. </value>
        [DataMember(Name="maxTerm", EmitDefaultValue=false)]
        public string MaxTerm { get; set; }

        /// <summary>
        /// If provided and true, only product offerings that are part of a points rewards program will be returned.  If provided and false, only product offerings that are NOT part of a points rewards program will be returned.  If not provided, then no filtering will occur based on the pointsRewardsProgram. 
        /// </summary>
        /// <value>If provided and true, only product offerings that are part of a points rewards program will be returned.  If provided and false, only product offerings that are NOT part of a points rewards program will be returned.  If not provided, then no filtering will occur based on the pointsRewardsProgram. </value>
        [DataMember(Name="pointsRewardsProgram", EmitDefaultValue=true)]
        public bool PointsRewardsProgram { get; set; }

        /// <summary>
        /// If provided, only the product offerings that match the company that sponsors the card (i.e. Visa, MasterCard, American Express, etc.) will be returned.  If not provided, then no filtering by brand will occur. Only applies to credit and debit card product offerings. 
        /// </summary>
        /// <value>If provided, only the product offerings that match the company that sponsors the card (i.e. Visa, MasterCard, American Express, etc.) will be returned.  If not provided, then no filtering by brand will occur. Only applies to credit and debit card product offerings. </value>
        [DataMember(Name="brand", EmitDefaultValue=false)]
        public string Brand { get; set; }

        /// <summary>
        /// If provided, it will only return risk interest rates where riskRateClassificationMinimum is below or equal to this provided value and the riskRateClassificationMaximum is above or equal to this value. 
        /// </summary>
        /// <value>If provided, it will only return risk interest rates where riskRateClassificationMinimum is below or equal to this provided value and the riskRateClassificationMaximum is above or equal to this value. </value>
        [DataMember(Name="riskRateClassification", EmitDefaultValue=false)]
        public string RiskRateClassification { get; set; }

        /// <summary>
        /// Gets or Sets CustomData
        /// </summary>
        [DataMember(Name="customData", EmitDefaultValue=false)]
        public AccessProfileCustomData CustomData { get; set; }

    }
}
