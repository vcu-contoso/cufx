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
    /// Contains Details about Real Estate collateral types.  Examples are: 1-4 Family; Multi-Family; Commercial; Land. 
    /// </summary>
    [DataContract]
    public partial class CollateralRealEstateCollateral 
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
        /// The property tax identification number for the real estate property. 
        /// </summary>
        /// <value>The property tax identification number for the real estate property. </value>
        [DataMember(Name="taxId", EmitDefaultValue=false)]
        public string TaxId { get; set; }

        /// <summary>
        /// The parcel number for the real estate property. 
        /// </summary>
        /// <value>The parcel number for the real estate property. </value>
        [DataMember(Name="parcelIDNNumber", EmitDefaultValue=false)]
        public string ParcelIDNNumber { get; set; }

        /// <summary>
        /// The section ID for the real estate property. 
        /// </summary>
        /// <value>The section ID for the real estate property. </value>
        [DataMember(Name="section", EmitDefaultValue=false)]
        public string Section { get; set; }

        /// <summary>
        /// The block ID for the real estate property. 
        /// </summary>
        /// <value>The block ID for the real estate property. </value>
        [DataMember(Name="block", EmitDefaultValue=false)]
        public string Block { get; set; }

        /// <summary>
        /// The lot ID for the real estate property. 
        /// </summary>
        /// <value>The lot ID for the real estate property. </value>
        [DataMember(Name="lot", EmitDefaultValue=false)]
        public string Lot { get; set; }

        /// <summary>
        /// Indicates that the loan is the first lien on the real estate property. 
        /// </summary>
        /// <value>Indicates that the loan is the first lien on the real estate property. </value>
        [DataMember(Name="firstLien", EmitDefaultValue=true)]
        public bool FirstLien { get; set; }

        /// <summary>
        /// Indicates that the real estate property is serving as collateral for other existing loans. 
        /// </summary>
        /// <value>Indicates that the real estate property is serving as collateral for other existing loans. </value>
        [DataMember(Name="existingLiens", EmitDefaultValue=true)]
        public bool ExistingLiens { get; set; }

        /// <summary>
        /// Indicates that the real estate property is being used as a dwelling. 
        /// </summary>
        /// <value>Indicates that the real estate property is being used as a dwelling. </value>
        [DataMember(Name="dwelling", EmitDefaultValue=true)]
        public bool Dwelling { get; set; }

        /// <summary>
        /// The number of family living units contained in the real estate property. 
        /// </summary>
        /// <value>The number of family living units contained in the real estate property. </value>
        [DataMember(Name="numberOfUnits", EmitDefaultValue=true)]
        public float NumberOfUnits { get; set; }

        /// <summary>
        /// Indicates that the real estate property is or will be occupied by the owner. 
        /// </summary>
        /// <value>Indicates that the real estate property is or will be occupied by the owner. </value>
        [DataMember(Name="ownerOccupied", EmitDefaultValue=true)]
        public bool OwnerOccupied { get; set; }

        /// <summary>
        /// Indicates that the real estate property is the principal dwelling for the owner. 
        /// </summary>
        /// <value>Indicates that the real estate property is the principal dwelling for the owner. </value>
        [DataMember(Name="principalDwelling", EmitDefaultValue=true)]
        public bool PrincipalDwelling { get; set; }

        /// <summary>
        /// Indicates that the loan is assumable. 
        /// </summary>
        /// <value>Indicates that the loan is assumable. </value>
        [DataMember(Name="assumable", EmitDefaultValue=true)]
        public bool Assumable { get; set; }

        /// <summary>
        /// Indicates that the real estate property includes a manufactured home. 
        /// </summary>
        /// <value>Indicates that the real estate property includes a manufactured home. </value>
        [DataMember(Name="manufacturedHousing", EmitDefaultValue=true)]
        public bool ManufacturedHousing { get; set; }

        /// <summary>
        /// Indicates that the real estate property is or will be under construction. 
        /// </summary>
        /// <value>Indicates that the real estate property is or will be under construction. </value>
        [DataMember(Name="construction", EmitDefaultValue=true)]
        public bool Construction { get; set; }

        /// <summary>
        /// The year in which the real estate structure was built. 
        /// </summary>
        /// <value>The year in which the real estate structure was built. </value>
        [DataMember(Name="yearBuilt", EmitDefaultValue=true)]
        public float YearBuilt { get; set; }

        /// <summary>
        /// Indicates that the real estate property is a condominium or a planned unit development. 
        /// </summary>
        /// <value>Indicates that the real estate property is a condominium or a planned unit development. </value>
        [DataMember(Name="condoPUD", EmitDefaultValue=true)]
        public bool CondoPUD { get; set; }

        /// <summary>
        /// The legal description of the real estate property. 
        /// </summary>
        /// <value>The legal description of the real estate property. </value>
        [DataMember(Name="legalDescription", EmitDefaultValue=false)]
        public string LegalDescription { get; set; }

        /// <summary>
        /// Indicates that the real estate property is used as a rental property. 
        /// </summary>
        /// <value>Indicates that the real estate property is used as a rental property. </value>
        [DataMember(Name="rentalProperty", EmitDefaultValue=true)]
        public bool RentalProperty { get; set; }

        /// <summary>
        /// The year that the owner first acquired the real estate property, if currently owned. 
        /// </summary>
        /// <value>The year that the owner first acquired the real estate property, if currently owned. </value>
        [DataMember(Name="yearAcquired", EmitDefaultValue=false)]
        public string YearAcquired { get; set; }

        /// <summary>
        /// Gets or Sets OriginalCost
        /// </summary>
        [DataMember(Name="originalCost", EmitDefaultValue=false)]
        public AccountAccountEscheatAmount OriginalCost { get; set; }

        /// <summary>
        /// Gets or Sets PresentValue
        /// </summary>
        [DataMember(Name="presentValue", EmitDefaultValue=false)]
        public AccountAccountEscheatAmount PresentValue { get; set; }

        /// <summary>
        /// Gets or Sets Improvements
        /// </summary>
        [DataMember(Name="improvements", EmitDefaultValue=false)]
        public AccountAccountEscheatAmount Improvements { get; set; }

        /// <summary>
        /// Indicates that the real estate property is a timeshare. 
        /// </summary>
        /// <value>Indicates that the real estate property is a timeshare. </value>
        [DataMember(Name="timeshare", EmitDefaultValue=true)]
        public bool Timeshare { get; set; }

    }
}
