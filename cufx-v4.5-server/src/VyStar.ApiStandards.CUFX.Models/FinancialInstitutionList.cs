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
    /// The master list of financial institutions available in the CUFX instance. A financial institution must be in a configuration list to have access to a specific set of data. 
    /// </summary>
    [DataContract]
    public partial class FinancialInstitutionList 
    {
        /// <summary>
        /// Pagination support. Current page of information presented in the message response. Typically used in combination with totalPages and pageSize. 
        /// </summary>
        /// <value>Pagination support. Current page of information presented in the message response. Typically used in combination with totalPages and pageSize. </value>
        [DataMember(Name="currentPage", EmitDefaultValue=true)]
        public int CurrentPage { get; set; }

        /// <summary>
        /// Pagination support. Total pages of information available as a result of the query. Typically used in combination with currentPage and pageSize. 
        /// </summary>
        /// <value>Pagination support. Total pages of information available as a result of the query. Typically used in combination with currentPage and pageSize. </value>
        [DataMember(Name="totalPages", EmitDefaultValue=true)]
        public int TotalPages { get; set; }

        /// <summary>
        /// Pagination support. The total number of records that may be returned as part of 1 page. Typically used in combination with currentPage and totalPages. 
        /// </summary>
        /// <value>Pagination support. The total number of records that may be returned as part of 1 page. Typically used in combination with currentPage and totalPages. </value>
        [DataMember(Name="pageSize", EmitDefaultValue=true)]
        public int PageSize { get; set; }

        /// <summary>
        /// Pagination support. The record position index of the current message response. 
        /// </summary>
        /// <value>Pagination support. The record position index of the current message response. </value>
        [DataMember(Name="positionIndex", EmitDefaultValue=false)]
        public string PositionIndex { get; set; }

        /// <summary>
        /// Pagination support. The requested page value to be returned in the message response. 
        /// </summary>
        /// <value>Pagination support. The requested page value to be returned in the message response. </value>
        [DataMember(Name="returnPage", EmitDefaultValue=true)]
        public int ReturnPage { get; set; }

        /// <summary>
        /// Pagination support. The requested record position to be returned in the message response. 
        /// </summary>
        /// <value>Pagination support. The requested record position to be returned in the message response. </value>
        [DataMember(Name="returnPositionIndex", EmitDefaultValue=false)]
        public string ReturnPositionIndex { get; set; }

        /// <summary>
        /// A financial instution that has permissions to this CUFX instance. A financial institution must be in the configuration list to have access to a specific set of data. 
        /// </summary>
        /// <value>A financial instution that has permissions to this CUFX instance. A financial institution must be in the configuration list to have access to a specific set of data. </value>
        [DataMember(Name="financialInstitution", EmitDefaultValue=false)]
        public List<FinancialInstitution> FinancialInstitution { get; set; }

    }
}