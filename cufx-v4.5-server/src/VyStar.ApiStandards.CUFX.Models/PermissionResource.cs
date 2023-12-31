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
    /// The account, user, or other securable asset that the action applies to.  Intended choice - Due to cross language serialization issues the choice construct has been removed. It is the responsibility of the implementer to add programmatic logic for this complex type to detect, handle and or error when population of more than one element is present. 
    /// </summary>
    [DataContract]
    public partial class PermissionResource 
    {
        /// <summary>
        /// The account ID is a persistent and unique identifier for the account. It must be unique for all users across the institution and remain the same over the life of the account. 
        /// </summary>
        /// <value>The account ID is a persistent and unique identifier for the account. It must be unique for all users across the institution and remain the same over the life of the account. </value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// FiUserId is a unique identifier for the credential group and is readable by the person. The person types this into systems to gain access, also using their password, PIN or whatever else is required to gain access. 
        /// </summary>
        /// <value>FiUserId is a unique identifier for the credential group and is readable by the person. The person types this into systems to gain access, also using their password, PIN or whatever else is required to gain access. </value>
        [DataMember(Name="fiUserId", EmitDefaultValue=false)]
        public string FiUserId { get; set; }

        /// <summary>
        /// The card ID is a persistent and unique identifier for the card. It must be unique for all users across the institution and remain the same over the life of the card. The card ID should not be the same as the card number embossed on the card. 
        /// </summary>
        /// <value>The card ID is a persistent and unique identifier for the card. It must be unique for all users across the institution and remain the same over the life of the card. The card ID should not be the same as the card number embossed on the card. </value>
        [DataMember(Name="cardId", EmitDefaultValue=false)]
        public string CardId { get; set; }

        /// <summary>
        /// The relationship ID is a persistent and unique identifier for the relationship. It should be unique for all relationships across the institution and remain the same over the life of the relationship with the financial institution. 
        /// </summary>
        /// <value>The relationship ID is a persistent and unique identifier for the relationship. It should be unique for all relationships across the institution and remain the same over the life of the relationship with the financial institution. </value>
        [DataMember(Name="relationshipId", EmitDefaultValue=false)]
        public string RelationshipId { get; set; }

        /// <summary>
        /// Product ID is a unique identifier for the product. 
        /// </summary>
        /// <value>Product ID is a unique identifier for the product. </value>
        [DataMember(Name="productId", EmitDefaultValue=false)]
        public string ProductId { get; set; }

    }
}
