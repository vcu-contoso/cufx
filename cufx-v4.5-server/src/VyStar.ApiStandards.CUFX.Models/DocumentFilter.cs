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
    /// The list of filter options for services requesting document data.  The options can be used in combination or by themselves.  It is up to the data source to either return or affect the data requested or return a standard error identifying why the request was rejected. 
    /// </summary>
    [DataContract]
    public partial class DocumentFilter 
    {
        /// <summary>
        /// Gets or Sets DocumentIdList
        /// </summary>
        [DataMember(Name="documentIdList", EmitDefaultValue=false)]
        public DocumentFilterDocumentIdList DocumentIdList { get; set; }

        /// <summary>
        /// Gets or Sets DocumentTitleList
        /// </summary>
        [DataMember(Name="documentTitleList", EmitDefaultValue=false)]
        public DocumentFilterDocumentTitleList DocumentTitleList { get; set; }

        /// <summary>
        /// Gets or Sets DocumentTypeList
        /// </summary>
        [DataMember(Name="documentTypeList", EmitDefaultValue=false)]
        public DocumentFilterDocumentTypeList DocumentTypeList { get; set; }

        /// <summary>
        /// Gets or Sets DocumentSubTypeList
        /// </summary>
        [DataMember(Name="documentSubTypeList", EmitDefaultValue=false)]
        public DocumentFilterDocumentSubTypeList DocumentSubTypeList { get; set; }

        /// <summary>
        /// Gets or Sets AppliesTo
        /// </summary>
        [DataMember(Name="appliesTo", EmitDefaultValue=false)]
        public AccessProfileCustomData AppliesTo { get; set; }

        /// <summary>
        /// Gets or Sets DocumentCreationDateRange
        /// </summary>
        [DataMember(Name="documentCreationDateRange", EmitDefaultValue=false)]
        public AccessProfileFilterCreateAccessDateRange DocumentCreationDateRange { get; set; }

        /// <summary>
        /// Gets or Sets DocumentEffectiveDateRange
        /// </summary>
        [DataMember(Name="documentEffectiveDateRange", EmitDefaultValue=false)]
        public AccessProfileFilterCreateAccessDateRange DocumentEffectiveDateRange { get; set; }

        /// <summary>
        /// Gets or Sets DocumentExpirationDateRange
        /// </summary>
        [DataMember(Name="documentExpirationDateRange", EmitDefaultValue=false)]
        public AccessProfileFilterCreateAccessDateRange DocumentExpirationDateRange { get; set; }

        /// <summary>
        /// A description that identifies the version of this document so that multiple versions of the same document can be managed. 
        /// </summary>
        /// <value>A description that identifies the version of this document so that multiple versions of the same document can be managed. </value>
        [DataMember(Name="documentVersion", EmitDefaultValue=false)]
        public string DocumentVersion { get; set; }

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
        /// Gets or Sets DocumentStatusList
        /// </summary>
        [DataMember(Name="documentStatusList", EmitDefaultValue=false)]
        public DocumentFilterDocumentStatusList DocumentStatusList { get; set; }

        /// <summary>
        /// Gets or Sets DocumentSignatureTypeList
        /// </summary>
        [DataMember(Name="documentSignatureTypeList", EmitDefaultValue=false)]
        public DocumentFilterDocumentSignatureTypeList DocumentSignatureTypeList { get; set; }

        /// <summary>
        /// Gets or Sets CustomData
        /// </summary>
        [DataMember(Name="customData", EmitDefaultValue=false)]
        public AccessProfileCustomData CustomData { get; set; }

        /// <summary>
        /// If set true then the response shall include the base 64 binary objects. When false or not set do not return the base 64 binary. This is intended to manage the response message size. 
        /// </summary>
        /// <value>If set true then the response shall include the base 64 binary objects. When false or not set do not return the base 64 binary. This is intended to manage the response message size. </value>
        [DataMember(Name="includeArtifactObjectFlag", EmitDefaultValue=true)]
        public bool IncludeArtifactObjectFlag { get; set; }

        /// <summary>
        /// Gets or Sets AccountIdentificationList
        /// </summary>
        [DataMember(Name="accountIdentificationList", EmitDefaultValue=false)]
        public AccountFilterAccountIdentificationList AccountIdentificationList { get; set; }

    }
}
