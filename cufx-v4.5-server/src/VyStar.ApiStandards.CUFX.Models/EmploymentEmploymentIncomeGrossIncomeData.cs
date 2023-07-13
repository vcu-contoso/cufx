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
    /// Details related to the applicant main income. 
    /// </summary>
    [DataContract]
    public partial class EmploymentEmploymentIncomeGrossIncomeData 
    {
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public AccountAccountEscheatAmount Amount { get; set; }


        /// <summary>
        /// The frequency of the income. 
        /// </summary>
        /// <value>The frequency of the income. </value>
        [TypeConverter(typeof(CustomEnumConverter<FrequencyEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum FrequencyEnum
        {
            
            /// <summary>
            /// Enum AmortizedScheduleEnum for AmortizedSchedule
            /// </summary>
            [EnumMember(Value = "AmortizedSchedule")]
            AmortizedScheduleEnum = 1,
            
            /// <summary>
            /// Enum AnnualEnum for Annual
            /// </summary>
            [EnumMember(Value = "Annual")]
            AnnualEnum = 2,
            
            /// <summary>
            /// Enum AtMaturityEnum for AtMaturity
            /// </summary>
            [EnumMember(Value = "AtMaturity")]
            AtMaturityEnum = 3,
            
            /// <summary>
            /// Enum BimonthlyEnum for Bimonthly
            /// </summary>
            [EnumMember(Value = "Bimonthly")]
            BimonthlyEnum = 4,
            
            /// <summary>
            /// Enum BiweeklyEnum for Biweekly
            /// </summary>
            [EnumMember(Value = "Biweekly")]
            BiweeklyEnum = 5,
            
            /// <summary>
            /// Enum BiweeklySkipFirstEnum for BiweeklySkipFirst
            /// </summary>
            [EnumMember(Value = "BiweeklySkipFirst")]
            BiweeklySkipFirstEnum = 6,
            
            /// <summary>
            /// Enum BiweeklySkipLastEnum for BiweeklySkipLast
            /// </summary>
            [EnumMember(Value = "BiweeklySkipLast")]
            BiweeklySkipLastEnum = 7,
            
            /// <summary>
            /// Enum DailyEnum for Daily
            /// </summary>
            [EnumMember(Value = "Daily")]
            DailyEnum = 8,
            
            /// <summary>
            /// Enum EventTriggerEnum for EventTrigger
            /// </summary>
            [EnumMember(Value = "EventTrigger")]
            EventTriggerEnum = 9,
            
            /// <summary>
            /// Enum HourlyEnum for Hourly
            /// </summary>
            [EnumMember(Value = "Hourly")]
            HourlyEnum = 10,
            
            /// <summary>
            /// Enum ImmediateEnum for Immediate
            /// </summary>
            [EnumMember(Value = "Immediate")]
            ImmediateEnum = 11,
            
            /// <summary>
            /// Enum MonthlyEnum for Monthly
            /// </summary>
            [EnumMember(Value = "Monthly")]
            MonthlyEnum = 12,
            
            /// <summary>
            /// Enum NoneEnum for None
            /// </summary>
            [EnumMember(Value = "None")]
            NoneEnum = 13,
            
            /// <summary>
            /// Enum OneTimeEnum for OneTime
            /// </summary>
            [EnumMember(Value = "OneTime")]
            OneTimeEnum = 14,
            
            /// <summary>
            /// Enum OtherEnum for Other
            /// </summary>
            [EnumMember(Value = "Other")]
            OtherEnum = 15,
            
            /// <summary>
            /// Enum PerUseEnum for PerUse
            /// </summary>
            [EnumMember(Value = "PerUse")]
            PerUseEnum = 16,
            
            /// <summary>
            /// Enum QuarterlyEnum for Quarterly
            /// </summary>
            [EnumMember(Value = "Quarterly")]
            QuarterlyEnum = 17,
            
            /// <summary>
            /// Enum SemiAnnualEnum for SemiAnnual
            /// </summary>
            [EnumMember(Value = "SemiAnnual")]
            SemiAnnualEnum = 18,
            
            /// <summary>
            /// Enum SemiMonthlyEnum for SemiMonthly
            /// </summary>
            [EnumMember(Value = "SemiMonthly")]
            SemiMonthlyEnum = 19,
            
            /// <summary>
            /// Enum TriannualEnum for Triannual
            /// </summary>
            [EnumMember(Value = "Triannual")]
            TriannualEnum = 20,
            
            /// <summary>
            /// Enum WeeklyEnum for Weekly
            /// </summary>
            [EnumMember(Value = "Weekly")]
            WeeklyEnum = 21,
            
            /// <summary>
            /// Enum WeeklySkipFirstEnum for WeeklySkipFirst
            /// </summary>
            [EnumMember(Value = "WeeklySkipFirst")]
            WeeklySkipFirstEnum = 22,
            
            /// <summary>
            /// Enum WeeklySkipLastEnum for WeeklySkipLast
            /// </summary>
            [EnumMember(Value = "WeeklySkipLast")]
            WeeklySkipLastEnum = 23,
            
            /// <summary>
            /// Enum XDaysEnum for XDays
            /// </summary>
            [EnumMember(Value = "XDays")]
            XDaysEnum = 24,
            
            /// <summary>
            /// Enum XMonthsEnum for XMonths
            /// </summary>
            [EnumMember(Value = "XMonths")]
            XMonthsEnum = 25,
            
            /// <summary>
            /// Enum XYearsEnum for XYears
            /// </summary>
            [EnumMember(Value = "XYears")]
            XYearsEnum = 26
        }

        /// <summary>
        /// The frequency of the income. 
        /// </summary>
        /// <value>The frequency of the income. </value>
        [DataMember(Name="frequency", EmitDefaultValue=true)]
        public FrequencyEnum Frequency { get; set; }

        /// <summary>
        /// Free form text that describes the frequency type \&quot;Other\&quot; when it is set in the frequency element. 
        /// </summary>
        /// <value>Free form text that describes the frequency type \&quot;Other\&quot; when it is set in the frequency element. </value>
        [DataMember(Name="otherFrequencyType", EmitDefaultValue=false)]
        public string OtherFrequencyType { get; set; }

        /// <summary>
        /// By default, income details are included in any applicable calculations. 
        /// </summary>
        /// <value>By default, income details are included in any applicable calculations. </value>
        [DataMember(Name="excludeIncomeFromCalculations", EmitDefaultValue=true)]
        public bool ExcludeIncomeFromCalculations { get; set; }

        /// <summary>
        /// Gets or Sets CustomData
        /// </summary>
        [DataMember(Name="customData", EmitDefaultValue=false)]
        public AccessProfileCustomData CustomData { get; set; }

    }
}