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
    /// This returns the status of the system, commonly used for online systems attempting to determine if the system is available for real-time transactions. 
    /// </summary>
    [DataContract]
    public partial class SystemState 
    {
        /// <summary>
        /// The name of the system within the financial institution that is providing the status. 
        /// </summary>
        /// <value>The name of the system within the financial institution that is providing the status. </value>
        [DataMember(Name="systemName", EmitDefaultValue=false)]
        public string SystemName { get; set; }

        /// <summary>
        /// The identification value of the system within the financial institution that is providing the status. 
        /// </summary>
        /// <value>The identification value of the system within the financial institution that is providing the status. </value>
        [DataMember(Name="systemId", EmitDefaultValue=false)]
        public string SystemId { get; set; }


        /// <summary>
        /// Current status of the system, i.e. online, offline, etc. \"Online\" implies the system is available for subsequent requests. \"Offline\" implies the system is not available for subsequent requests. \"MemoPost\" implies that a subset of features is available. For example, the host system may be in MemoPost mode and accept transactions that are processed at a later time. Examples of such features are: intra-CU transfers and stop pay. Examples of features that may not be available during MemoPost are: loan application and change security settings. These examples are provided for demonstration purposes only; the exact feature list will vary depending on each implementation. 
        /// </summary>
        /// <value>Current status of the system, i.e. online, offline, etc. \"Online\" implies the system is available for subsequent requests. \"Offline\" implies the system is not available for subsequent requests. \"MemoPost\" implies that a subset of features is available. For example, the host system may be in MemoPost mode and accept transactions that are processed at a later time. Examples of such features are: intra-CU transfers and stop pay. Examples of features that may not be available during MemoPost are: loan application and change security settings. These examples are provided for demonstration purposes only; the exact feature list will vary depending on each implementation. </value>
        [TypeConverter(typeof(CustomEnumConverter<SystemStatusEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum SystemStatusEnum
        {
            
            /// <summary>
            /// Enum OnlineEnum for Online
            /// </summary>
            [EnumMember(Value = "Online")]
            OnlineEnum = 1,
            
            /// <summary>
            /// Enum OfflineEnum for Offline
            /// </summary>
            [EnumMember(Value = "Offline")]
            OfflineEnum = 2,
            
            /// <summary>
            /// Enum MemoPostEnum for MemoPost
            /// </summary>
            [EnumMember(Value = "MemoPost")]
            MemoPostEnum = 3
        }

        /// <summary>
        /// Current status of the system, i.e. online, offline, etc. \&quot;Online\&quot; implies the system is available for subsequent requests. \&quot;Offline\&quot; implies the system is not available for subsequent requests. \&quot;MemoPost\&quot; implies that a subset of features is available. For example, the host system may be in MemoPost mode and accept transactions that are processed at a later time. Examples of such features are: intra-CU transfers and stop pay. Examples of features that may not be available during MemoPost are: loan application and change security settings. These examples are provided for demonstration purposes only; the exact feature list will vary depending on each implementation. 
        /// </summary>
        /// <value>Current status of the system, i.e. online, offline, etc. \&quot;Online\&quot; implies the system is available for subsequent requests. \&quot;Offline\&quot; implies the system is not available for subsequent requests. \&quot;MemoPost\&quot; implies that a subset of features is available. For example, the host system may be in MemoPost mode and accept transactions that are processed at a later time. Examples of such features are: intra-CU transfers and stop pay. Examples of features that may not be available during MemoPost are: loan application and change security settings. These examples are provided for demonstration purposes only; the exact feature list will vary depending on each implementation. </value>
        [DataMember(Name="systemStatus", EmitDefaultValue=true)]
        public SystemStatusEnum SystemStatus { get; set; }

        /// <summary>
        /// Description of the system. 
        /// </summary>
        /// <value>Description of the system. </value>
        [DataMember(Name="systemDescription", EmitDefaultValue=false)]
        public string SystemDescription { get; set; }

        /// <summary>
        /// Is the current day a business day. 
        /// </summary>
        /// <value>Is the current day a business day. </value>
        [DataMember(Name="isBusinessDay", EmitDefaultValue=true)]
        public bool IsBusinessDay { get; set; }

        /// <summary>
        /// The next business date past the current date. 
        /// </summary>
        /// <value>The next business date past the current date. </value>
        [DataMember(Name="nextBusinessDate", EmitDefaultValue=false)]
        public DateTime NextBusinessDate { get; set; }

        /// <summary>
        /// The previous business date from the current date. 
        /// </summary>
        /// <value>The previous business date from the current date. </value>
        [DataMember(Name="previousBusinessDate", EmitDefaultValue=false)]
        public DateTime PreviousBusinessDate { get; set; }

        /// <summary>
        /// The current posting date of the system. 
        /// </summary>
        /// <value>The current posting date of the system. </value>
        [DataMember(Name="postingDate", EmitDefaultValue=false)]
        public DateTime PostingDate { get; set; }

        /// <summary>
        /// The dateTime of the next system cut off. The date/time should be ISO 8601 UTC format.  yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. 
        /// </summary>
        /// <value>The dateTime of the next system cut off. The date/time should be ISO 8601 UTC format.  yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. </value>
        [DataMember(Name="systemCutOffDateTime", EmitDefaultValue=false)]
        public string SystemCutOffDateTime { get; set; }

        /// <summary>
        /// Gets or Sets SystemStatusCustomData
        /// </summary>
        [DataMember(Name="systemStatusCustomData", EmitDefaultValue=false)]
        public AccessProfileCustomData SystemStatusCustomData { get; set; }

    }
}
