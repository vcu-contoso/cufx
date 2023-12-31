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
    public partial class NetworkNodeFilter 
    {
        /// <summary>
        /// Gets or Sets NetworkIdList
        /// </summary>
        [DataMember(Name="networkIdList", EmitDefaultValue=false)]
        public NetworkNodeFilterNetworkIdList NetworkIdList { get; set; }

        /// <summary>
        /// Gets or Sets NetworkNodeIdList
        /// </summary>
        [DataMember(Name="networkNodeIdList", EmitDefaultValue=false)]
        public ConfigurationFilterNetworkNodeAddressIdList NetworkNodeIdList { get; set; }

        /// <summary>
        /// Gets or Sets NetworkNodeStatusList
        /// </summary>
        [DataMember(Name="networkNodeStatusList", EmitDefaultValue=false)]
        public NetworkNodeFilterNetworkNodeStatusList NetworkNodeStatusList { get; set; }

        /// <summary>
        /// Gets or Sets NetworkNodeTypeList
        /// </summary>
        [DataMember(Name="networkNodeTypeList", EmitDefaultValue=false)]
        public NetworkNodeFilterNetworkNodeTypeList NetworkNodeTypeList { get; set; }

        /// <summary>
        /// Gets or Sets NetworkNodeAddressIdList
        /// </summary>
        [DataMember(Name="networkNodeAddressIdList", EmitDefaultValue=false)]
        public NetworkNodeFilterNetworkNodeAddressIdList NetworkNodeAddressIdList { get; set; }

        /// <summary>
        /// Gets or Sets NetworkNodeAddressValueList
        /// </summary>
        [DataMember(Name="networkNodeAddressValueList", EmitDefaultValue=false)]
        public NetworkNodeFilterNetworkNodeAddressValueList NetworkNodeAddressValueList { get; set; }

        /// <summary>
        /// The network node scope of the address property based on standard IPV4 and IPV6 conventions is local. 
        /// </summary>
        /// <value>The network node scope of the address property based on standard IPV4 and IPV6 conventions is local. </value>
        [DataMember(Name="networkNodeAddressScopeIsLocal", EmitDefaultValue=true)]
        public bool NetworkNodeAddressScopeIsLocal { get; set; }

        /// <summary>
        /// Gets or Sets NetworkNodeAddressTypeList
        /// </summary>
        [DataMember(Name="networkNodeAddressTypeList", EmitDefaultValue=false)]
        public NetworkNodeFilterNetworkNodeAddressTypeList NetworkNodeAddressTypeList { get; set; }

        /// <summary>
        /// Gets or Sets NetworkNodeAddressPortList
        /// </summary>
        [DataMember(Name="networkNodeAddressPortList", EmitDefaultValue=false)]
        public NetworkNodeFilterNetworkNodeAddressPortList NetworkNodeAddressPortList { get; set; }

        /// <summary>
        /// Gets or Sets CustomData
        /// </summary>
        [DataMember(Name="customData", EmitDefaultValue=false)]
        public AccessProfileCustomData CustomData { get; set; }

    }
}
