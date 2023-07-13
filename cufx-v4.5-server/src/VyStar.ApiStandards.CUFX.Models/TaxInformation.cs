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
    public partial class TaxInformation 
    {
        /// <summary>
        /// Individual Social Security Number (SSN), Individual Tax Payer Number (TIN), the organizational Employer Identification Number (EIN), or other international Tax ID. 
        /// </summary>
        /// <value>Individual Social Security Number (SSN), Individual Tax Payer Number (TIN), the organizational Employer Identification Number (EIN), or other international Tax ID. </value>
        [DataMember(Name="taxId", EmitDefaultValue=false)]
        public string TaxId { get; set; }

        /// <summary>
        /// If true, indicates that the tax ID was encrypted. Encryption method is agreed upon by application end point providers.  Assume itâ€™s NOT encrypted if this flag is not provided. The message context will be used by the service to understand which client is calling the service and know which encryption algorithm to apply. 
        /// </summary>
        /// <value>If true, indicates that the tax ID was encrypted. Encryption method is agreed upon by application end point providers.  Assume itâ€™s NOT encrypted if this flag is not provided. The message context will be used by the service to understand which client is calling the service and know which encryption algorithm to apply. </value>
        [DataMember(Name="taxIdEncrypted", EmitDefaultValue=true)]
        public bool TaxIdEncrypted { get; set; }


        /// <summary>
        /// Identifies what type of tax ID is in the taxId field.  Standard IRS codes plus two foreign codes. http://www.irs.gov/Individuals/International-Taxpayers/Taxpayer-Identification-Numbers-(TIN) 
        /// </summary>
        /// <value>Identifies what type of tax ID is in the taxId field.  Standard IRS codes plus two foreign codes. http://www.irs.gov/Individuals/International-Taxpayers/Taxpayer-Identification-Numbers-(TIN) </value>
        [TypeConverter(typeof(CustomEnumConverter<TaxIdTypeEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TaxIdTypeEnum
        {
            
            /// <summary>
            /// Enum SocialSecurityNumberEnum for SocialSecurityNumber
            /// </summary>
            [EnumMember(Value = "SocialSecurityNumber")]
            SocialSecurityNumberEnum = 1,
            
            /// <summary>
            /// Enum EmployerIdentificationNumberEnum for EmployerIdentificationNumber
            /// </summary>
            [EnumMember(Value = "EmployerIdentificationNumber")]
            EmployerIdentificationNumberEnum = 2,
            
            /// <summary>
            /// Enum IndividualTaxpayerIdentificationNumberEnum for IndividualTaxpayerIdentificationNumber
            /// </summary>
            [EnumMember(Value = "IndividualTaxpayerIdentificationNumber")]
            IndividualTaxpayerIdentificationNumberEnum = 3,
            
            /// <summary>
            /// Enum TaxpayerIdentificationNumberForPendingUSAdoptionsEnum for TaxpayerIdentificationNumberForPendingUSAdoptions
            /// </summary>
            [EnumMember(Value = "TaxpayerIdentificationNumberForPendingUSAdoptions")]
            TaxpayerIdentificationNumberForPendingUSAdoptionsEnum = 4,
            
            /// <summary>
            /// Enum PreparerTaxpayerIdentificationNumberEnum for PreparerTaxpayerIdentificationNumber
            /// </summary>
            [EnumMember(Value = "PreparerTaxpayerIdentificationNumber")]
            PreparerTaxpayerIdentificationNumberEnum = 5,
            
            /// <summary>
            /// Enum ForeignNationalEnum for ForeignNational
            /// </summary>
            [EnumMember(Value = "ForeignNational")]
            ForeignNationalEnum = 6,
            
            /// <summary>
            /// Enum ForeignNumberNoTINEnum for ForeignNumberNoTIN
            /// </summary>
            [EnumMember(Value = "ForeignNumberNoTIN")]
            ForeignNumberNoTINEnum = 7,
            
            /// <summary>
            /// Enum OtherEnum for Other
            /// </summary>
            [EnumMember(Value = "Other")]
            OtherEnum = 8,
            
            /// <summary>
            /// Enum SocialInsuranceNumberEnum for SocialInsuranceNumber
            /// </summary>
            [EnumMember(Value = "SocialInsuranceNumber")]
            SocialInsuranceNumberEnum = 9
        }

        /// <summary>
        /// Identifies what type of tax ID is in the taxId field.  Standard IRS codes plus two foreign codes. http://www.irs.gov/Individuals/International-Taxpayers/Taxpayer-Identification-Numbers-(TIN) 
        /// </summary>
        /// <value>Identifies what type of tax ID is in the taxId field.  Standard IRS codes plus two foreign codes. http://www.irs.gov/Individuals/International-Taxpayers/Taxpayer-Identification-Numbers-(TIN) </value>
        [DataMember(Name="taxIdType", EmitDefaultValue=true)]
        public TaxIdTypeEnum TaxIdType { get; set; }

        /// <summary>
        /// Description of other tax id when taxIdType is equal to Other. 
        /// </summary>
        /// <value>Description of other tax id when taxIdType is equal to Other. </value>
        [DataMember(Name="otherTaxIdType", EmitDefaultValue=false)]
        public string OtherTaxIdType { get; set; }

        /// <summary>
        /// Whether the financial income for this party should be reported to the U.S. government (IRS) when related to an account in a way which requires reporting (for example, primary, joint ownership). Defaults to true if not specified. 
        /// </summary>
        /// <value>Whether the financial income for this party should be reported to the U.S. government (IRS) when related to an account in a way which requires reporting (for example, primary, joint ownership). Defaults to true if not specified. </value>
        [DataMember(Name="reportingFlag", EmitDefaultValue=true)]
        public bool ReportingFlag { get; set; }

        /// <summary>
        /// The tax ID has been verified by the IRS as valid. 
        /// </summary>
        /// <value>The tax ID has been verified by the IRS as valid. </value>
        [DataMember(Name="verifiedTaxIdFlag", EmitDefaultValue=true)]
        public bool VerifiedTaxIdFlag { get; set; }

        /// <summary>
        /// Number of times that the IRS has notified the FI that there are issues with the tax ID. This is not used in initial creation but can be used for later processing. 
        /// </summary>
        /// <value>Number of times that the IRS has notified the FI that there are issues with the tax ID. This is not used in initial creation but can be used for later processing. </value>
        [DataMember(Name="taxIdWarningCount", EmitDefaultValue=true)]
        public int TaxIdWarningCount { get; set; }

        /// <summary>
        /// This tax ID is subject to backup withholding. 
        /// </summary>
        /// <value>This tax ID is subject to backup withholding. </value>
        [DataMember(Name="backupWithholdingFlag", EmitDefaultValue=true)]
        public bool BackupWithholdingFlag { get; set; }

        /// <summary>
        /// The reason that the tax ID is subject to backup withholding. 
        /// </summary>
        /// <value>The reason that the tax ID is subject to backup withholding. </value>
        [DataMember(Name="backupWithholdingReason", EmitDefaultValue=false)]
        public string BackupWithholdingReason { get; set; }


        /// <summary>
        /// The reason that the tax ID is NOT subject to backup withholding. 
        /// </summary>
        /// <value>The reason that the tax ID is NOT subject to backup withholding. </value>
        [TypeConverter(typeof(CustomEnumConverter<BackupWithholdingExemptionReasonEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum BackupWithholdingExemptionReasonEnum
        {
            
            /// <summary>
            /// Enum ExceptFromWithholdingEnum for ExceptFromWithholding
            /// </summary>
            [EnumMember(Value = "ExceptFromWithholding")]
            ExceptFromWithholdingEnum = 1,
            
            /// <summary>
            /// Enum NotNotifiedByIrsEnum for NotNotifiedByIrs
            /// </summary>
            [EnumMember(Value = "NotNotifiedByIrs")]
            NotNotifiedByIrsEnum = 2,
            
            /// <summary>
            /// Enum IrsNotifiedNoLongSubjectEnum for IrsNotifiedNoLongSubject
            /// </summary>
            [EnumMember(Value = "IrsNotifiedNoLongSubject")]
            IrsNotifiedNoLongSubjectEnum = 3
        }

        /// <summary>
        /// The reason that the tax ID is NOT subject to backup withholding. 
        /// </summary>
        /// <value>The reason that the tax ID is NOT subject to backup withholding. </value>
        [DataMember(Name="backupWithholdingExemptionReason", EmitDefaultValue=true)]
        public BackupWithholdingExemptionReasonEnum BackupWithholdingExemptionReason { get; set; }

        /// <summary>
        /// The date the tax ID has submitted their backup withholding information. The date/time should be ISO 8601 UTC format. yyyy-mm-dd (2011-03-28) format is supported. 
        /// </summary>
        /// <value>The date the tax ID has submitted their backup withholding information. The date/time should be ISO 8601 UTC format. yyyy-mm-dd (2011-03-28) format is supported. </value>
        [DataMember(Name="backupWithholdingEffectiveDate", EmitDefaultValue=false)]
        public DateTime BackupWithholdingEffectiveDate { get; set; }

        /// <summary>
        /// Gets or Sets CustomData
        /// </summary>
        [DataMember(Name="customData", EmitDefaultValue=false)]
        public AccessProfileCustomData CustomData { get; set; }

        /// <summary>
        /// Gets or Sets WithholdingsInfoList
        /// </summary>
        [DataMember(Name="withholdingsInfoList", EmitDefaultValue=false)]
        public AccountWithholdingsInfoList WithholdingsInfoList { get; set; }

        /// <summary>
        /// Date that a tax id will expire as being valid. Example usage US federal government - An Individual Taxpayer Identification Number ITIN will expire if not used on a federal income tax return for ANY year during a period of 5 consecutive years. The date/time should be ISO 8601 UTC format. yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. 
        /// </summary>
        /// <value>Date that a tax id will expire as being valid. Example usage US federal government - An Individual Taxpayer Identification Number ITIN will expire if not used on a federal income tax return for ANY year during a period of 5 consecutive years. The date/time should be ISO 8601 UTC format. yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. </value>
        [DataMember(Name="taxIdExpirationDateTime", EmitDefaultValue=false)]
        public string TaxIdExpirationDateTime { get; set; }

    }
}
