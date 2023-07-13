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
    /// Details related to pleasure boat collateral. 
    /// </summary>
    [DataContract]
    public partial class CollateralBoatCollateral 
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
        /// The year of the titled collateral. 
        /// </summary>
        /// <value>The year of the titled collateral. </value>
        [DataMember(Name="year", EmitDefaultValue=true)]
        public int Year { get; set; }

        /// <summary>
        /// The manufacturer of the titled collateral. 
        /// </summary>
        /// <value>The manufacturer of the titled collateral. </value>
        [DataMember(Name="manufacturer", EmitDefaultValue=false)]
        public string Manufacturer { get; set; }

        /// <summary>
        /// The titled collateral make. 
        /// </summary>
        /// <value>The titled collateral make. </value>
        [DataMember(Name="make", EmitDefaultValue=false)]
        public string Make { get; set; }

        /// <summary>
        /// The titled collateral model. 
        /// </summary>
        /// <value>The titled collateral model. </value>
        [DataMember(Name="model", EmitDefaultValue=false)]
        public string Model { get; set; }

        /// <summary>
        /// The color of the titled collateral. 
        /// </summary>
        /// <value>The color of the titled collateral. </value>
        [DataMember(Name="color", EmitDefaultValue=false)]
        public string Color { get; set; }

        /// <summary>
        /// Gets or Sets PurchasePrice
        /// </summary>
        [DataMember(Name="purchasePrice", EmitDefaultValue=false)]
        public AccountAccountEscheatAmount PurchasePrice { get; set; }

        /// <summary>
        /// Whether the titled collateral is used or new. 
        /// </summary>
        /// <value>Whether the titled collateral is used or new. </value>
        [DataMember(Name="isVehicleUsed", EmitDefaultValue=true)]
        public bool IsVehicleUsed { get; set; }

        /// <summary>
        /// Code used to register boats, RVs etc. Vehicles that dont have a title value because some states use UCC instead of titles altogether. 
        /// </summary>
        /// <value>Code used to register boats, RVs etc. Vehicles that dont have a title value because some states use UCC instead of titles altogether. </value>
        [DataMember(Name="uccCode", EmitDefaultValue=false)]
        public string UccCode { get; set; }

        /// <summary>
        /// The body style of the boat. 
        /// </summary>
        /// <value>The body style of the boat. </value>
        [DataMember(Name="bodyStyle", EmitDefaultValue=false)]
        public string BodyStyle { get; set; }

        /// <summary>
        /// The boat manufacturers assigned serial number. 
        /// </summary>
        /// <value>The boat manufacturers assigned serial number. </value>
        [DataMember(Name="serialNumber", EmitDefaultValue=false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// The marina or port at which the boat is primarily docked. 
        /// </summary>
        /// <value>The marina or port at which the boat is primarily docked. </value>
        [DataMember(Name="marinaPort", EmitDefaultValue=false)]
        public string MarinaPort { get; set; }

        /// <summary>
        /// Description of the equipment and engines installed in the boat. 
        /// </summary>
        /// <value>Description of the equipment and engines installed in the boat. </value>
        [DataMember(Name="descOfEnginesEquip", EmitDefaultValue=false)]
        public string DescOfEnginesEquip { get; set; }

        /// <summary>
        /// Description of the boat bull and engine log books. 
        /// </summary>
        /// <value>Description of the boat bull and engine log books. </value>
        [DataMember(Name="descOfLogBooks", EmitDefaultValue=false)]
        public string DescOfLogBooks { get; set; }

    }
}
