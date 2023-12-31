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
    /// The list of filter options for configuration data. 
    /// </summary>
    [DataContract]
    public partial class ConfigurationFilter 
    {
        /// <summary>
        /// Gets or Sets ConfigurationIdList
        /// </summary>
        [DataMember(Name="configurationIdList", EmitDefaultValue=false)]
        public ConfigurationFilterConfigurationIdList ConfigurationIdList { get; set; }

        /// <summary>
        /// Gets or Sets ConfigurationNameList
        /// </summary>
        [DataMember(Name="configurationNameList", EmitDefaultValue=false)]
        public ConfigurationFilterConfigurationNameList ConfigurationNameList { get; set; }

        /// <summary>
        /// Gets or Sets EnvironmentList
        /// </summary>
        [DataMember(Name="environmentList", EmitDefaultValue=false)]
        public ConfigurationFilterEnvironmentList EnvironmentList { get; set; }

        /// <summary>
        /// Gets or Sets ConfigurationStatusList
        /// </summary>
        [DataMember(Name="configurationStatusList", EmitDefaultValue=false)]
        public ConfigurationFilterConfigurationStatusList ConfigurationStatusList { get; set; }

        /// <summary>
        /// Gets or Sets ConfigurationCreatedDateRange
        /// </summary>
        [DataMember(Name="configurationCreatedDateRange", EmitDefaultValue=false)]
        public AccessProfileFilterCreateAccessDateRange ConfigurationCreatedDateRange { get; set; }

        /// <summary>
        /// Gets or Sets ConfigurationCreatedByList
        /// </summary>
        [DataMember(Name="configurationCreatedByList", EmitDefaultValue=false)]
        public ConfigurationFilterConfigurationCreatedByList ConfigurationCreatedByList { get; set; }

        /// <summary>
        /// Gets or Sets ConfigurationUpdatedDateRange
        /// </summary>
        [DataMember(Name="configurationUpdatedDateRange", EmitDefaultValue=false)]
        public AccessProfileFilterCreateAccessDateRange ConfigurationUpdatedDateRange { get; set; }

        /// <summary>
        /// Gets or Sets ConfigurationLastUpdatedByList
        /// </summary>
        [DataMember(Name="configurationLastUpdatedByList", EmitDefaultValue=false)]
        public ConfigurationFilterConfigurationLastUpdatedByList ConfigurationLastUpdatedByList { get; set; }

        /// <summary>
        /// Gets or Sets FiIdList
        /// </summary>
        [DataMember(Name="fiIdList", EmitDefaultValue=false)]
        public ConfigurationFilterFiIdList FiIdList { get; set; }

        /// <summary>
        /// Gets or Sets ConfigurationFiIdList
        /// </summary>
        [DataMember(Name="configurationFiIdList", EmitDefaultValue=false)]
        public ConfigurationFilterConfigurationFiIdList ConfigurationFiIdList { get; set; }

        /// <summary>
        /// Gets or Sets ConfigurationFiVendorIdList
        /// </summary>
        [DataMember(Name="configurationFiVendorIdList", EmitDefaultValue=false)]
        public ConfigurationFilterConfigurationFiVendorIdList ConfigurationFiVendorIdList { get; set; }

        /// <summary>
        /// Gets or Sets VendorIdList
        /// </summary>
        [DataMember(Name="vendorIdList", EmitDefaultValue=false)]
        public AppFilterVendorIdList VendorIdList { get; set; }

        /// <summary>
        /// Gets or Sets ServiceList
        /// </summary>
        [DataMember(Name="serviceList", EmitDefaultValue=false)]
        public ConfigurationServiceList ServiceList { get; set; }

        /// <summary>
        /// Gets or Sets MethodIdList
        /// </summary>
        [DataMember(Name="methodIdList", EmitDefaultValue=false)]
        public ConfigurationFilterMethodIdList MethodIdList { get; set; }

        /// <summary>
        /// Gets or Sets MethodDependencyIdList
        /// </summary>
        [DataMember(Name="methodDependencyIdList", EmitDefaultValue=false)]
        public ConfigurationFilterMethodDependencyIdList MethodDependencyIdList { get; set; }

        /// <summary>
        /// Gets or Sets ConfigurationAppIdList
        /// </summary>
        [DataMember(Name="configurationAppIdList", EmitDefaultValue=false)]
        public ConfigurationFilterConfigurationAppIdList ConfigurationAppIdList { get; set; }

        /// <summary>
        /// Gets or Sets AppIdList
        /// </summary>
        [DataMember(Name="appIdList", EmitDefaultValue=false)]
        public AppFilterAppIdList AppIdList { get; set; }

        /// <summary>
        /// Gets or Sets ConfigurationAppParameterIdList
        /// </summary>
        [DataMember(Name="configurationAppParameterIdList", EmitDefaultValue=false)]
        public ConfigurationFilterConfigurationAppParameterIdList ConfigurationAppParameterIdList { get; set; }

        /// <summary>
        /// Gets or Sets AppParameterIdList
        /// </summary>
        [DataMember(Name="appParameterIdList", EmitDefaultValue=false)]
        public AppFilterAppParameterIdList AppParameterIdList { get; set; }

        /// <summary>
        /// Gets or Sets ParameterNameList
        /// </summary>
        [DataMember(Name="parameterNameList", EmitDefaultValue=false)]
        public AppFilterParameterNameList ParameterNameList { get; set; }

        /// <summary>
        /// Gets or Sets ConfigurationFiAppIdList
        /// </summary>
        [DataMember(Name="configurationFiAppIdList", EmitDefaultValue=false)]
        public ConfigurationFilterConfigurationFiAppIdList ConfigurationFiAppIdList { get; set; }

        /// <summary>
        /// Gets or Sets ConfigurationFiAppParameterIdList
        /// </summary>
        [DataMember(Name="configurationFiAppParameterIdList", EmitDefaultValue=false)]
        public ConfigurationFilterConfigurationFiAppParameterIdList ConfigurationFiAppParameterIdList { get; set; }

        /// <summary>
        /// Gets or Sets ConfigurationNetworkNodeAddressIdList
        /// </summary>
        [DataMember(Name="configurationNetworkNodeAddressIdList", EmitDefaultValue=false)]
        public ConfigurationFilterConfigurationNetworkNodeAddressIdList ConfigurationNetworkNodeAddressIdList { get; set; }

        /// <summary>
        /// Gets or Sets NetworkNodeAddressIdList
        /// </summary>
        [DataMember(Name="networkNodeAddressIdList", EmitDefaultValue=false)]
        public ConfigurationFilterNetworkNodeAddressIdList NetworkNodeAddressIdList { get; set; }

        /// <summary>
        /// Gets or Sets NetworkNodeIdList
        /// </summary>
        [DataMember(Name="networkNodeIdList", EmitDefaultValue=false)]
        public ConfigurationFilterNetworkNodeAddressIdList NetworkNodeIdList { get; set; }

        /// <summary>
        /// Gets or Sets CustomData
        /// </summary>
        [DataMember(Name="customData", EmitDefaultValue=false)]
        public AccessProfileCustomData CustomData { get; set; }

    }
}
