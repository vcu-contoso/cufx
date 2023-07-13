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
    /// A check disbursement would be used to produce a check with the given payee for the given amount. The check would draw from the funds of the new loan.  The host system is expected to calculate the check number and print out the check. 
    /// </summary>
    [DataContract]
    public partial class LoanDisbursementLoanDisbursementCheck 
    {
        /// <summary>
        /// Unique identifier for this loan disbursement record. This should be a globally unique identifier, meaning it should be unique across all loans, not just this loan. 
        /// </summary>
        /// <value>Unique identifier for this loan disbursement record. This should be a globally unique identifier, meaning it should be unique across all loans, not just this loan. </value>
        [DataMember(Name="loanDisbursementId", EmitDefaultValue=false)]
        public string LoanDisbursementId { get; set; }

        /// <summary>
        /// The amount of this disbursement.  This is a required field. 
        /// </summary>
        /// <value>The amount of this disbursement.  This is a required field. </value>
        [DataMember(Name="amount", EmitDefaultValue=true)]
        public decimal Amount { get; set; }

        /// <summary>
        /// A description of this disbursement.  This is for informative purposes and is optional. 
        /// </summary>
        /// <value>A description of this disbursement.  This is for informative purposes and is optional. </value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// An optional comment that would be created on the host system corresponding to this transaction.  An example comment is: Disbursement from loan 1234-L10. 
        /// </summary>
        /// <value>An optional comment that would be created on the host system corresponding to this transaction.  An example comment is: Disbursement from loan 1234-L10. </value>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// A check can have up to 3 payee lines printed on the check.  You need at least one payee line, otherwise the check cannot be printed. 
        /// </summary>
        /// <value>A check can have up to 3 payee lines printed on the check.  You need at least one payee line, otherwise the check cannot be printed. </value>
        [DataMember(Name="payeeLines", EmitDefaultValue=false)]
        public string PayeeLines { get; set; }

    }
}
