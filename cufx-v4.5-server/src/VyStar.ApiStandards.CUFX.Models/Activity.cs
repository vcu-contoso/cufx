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
    /// General purpose definition describing physical or electronic activity. 
    /// </summary>
    [DataContract]
    public partial class Activity 
    {
        /// <summary>
        /// Gets or Sets ActivityId
        /// </summary>
        [DataMember(Name="activityId", EmitDefaultValue=false)]
        public ActivityActivityId ActivityId { get; set; }

        /// <summary>
        /// Previous activities that indicate what order the activities should be performed in. These activities should be completed prior to executing this activity. 
        /// </summary>
        /// <value>Previous activities that indicate what order the activities should be performed in. These activities should be completed prior to executing this activity. </value>
        [DataMember(Name="previousActivityId", EmitDefaultValue=false)]
        public string PreviousActivityId { get; set; }

        /// <summary>
        /// An external identifier or reference value used by a 3rd party repository. 
        /// </summary>
        /// <value>An external identifier or reference value used by a 3rd party repository. </value>
        [DataMember(Name="externalActivityId", EmitDefaultValue=false)]
        public string ExternalActivityId { get; set; }

        /// <summary>
        /// Gets or Sets ActivityRelatedTo
        /// </summary>
        [DataMember(Name="activityRelatedTo", EmitDefaultValue=false)]
        public ActivityActivityRelatedTo ActivityRelatedTo { get; set; }


        /// <summary>
        /// Status of the activity within request to indicate how the activity is progressing from a workflow standpoint. The activity is new and has not been handled by internal teams. The activity  has been allocated to a resource but no time has been spent on the activity. The activity is being actively being worked on. The activity is in progress but has stalled due to some issue. The details of why its being held up will be in the notes related to the request/activity. The activity has been completed. The activity has been cancelled. The activity is intentionally on hold. The details of why it is on hold will be in the notes related to the request/activity. 
        /// </summary>
        /// <value>Status of the activity within request to indicate how the activity is progressing from a workflow standpoint. The activity is new and has not been handled by internal teams. The activity  has been allocated to a resource but no time has been spent on the activity. The activity is being actively being worked on. The activity is in progress but has stalled due to some issue. The details of why its being held up will be in the notes related to the request/activity. The activity has been completed. The activity has been cancelled. The activity is intentionally on hold. The details of why it is on hold will be in the notes related to the request/activity. </value>
        [TypeConverter(typeof(CustomEnumConverter<ActivityStatusEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ActivityStatusEnum
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
            /// Enum InProgressActiveEnum for InProgressActive
            /// </summary>
            [EnumMember(Value = "InProgressActive")]
            InProgressActiveEnum = 3,
            
            /// <summary>
            /// Enum InProgressInactiveEnum for InProgressInactive
            /// </summary>
            [EnumMember(Value = "InProgressInactive")]
            InProgressInactiveEnum = 4,
            
            /// <summary>
            /// Enum CompletedEnum for Completed
            /// </summary>
            [EnumMember(Value = "Completed")]
            CompletedEnum = 5,
            
            /// <summary>
            /// Enum CancelledEnum for Cancelled
            /// </summary>
            [EnumMember(Value = "Cancelled")]
            CancelledEnum = 6,
            
            /// <summary>
            /// Enum OnHoldEnum for OnHold
            /// </summary>
            [EnumMember(Value = "OnHold")]
            OnHoldEnum = 7
        }

        /// <summary>
        /// Status of the activity within request to indicate how the activity is progressing from a workflow standpoint. The activity is new and has not been handled by internal teams. The activity  has been allocated to a resource but no time has been spent on the activity. The activity is being actively being worked on. The activity is in progress but has stalled due to some issue. The details of why its being held up will be in the notes related to the request/activity. The activity has been completed. The activity has been cancelled. The activity is intentionally on hold. The details of why it is on hold will be in the notes related to the request/activity. 
        /// </summary>
        /// <value>Status of the activity within request to indicate how the activity is progressing from a workflow standpoint. The activity is new and has not been handled by internal teams. The activity  has been allocated to a resource but no time has been spent on the activity. The activity is being actively being worked on. The activity is in progress but has stalled due to some issue. The details of why its being held up will be in the notes related to the request/activity. The activity has been completed. The activity has been cancelled. The activity is intentionally on hold. The details of why it is on hold will be in the notes related to the request/activity. </value>
        [DataMember(Name="activityStatus", EmitDefaultValue=true)]
        public ActivityStatusEnum ActivityStatus { get; set; }

        /// <summary>
        /// The MIME type of the activity.  See RFC 2046 for valid MIME type. 
        /// </summary>
        /// <value>The MIME type of the activity.  See RFC 2046 for valid MIME type. </value>
        [DataMember(Name="activityType", EmitDefaultValue=false)]
        public string ActivityType { get; set; }

        /// <summary>
        /// A human-readable name of the activity, for example Order checks, Ship checks, etc. 
        /// </summary>
        /// <value>A human-readable name of the activity, for example Order checks, Ship checks, etc. </value>
        [DataMember(Name="activityName", EmitDefaultValue=false)]
        public string ActivityName { get; set; }

        /// <summary>
        /// A human-readable short text describing the activity. 
        /// </summary>
        /// <value>A human-readable short text describing the activity. </value>
        [DataMember(Name="activityShortDescription", EmitDefaultValue=false)]
        public string ActivityShortDescription { get; set; }

        /// <summary>
        /// A human-readable long text describing the activity. 
        /// </summary>
        /// <value>A human-readable long text describing the activity. </value>
        [DataMember(Name="activityDescription", EmitDefaultValue=false)]
        public string ActivityDescription { get; set; }

        /// <summary>
        /// Gets or Sets ActivityFieldImpactedList
        /// </summary>
        [DataMember(Name="activityFieldImpactedList", EmitDefaultValue=false)]
        public ActivityActivityFieldImpactedList ActivityFieldImpactedList { get; set; }

        /// <summary>
        /// A human-readable string describing the owner of the activity. Name or ID of person, system, etc. that created the activity. 
        /// </summary>
        /// <value>A human-readable string describing the owner of the activity. Name or ID of person, system, etc. that created the activity. </value>
        [DataMember(Name="creator", EmitDefaultValue=false)]
        public string Creator { get; set; }

        /// <summary>
        /// Gets or Sets ActivityNoteList
        /// </summary>
        [DataMember(Name="activityNoteList", EmitDefaultValue=false)]
        public AccountAccountNoteList ActivityNoteList { get; set; }

        /// <summary>
        /// Gets or Sets CredentialTypesRequiredList
        /// </summary>
        [DataMember(Name="credentialTypesRequiredList", EmitDefaultValue=false)]
        public ActivityCredentialTypesRequiredList CredentialTypesRequiredList { get; set; }

        /// <summary>
        /// Gets or Sets CredentialsProvidedList
        /// </summary>
        [DataMember(Name="credentialsProvidedList", EmitDefaultValue=false)]
        public ActivityCredentialsProvidedList CredentialsProvidedList { get; set; }

        /// <summary>
        /// UTC date and time when activity occurred. The date/time should be ISO 8601 UTC format: yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. 
        /// </summary>
        /// <value>UTC date and time when activity occurred. The date/time should be ISO 8601 UTC format: yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. </value>
        [DataMember(Name="activityDateTime", EmitDefaultValue=false)]
        public string ActivityDateTime { get; set; }

        /// <summary>
        /// Gets or Sets ActivityAmount
        /// </summary>
        [DataMember(Name="activityAmount", EmitDefaultValue=false)]
        public AccountAccountEscheatAmount ActivityAmount { get; set; }

        /// <summary>
        /// UTC date and time when activity was created. The date/time should be ISO 8601 UTC format: yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. 
        /// </summary>
        /// <value>UTC date and time when activity was created. The date/time should be ISO 8601 UTC format: yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. </value>
        [DataMember(Name="activityCreationDateTime", EmitDefaultValue=false)]
        public string ActivityCreationDateTime { get; set; }

        /// <summary>
        /// UTC date and time when the activity was modified. The date/time should be ISO 8601 UTC format: yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. 
        /// </summary>
        /// <value>UTC date and time when the activity was modified. The date/time should be ISO 8601 UTC format: yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. </value>
        [DataMember(Name="activityModifiedDateTime", EmitDefaultValue=false)]
        public string ActivityModifiedDateTime { get; set; }

        /// <summary>
        /// UTC date and time when activity was requested.  In most cases this will be the same as the create date unless this activity was subsequently added. The date/time should be ISO 8601 UTC format: yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. 
        /// </summary>
        /// <value>UTC date and time when activity was requested.  In most cases this will be the same as the create date unless this activity was subsequently added. The date/time should be ISO 8601 UTC format: yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. </value>
        [DataMember(Name="activityRequestedDateTime", EmitDefaultValue=false)]
        public string ActivityRequestedDateTime { get; set; }

        /// <summary>
        /// UTC date and time when activity is due. The date/time should be ISO 8601 UTC format: yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. 
        /// </summary>
        /// <value>UTC date and time when activity is due. The date/time should be ISO 8601 UTC format: yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. </value>
        [DataMember(Name="activityDueDateTime", EmitDefaultValue=false)]
        public string ActivityDueDateTime { get; set; }

        /// <summary>
        /// UTC date and time when activity was started. The date/time should be ISO 8601 UTC format: yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. 
        /// </summary>
        /// <value>UTC date and time when activity was started. The date/time should be ISO 8601 UTC format: yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. </value>
        [DataMember(Name="activityStartDateTime", EmitDefaultValue=false)]
        public string ActivityStartDateTime { get; set; }

        /// <summary>
        /// UTC date and time when activity completed. The date/time should be ISO 8601 UTC format: yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. 
        /// </summary>
        /// <value>UTC date and time when activity completed. The date/time should be ISO 8601 UTC format: yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. </value>
        [DataMember(Name="activityCompletedDateTime", EmitDefaultValue=false)]
        public string ActivityCompletedDateTime { get; set; }

        /// <summary>
        /// UTC date and time when the activity was archived. The date/time should be ISO 8601 UTC format: yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. 
        /// </summary>
        /// <value>UTC date and time when the activity was archived. The date/time should be ISO 8601 UTC format: yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. </value>
        [DataMember(Name="activityArchivedDatetime", EmitDefaultValue=false)]
        public string ActivityArchivedDatetime { get; set; }

        /// <summary>
        /// UTC date and time when the activity was deleted. The date/time should be ISO 8601 UTC format: yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. 
        /// </summary>
        /// <value>UTC date and time when the activity was deleted. The date/time should be ISO 8601 UTC format: yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. </value>
        [DataMember(Name="activityDeletedDateTime", EmitDefaultValue=false)]
        public string ActivityDeletedDateTime { get; set; }

        /// <summary>
        /// IP Address string 
        /// </summary>
        /// <value>IP Address string </value>
        [DataMember(Name="activityIpAddress", EmitDefaultValue=false)]
        public string ActivityIpAddress { get; set; }

        /// <summary>
        /// A flag used to determine if the activity is scheduled or not. May be used as part of the filter request. 
        /// </summary>
        /// <value>A flag used to determine if the activity is scheduled or not. May be used as part of the filter request. </value>
        [DataMember(Name="activityScheduled", EmitDefaultValue=true)]
        public bool ActivityScheduled { get; set; }

        /// <summary>
        /// Gets or Sets ActivityCustomData
        /// </summary>
        [DataMember(Name="activityCustomData", EmitDefaultValue=false)]
        public AccessProfileCustomData ActivityCustomData { get; set; }

    }
}
