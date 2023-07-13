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
    /// Contains details about security-based secured collateral types. 
    /// </summary>
    [DataContract]
    public partial class CollateralSecuritiesCollateral 
    {
        /// <summary>
        /// The collateral ID is a persistent and unique identifier for the collateral item. 
        /// </summary>
        /// <value>The collateral ID is a persistent and unique identifier for the collateral item. </value>
        [DataMember(Name="collateralId", EmitDefaultValue=false)]
        public string CollateralId { get; set; }

        /// <summary>
        /// This is FI-defined and is used to describe the collateral for a secured loan, i.e. vehicle, boat, shares  (will be conditional for Secured Loans). 
        /// </summary>
        /// <value>This is FI-defined and is used to describe the collateral for a secured loan, i.e. vehicle, boat, shares  (will be conditional for Secured Loans). </value>
        [DataMember(Name="collateralCode", EmitDefaultValue=false)]
        public string CollateralCode { get; set; }

        /// <summary>
        /// Date that the collateral is pledged for a loan. 
        /// </summary>
        /// <value>Date that the collateral is pledged for a loan. </value>
        [DataMember(Name="collateralPledgedDate", EmitDefaultValue=false)]
        public DateTime CollateralPledgedDate { get; set; }

        /// <summary>
        /// Description of the type of collateral/security. 
        /// </summary>
        /// <value>Description of the type of collateral/security. </value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Code describing how the loan is secured (100%, partial release, etc.) for a loan secured by savings, certificates, or stock. 
        /// </summary>
        /// <value>Code describing how the loan is secured (100%, partial release, etc.) for a loan secured by savings, certificates, or stock. </value>
        [DataMember(Name="securedCode", EmitDefaultValue=false)]
        public string SecuredCode { get; set; }

        /// <summary>
        /// Gets or Sets TotalSecuredAmount
        /// </summary>
        [DataMember(Name="totalSecuredAmount", EmitDefaultValue=false)]
        public AccountAccountEscheatAmount TotalSecuredAmount { get; set; }

        /// <summary>
        /// Gets or Sets ValuationOfCollateral
        /// </summary>
        [DataMember(Name="valuationOfCollateral", EmitDefaultValue=false)]
        public AccountAccountEscheatAmount ValuationOfCollateral { get; set; }

        /// <summary>
        /// Name of the owner of the collateral. 
        /// </summary>
        /// <value>Name of the owner of the collateral. </value>
        [DataMember(Name="ownerOfCollateral", EmitDefaultValue=false)]
        public string OwnerOfCollateral { get; set; }

        /// <summary>
        /// Loan to value percentage: calculation of the original loan amount to the collateral value. 
        /// </summary>
        /// <value>Loan to value percentage: calculation of the original loan amount to the collateral value. </value>
        [DataMember(Name="loanToValuePercentage", EmitDefaultValue=true)]
        public decimal LoanToValuePercentage { get; set; }

        /// <summary>
        /// The date that the estimated value was obtained from the collateral value source. 
        /// </summary>
        /// <value>The date that the estimated value was obtained from the collateral value source. </value>
        [DataMember(Name="collateralValueSourceDate", EmitDefaultValue=false)]
        public DateTime CollateralValueSourceDate { get; set; }

        /// <summary>
        /// The source used to value the collateral. Examples: Kelly Blue Book, NADA - National Automobile Dealers Association, appraisal, etc. 
        /// </summary>
        /// <value>The source used to value the collateral. Examples: Kelly Blue Book, NADA - National Automobile Dealers Association, appraisal, etc. </value>
        [DataMember(Name="collateralValueSource", EmitDefaultValue=false)]
        public string CollateralValueSource { get; set; }


        /// <summary>
        /// The type of collateral. 
        /// </summary>
        /// <value>The type of collateral. </value>
        [TypeConverter(typeof(CustomEnumConverter<CollateralTypeEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum CollateralTypeEnum
        {
            
            /// <summary>
            /// Enum AircraftCollateralEnum for aircraftCollateral
            /// </summary>
            [EnumMember(Value = "aircraftCollateral")]
            AircraftCollateralEnum = 1,
            
            /// <summary>
            /// Enum BoatCollateralEnum for boatCollateral
            /// </summary>
            [EnumMember(Value = "boatCollateral")]
            BoatCollateralEnum = 2,
            
            /// <summary>
            /// Enum LetterOfCreditCollateralEnum for letterOfCreditCollateral
            /// </summary>
            [EnumMember(Value = "letterOfCreditCollateral")]
            LetterOfCreditCollateralEnum = 3,
            
            /// <summary>
            /// Enum MobileHomeCollateralEnum for mobileHomeCollateral
            /// </summary>
            [EnumMember(Value = "mobileHomeCollateral")]
            MobileHomeCollateralEnum = 4,
            
            /// <summary>
            /// Enum MotorVehicleCollateralEnum for motorVehicleCollateral
            /// </summary>
            [EnumMember(Value = "motorVehicleCollateral")]
            MotorVehicleCollateralEnum = 5,
            
            /// <summary>
            /// Enum OtherTitledCollateralEnum for otherTitledCollateral
            /// </summary>
            [EnumMember(Value = "otherTitledCollateral")]
            OtherTitledCollateralEnum = 6,
            
            /// <summary>
            /// Enum RealEstateCollateralEnum for realEstateCollateral
            /// </summary>
            [EnumMember(Value = "realEstateCollateral")]
            RealEstateCollateralEnum = 7,
            
            /// <summary>
            /// Enum SavingsCDCollateralEnum for savingsCDCollateral
            /// </summary>
            [EnumMember(Value = "savingsCDCollateral")]
            SavingsCDCollateralEnum = 8,
            
            /// <summary>
            /// Enum SecuritiesCollateralEnum for securitiesCollateral
            /// </summary>
            [EnumMember(Value = "securitiesCollateral")]
            SecuritiesCollateralEnum = 9,
            
            /// <summary>
            /// Enum ShipCollateralEnum for shipCollateral
            /// </summary>
            [EnumMember(Value = "shipCollateral")]
            ShipCollateralEnum = 10,
            
            /// <summary>
            /// Enum TrailerCollateralEnum for trailerCollateral
            /// </summary>
            [EnumMember(Value = "trailerCollateral")]
            TrailerCollateralEnum = 11,
            
            /// <summary>
            /// Enum UccCollateralEnum for uccCollateral
            /// </summary>
            [EnumMember(Value = "uccCollateral")]
            UccCollateralEnum = 12
        }

        /// <summary>
        /// The type of collateral. 
        /// </summary>
        /// <value>The type of collateral. </value>
        [DataMember(Name="collateralType", EmitDefaultValue=true)]
        public CollateralTypeEnum CollateralType { get; set; }

        /// <summary>
        /// The collateralSubType supports discreet sub classifications of the collateral by an institution. 
        /// </summary>
        /// <value>The collateralSubType supports discreet sub classifications of the collateral by an institution. </value>
        [DataMember(Name="collateralSubType", EmitDefaultValue=false)]
        public string CollateralSubType { get; set; }

        /// <summary>
        /// The description of the collateralSubType as defined by the institution. 
        /// </summary>
        /// <value>The description of the collateralSubType as defined by the institution. </value>
        [DataMember(Name="collateralSubTypeDescription", EmitDefaultValue=false)]
        public string CollateralSubTypeDescription { get; set; }

        /// <summary>
        /// Gets or Sets AccountIdentificationList
        /// </summary>
        [DataMember(Name="accountIdentificationList", EmitDefaultValue=false)]
        public AccountFilterAccountIdentificationList AccountIdentificationList { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public AccountExternalAccountBankAddress Address { get; set; }

        /// <summary>
        /// Gets or Sets SecurityCollateralValueLimit
        /// </summary>
        [DataMember(Name="securityCollateralValueLimit", EmitDefaultValue=false)]
        public AccountAccountEscheatAmount SecurityCollateralValueLimit { get; set; }

        /// <summary>
        /// The desired percentage for the collateral value to loan ration, below which the loan will be considered in default. 
        /// </summary>
        /// <value>The desired percentage for the collateral value to loan ration, below which the loan will be considered in default. </value>
        [DataMember(Name="securityMarketValueLimit", EmitDefaultValue=true)]
        public decimal SecurityMarketValueLimit { get; set; }

        /// <summary>
        /// The account or other number for the security. 
        /// </summary>
        /// <value>The account or other number for the security. </value>
        [DataMember(Name="possessoryNumber", EmitDefaultValue=false)]
        public string PossessoryNumber { get; set; }

        /// <summary>
        /// The face value of the security instrument(s). 
        /// </summary>
        /// <value>The face value of the security instrument(s). </value>
        [DataMember(Name="faceValue", EmitDefaultValue=false)]
        public string FaceValue { get; set; }

        /// <summary>
        /// The issuer of the security instrument(s). 
        /// </summary>
        /// <value>The issuer of the security instrument(s). </value>
        [DataMember(Name="issuer", EmitDefaultValue=false)]
        public string Issuer { get; set; }

        /// <summary>
        /// The number of shares of stock being used as collateral. 
        /// </summary>
        /// <value>The number of shares of stock being used as collateral. </value>
        [DataMember(Name="numberOfShares", EmitDefaultValue=true)]
        public decimal NumberOfShares { get; set; }

        /// <summary>
        /// Enter the CUSIP No. identifier for this piece of collateral, if it was issued in the United States. If this is a foreign security, enter the CUSIP number. The CUSIP No. identifier consists of seven numbers and two letters and appears on all U.S. securites issued after 1970 in book-entry or certificate form. Foreign securities issued after 1989 are identified by a nine-digit identifier. 
        /// </summary>
        /// <value>Enter the CUSIP No. identifier for this piece of collateral, if it was issued in the United States. If this is a foreign security, enter the CUSIP number. The CUSIP No. identifier consists of seven numbers and two letters and appears on all U.S. securites issued after 1970 in book-entry or certificate form. Foreign securities issued after 1989 are identified by a nine-digit identifier. </value>
        [DataMember(Name="cusipNumber", EmitDefaultValue=false)]
        public string CusipNumber { get; set; }

        /// <summary>
        /// If the securites will be held by the lender, indicate lender. If the securities will be held by another holder, indicate the other holder. 
        /// </summary>
        /// <value>If the securites will be held by the lender, indicate lender. If the securities will be held by another holder, indicate the other holder. </value>
        [DataMember(Name="heldBy", EmitDefaultValue=false)]
        public string HeldBy { get; set; }

        /// <summary>
        /// Indicates if the security is registered in the books of the depository institution at which it is held and there is no physical evidence of the collateral. 
        /// </summary>
        /// <value>Indicates if the security is registered in the books of the depository institution at which it is held and there is no physical evidence of the collateral. </value>
        [DataMember(Name="bookEntry", EmitDefaultValue=true)]
        public bool BookEntry { get; set; }


        /// <summary>
        /// Indicates the frequency by which the value of the security will be updated. 
        /// </summary>
        /// <value>Indicates the frequency by which the value of the security will be updated. </value>
        [TypeConverter(typeof(CustomEnumConverter<ValuationFrequencyEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ValuationFrequencyEnum
        {
            
            /// <summary>
            /// Enum WeeklyEnum for Weekly
            /// </summary>
            [EnumMember(Value = "Weekly")]
            WeeklyEnum = 1,
            
            /// <summary>
            /// Enum BiWeeklyEnum for BiWeekly
            /// </summary>
            [EnumMember(Value = "BiWeekly")]
            BiWeeklyEnum = 2,
            
            /// <summary>
            /// Enum MonthlyEnum for Monthly
            /// </summary>
            [EnumMember(Value = "Monthly")]
            MonthlyEnum = 3,
            
            /// <summary>
            /// Enum BiMonthlyEnum for BiMonthly
            /// </summary>
            [EnumMember(Value = "BiMonthly")]
            BiMonthlyEnum = 4,
            
            /// <summary>
            /// Enum QuarterlyEnum for Quarterly
            /// </summary>
            [EnumMember(Value = "Quarterly")]
            QuarterlyEnum = 5,
            
            /// <summary>
            /// Enum SemiAnnuallyEnum for SemiAnnually
            /// </summary>
            [EnumMember(Value = "SemiAnnually")]
            SemiAnnuallyEnum = 6,
            
            /// <summary>
            /// Enum AnnuallyEnum for Annually
            /// </summary>
            [EnumMember(Value = "Annually")]
            AnnuallyEnum = 7
        }

        /// <summary>
        /// Indicates the frequency by which the value of the security will be updated. 
        /// </summary>
        /// <value>Indicates the frequency by which the value of the security will be updated. </value>
        [DataMember(Name="valuationFrequency", EmitDefaultValue=true)]
        public ValuationFrequencyEnum ValuationFrequency { get; set; }

    }
}
