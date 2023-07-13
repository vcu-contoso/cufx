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
    /// Contains details about share and CD secured collateral types. 
    /// </summary>
    [DataContract]
    public partial class CollateralSavingsCDCollateral 
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
        /// The account number providing security for the loan. 
        /// </summary>
        /// <value>The account number providing security for the loan. </value>
        [DataMember(Name="accountNumber", EmitDefaultValue=false)]
        public string AccountNumber { get; set; }


        /// <summary>
        /// Checking account, i.e., checks can be written against the account. Money market accounts can be included here or in money markets.  Its up to the institution. Savings and club accounts.  This can optionally include CDs, but its up to the institution. Auto loans, etc. Loans that are NOT lines of credit or credit cards. Loan behind the credit card.  Note the actual card information in the card object. Loan that is a line of credit but NOT a credit card. Loan that is made in exchange for taking title of property. Investment accounts such as brokerage and this can optionally include CDs and/or money markets, but its up to the institution. This account is a special type of checking account connected to a pre-paid card. Other account type. Loan that is made in installments. Loan is typically unsecured. This enumeration is considered deprecated. Recommend using account type Loan and subAccount of Installment. Loan that is a made to a business organization. This enumeration is considered deprecated. Recommend using account type Loan and subAccount of Commercial. Line of Credit that is a made to a business organization. This enumeration is considered deprecated. Recommend using account type Loan and subAccount of CommercialLineOfCredit. A general ledger account of the financial institution. A loan account type that has not been prevously defined. This enumeration is considered deprecated. Recommend using account type loan and subAccount of OtherLoan. 
        /// </summary>
        /// <value>Checking account, i.e., checks can be written against the account. Money market accounts can be included here or in money markets.  Its up to the institution. Savings and club accounts.  This can optionally include CDs, but its up to the institution. Auto loans, etc. Loans that are NOT lines of credit or credit cards. Loan behind the credit card.  Note the actual card information in the card object. Loan that is a line of credit but NOT a credit card. Loan that is made in exchange for taking title of property. Investment accounts such as brokerage and this can optionally include CDs and/or money markets, but its up to the institution. This account is a special type of checking account connected to a pre-paid card. Other account type. Loan that is made in installments. Loan is typically unsecured. This enumeration is considered deprecated. Recommend using account type Loan and subAccount of Installment. Loan that is a made to a business organization. This enumeration is considered deprecated. Recommend using account type Loan and subAccount of Commercial. Line of Credit that is a made to a business organization. This enumeration is considered deprecated. Recommend using account type Loan and subAccount of CommercialLineOfCredit. A general ledger account of the financial institution. A loan account type that has not been prevously defined. This enumeration is considered deprecated. Recommend using account type loan and subAccount of OtherLoan. </value>
        [TypeConverter(typeof(CustomEnumConverter<AccountTypeEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum AccountTypeEnum
        {
            
            /// <summary>
            /// Enum CheckingEnum for Checking
            /// </summary>
            [EnumMember(Value = "Checking")]
            CheckingEnum = 1,
            
            /// <summary>
            /// Enum SavingsEnum for Savings
            /// </summary>
            [EnumMember(Value = "Savings")]
            SavingsEnum = 2,
            
            /// <summary>
            /// Enum LoanEnum for Loan
            /// </summary>
            [EnumMember(Value = "Loan")]
            LoanEnum = 3,
            
            /// <summary>
            /// Enum CreditCardEnum for CreditCard
            /// </summary>
            [EnumMember(Value = "CreditCard")]
            CreditCardEnum = 4,
            
            /// <summary>
            /// Enum LineOfCreditEnum for LineOfCredit
            /// </summary>
            [EnumMember(Value = "LineOfCredit")]
            LineOfCreditEnum = 5,
            
            /// <summary>
            /// Enum MortgageEnum for Mortgage
            /// </summary>
            [EnumMember(Value = "Mortgage")]
            MortgageEnum = 6,
            
            /// <summary>
            /// Enum InvestmentEnum for Investment
            /// </summary>
            [EnumMember(Value = "Investment")]
            InvestmentEnum = 7,
            
            /// <summary>
            /// Enum PrePaidCardEnum for PrePaidCard
            /// </summary>
            [EnumMember(Value = "PrePaidCard")]
            PrePaidCardEnum = 8,
            
            /// <summary>
            /// Enum OtherEnum for Other
            /// </summary>
            [EnumMember(Value = "Other")]
            OtherEnum = 9,
            
            /// <summary>
            /// Enum InstallmentEnum for Installment
            /// </summary>
            [EnumMember(Value = "Installment")]
            InstallmentEnum = 10,
            
            /// <summary>
            /// Enum CommercialLoanEnum for CommercialLoan
            /// </summary>
            [EnumMember(Value = "CommercialLoan")]
            CommercialLoanEnum = 11,
            
            /// <summary>
            /// Enum CommercialLineOfCreditEnum for CommercialLineOfCredit
            /// </summary>
            [EnumMember(Value = "CommercialLineOfCredit")]
            CommercialLineOfCreditEnum = 12,
            
            /// <summary>
            /// Enum GeneralLedgerEnum for GeneralLedger
            /// </summary>
            [EnumMember(Value = "GeneralLedger")]
            GeneralLedgerEnum = 13,
            
            /// <summary>
            /// Enum OtherLoanEnum for OtherLoan
            /// </summary>
            [EnumMember(Value = "OtherLoan")]
            OtherLoanEnum = 14
        }

        /// <summary>
        /// Checking account, i.e., checks can be written against the account. Money market accounts can be included here or in money markets.  Its up to the institution. Savings and club accounts.  This can optionally include CDs, but its up to the institution. Auto loans, etc. Loans that are NOT lines of credit or credit cards. Loan behind the credit card.  Note the actual card information in the card object. Loan that is a line of credit but NOT a credit card. Loan that is made in exchange for taking title of property. Investment accounts such as brokerage and this can optionally include CDs and/or money markets, but its up to the institution. This account is a special type of checking account connected to a pre-paid card. Other account type. Loan that is made in installments. Loan is typically unsecured. This enumeration is considered deprecated. Recommend using account type Loan and subAccount of Installment. Loan that is a made to a business organization. This enumeration is considered deprecated. Recommend using account type Loan and subAccount of Commercial. Line of Credit that is a made to a business organization. This enumeration is considered deprecated. Recommend using account type Loan and subAccount of CommercialLineOfCredit. A general ledger account of the financial institution. A loan account type that has not been prevously defined. This enumeration is considered deprecated. Recommend using account type loan and subAccount of OtherLoan. 
        /// </summary>
        /// <value>Checking account, i.e., checks can be written against the account. Money market accounts can be included here or in money markets.  Its up to the institution. Savings and club accounts.  This can optionally include CDs, but its up to the institution. Auto loans, etc. Loans that are NOT lines of credit or credit cards. Loan behind the credit card.  Note the actual card information in the card object. Loan that is a line of credit but NOT a credit card. Loan that is made in exchange for taking title of property. Investment accounts such as brokerage and this can optionally include CDs and/or money markets, but its up to the institution. This account is a special type of checking account connected to a pre-paid card. Other account type. Loan that is made in installments. Loan is typically unsecured. This enumeration is considered deprecated. Recommend using account type Loan and subAccount of Installment. Loan that is a made to a business organization. This enumeration is considered deprecated. Recommend using account type Loan and subAccount of Commercial. Line of Credit that is a made to a business organization. This enumeration is considered deprecated. Recommend using account type Loan and subAccount of CommercialLineOfCredit. A general ledger account of the financial institution. A loan account type that has not been prevously defined. This enumeration is considered deprecated. Recommend using account type loan and subAccount of OtherLoan. </value>
        [DataMember(Name="accountType", EmitDefaultValue=true)]
        public AccountTypeEnum AccountType { get; set; }

        /// <summary>
        /// The account subtype identifies the specific account type that the back end system will recognize. 
        /// </summary>
        /// <value>The account subtype identifies the specific account type that the back end system will recognize. </value>
        [DataMember(Name="accountSubType", EmitDefaultValue=false)]
        public string AccountSubType { get; set; }

        /// <summary>
        /// The face value of the account. 
        /// </summary>
        /// <value>The face value of the account. </value>
        [DataMember(Name="faceValue", EmitDefaultValue=false)]
        public string FaceValue { get; set; }

        /// <summary>
        /// The issuing or depository financial institution. 
        /// </summary>
        /// <value>The issuing or depository financial institution. </value>
        [DataMember(Name="issuerType", EmitDefaultValue=false)]
        public string IssuerType { get; set; }

        /// <summary>
        /// Indicates if there is physical evidence of the collateral that the lender can take into its possession (e.g. Passbook, Certificate of Deposit). 
        /// </summary>
        /// <value>Indicates if there is physical evidence of the collateral that the lender can take into its possession (e.g. Passbook, Certificate of Deposit). </value>
        [DataMember(Name="certified", EmitDefaultValue=true)]
        public bool Certified { get; set; }

        /// <summary>
        /// Gets or Sets PossessoryInterestRate
        /// </summary>
        [DataMember(Name="possessoryInterestRate", EmitDefaultValue=false)]
        public AccountAccountEscheatAmount PossessoryInterestRate { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public AccountAccountEscheatAmount Amount { get; set; }

        /// <summary>
        /// Percentage of the loan pledged. 
        /// </summary>
        /// <value>Percentage of the loan pledged. </value>
        [DataMember(Name="percentage", EmitDefaultValue=true)]
        public decimal Percentage { get; set; }

        /// <summary>
        /// The certificate number of the collateral account that is providing security for the loan. 
        /// </summary>
        /// <value>The certificate number of the collateral account that is providing security for the loan. </value>
        [DataMember(Name="certificateNumber", EmitDefaultValue=false)]
        public string CertificateNumber { get; set; }

    }
}
