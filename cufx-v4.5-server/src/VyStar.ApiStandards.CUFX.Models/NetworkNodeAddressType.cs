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
        /// The fourth version of the Internet Protocol (IP). It is one of the core protocols of standards-based internetworking methods in the Internet, and was the first version deployed for production in the ARPANET in 1983. https://en.wikipedia.org/wiki/IPv4 Most recent version of the Internet Protocol (IP), the communications protocol that provides an identification and location system for computers on networks and routes traffic across the Internet. https://en.wikipedia.org/wiki/IPv6 A media access control address (MAC address) of a device is a unique identifier assigned to network interface controllers for communications at the data link layer of a network segment. https://en.wikipedia.org/wiki/MAC_address A reference to a web resource that specifies its location on a computer network and a mechanism for retrieving it. https://en.wikipedia.org/wiki/URL A network node address type yet to be defined by the specification. 
        /// </summary>
        /// <value>The fourth version of the Internet Protocol (IP). It is one of the core protocols of standards-based internetworking methods in the Internet, and was the first version deployed for production in the ARPANET in 1983. https://en.wikipedia.org/wiki/IPv4 Most recent version of the Internet Protocol (IP), the communications protocol that provides an identification and location system for computers on networks and routes traffic across the Internet. https://en.wikipedia.org/wiki/IPv6 A media access control address (MAC address) of a device is a unique identifier assigned to network interface controllers for communications at the data link layer of a network segment. https://en.wikipedia.org/wiki/MAC_address A reference to a web resource that specifies its location on a computer network and a mechanism for retrieving it. https://en.wikipedia.org/wiki/URL A network node address type yet to be defined by the specification. </value>
        [TypeConverter(typeof(CustomEnumConverter<NetworkNodeAddressType>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NetworkNodeAddressType
        {
            
            /// <summary>
            /// Enum IPV4Enum for IPV4
            /// </summary>
            [EnumMember(Value = "IPV4")]
            IPV4Enum = 1,
            
            /// <summary>
            /// Enum IPV6Enum for IPV6
            /// </summary>
            [EnumMember(Value = "IPV6")]
            IPV6Enum = 2,
            
            /// <summary>
            /// Enum MACEnum for MAC
            /// </summary>
            [EnumMember(Value = "MAC")]
            MACEnum = 3,
            
            /// <summary>
            /// Enum URLEnum for URL
            /// </summary>
            [EnumMember(Value = "URL")]
            URLEnum = 4,
            
            /// <summary>
            /// Enum OtherEnum for Other
            /// </summary>
            [EnumMember(Value = "Other")]
            OtherEnum = 5
        }
}