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
    /// The list of filter options for services requesting billPayee data. The options can be used in combination or by themselves. It is up to the data source to either return or affect the data requested or return a standard error identifying why the request was rejected. 
    /// </summary>
    [DataContract]
    public partial class BillPayeeFilter 
    {
        /// <summary>
        /// Gets or Sets BillPayeeGlobalIdList
        /// </summary>
        [DataMember(Name="billPayeeGlobalIdList", EmitDefaultValue=false)]
        public BillPayeeFilterBillPayeeGlobalIdList BillPayeeGlobalIdList { get; set; }

        /// <summary>
        /// Gets or Sets BillPayeeIdList
        /// </summary>
        [DataMember(Name="billPayeeIdList", EmitDefaultValue=false)]
        public BillFilterBillFromPayeeIdList BillPayeeIdList { get; set; }

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
        /// If a person, the first and last name of the person. If a business or trust, will include the business or trust name. 
        /// </summary>
        /// <value>If a person, the first and last name of the person. If a business or trust, will include the business or trust name. </value>
        [DataMember(Name="payeeName", EmitDefaultValue=false)]
        public string PayeeName { get; set; }

        /// <summary>
        /// True for electronic processing. False for sending a paper check. 
        /// </summary>
        /// <value>True for electronic processing. False for sending a paper check. </value>
        [DataMember(Name="isElectronic", EmitDefaultValue=true)]
        public bool IsElectronic { get; set; }

        /// <summary>
        /// The user-defined name for payee.  Could be a nickname. 
        /// </summary>
        /// <value>The user-defined name for payee.  Could be a nickname. </value>
        [DataMember(Name="userDefinedName", EmitDefaultValue=false)]
        public string UserDefinedName { get; set; }

        /// <summary>
        /// A member defined category that can be used for reporting purposes. 
        /// </summary>
        /// <value>A member defined category that can be used for reporting purposes. </value>
        [DataMember(Name="payeeCategory", EmitDefaultValue=false)]
        public string PayeeCategory { get; set; }

        /// <summary>
        /// Gets or Sets PayeeStatusList
        /// </summary>
        [DataMember(Name="payeeStatusList", EmitDefaultValue=false)]
        public BillPayeeFilterPayeeStatusList PayeeStatusList { get; set; }

        /// <summary>
        /// Gets or Sets EarlyPaymentDateRange
        /// </summary>
        [DataMember(Name="earlyPaymentDateRange", EmitDefaultValue=false)]
        public AccessProfileFilterCreateAccessDateRange EarlyPaymentDateRange { get; set; }

        /// <summary>
        /// Gets or Sets NextPaymenDateRange
        /// </summary>
        [DataMember(Name="nextPaymenDateRange", EmitDefaultValue=false)]
        public AccessProfileFilterCreateAccessDateRange NextPaymenDateRange { get; set; }

        /// <summary>
        /// Gets or Sets PayeeAddedDateRange
        /// </summary>
        [DataMember(Name="payeeAddedDateRange", EmitDefaultValue=false)]
        public AccessProfileFilterCreateAccessDateRange PayeeAddedDateRange { get; set; }

        /// <summary>
        /// Gets or Sets PayeeUpdatedDateRange
        /// </summary>
        [DataMember(Name="payeeUpdatedDateRange", EmitDefaultValue=false)]
        public AccessProfileFilterCreateAccessDateRange PayeeUpdatedDateRange { get; set; }

        /// <summary>
        /// Gets or Sets CustomData
        /// </summary>
        [DataMember(Name="customData", EmitDefaultValue=false)]
        public AccessProfileCustomData CustomData { get; set; }

        /// <summary>
        /// Gets or Sets EBillEnrollmentStatusList
        /// </summary>
        [DataMember(Name="eBillEnrollmentStatusList", EmitDefaultValue=false)]
        public BillPayeeFilterEBillEnrollmentStatusList EBillEnrollmentStatusList { get; set; }

        /// <summary>
        /// Gets or Sets AccountIdentificationList
        /// </summary>
        [DataMember(Name="accountIdentificationList", EmitDefaultValue=false)]
        public AccountFilterAccountIdentificationList AccountIdentificationList { get; set; }

    }
}
