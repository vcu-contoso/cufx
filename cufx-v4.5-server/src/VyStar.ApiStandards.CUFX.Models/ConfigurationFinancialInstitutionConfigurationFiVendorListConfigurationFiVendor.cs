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
    public partial class ConfigurationFinancialInstitutionConfigurationFiVendorListConfigurationFiVendor 
    {
        /// <summary>
        /// The unique identifier for the configuration and financial institution and vendor. 
        /// </summary>
        /// <value>The unique identifier for the configuration and financial institution and vendor. </value>
        [DataMember(Name="configurationFiVendorId", EmitDefaultValue=false)]
        public string ConfigurationFiVendorId { get; set; }

        /// <summary>
        /// The vendor ID is a unique identifier which identifies the vendor that is creating a message. The vendor ID is assigned by the FI or established in concert by the vendor and FI. The client application sends this along with the messages so that logging or other business may take place based on the vendor utilizing the service. This ID is not generated per data or security request but is generated \&quot;out-of-band\&quot; (i.e. prior generation by some external mechanism) of this process and stored in the Financial Institutions and Vendorâ€™s systems. A standard error will be returned if the vendor ID is not provided when it is required. 
        /// </summary>
        /// <value>The vendor ID is a unique identifier which identifies the vendor that is creating a message. The vendor ID is assigned by the FI or established in concert by the vendor and FI. The client application sends this along with the messages so that logging or other business may take place based on the vendor utilizing the service. This ID is not generated per data or security request but is generated \&quot;out-of-band\&quot; (i.e. prior generation by some external mechanism) of this process and stored in the Financial Institutions and Vendorâ€™s systems. A standard error will be returned if the vendor ID is not provided when it is required. </value>
        [DataMember(Name="vendorId", EmitDefaultValue=false)]
        public string VendorId { get; set; }

        /// <summary>
        /// The party ID is a persistent and unique identifier for the party not related to the accounts they own but tied to that person or organization. It should be unique for all parties across the institution and remain the same over the life of the relationship with the financial institution. 
        /// </summary>
        /// <value>The party ID is a persistent and unique identifier for the party not related to the accounts they own but tied to that person or organization. It should be unique for all parties across the institution and remain the same over the life of the relationship with the financial institution. </value>
        [DataMember(Name="partyId", EmitDefaultValue=false)]
        public string PartyId { get; set; }

        /// <summary>
        /// Gets or Sets CustomData
        /// </summary>
        [DataMember(Name="customData", EmitDefaultValue=false)]
        public AccessProfileCustomData CustomData { get; set; }

    }
}
