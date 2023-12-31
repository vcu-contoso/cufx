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
    /// The list of options to filter wire transfers. 
    /// </summary>
    [DataContract]
    public partial class WireFilter 
    {
        /// <summary>
        /// Gets or Sets OccurrenceIdList
        /// </summary>
        [DataMember(Name="occurrenceIdList", EmitDefaultValue=false)]
        public BillPaymentFilterOccurrenceIdList OccurrenceIdList { get; set; }

        /// <summary>
        /// Gets or Sets RecurringIdList
        /// </summary>
        [DataMember(Name="recurringIdList", EmitDefaultValue=false)]
        public BillPaymentFilterRecurringIdList RecurringIdList { get; set; }

        /// <summary>
        /// Gets or Sets TransferCompletedDateRange
        /// </summary>
        [DataMember(Name="transferCompletedDateRange", EmitDefaultValue=false)]
        public AccessProfileFilterCreateAccessDateRange TransferCompletedDateRange { get; set; }

        /// <summary>
        /// Gets or Sets AccountIDList
        /// </summary>
        [DataMember(Name="accountIDList", EmitDefaultValue=false)]
        public AccountFilterAccountIdList AccountIDList { get; set; }

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
        /// Gets or Sets OccurrenceStatusList
        /// </summary>
        [DataMember(Name="occurrenceStatusList", EmitDefaultValue=false)]
        public BillPaymentFilterOccurrenceStatusList OccurrenceStatusList { get; set; }

        /// <summary>
        /// Gets or Sets RecurringStatusList
        /// </summary>
        [DataMember(Name="recurringStatusList", EmitDefaultValue=false)]
        public BillPaymentFilterRecurringStatusList RecurringStatusList { get; set; }

        /// <summary>
        /// Gets or Sets MinAmount
        /// </summary>
        [DataMember(Name="minAmount", EmitDefaultValue=false)]
        public AccountAccountEscheatAmount MinAmount { get; set; }

        /// <summary>
        /// Gets or Sets MaxAmount
        /// </summary>
        [DataMember(Name="maxAmount", EmitDefaultValue=false)]
        public AccountAccountEscheatAmount MaxAmount { get; set; }

        /// <summary>
        /// Gets or Sets BatchIdList
        /// </summary>
        [DataMember(Name="batchIdList", EmitDefaultValue=false)]
        public BillPaymentFilterBatchIdList BatchIdList { get; set; }

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
        /// If this is not provided, it will not return notes. If it is provided and its true, it will return all active non-expired notes. 
        /// </summary>
        /// <value>If this is not provided, it will not return notes. If it is provided and its true, it will return all active non-expired notes. </value>
        [DataMember(Name="includeNotesFlag", EmitDefaultValue=true)]
        public bool IncludeNotesFlag { get; set; }

        /// <summary>
        /// Gets or Sets WireTransferTypeList
        /// </summary>
        [DataMember(Name="wireTransferTypeList", EmitDefaultValue=false)]
        public WireFilterWireTransferTypeList WireTransferTypeList { get; set; }

        /// <summary>
        /// Wire filter for escrow number that should be returned or affected by a read, update or delete request. 
        /// </summary>
        /// <value>Wire filter for escrow number that should be returned or affected by a read, update or delete request. </value>
        [DataMember(Name="escrowNumber", EmitDefaultValue=false)]
        public string EscrowNumber { get; set; }

        /// <summary>
        /// Wire filter for escrow officer name that should be returned or affected by a read, update or delete request. 
        /// </summary>
        /// <value>Wire filter for escrow officer name that should be returned or affected by a read, update or delete request. </value>
        [DataMember(Name="escrowOfficerName", EmitDefaultValue=false)]
        public string EscrowOfficerName { get; set; }

        /// <summary>
        /// The account number portion of a draft or line of credit MICR line. 
        /// </summary>
        /// <value>The account number portion of a draft or line of credit MICR line. </value>
        [DataMember(Name="toAccountMicrAccountNumber", EmitDefaultValue=false)]
        public string ToAccountMicrAccountNumber { get; set; }

        /// <summary>
        /// Routing number for the destination account. See occurrenceToAccount. 
        /// </summary>
        /// <value>Routing number for the destination account. See occurrenceToAccount. </value>
        [DataMember(Name="toAccountRoutingNumber", EmitDefaultValue=false)]
        public string ToAccountRoutingNumber { get; set; }

        /// <summary>
        /// The account number portion of a draft or line of credit MICR line. 
        /// </summary>
        /// <value>The account number portion of a draft or line of credit MICR line. </value>
        [DataMember(Name="fromAccountMicrAccountNumber", EmitDefaultValue=false)]
        public string FromAccountMicrAccountNumber { get; set; }

        /// <summary>
        /// Routing number of the orgination account. See occurrenceFromAccount. 
        /// </summary>
        /// <value>Routing number of the orgination account. See occurrenceFromAccount. </value>
        [DataMember(Name="fromAccountRoutingNumber", EmitDefaultValue=false)]
        public string FromAccountRoutingNumber { get; set; }

        /// <summary>
        /// SWIFTCode for wire transfer. 
        /// </summary>
        /// <value>SWIFTCode for wire transfer. </value>
        [DataMember(Name="externalAccountSWIFTCode", EmitDefaultValue=false)]
        public string ExternalAccountSWIFTCode { get; set; }

        /// <summary>
        /// IBAN of external institution, used for wire transfers.  This replaces the micrAccountNumber for certain financial institutions in foreign nations, and no routing or SWIFT code is necessary when an IBAN (and potentially bank code, below) is provided to identify the account. 
        /// </summary>
        /// <value>IBAN of external institution, used for wire transfers.  This replaces the micrAccountNumber for certain financial institutions in foreign nations, and no routing or SWIFT code is necessary when an IBAN (and potentially bank code, below) is provided to identify the account. </value>
        [DataMember(Name="externalAccountIBANCode", EmitDefaultValue=false)]
        public string ExternalAccountIBANCode { get; set; }

        /// <summary>
        /// Bank code, required (in addiiton to other identitiers) for institutions in certain foreign nations, used for wire transfers. 
        /// </summary>
        /// <value>Bank code, required (in addiiton to other identitiers) for institutions in certain foreign nations, used for wire transfers. </value>
        [DataMember(Name="externalAccountBankCode", EmitDefaultValue=false)]
        public string ExternalAccountBankCode { get; set; }

    }
}
