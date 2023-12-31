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
    public partial class DepositPartyDepositPartyRelationshipTypeAgent 
    {

        /// <summary>
        /// Party acts on behalf of the account holder or borrower. If this is at the relationship level, they can manage all deposits and loans within the relationship. Party acting on behalf of the trust account based on a trust agreement. If this is at the relationship level, the party can manage all deposits and loans within the relationship. Party acting on behalf of the account holder or borrower based on a power of attorney letter. Party which can deposit government checks on behalf of the deposit account holder. If this is at the relationship level, they can deposit government checks in any of the deposits within the relationship. Party reported to government for CTR transactions on behalf of the account holder or borrower. Party is attorney-in-fact managing an account for a client. If this is at the relationship level, the party can manage all deposits and loans within the relationship. Party that is the adult caretaker of a Coverdell ESA deposit account. Typically this is the parent of the beneficiary upon distribution. Party with signature capability on the deposit or loan. If this is at the relationship level, the party has signature capability on all deposits and loans within the relationship. Depending on the loan arrangement, the authorized signer may be liable for the loan. Investment Company that is managing the investment on behalf of the investment account holder. 
        /// </summary>
        /// <value>Party acts on behalf of the account holder or borrower. If this is at the relationship level, they can manage all deposits and loans within the relationship. Party acting on behalf of the trust account based on a trust agreement. If this is at the relationship level, the party can manage all deposits and loans within the relationship. Party acting on behalf of the account holder or borrower based on a power of attorney letter. Party which can deposit government checks on behalf of the deposit account holder. If this is at the relationship level, they can deposit government checks in any of the deposits within the relationship. Party reported to government for CTR transactions on behalf of the account holder or borrower. Party is attorney-in-fact managing an account for a client. If this is at the relationship level, the party can manage all deposits and loans within the relationship. Party that is the adult caretaker of a Coverdell ESA deposit account. Typically this is the parent of the beneficiary upon distribution. Party with signature capability on the deposit or loan. If this is at the relationship level, the party has signature capability on all deposits and loans within the relationship. Depending on the loan arrangement, the authorized signer may be liable for the loan. Investment Company that is managing the investment on behalf of the investment account holder. </value>
        [TypeConverter(typeof(CustomEnumConverter<QualifierEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum QualifierEnum
        {
            
            /// <summary>
            /// Enum CustodianEnum for Custodian
            /// </summary>
            [EnumMember(Value = "Custodian")]
            CustodianEnum = 1,
            
            /// <summary>
            /// Enum TrusteeEnum for Trustee
            /// </summary>
            [EnumMember(Value = "Trustee")]
            TrusteeEnum = 2,
            
            /// <summary>
            /// Enum PowerOfAttorneyEnum for PowerOfAttorney
            /// </summary>
            [EnumMember(Value = "PowerOfAttorney")]
            PowerOfAttorneyEnum = 3,
            
            /// <summary>
            /// Enum RepresentativeEnum for Representative
            /// </summary>
            [EnumMember(Value = "Representative")]
            RepresentativeEnum = 4,
            
            /// <summary>
            /// Enum CtrTransactorEnum for CtrTransactor
            /// </summary>
            [EnumMember(Value = "CtrTransactor")]
            CtrTransactorEnum = 5,
            
            /// <summary>
            /// Enum AttorneyTrustEnum for AttorneyTrust
            /// </summary>
            [EnumMember(Value = "AttorneyTrust")]
            AttorneyTrustEnum = 6,
            
            /// <summary>
            /// Enum ResponsibleIndividualEnum for ResponsibleIndividual
            /// </summary>
            [EnumMember(Value = "ResponsibleIndividual")]
            ResponsibleIndividualEnum = 7,
            
            /// <summary>
            /// Enum SignerEnum for Signer
            /// </summary>
            [EnumMember(Value = "Signer")]
            SignerEnum = 8,
            
            /// <summary>
            /// Enum InvestmentCompanyEnum for InvestmentCompany
            /// </summary>
            [EnumMember(Value = "InvestmentCompany")]
            InvestmentCompanyEnum = 9
        }

        /// <summary>
        /// Party acts on behalf of the account holder or borrower. If this is at the relationship level, they can manage all deposits and loans within the relationship. Party acting on behalf of the trust account based on a trust agreement. If this is at the relationship level, the party can manage all deposits and loans within the relationship. Party acting on behalf of the account holder or borrower based on a power of attorney letter. Party which can deposit government checks on behalf of the deposit account holder. If this is at the relationship level, they can deposit government checks in any of the deposits within the relationship. Party reported to government for CTR transactions on behalf of the account holder or borrower. Party is attorney-in-fact managing an account for a client. If this is at the relationship level, the party can manage all deposits and loans within the relationship. Party that is the adult caretaker of a Coverdell ESA deposit account. Typically this is the parent of the beneficiary upon distribution. Party with signature capability on the deposit or loan. If this is at the relationship level, the party has signature capability on all deposits and loans within the relationship. Depending on the loan arrangement, the authorized signer may be liable for the loan. Investment Company that is managing the investment on behalf of the investment account holder. 
        /// </summary>
        /// <value>Party acts on behalf of the account holder or borrower. If this is at the relationship level, they can manage all deposits and loans within the relationship. Party acting on behalf of the trust account based on a trust agreement. If this is at the relationship level, the party can manage all deposits and loans within the relationship. Party acting on behalf of the account holder or borrower based on a power of attorney letter. Party which can deposit government checks on behalf of the deposit account holder. If this is at the relationship level, they can deposit government checks in any of the deposits within the relationship. Party reported to government for CTR transactions on behalf of the account holder or borrower. Party is attorney-in-fact managing an account for a client. If this is at the relationship level, the party can manage all deposits and loans within the relationship. Party that is the adult caretaker of a Coverdell ESA deposit account. Typically this is the parent of the beneficiary upon distribution. Party with signature capability on the deposit or loan. If this is at the relationship level, the party has signature capability on all deposits and loans within the relationship. Depending on the loan arrangement, the authorized signer may be liable for the loan. Investment Company that is managing the investment on behalf of the investment account holder. </value>
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

    }
}
