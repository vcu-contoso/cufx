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
    /// The product service request object defines all the fields necessary to define that an existing or potential party is interested in a particular product or service. The product service request can migrate through several statuses as the product service request progresses. To enroll in a product or service please see Application.xsd or ProductServiceEnrollment.xsd. 
    /// </summary>
    [DataContract]
    public partial class ProductServiceRequest 
    {
        /// <summary>
        /// The product service request ID is a persistent and unique identifier for the product service request.  It should be unique for all product service requests across the institution and remain the same over the life of the product service request within the financial institution. 
        /// </summary>
        /// <value>The product service request ID is a persistent and unique identifier for the product service request.  It should be unique for all product service requests across the institution and remain the same over the life of the product service request within the financial institution. </value>
        [DataMember(Name="productServiceRequestId", EmitDefaultValue=false)]
        public string ProductServiceRequestId { get; set; }

        /// <summary>
        /// Gets or Sets RequestList
        /// </summary>
        [DataMember(Name="requestList", EmitDefaultValue=false)]
        public ProductServiceRequestRequestList RequestList { get; set; }

        /// <summary>
        /// What channel did this product service request originate from, for example but not limited to website, new member application, walk up, partner web site, business development, marketing, etc. 
        /// </summary>
        /// <value>What channel did this product service request originate from, for example but not limited to website, new member application, walk up, partner web site, business development, marketing, etc. </value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }


        /// <summary>
        /// Status of the product service request to indicate how the product service request is progressing from a workflow standpoint. The product service request is new and has not been handled by internal teams. The product service request has been allocated to a resource to get back to the party. The internal resource has contacted the product service request and is negotiating with the party. The internal resource has proposed a product or service to the party and is waiting on an answer from the party. The party has tentatively accepted the proposal but has not officially committed to the offer. The party has accepted the proposal and committed to the offer. The process is complete for the product service request. The party has rejected the proposal and is not interested in further proposals.  The process is complete for the product service request. Some other status not covered above. 
        /// </summary>
        /// <value>Status of the product service request to indicate how the product service request is progressing from a workflow standpoint. The product service request is new and has not been handled by internal teams. The product service request has been allocated to a resource to get back to the party. The internal resource has contacted the product service request and is negotiating with the party. The internal resource has proposed a product or service to the party and is waiting on an answer from the party. The party has tentatively accepted the proposal but has not officially committed to the offer. The party has accepted the proposal and committed to the offer. The process is complete for the product service request. The party has rejected the proposal and is not interested in further proposals.  The process is complete for the product service request. Some other status not covered above. </value>
        [TypeConverter(typeof(CustomEnumConverter<StatusEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum NewEnum for New
            /// </summary>
            [EnumMember(Value = "New")]
            NewEnum = 1,
            
            /// <summary>
            /// Enum AssignedEnum for Assigned
            /// </summary>
            [EnumMember(Value = "Assigned")]
            AssignedEnum = 2,
            
            /// <summary>
            /// Enum InDiscussionEnum for InDiscussion
            /// </summary>
            [EnumMember(Value = "InDiscussion")]
            InDiscussionEnum = 3,
            
            /// <summary>
            /// Enum InProposalEnum for InProposal
            /// </summary>
            [EnumMember(Value = "InProposal")]
            InProposalEnum = 4,
            
            /// <summary>
            /// Enum VerbalCommitmentEnum for VerbalCommitment
            /// </summary>
            [EnumMember(Value = "VerbalCommitment")]
            VerbalCommitmentEnum = 5,
            
            /// <summary>
            /// Enum ConvertedEnum for Converted
            /// </summary>
            [EnumMember(Value = "Converted")]
            ConvertedEnum = 6,
            
            /// <summary>
            /// Enum LostEnum for Lost
            /// </summary>
            [EnumMember(Value = "Lost")]
            LostEnum = 7,
            
            /// <summary>
            /// Enum OtherEnum for Other
            /// </summary>
            [EnumMember(Value = "Other")]
            OtherEnum = 8
        }

        /// <summary>
        /// Status of the product service request to indicate how the product service request is progressing from a workflow standpoint. The product service request is new and has not been handled by internal teams. The product service request has been allocated to a resource to get back to the party. The internal resource has contacted the product service request and is negotiating with the party. The internal resource has proposed a product or service to the party and is waiting on an answer from the party. The party has tentatively accepted the proposal but has not officially committed to the offer. The party has accepted the proposal and committed to the offer. The process is complete for the product service request. The party has rejected the proposal and is not interested in further proposals.  The process is complete for the product service request. Some other status not covered above. 
        /// </summary>
        /// <value>Status of the product service request to indicate how the product service request is progressing from a workflow standpoint. The product service request is new and has not been handled by internal teams. The product service request has been allocated to a resource to get back to the party. The internal resource has contacted the product service request and is negotiating with the party. The internal resource has proposed a product or service to the party and is waiting on an answer from the party. The party has tentatively accepted the proposal but has not officially committed to the offer. The party has accepted the proposal and committed to the offer. The process is complete for the product service request. The party has rejected the proposal and is not interested in further proposals.  The process is complete for the product service request. Some other status not covered above. </value>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public StatusEnum Status { get; set; }

        /// <summary>
        /// The UTC date/time that the product service request was created in the system.  The date/time should be ISO 8601 UTC format: yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. 
        /// </summary>
        /// <value>The UTC date/time that the product service request was created in the system.  The date/time should be ISO 8601 UTC format: yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. </value>
        [DataMember(Name="createDateTime", EmitDefaultValue=false)]
        public string CreateDateTime { get; set; }

        /// <summary>
        /// Gets or Sets ProductServiceRequestRelatedTo
        /// </summary>
        [DataMember(Name="productServiceRequestRelatedTo", EmitDefaultValue=false)]
        public ActivityActivityRelatedTo ProductServiceRequestRelatedTo { get; set; }

        /// <summary>
        /// Gets or Sets ProductServiceRequestNoteList
        /// </summary>
        [DataMember(Name="productServiceRequestNoteList", EmitDefaultValue=false)]
        public AccountAccountNoteList ProductServiceRequestNoteList { get; set; }

        /// <summary>
        /// Gets or Sets ProductServiceRequestCustomData
        /// </summary>
        [DataMember(Name="productServiceRequestCustomData", EmitDefaultValue=false)]
        public AccessProfileCustomData ProductServiceRequestCustomData { get; set; }

    }
}