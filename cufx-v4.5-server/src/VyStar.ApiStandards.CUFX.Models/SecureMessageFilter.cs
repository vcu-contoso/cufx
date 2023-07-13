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
    /// The list of filter options for services requesting secure message data.  The options can be used in combination or by themselves.  It is up to the data source to either return or affect the data requested or return a standard error identifying why the request was rejected. 
    /// </summary>
    [DataContract]
    public partial class SecureMessageFilter 
    {
        /// <summary>
        /// Gets or Sets SecureMessageIdList
        /// </summary>
        [DataMember(Name="secureMessageIdList", EmitDefaultValue=false)]
        public ProductServiceRequestFilterSecureMessageIdList SecureMessageIdList { get; set; }

        /// <summary>
        /// Gets or Sets ThreadIdList
        /// </summary>
        [DataMember(Name="threadIdList", EmitDefaultValue=false)]
        public SecureMessageFilterThreadIdList ThreadIdList { get; set; }

        /// <summary>
        /// Gets or Sets SubjectLineContainsList
        /// </summary>
        [DataMember(Name="subjectLineContainsList", EmitDefaultValue=false)]
        public SecureMessageFilterSubjectLineContainsList SubjectLineContainsList { get; set; }

        /// <summary>
        /// Gets or Sets MessageFromList
        /// </summary>
        [DataMember(Name="messageFromList", EmitDefaultValue=false)]
        public SecureMessageMessageFromList MessageFromList { get; set; }

        /// <summary>
        /// Gets or Sets MessageToList
        /// </summary>
        [DataMember(Name="messageToList", EmitDefaultValue=false)]
        public SecureMessageMessageFromList MessageToList { get; set; }

        /// <summary>
        /// Gets or Sets CarbonCopyList
        /// </summary>
        [DataMember(Name="carbonCopyList", EmitDefaultValue=false)]
        public SecureMessageMessageFromList CarbonCopyList { get; set; }

        /// <summary>
        /// Gets or Sets BlindCarbonCopyList
        /// </summary>
        [DataMember(Name="blindCarbonCopyList", EmitDefaultValue=false)]
        public SecureMessageMessageFromList BlindCarbonCopyList { get; set; }

        /// <summary>
        /// Gets or Sets ReplyToList
        /// </summary>
        [DataMember(Name="replyToList", EmitDefaultValue=false)]
        public SecureMessageMessageFromList ReplyToList { get; set; }

        /// <summary>
        /// Gets or Sets SecureMessageTypeList
        /// </summary>
        [DataMember(Name="secureMessageTypeList", EmitDefaultValue=false)]
        public SecureMessageFilterSecureMessageTypeList SecureMessageTypeList { get; set; }

        /// <summary>
        /// Gets or Sets CurrentStatusList
        /// </summary>
        [DataMember(Name="currentStatusList", EmitDefaultValue=false)]
        public SecureMessageFilterCurrentStatusList CurrentStatusList { get; set; }

        /// <summary>
        /// Gets or Sets StatusLogList
        /// </summary>
        [DataMember(Name="statusLogList", EmitDefaultValue=false)]
        public SecureMessageFilterCurrentStatusList StatusLogList { get; set; }

        /// <summary>
        /// Gets or Sets StatusLogDateRange
        /// </summary>
        [DataMember(Name="statusLogDateRange", EmitDefaultValue=false)]
        public AccessProfileFilterCreateAccessDateRange StatusLogDateRange { get; set; }

        /// <summary>
        /// Gets or Sets BodyContainsList
        /// </summary>
        [DataMember(Name="bodyContainsList", EmitDefaultValue=false)]
        public SecureMessageFilterBodyContainsList BodyContainsList { get; set; }

        /// <summary>
        /// If true, all previous messages linked to the messages that matched the search criteria, if available, will be returned.  Based on previousSecureMessageId. 
        /// </summary>
        /// <value>If true, all previous messages linked to the messages that matched the search criteria, if available, will be returned.  Based on previousSecureMessageId. </value>
        [DataMember(Name="returnConversation", EmitDefaultValue=true)]
        public bool ReturnConversation { get; set; }

        /// <summary>
        /// Gets or Sets DocumentIDList
        /// </summary>
        [DataMember(Name="documentIDList", EmitDefaultValue=false)]
        public DocumentFilterDocumentIdList DocumentIDList { get; set; }

        /// <summary>
        /// Gets or Sets ProductServiceRequestIDList
        /// </summary>
        [DataMember(Name="productServiceRequestIDList", EmitDefaultValue=false)]
        public FieldFilterProductServiceRequestIdList ProductServiceRequestIDList { get; set; }

        /// <summary>
        /// Gets or Sets CustomData
        /// </summary>
        [DataMember(Name="customData", EmitDefaultValue=false)]
        public AccessProfileCustomData CustomData { get; set; }

    }
}