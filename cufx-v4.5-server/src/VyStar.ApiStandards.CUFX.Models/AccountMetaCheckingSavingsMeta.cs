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
    public partial class AccountMetaCheckingSavingsMeta 
    {
        /// <summary>
        /// Annual percentage yield. Is a normalized representation of an interest rate, based on a compounding period of one year. Value is formatted as a percentile. A passed value of 4.5 is equivalent to 0.045 actual. 4.500 may be displayed as 4.500% or 4.5% depending on the user interface. Decimals available: 999.999 
        /// </summary>
        /// <value>Annual percentage yield. Is a normalized representation of an interest rate, based on a compounding period of one year. Value is formatted as a percentile. A passed value of 4.5 is equivalent to 0.045 actual. 4.500 may be displayed as 4.500% or 4.5% depending on the user interface. Decimals available: 999.999 </value>
        [DataMember(Name="annualPercentageYield", EmitDefaultValue=true)]
        public decimal AnnualPercentageYield { get; set; }

        /// <summary>
        /// True if the account is enrolled in overdraft protection 
        /// </summary>
        /// <value>True if the account is enrolled in overdraft protection </value>
        [DataMember(Name="overDraftProtectionEnabled", EmitDefaultValue=true)]
        public bool OverDraftProtectionEnabled { get; set; }

        /// <summary>
        /// Gets or Sets OverDraftFeesYtd
        /// </summary>
        [DataMember(Name="overDraftFeesYtd", EmitDefaultValue=false)]
        public AccountAccountEscheatAmount OverDraftFeesYtd { get; set; }

        /// <summary>
        /// Gets or Sets YtdInsufficientFundsFees
        /// </summary>
        [DataMember(Name="ytdInsufficientFundsFees", EmitDefaultValue=false)]
        public AccountAccountEscheatAmount YtdInsufficientFundsFees { get; set; }

        /// <summary>
        /// Gets or Sets MtdInsufficientFundsFees
        /// </summary>
        [DataMember(Name="mtdInsufficientFundsFees", EmitDefaultValue=false)]
        public AccountAccountEscheatAmount MtdInsufficientFundsFees { get; set; }

        /// <summary>
        /// Gets or Sets YtdInterestEarned
        /// </summary>
        [DataMember(Name="ytdInterestEarned", EmitDefaultValue=false)]
        public AccountAccountEscheatAmount YtdInterestEarned { get; set; }

        /// <summary>
        /// Gets or Sets PreviousYtdInterestEarned
        /// </summary>
        [DataMember(Name="previousYtdInterestEarned", EmitDefaultValue=false)]
        public AccountAccountEscheatAmount PreviousYtdInterestEarned { get; set; }

        /// <summary>
        /// This is the date of the last interest/dividends posted to the account. The date should be ISO 8601 format yyyy-mm-dd (2011-03-28). 
        /// </summary>
        /// <value>This is the date of the last interest/dividends posted to the account. The date should be ISO 8601 format yyyy-mm-dd (2011-03-28). </value>
        [DataMember(Name="lastInterestEarnedDate", EmitDefaultValue=false)]
        public DateTime LastInterestEarnedDate { get; set; }

        /// <summary>
        /// Gets or Sets LastInterestEarnedAmount
        /// </summary>
        [DataMember(Name="lastInterestEarnedAmount", EmitDefaultValue=false)]
        public AccountAccountEscheatAmount LastInterestEarnedAmount { get; set; }

        /// <summary>
        /// The date of the most recent statement The date should be ISO 8601 format yyyy-mm-dd (2011-03-28). 
        /// </summary>
        /// <value>The date of the most recent statement The date should be ISO 8601 format yyyy-mm-dd (2011-03-28). </value>
        [DataMember(Name="lastStatementDate", EmitDefaultValue=false)]
        public DateTime LastStatementDate { get; set; }

        /// <summary>
        /// The date of the previous statment The date should be ISO 8601 format yyyy-mm-dd (2011-03-28). 
        /// </summary>
        /// <value>The date of the previous statment The date should be ISO 8601 format yyyy-mm-dd (2011-03-28). </value>
        [DataMember(Name="previousStatementDate", EmitDefaultValue=false)]
        public DateTime PreviousStatementDate { get; set; }

        /// <summary>
        /// The date of the most recent transaction. The date should be ISO 8601 format yyyy-mm-dd (2011-03-28). 
        /// </summary>
        /// <value>The date of the most recent transaction. The date should be ISO 8601 format yyyy-mm-dd (2011-03-28). </value>
        [DataMember(Name="lastTransactionDate", EmitDefaultValue=false)]
        public DateTime LastTransactionDate { get; set; }

        /// <summary>
        /// Interest Rate earned by the investment. Determines the amount earned each time period based on the period. Value is formatted as a percentile. A passed value of 4.5 is equivalent to 0.045 actual. 4.500 may be displayed as 4.500% or 4.5% depending on the user interface. Decimals available: 999.999 
        /// </summary>
        /// <value>Interest Rate earned by the investment. Determines the amount earned each time period based on the period. Value is formatted as a percentile. A passed value of 4.5 is equivalent to 0.045 actual. 4.500 may be displayed as 4.500% or 4.5% depending on the user interface. Decimals available: 999.999 </value>
        [DataMember(Name="interestRate", EmitDefaultValue=true)]
        public decimal InterestRate { get; set; }

        /// <summary>
        /// Gets or Sets OriginalBalance
        /// </summary>
        [DataMember(Name="originalBalance", EmitDefaultValue=false)]
        public AccountAccountEscheatAmount OriginalBalance { get; set; }

    }
}