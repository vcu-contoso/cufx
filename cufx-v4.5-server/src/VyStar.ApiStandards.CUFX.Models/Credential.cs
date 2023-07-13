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
    /// 
    /// </summary>
    [DataContract]
    public partial class Credential 
    {
        /// <summary>
        /// The credential ID is a persistent and unique identifier for the credential. It should be unique for all credentials across the institution and remain the same over the life of the relationship with the financial institution. 
        /// </summary>
        /// <value>The credential ID is a persistent and unique identifier for the credential. It should be unique for all credentials across the institution and remain the same over the life of the relationship with the financial institution. </value>
        [DataMember(Name="credentialId", EmitDefaultValue=false)]
        public string CredentialId { get; set; }

        /// <summary>
        /// The credential ID is a persistent and unique identifier for the credential. It should be unique for all credentials across the institution and remain the same over the life of the relationship with the financial institution. 
        /// </summary>
        /// <value>The credential ID is a persistent and unique identifier for the credential. It should be unique for all credentials across the institution and remain the same over the life of the relationship with the financial institution. </value>
        [DataMember(Name="relatedCredentialId", EmitDefaultValue=false)]
        public string RelatedCredentialId { get; set; }


        /// <summary>
        /// Type of the credentials being used. Username is a system ID that is typically a shortened version of their name with no spaces. It is used to access an account when the person is using a computer system. The user usually selects their user name during signup.  It is typically unique for that individual or account across the entire system of record. Password is a combination of characters known by the user that is used to access an account when the person is on a computer system. The ATM PIN is usually a 4 digit number with no spaces that is used at an ATM terminal to access cash funds, inquire about balances or perform transfers. Depending upon the provider, this number can be randomly generated or selected by the user at time they create an account or activate their ATM card. Codeword is used to access an account in person or over the phone. This is typically different than the password used when electronically accessing the account. A token that was generated by a system for accessing a system.  Tokens can be rather lengthy to keep them confidential. A question that the user has selected that is paired with a security answer, which the system uses to confirm that the person is authorized to the account.  This is typically used in resetting the password on a system. An answer to a security question that the system uses to confirm that the person is authorized to the account. This is typically used in resetting the password on a system. A question that the user has selected and paired with a challenge answer so that the system can confirm that the person is authorized to the account.  This is typically used to enable a higher risk transaction on an account that requires a higher level of authentication to perform the transaction, such as sending money externally. An answer to a challenge question that allows the system to confirm that the person is authorized to the account. This is typically used to enable a higher risk transaction on an account that requires a higher level of authentication to perform the transaction, such as sending money externally. A phrase that the user can assign so that when they log into their account, the user can confirm that they have not been sent to a different website. This prevents them from performing transactions or providing confidential information on a fraudulent site. A URL to an image that the user selected and assigned to their account so that when they log into their account, the user can confirm that they have not been sent to a different website. This prevents them from performing transactions or providing confidential information on a fraudulent site. A pointer to an image in the artifact repositor that the user selected and assigned to their account so that when they log into their account, the user can confirm that they have not been sent to a different website. This prevents them from performing transactions or providing confidential information on a fraudulent site. Can be used to authorize transactions such as wire transfers, password reset, ACH transactions, etc. Other credential type, see element credentialSubType for additional detail. Validation of a Decentralized identifier. W3C compliant verifiable credential. Presentation of a verified credential data from a trust registry. Presentation of a connection protocol. 
        /// </summary>
        /// <value>Type of the credentials being used. Username is a system ID that is typically a shortened version of their name with no spaces. It is used to access an account when the person is using a computer system. The user usually selects their user name during signup.  It is typically unique for that individual or account across the entire system of record. Password is a combination of characters known by the user that is used to access an account when the person is on a computer system. The ATM PIN is usually a 4 digit number with no spaces that is used at an ATM terminal to access cash funds, inquire about balances or perform transfers. Depending upon the provider, this number can be randomly generated or selected by the user at time they create an account or activate their ATM card. Codeword is used to access an account in person or over the phone. This is typically different than the password used when electronically accessing the account. A token that was generated by a system for accessing a system.  Tokens can be rather lengthy to keep them confidential. A question that the user has selected that is paired with a security answer, which the system uses to confirm that the person is authorized to the account.  This is typically used in resetting the password on a system. An answer to a security question that the system uses to confirm that the person is authorized to the account. This is typically used in resetting the password on a system. A question that the user has selected and paired with a challenge answer so that the system can confirm that the person is authorized to the account.  This is typically used to enable a higher risk transaction on an account that requires a higher level of authentication to perform the transaction, such as sending money externally. An answer to a challenge question that allows the system to confirm that the person is authorized to the account. This is typically used to enable a higher risk transaction on an account that requires a higher level of authentication to perform the transaction, such as sending money externally. A phrase that the user can assign so that when they log into their account, the user can confirm that they have not been sent to a different website. This prevents them from performing transactions or providing confidential information on a fraudulent site. A URL to an image that the user selected and assigned to their account so that when they log into their account, the user can confirm that they have not been sent to a different website. This prevents them from performing transactions or providing confidential information on a fraudulent site. A pointer to an image in the artifact repositor that the user selected and assigned to their account so that when they log into their account, the user can confirm that they have not been sent to a different website. This prevents them from performing transactions or providing confidential information on a fraudulent site. Can be used to authorize transactions such as wire transfers, password reset, ACH transactions, etc. Other credential type, see element credentialSubType for additional detail. Validation of a Decentralized identifier. W3C compliant verifiable credential. Presentation of a verified credential data from a trust registry. Presentation of a connection protocol. </value>
        [TypeConverter(typeof(CustomEnumConverter<CredentialTypeEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum CredentialTypeEnum
        {
            
            /// <summary>
            /// Enum UsernameEnum for Username
            /// </summary>
            [EnumMember(Value = "Username")]
            UsernameEnum = 1,
            
            /// <summary>
            /// Enum PasswordEnum for Password
            /// </summary>
            [EnumMember(Value = "Password")]
            PasswordEnum = 2,
            
            /// <summary>
            /// Enum AtmPinEnum for AtmPin
            /// </summary>
            [EnumMember(Value = "AtmPin")]
            AtmPinEnum = 3,
            
            /// <summary>
            /// Enum CodewordEnum for Codeword
            /// </summary>
            [EnumMember(Value = "Codeword")]
            CodewordEnum = 4,
            
            /// <summary>
            /// Enum TokenEnum for Token
            /// </summary>
            [EnumMember(Value = "Token")]
            TokenEnum = 5,
            
            /// <summary>
            /// Enum SecurityQuestionEnum for SecurityQuestion
            /// </summary>
            [EnumMember(Value = "SecurityQuestion")]
            SecurityQuestionEnum = 6,
            
            /// <summary>
            /// Enum SecurityAnswerEnum for SecurityAnswer
            /// </summary>
            [EnumMember(Value = "SecurityAnswer")]
            SecurityAnswerEnum = 7,
            
            /// <summary>
            /// Enum ChallengeQuestionEnum for ChallengeQuestion
            /// </summary>
            [EnumMember(Value = "ChallengeQuestion")]
            ChallengeQuestionEnum = 8,
            
            /// <summary>
            /// Enum ChallengeAnswerEnum for ChallengeAnswer
            /// </summary>
            [EnumMember(Value = "ChallengeAnswer")]
            ChallengeAnswerEnum = 9,
            
            /// <summary>
            /// Enum AntiphishingPhraseEnum for AntiphishingPhrase
            /// </summary>
            [EnumMember(Value = "AntiphishingPhrase")]
            AntiphishingPhraseEnum = 10,
            
            /// <summary>
            /// Enum AntiphishingImageUrlEnum for AntiphishingImageUrl
            /// </summary>
            [EnumMember(Value = "AntiphishingImageUrl")]
            AntiphishingImageUrlEnum = 11,
            
            /// <summary>
            /// Enum AntiphishingImageArtifactIdEnum for AntiphishingImageArtifactId
            /// </summary>
            [EnumMember(Value = "AntiphishingImageArtifactId")]
            AntiphishingImageArtifactIdEnum = 12,
            
            /// <summary>
            /// Enum AuthorizationCodeEnum for AuthorizationCode
            /// </summary>
            [EnumMember(Value = "AuthorizationCode")]
            AuthorizationCodeEnum = 13,
            
            /// <summary>
            /// Enum OtherEnum for Other
            /// </summary>
            [EnumMember(Value = "Other")]
            OtherEnum = 14,
            
            /// <summary>
            /// Enum DidValidationEnum for DidValidation
            /// </summary>
            [EnumMember(Value = "DidValidation")]
            DidValidationEnum = 15,
            
            /// <summary>
            /// Enum VerifiedCredentialEnum for VerifiedCredential
            /// </summary>
            [EnumMember(Value = "VerifiedCredential")]
            VerifiedCredentialEnum = 16,
            
            /// <summary>
            /// Enum ConnectionProtocolEnum for ConnectionProtocol
            /// </summary>
            [EnumMember(Value = "ConnectionProtocol")]
            ConnectionProtocolEnum = 17
        }

        /// <summary>
        /// Type of the credentials being used. Username is a system ID that is typically a shortened version of their name with no spaces. It is used to access an account when the person is using a computer system. The user usually selects their user name during signup.  It is typically unique for that individual or account across the entire system of record. Password is a combination of characters known by the user that is used to access an account when the person is on a computer system. The ATM PIN is usually a 4 digit number with no spaces that is used at an ATM terminal to access cash funds, inquire about balances or perform transfers. Depending upon the provider, this number can be randomly generated or selected by the user at time they create an account or activate their ATM card. Codeword is used to access an account in person or over the phone. This is typically different than the password used when electronically accessing the account. A token that was generated by a system for accessing a system.  Tokens can be rather lengthy to keep them confidential. A question that the user has selected that is paired with a security answer, which the system uses to confirm that the person is authorized to the account.  This is typically used in resetting the password on a system. An answer to a security question that the system uses to confirm that the person is authorized to the account. This is typically used in resetting the password on a system. A question that the user has selected and paired with a challenge answer so that the system can confirm that the person is authorized to the account.  This is typically used to enable a higher risk transaction on an account that requires a higher level of authentication to perform the transaction, such as sending money externally. An answer to a challenge question that allows the system to confirm that the person is authorized to the account. This is typically used to enable a higher risk transaction on an account that requires a higher level of authentication to perform the transaction, such as sending money externally. A phrase that the user can assign so that when they log into their account, the user can confirm that they have not been sent to a different website. This prevents them from performing transactions or providing confidential information on a fraudulent site. A URL to an image that the user selected and assigned to their account so that when they log into their account, the user can confirm that they have not been sent to a different website. This prevents them from performing transactions or providing confidential information on a fraudulent site. A pointer to an image in the artifact repositor that the user selected and assigned to their account so that when they log into their account, the user can confirm that they have not been sent to a different website. This prevents them from performing transactions or providing confidential information on a fraudulent site. Can be used to authorize transactions such as wire transfers, password reset, ACH transactions, etc. Other credential type, see element credentialSubType for additional detail. Validation of a Decentralized identifier. W3C compliant verifiable credential. Presentation of a verified credential data from a trust registry. Presentation of a connection protocol. 
        /// </summary>
        /// <value>Type of the credentials being used. Username is a system ID that is typically a shortened version of their name with no spaces. It is used to access an account when the person is using a computer system. The user usually selects their user name during signup.  It is typically unique for that individual or account across the entire system of record. Password is a combination of characters known by the user that is used to access an account when the person is on a computer system. The ATM PIN is usually a 4 digit number with no spaces that is used at an ATM terminal to access cash funds, inquire about balances or perform transfers. Depending upon the provider, this number can be randomly generated or selected by the user at time they create an account or activate their ATM card. Codeword is used to access an account in person or over the phone. This is typically different than the password used when electronically accessing the account. A token that was generated by a system for accessing a system.  Tokens can be rather lengthy to keep them confidential. A question that the user has selected that is paired with a security answer, which the system uses to confirm that the person is authorized to the account.  This is typically used in resetting the password on a system. An answer to a security question that the system uses to confirm that the person is authorized to the account. This is typically used in resetting the password on a system. A question that the user has selected and paired with a challenge answer so that the system can confirm that the person is authorized to the account.  This is typically used to enable a higher risk transaction on an account that requires a higher level of authentication to perform the transaction, such as sending money externally. An answer to a challenge question that allows the system to confirm that the person is authorized to the account. This is typically used to enable a higher risk transaction on an account that requires a higher level of authentication to perform the transaction, such as sending money externally. A phrase that the user can assign so that when they log into their account, the user can confirm that they have not been sent to a different website. This prevents them from performing transactions or providing confidential information on a fraudulent site. A URL to an image that the user selected and assigned to their account so that when they log into their account, the user can confirm that they have not been sent to a different website. This prevents them from performing transactions or providing confidential information on a fraudulent site. A pointer to an image in the artifact repositor that the user selected and assigned to their account so that when they log into their account, the user can confirm that they have not been sent to a different website. This prevents them from performing transactions or providing confidential information on a fraudulent site. Can be used to authorize transactions such as wire transfers, password reset, ACH transactions, etc. Other credential type, see element credentialSubType for additional detail. Validation of a Decentralized identifier. W3C compliant verifiable credential. Presentation of a verified credential data from a trust registry. Presentation of a connection protocol. </value>
        [DataMember(Name="credentialType", EmitDefaultValue=true)]
        public CredentialTypeEnum CredentialType { get; set; }

        /// <summary>
        /// The sub type of credential or other credential. Provides additional support for subtypes that are not defined. 
        /// </summary>
        /// <value>The sub type of credential or other credential. Provides additional support for subtypes that are not defined. </value>
        [DataMember(Name="credentialSubType", EmitDefaultValue=false)]
        public string CredentialSubType { get; set; }

        /// <summary>
        /// If true, indicates that the credential was encrypted. Encryption method is agreed upon by application end point providers.  Assume itâ€™s NOT encrypted if this flag is not provided. The message context will be used by the service to understand which client is calling the service to know which encryption algorithm to apply. 
        /// </summary>
        /// <value>If true, indicates that the credential was encrypted. Encryption method is agreed upon by application end point providers.  Assume itâ€™s NOT encrypted if this flag is not provided. The message context will be used by the service to understand which client is calling the service to know which encryption algorithm to apply. </value>
        [DataMember(Name="encrypted", EmitDefaultValue=true)]
        public bool Encrypted { get; set; }

        /// <summary>
        /// The value of the credential, i.e. the actual password, pin, answer, question, url for the image, DID, etc.  Recommended: This value can be encrypted beyond the message encryption since the data values are very sensitive.   Optionally, client and Security Services can pass encrypted credential values using RSA-2048. A credential encrypted flag indicates that it was encrypted. 
        /// </summary>
        /// <value>The value of the credential, i.e. the actual password, pin, answer, question, url for the image, DID, etc.  Recommended: This value can be encrypted beyond the message encryption since the data values are very sensitive.   Optionally, client and Security Services can pass encrypted credential values using RSA-2048. A credential encrypted flag indicates that it was encrypted. </value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Expiration date and time of the credentials.  The date/time should be ISO 8601 UTC format.  yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. 
        /// </summary>
        /// <value>Expiration date and time of the credentials.  The date/time should be ISO 8601 UTC format.  yyyy-mm-ddThh:mmZ (2011-03-28T12:00Z) or yyyy-mm-dd (2011-03-28) formats are supported.  The time is assumed to be 00:00Z if omitted. </value>
        [DataMember(Name="expirationDateTime", EmitDefaultValue=false)]
        public string ExpirationDateTime { get; set; }

        /// <summary>
        /// If true, the credentials are temporary and must be reset upon first use of the credentials. 
        /// </summary>
        /// <value>If true, the credentials are temporary and must be reset upon first use of the credentials. </value>
        [DataMember(Name="temporary", EmitDefaultValue=true)]
        public bool Temporary { get; set; }

        /// <summary>
        /// Gets or Sets CustomData
        /// </summary>
        [DataMember(Name="customData", EmitDefaultValue=false)]
        public AccessProfileCustomData CustomData { get; set; }

        /// <summary>
        /// Gets or Sets DidValidation
        /// </summary>
        [DataMember(Name="didValidation", EmitDefaultValue=false)]
        public CredentialDidValidation DidValidation { get; set; }

        /// <summary>
        /// Gets or Sets VerifiedCredential
        /// </summary>
        [DataMember(Name="verifiedCredential", EmitDefaultValue=false)]
        public CredentialVerifiedCredential VerifiedCredential { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionProtocol
        /// </summary>
        [DataMember(Name="connectionProtocol", EmitDefaultValue=false)]
        public CredentialConnectionProtocol ConnectionProtocol { get; set; }

    }
}