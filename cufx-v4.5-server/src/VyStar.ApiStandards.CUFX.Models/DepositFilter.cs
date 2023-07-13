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
    /// The list of filter options for services requesting deposit account or deposit account detail data. The options can be used in combination or by themselves.  It is up to the data source to either return or affect the data requested or return a standard error identifying why the request was rejected. 
    /// </summary>
    [DataContract]
    public partial class DepositFilter 
    {
        /// <summary>
        /// Gets or Sets AccountIdList
        /// </summary>
        [DataMember(Name="accountIdList", EmitDefaultValue=false)]
        public AccountFilterAccountIdList AccountIdList { get; set; }

        /// <summary>
        /// Gets or Sets AccountStatusList
        /// </summary>
        [DataMember(Name="accountStatusList", EmitDefaultValue=false)]
        public AccountFilterAccountStatusList AccountStatusList { get; set; }

        /// <summary>
        /// Gets or Sets PartyIdList
        /// </summary>
        [DataMember(Name="partyIdList", EmitDefaultValue=false)]
        public AccountPartyIdList PartyIdList { get; set; }

        /// <summary>
        /// Gets or Sets RelationshipIdList
        /// </summary>
        [DataMember(Name="relationshipIdList", EmitDefaultValue=false)]
        public AccountFilterRelationshipIdList RelationshipIdList { get; set; }

        /// <summary>
        /// Gets or Sets AccountTypeList
        /// </summary>
        [DataMember(Name="accountTypeList", EmitDefaultValue=false)]
        public AccountFilterAccountTypeList AccountTypeList { get; set; }

        /// <summary>
        /// If this is not provided, it returns all accounts regardless of whether they are internal or external. If it is provided and its true, it returns only external accounts; if its false, it returns only internal accounts. 
        /// </summary>
        /// <value>If this is not provided, it returns all accounts regardless of whether they are internal or external. If it is provided and its true, it returns only external accounts; if its false, it returns only internal accounts. </value>
        [DataMember(Name="externalAccountFlag", EmitDefaultValue=true)]
        public bool ExternalAccountFlag { get; set; }

        /// <summary>
        /// If this is not provided, it will not return notes. If it is provided and its true, it will return all active non-expired notes. 
        /// </summary>
        /// <value>If this is not provided, it will not return notes. If it is provided and its true, it will return all active non-expired notes. </value>
        [DataMember(Name="includeNotesFlag", EmitDefaultValue=true)]
        public bool IncludeNotesFlag { get; set; }

        /// <summary>
        /// Gets or Sets TransactionDateRange
        /// </summary>
        [DataMember(Name="transactionDateRange", EmitDefaultValue=false)]
        public AccessProfileFilterCreateAccessDateRange TransactionDateRange { get; set; }

        /// <summary>
        /// Gets or Sets AccountMicrList
        /// </summary>
        [DataMember(Name="accountMicrList", EmitDefaultValue=false)]
        public AccountFilterAccountMicrList AccountMicrList { get; set; }

        /// <summary>
        /// Gets or Sets CustomData
        /// </summary>
        [DataMember(Name="customData", EmitDefaultValue=false)]
        public AccessProfileCustomData CustomData { get; set; }

        /// <summary>
        /// Gets or Sets AccountIdentificationList
        /// </summary>
        [DataMember(Name="accountIdentificationList", EmitDefaultValue=false)]
        public AccountFilterAccountIdentificationList AccountIdentificationList { get; set; }

        /// <summary>
        /// Filter that is used to search the account maturity dates. Usage see common.xsd DateRange. 
        /// </summary>
        /// <value>Filter that is used to search the account maturity dates. Usage see common.xsd DateRange. </value>
        [DataMember(Name="maturityDateRange", EmitDefaultValue=false)]
        public List<DateRange> MaturityDateRange { get; set; }

    }
}
