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
    /// Standard definition for money values to include both the value and the currency. Currency defaults to USD (United States $) if not specified. 
    /// </summary>
    [DataContract]
    public partial class MicroDeposit 
    {
        /// <summary>
        /// Unique id of the micro deposit. 
        /// </summary>
        /// <value>Unique id of the micro deposit. </value>
        [DataMember(Name="microDepositId", EmitDefaultValue=false)]
        public string MicroDepositId { get; set; }

        /// <summary>
        /// Gets or Sets MicroDepositAmount
        /// </summary>
        [DataMember(Name="microDepositAmount", EmitDefaultValue=false)]
        public AccountAccountEscheatAmount MicroDepositAmount { get; set; }

        /// <summary>
        /// Confirmation code for the microdeposit. As each microdeposit is processed independently a seperate response is possible for each occurence of the value and currency code pair. 
        /// </summary>
        /// <value>Confirmation code for the microdeposit. As each microdeposit is processed independently a seperate response is possible for each occurence of the value and currency code pair. </value>
        [DataMember(Name="microDepositConfirmationCode", EmitDefaultValue=false)]
        public string MicroDepositConfirmationCode { get; set; }

    }
}