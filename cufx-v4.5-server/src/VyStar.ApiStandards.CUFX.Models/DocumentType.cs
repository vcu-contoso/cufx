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
        /// The type of document or document template, such as Notice, Statement, Disclosure, etc. A picture of a check.  If separate documents are used to denote the front and the back, then you may use the sub type to identify each side or just use the artifact collection to have each side. Legal information required to be delivered to party(ies) so they know how their accounts work and what their legal rights are. Information that is used to ID the consumer, organization, estate or trust when the party arrives at the front line. Information that relays the terms and agreements of a loan. Information that contains information about their applicatoon and relays the terms and agreements of joining a financial institution when an agreement is necessary to join. Legal notice to party(ies) that is required to be sent when an event happens on their associated accounts. Document that relays the image of a transaction or transactions that happened at a teller window, at an ATM or other delivery method. Balances, transactions and other information of the party(ies)s accounts at a point in time. A report that summarizes activities, segmentation, transactions, etc. May contain, but not limited to, information regarding their account, an image of the person, and a signature of the person for identification purposes. IRS-related information about earnings on accounts. This value can be used when no other types relate to the particular document.  What the document is can be found using the document title, sub type or appliesTo information. 
        /// </summary>
        /// <value>The type of document or document template, such as Notice, Statement, Disclosure, etc. A picture of a check.  If separate documents are used to denote the front and the back, then you may use the sub type to identify each side or just use the artifact collection to have each side. Legal information required to be delivered to party(ies) so they know how their accounts work and what their legal rights are. Information that is used to ID the consumer, organization, estate or trust when the party arrives at the front line. Information that relays the terms and agreements of a loan. Information that contains information about their applicatoon and relays the terms and agreements of joining a financial institution when an agreement is necessary to join. Legal notice to party(ies) that is required to be sent when an event happens on their associated accounts. Document that relays the image of a transaction or transactions that happened at a teller window, at an ATM or other delivery method. Balances, transactions and other information of the party(ies)s accounts at a point in time. A report that summarizes activities, segmentation, transactions, etc. May contain, but not limited to, information regarding their account, an image of the person, and a signature of the person for identification purposes. IRS-related information about earnings on accounts. This value can be used when no other types relate to the particular document.  What the document is can be found using the document title, sub type or appliesTo information. </value>
        [TypeConverter(typeof(CustomEnumConverter<DocumentType>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum DocumentType
        {
            
            /// <summary>
            /// Enum CheckImageEnum for CheckImage
            /// </summary>
            [EnumMember(Value = "CheckImage")]
            CheckImageEnum = 1,
            
            /// <summary>
            /// Enum DisclosureEnum for Disclosure
            /// </summary>
            [EnumMember(Value = "Disclosure")]
            DisclosureEnum = 2,
            
            /// <summary>
            /// Enum IdentificationDocumentEnum for IdentificationDocument
            /// </summary>
            [EnumMember(Value = "IdentificationDocument")]
            IdentificationDocumentEnum = 3,
            
            /// <summary>
            /// Enum LoanDocumentEnum for LoanDocument
            /// </summary>
            [EnumMember(Value = "LoanDocument")]
            LoanDocumentEnum = 4,
            
            /// <summary>
            /// Enum MembershipDocumentEnum for MembershipDocument
            /// </summary>
            [EnumMember(Value = "MembershipDocument")]
            MembershipDocumentEnum = 5,
            
            /// <summary>
            /// Enum NoticeEnum for Notice
            /// </summary>
            [EnumMember(Value = "Notice")]
            NoticeEnum = 6,
            
            /// <summary>
            /// Enum ReceiptEnum for Receipt
            /// </summary>
            [EnumMember(Value = "Receipt")]
            ReceiptEnum = 7,
            
            /// <summary>
            /// Enum StatementEnum for Statement
            /// </summary>
            [EnumMember(Value = "Statement")]
            StatementEnum = 8,
            
            /// <summary>
            /// Enum ReportEnum for Report
            /// </summary>
            [EnumMember(Value = "Report")]
            ReportEnum = 9,
            
            /// <summary>
            /// Enum SignatureCardEnum for SignatureCard
            /// </summary>
            [EnumMember(Value = "SignatureCard")]
            SignatureCardEnum = 10,
            
            /// <summary>
            /// Enum TaxFormEnum for TaxForm
            /// </summary>
            [EnumMember(Value = "TaxForm")]
            TaxFormEnum = 11,
            
            /// <summary>
            /// Enum OtherEnum for Other
            /// </summary>
            [EnumMember(Value = "Other")]
            OtherEnum = 12
        }
}
