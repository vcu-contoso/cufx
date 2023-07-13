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
    /// Fields related to when the party is an individual. 
    /// </summary>
    [DataContract]
    public partial class PartyCharacteristicsIndividual 
    {
        /// <summary>
        /// The partyâ€™s first name is the persons given name. 
        /// </summary>
        /// <value>The partyâ€™s first name is the persons given name. </value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The partyâ€™s middle name. 
        /// </summary>
        /// <value>The partyâ€™s middle name. </value>
        [DataMember(Name="middleName", EmitDefaultValue=false)]
        public string MiddleName { get; set; }

        /// <summary>
        /// The partyâ€™s last name or surname. 
        /// </summary>
        /// <value>The partyâ€™s last name or surname. </value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// The partyâ€™s prefix to their name, as in their title.  Typical examples are Dr., Mr., Mrs., etc.. 
        /// </summary>
        /// <value>The partyâ€™s prefix to their name, as in their title.  Typical examples are Dr., Mr., Mrs., etc.. </value>
        [DataMember(Name="prefix", EmitDefaultValue=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// The partyâ€™s suffix to their name.  Typical examples are Jr., III, etc.. 
        /// </summary>
        /// <value>The partyâ€™s suffix to their name.  Typical examples are Jr., III, etc.. </value>
        [DataMember(Name="suffix", EmitDefaultValue=false)]
        public string Suffix { get; set; }

        /// <summary>
        /// All party name fields combined into one. This is typically a read-only field that can be returned by the data source. To remain flexible, this field can be either written to or returned by the data source. 
        /// </summary>
        /// <value>All party name fields combined into one. This is typically a read-only field that can be returned by the data source. To remain flexible, this field can be either written to or returned by the data source. </value>
        [DataMember(Name="formattedName", EmitDefaultValue=false)]
        public string FormattedName { get; set; }

        /// <summary>
        /// The partys mothers maiden name.  This has recently been falling out of favor for an account code word.  See the credentials collection. 
        /// </summary>
        /// <value>The partys mothers maiden name.  This has recently been falling out of favor for an account code word.  See the credentials collection. </value>
        [DataMember(Name="mothersMaidenName", EmitDefaultValue=false)]
        public string MothersMaidenName { get; set; }

        /// <summary>
        /// The partyâ€™s casual or familiar name reference. Typical examples might be Tim if the partys first name is Timothy, or Jenny if the first name is Jennifer. 
        /// </summary>
        /// <value>The partyâ€™s casual or familiar name reference. Typical examples might be Tim if the partys first name is Timothy, or Jenny if the first name is Jennifer. </value>
        [DataMember(Name="nickname", EmitDefaultValue=false)]
        public string Nickname { get; set; }

        /// <summary>
        /// Birth date of the individual. The date/time should be ISO 8601 UTC format. yyyy-mm-dd (2011-03-28) format is supported. 
        /// </summary>
        /// <value>Birth date of the individual. The date/time should be ISO 8601 UTC format. yyyy-mm-dd (2011-03-28) format is supported. </value>
        [DataMember(Name="birthdate", EmitDefaultValue=false)]
        public DateTime Birthdate { get; set; }

        /// <summary>
        /// Deceased date of the individual. The date/time should be ISO 8601 UTC format. yyyy-mm-dd (2011-03-28) format is supported. 
        /// </summary>
        /// <value>Deceased date of the individual. The date/time should be ISO 8601 UTC format. yyyy-mm-dd (2011-03-28) format is supported. </value>
        [DataMember(Name="deathDate", EmitDefaultValue=false)]
        public DateTime DeathDate { get; set; }


        /// <summary>
        /// Gender of the party. 
        /// </summary>
        /// <value>Gender of the party. </value>
        [TypeConverter(typeof(CustomEnumConverter<GenderEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum GenderEnum
        {
            
            /// <summary>
            /// Enum MaleEnum for Male
            /// </summary>
            [EnumMember(Value = "Male")]
            MaleEnum = 1,
            
            /// <summary>
            /// Enum FemaleEnum for Female
            /// </summary>
            [EnumMember(Value = "Female")]
            FemaleEnum = 2,
            
            /// <summary>
            /// Enum OtherEnum for Other
            /// </summary>
            [EnumMember(Value = "Other")]
            OtherEnum = 3
        }

        /// <summary>
        /// Gender of the party. 
        /// </summary>
        /// <value>Gender of the party. </value>
        [DataMember(Name="gender", EmitDefaultValue=true)]
        public GenderEnum Gender { get; set; }

        /// <summary>
        /// Birth place of individual (city only). 
        /// </summary>
        /// <value>Birth place of individual (city only). </value>
        [DataMember(Name="cityOfBirth", EmitDefaultValue=false)]
        public string CityOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets CitizenshipList
        /// </summary>
        [DataMember(Name="citizenshipList", EmitDefaultValue=false)]
        public PartyCharacteristicsIndividualCitizenshipList CitizenshipList { get; set; }


        /// <summary>
        /// Represents available individual employment status values, i.e. employed, unemployed, contract, etc.. 
        /// </summary>
        /// <value>Represents available individual employment status values, i.e. employed, unemployed, contract, etc.. </value>
        [TypeConverter(typeof(CustomEnumConverter<EmploymentStatusEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum EmploymentStatusEnum
        {
            
            /// <summary>
            /// Enum ContractEnum for Contract
            /// </summary>
            [EnumMember(Value = "Contract")]
            ContractEnum = 1,
            
            /// <summary>
            /// Enum EmployedEnum for Employed
            /// </summary>
            [EnumMember(Value = "Employed")]
            EmployedEnum = 2,
            
            /// <summary>
            /// Enum HomemakerEnum for Homemaker
            /// </summary>
            [EnumMember(Value = "Homemaker")]
            HomemakerEnum = 3,
            
            /// <summary>
            /// Enum OtherEnum for Other
            /// </summary>
            [EnumMember(Value = "Other")]
            OtherEnum = 4,
            
            /// <summary>
            /// Enum RetiredEnum for Retired
            /// </summary>
            [EnumMember(Value = "Retired")]
            RetiredEnum = 5,
            
            /// <summary>
            /// Enum SelfEmployedEnum for SelfEmployed
            /// </summary>
            [EnumMember(Value = "SelfEmployed")]
            SelfEmployedEnum = 6,
            
            /// <summary>
            /// Enum StudentEnum for Student
            /// </summary>
            [EnumMember(Value = "Student")]
            StudentEnum = 7,
            
            /// <summary>
            /// Enum TemporaryEnum for Temporary
            /// </summary>
            [EnumMember(Value = "Temporary")]
            TemporaryEnum = 8,
            
            /// <summary>
            /// Enum UnemployedEnum for Unemployed
            /// </summary>
            [EnumMember(Value = "Unemployed")]
            UnemployedEnum = 9
        }

        /// <summary>
        /// Represents available individual employment status values, i.e. employed, unemployed, contract, etc.. 
        /// </summary>
        /// <value>Represents available individual employment status values, i.e. employed, unemployed, contract, etc.. </value>
        [DataMember(Name="employmentStatus", EmitDefaultValue=true)]
        public EmploymentStatusEnum EmploymentStatus { get; set; }

        /// <summary>
        /// Gets or Sets EmploymentList
        /// </summary>
        [DataMember(Name="employmentList", EmitDefaultValue=false)]
        public PartyCharacteristicsIndividualEmploymentList EmploymentList { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalIncomeList
        /// </summary>
        [DataMember(Name="additionalIncomeList", EmitDefaultValue=false)]
        public PartyCharacteristicsIndividualAdditionalIncomeList AdditionalIncomeList { get; set; }

        /// <summary>
        /// Gets or Sets LiabilityList
        /// </summary>
        [DataMember(Name="liabilityList", EmitDefaultValue=false)]
        public PartyCharacteristicsIndividualLiabilityList LiabilityList { get; set; }

        /// <summary>
        /// Gets or Sets Residence
        /// </summary>
        [DataMember(Name="residence", EmitDefaultValue=false)]
        public PartyCharacteristicsIndividualResidence Residence { get; set; }

        /// <summary>
        /// Recommended population per Ethnicity definitions of the US Dept of Labor. Enumerations were not applied as alternate populations may exist that predate the current definitions and may not account for international definitions that could also be applicable. \&quot;Hispanic or Latino\&quot; \&quot;Not Hispanic or Latino\&quot; 
        /// </summary>
        /// <value>Recommended population per Ethnicity definitions of the US Dept of Labor. Enumerations were not applied as alternate populations may exist that predate the current definitions and may not account for international definitions that could also be applicable. \&quot;Hispanic or Latino\&quot; \&quot;Not Hispanic or Latino\&quot; </value>
        [DataMember(Name="ethnicity", EmitDefaultValue=false)]
        public string Ethnicity { get; set; }

        /// <summary>
        /// Recommended population per race definitions of the US Dept of Labor. Enumerations were not applied as alternate populations may exist that predate the current definitions and may not account for international definitions that could also be applicable. \&quot;American Indian or Alaska Native\&quot; \&quot;Asian\&quot; \&quot;Black or African American\&quot; \&quot;Native Hawaiian or Other Pacific Islander\&quot; \&quot;White\&quot; 
        /// </summary>
        /// <value>Recommended population per race definitions of the US Dept of Labor. Enumerations were not applied as alternate populations may exist that predate the current definitions and may not account for international definitions that could also be applicable. \&quot;American Indian or Alaska Native\&quot; \&quot;Asian\&quot; \&quot;Black or African American\&quot; \&quot;Native Hawaiian or Other Pacific Islander\&quot; \&quot;White\&quot; </value>
        [DataMember(Name="race", EmitDefaultValue=false)]
        public string Race { get; set; }


        /// <summary>
        /// The current marital status of the individual. 
        /// </summary>
        /// <value>The current marital status of the individual. </value>
        [TypeConverter(typeof(CustomEnumConverter<MaritalStatusEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum MaritalStatusEnum
        {
            
            /// <summary>
            /// Enum AnnulledEnum for Annulled
            /// </summary>
            [EnumMember(Value = "Annulled")]
            AnnulledEnum = 1,
            
            /// <summary>
            /// Enum CommonLawEnum for CommonLaw
            /// </summary>
            [EnumMember(Value = "CommonLaw")]
            CommonLawEnum = 2,
            
            /// <summary>
            /// Enum DivorcedEnum for Divorced
            /// </summary>
            [EnumMember(Value = "Divorced")]
            DivorcedEnum = 3,
            
            /// <summary>
            /// Enum DomesticPartnerEnum for DomesticPartner
            /// </summary>
            [EnumMember(Value = "DomesticPartner")]
            DomesticPartnerEnum = 4,
            
            /// <summary>
            /// Enum InterlocutoryEnum for Interlocutory
            /// </summary>
            [EnumMember(Value = "Interlocutory")]
            InterlocutoryEnum = 5,
            
            /// <summary>
            /// Enum LegallySeparatedEnum for LegallySeparated
            /// </summary>
            [EnumMember(Value = "LegallySeparated")]
            LegallySeparatedEnum = 6,
            
            /// <summary>
            /// Enum MarriedEnum for Married
            /// </summary>
            [EnumMember(Value = "Married")]
            MarriedEnum = 7,
            
            /// <summary>
            /// Enum RegisteredDomesticPartnerEnum for RegisteredDomesticPartner
            /// </summary>
            [EnumMember(Value = "RegisteredDomesticPartner")]
            RegisteredDomesticPartnerEnum = 8,
            
            /// <summary>
            /// Enum SeparatedEnum for Separated
            /// </summary>
            [EnumMember(Value = "Separated")]
            SeparatedEnum = 9,
            
            /// <summary>
            /// Enum SingleEnum for Single
            /// </summary>
            [EnumMember(Value = "Single")]
            SingleEnum = 10,
            
            /// <summary>
            /// Enum WidowedEnum for Widowed
            /// </summary>
            [EnumMember(Value = "Widowed")]
            WidowedEnum = 11,
            
            /// <summary>
            /// Enum UnknownEnum for Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            UnknownEnum = 12
        }

        /// <summary>
        /// The current marital status of the individual. 
        /// </summary>
        /// <value>The current marital status of the individual. </value>
        [DataMember(Name="maritalStatus", EmitDefaultValue=true)]
        public MaritalStatusEnum MaritalStatus { get; set; }

    }
}
