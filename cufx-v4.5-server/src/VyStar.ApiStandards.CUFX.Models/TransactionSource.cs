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
        /// System or delivery channel that was the origination source for the transaction. Automated Clearing House. Automated Teller Machine. Interactive Voice Response. Point Of Sale. 
        /// </summary>
        /// <value>System or delivery channel that was the origination source for the transaction. Automated Clearing House. Automated Teller Machine. Interactive Voice Response. Point Of Sale. </value>
        [TypeConverter(typeof(CustomEnumConverter<TransactionSource>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TransactionSource
        {
            
            /// <summary>
            /// Enum AchEnum for Ach
            /// </summary>
            [EnumMember(Value = "Ach")]
            AchEnum = 1,
            
            /// <summary>
            /// Enum AdjustmentEnum for Adjustment
            /// </summary>
            [EnumMember(Value = "Adjustment")]
            AdjustmentEnum = 2,
            
            /// <summary>
            /// Enum AtmEnum for Atm
            /// </summary>
            [EnumMember(Value = "Atm")]
            AtmEnum = 3,
            
            /// <summary>
            /// Enum BalanceTransferEnum for BalanceTransfer
            /// </summary>
            [EnumMember(Value = "BalanceTransfer")]
            BalanceTransferEnum = 4,
            
            /// <summary>
            /// Enum BillPayEnum for BillPay
            /// </summary>
            [EnumMember(Value = "BillPay")]
            BillPayEnum = 5,
            
            /// <summary>
            /// Enum BulkDepositEnum for BulkDeposit
            /// </summary>
            [EnumMember(Value = "BulkDeposit")]
            BulkDepositEnum = 6,
            
            /// <summary>
            /// Enum CashEnum for Cash
            /// </summary>
            [EnumMember(Value = "Cash")]
            CashEnum = 7,
            
            /// <summary>
            /// Enum CheckEnum for Check
            /// </summary>
            [EnumMember(Value = "Check")]
            CheckEnum = 8,
            
            /// <summary>
            /// Enum FeeEnum for Fee
            /// </summary>
            [EnumMember(Value = "Fee")]
            FeeEnum = 9,
            
            /// <summary>
            /// Enum HomeBankingEnum for HomeBanking
            /// </summary>
            [EnumMember(Value = "HomeBanking")]
            HomeBankingEnum = 10,
            
            /// <summary>
            /// Enum InsuranceEnum for Insurance
            /// </summary>
            [EnumMember(Value = "Insurance")]
            InsuranceEnum = 11,
            
            /// <summary>
            /// Enum InterestEarnedEnum for InterestEarned
            /// </summary>
            [EnumMember(Value = "InterestEarned")]
            InterestEarnedEnum = 12,
            
            /// <summary>
            /// Enum InterestPaidEnum for InterestPaid
            /// </summary>
            [EnumMember(Value = "InterestPaid")]
            InterestPaidEnum = 13,
            
            /// <summary>
            /// Enum InterestRefundEnum for InterestRefund
            /// </summary>
            [EnumMember(Value = "InterestRefund")]
            InterestRefundEnum = 14,
            
            /// <summary>
            /// Enum IvrEnum for Ivr
            /// </summary>
            [EnumMember(Value = "Ivr")]
            IvrEnum = 15,
            
            /// <summary>
            /// Enum KioskEnum for Kiosk
            /// </summary>
            [EnumMember(Value = "Kiosk")]
            KioskEnum = 16,
            
            /// <summary>
            /// Enum MobileBankingEnum for MobileBanking
            /// </summary>
            [EnumMember(Value = "MobileBanking")]
            MobileBankingEnum = 17,
            
            /// <summary>
            /// Enum OtherEnum for Other
            /// </summary>
            [EnumMember(Value = "Other")]
            OtherEnum = 18,
            
            /// <summary>
            /// Enum PayrollEnum for Payroll
            /// </summary>
            [EnumMember(Value = "Payroll")]
            PayrollEnum = 19,
            
            /// <summary>
            /// Enum PinPurchaseEnum for PinPurchase
            /// </summary>
            [EnumMember(Value = "PinPurchase")]
            PinPurchaseEnum = 20,
            
            /// <summary>
            /// Enum POSEnum for POS
            /// </summary>
            [EnumMember(Value = "POS")]
            POSEnum = 21,
            
            /// <summary>
            /// Enum SharedBranchEnum for SharedBranch
            /// </summary>
            [EnumMember(Value = "SharedBranch")]
            SharedBranchEnum = 22,
            
            /// <summary>
            /// Enum SignatureEnum for Signature
            /// </summary>
            [EnumMember(Value = "Signature")]
            SignatureEnum = 23,
            
            /// <summary>
            /// Enum WireEnum for Wire
            /// </summary>
            [EnumMember(Value = "Wire")]
            WireEnum = 24,
            
            /// <summary>
            /// Enum WithholdingEnum for Withholding
            /// </summary>
            [EnumMember(Value = "Withholding")]
            WithholdingEnum = 25
        }
}
