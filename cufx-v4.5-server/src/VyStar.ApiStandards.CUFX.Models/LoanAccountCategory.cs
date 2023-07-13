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
        /// Gets or Sets LoanAccountCategory
        /// </summary>
        [TypeConverter(typeof(CustomEnumConverter<LoanAccountCategory>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum LoanAccountCategory
        {
            
            /// <summary>
            /// Enum AverageDailyBalanceLineOfCreditEnum for AverageDailyBalanceLineOfCredit
            /// </summary>
            [EnumMember(Value = "AverageDailyBalanceLineOfCredit")]
            AverageDailyBalanceLineOfCreditEnum = 1,
            
            /// <summary>
            /// Enum ClosedEndEnum for ClosedEnd
            /// </summary>
            [EnumMember(Value = "ClosedEnd")]
            ClosedEndEnum = 2,
            
            /// <summary>
            /// Enum CreditCardEnum for CreditCard
            /// </summary>
            [EnumMember(Value = "CreditCard")]
            CreditCardEnum = 3,
            
            /// <summary>
            /// Enum LeaseEnum for Lease
            /// </summary>
            [EnumMember(Value = "Lease")]
            LeaseEnum = 4,
            
            /// <summary>
            /// Enum LineOfCreditEnum for LineOfCredit
            /// </summary>
            [EnumMember(Value = "LineOfCredit")]
            LineOfCreditEnum = 5,
            
            /// <summary>
            /// Enum LineOfCreditCombinationEnum for LineOfCreditCombination
            /// </summary>
            [EnumMember(Value = "LineOfCreditCombination")]
            LineOfCreditCombinationEnum = 6,
            
            /// <summary>
            /// Enum OpenEndEnum for OpenEnd
            /// </summary>
            [EnumMember(Value = "OpenEnd")]
            OpenEndEnum = 7,
            
            /// <summary>
            /// Enum InstallmentEnum for Installment
            /// </summary>
            [EnumMember(Value = "Installment")]
            InstallmentEnum = 8,
            
            /// <summary>
            /// Enum CommercialEnum for Commercial
            /// </summary>
            [EnumMember(Value = "Commercial")]
            CommercialEnum = 9,
            
            /// <summary>
            /// Enum CommercialLineOfCreditEnum for CommercialLineOfCredit
            /// </summary>
            [EnumMember(Value = "CommercialLineOfCredit")]
            CommercialLineOfCreditEnum = 10,
            
            /// <summary>
            /// Enum MortgageEnum for Mortgage
            /// </summary>
            [EnumMember(Value = "Mortgage")]
            MortgageEnum = 11,
            
            /// <summary>
            /// Enum OtherLoanEnum for OtherLoan
            /// </summary>
            [EnumMember(Value = "OtherLoan")]
            OtherLoanEnum = 12
        }
}