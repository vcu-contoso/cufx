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
        /// A business that legally has no separate existence from its owner. Income and losses are taxed on the individuals personal income tax return. Legal form of company that provides limited liability to its owners in the vast majority of United States jurisdictions. A nominate contract between individuals who, in a spirit of cooperation, agree to carry on an enterprise; contribute to it by combining property, knowledge or activities; and share its profit. An association of individuals, created by law or under authority of law, having a continuous existence independent of the existences of its members, and powers and liabilities distinct from those of its members. A not for profit organization is a type of organization that does not earn profits for its owners. All of the money earned by or donated to a not for profit organization is used in pursuing the organizations objectives. Typically not for profit organizations are charities or other types of public service organizations. Generally, not for profit organizations can apply for a tax exempt status so that the organization is not subject to most forms of taxation. Donations made to a tax exempt not for profit organization may also be tax-deductible for the donor. Taken from investopedia.com. An organization composed of people who voluntarily meet on a regular basis for a mutual purpose other than educational, religious, charitable, or financial pursuits. A club is any kind of group that has members who meet for a social, literary, or political purpose, such as health clubs, country clubs, book clubs, and womens associations. The term club is not a legal term per se, but a group that organizes itself as a club must comply with any laws governing its organization and otherwise be cognizant of the legal ramifications in undertaking to organize itself in this manner. Taken from legal-dictionary.thefreedictionary.com 
        /// </summary>
        /// <value>A business that legally has no separate existence from its owner. Income and losses are taxed on the individuals personal income tax return. Legal form of company that provides limited liability to its owners in the vast majority of United States jurisdictions. A nominate contract between individuals who, in a spirit of cooperation, agree to carry on an enterprise; contribute to it by combining property, knowledge or activities; and share its profit. An association of individuals, created by law or under authority of law, having a continuous existence independent of the existences of its members, and powers and liabilities distinct from those of its members. A not for profit organization is a type of organization that does not earn profits for its owners. All of the money earned by or donated to a not for profit organization is used in pursuing the organizations objectives. Typically not for profit organizations are charities or other types of public service organizations. Generally, not for profit organizations can apply for a tax exempt status so that the organization is not subject to most forms of taxation. Donations made to a tax exempt not for profit organization may also be tax-deductible for the donor. Taken from investopedia.com. An organization composed of people who voluntarily meet on a regular basis for a mutual purpose other than educational, religious, charitable, or financial pursuits. A club is any kind of group that has members who meet for a social, literary, or political purpose, such as health clubs, country clubs, book clubs, and womens associations. The term club is not a legal term per se, but a group that organizes itself as a club must comply with any laws governing its organization and otherwise be cognizant of the legal ramifications in undertaking to organize itself in this manner. Taken from legal-dictionary.thefreedictionary.com </value>
        [TypeConverter(typeof(CustomEnumConverter<OrganizationType>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum OrganizationType
        {
            
            /// <summary>
            /// Enum SoleProprietorshipEnum for SoleProprietorship
            /// </summary>
            [EnumMember(Value = "SoleProprietorship")]
            SoleProprietorshipEnum = 1,
            
            /// <summary>
            /// Enum LlcEnum for Llc
            /// </summary>
            [EnumMember(Value = "Llc")]
            LlcEnum = 2,
            
            /// <summary>
            /// Enum PartnershipEnum for Partnership
            /// </summary>
            [EnumMember(Value = "Partnership")]
            PartnershipEnum = 3,
            
            /// <summary>
            /// Enum CorporationEnum for Corporation
            /// </summary>
            [EnumMember(Value = "Corporation")]
            CorporationEnum = 4,
            
            /// <summary>
            /// Enum NotForProfitEnum for NotForProfit
            /// </summary>
            [EnumMember(Value = "NotForProfit")]
            NotForProfitEnum = 5,
            
            /// <summary>
            /// Enum ClubEnum for Club
            /// </summary>
            [EnumMember(Value = "Club")]
            ClubEnum = 6
        }
}
