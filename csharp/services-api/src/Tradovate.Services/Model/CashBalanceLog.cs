/* 
 * Tradovate API
 *
 * Tradovate API
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Tradovate.Services.Model
{
    /// <summary>
    /// CashBalanceLog
    /// </summary>
    [DataContract]
    public partial class CashBalanceLog :  IEquatable<CashBalanceLog>
    {
        /// <summary>
        /// AutomaticReconciliation, BrokerageFee, CancelledPairedTrade, ClearingFee, Commission, DeskFee, EntitlementSubscription, ExchangeFee, FundTransaction, FundTransactionFee, IPFee, LiquidationFee, ManualAdjustment, MarketDataSubscription, NewSession, NfaFee, OptionsTrade, OrderRoutingFee, TradePaired, TradovateSubscription
        /// </summary>
        /// <value>AutomaticReconciliation, BrokerageFee, CancelledPairedTrade, ClearingFee, Commission, DeskFee, EntitlementSubscription, ExchangeFee, FundTransaction, FundTransactionFee, IPFee, LiquidationFee, ManualAdjustment, MarketDataSubscription, NewSession, NfaFee, OptionsTrade, OrderRoutingFee, TradePaired, TradovateSubscription</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CashChangeTypeEnum
        {
            
            /// <summary>
            /// Enum ClearingFee for "ClearingFee"
            /// </summary>
            [EnumMember(Value = "ClearingFee")]
            ClearingFee,
            
            /// <summary>
            /// Enum TradovateSubscription for "TradovateSubscription"
            /// </summary>
            [EnumMember(Value = "TradovateSubscription")]
            TradovateSubscription,
            
            /// <summary>
            /// Enum FundTransactionFee for "FundTransactionFee"
            /// </summary>
            [EnumMember(Value = "FundTransactionFee")]
            FundTransactionFee,
            
            /// <summary>
            /// Enum MarketDataSubscription for "MarketDataSubscription"
            /// </summary>
            [EnumMember(Value = "MarketDataSubscription")]
            MarketDataSubscription,
            
            /// <summary>
            /// Enum LiquidationFee for "LiquidationFee"
            /// </summary>
            [EnumMember(Value = "LiquidationFee")]
            LiquidationFee,
            
            /// <summary>
            /// Enum OptionsTrade for "OptionsTrade"
            /// </summary>
            [EnumMember(Value = "OptionsTrade")]
            OptionsTrade,
            
            /// <summary>
            /// Enum BrokerageFee for "BrokerageFee"
            /// </summary>
            [EnumMember(Value = "BrokerageFee")]
            BrokerageFee,
            
            /// <summary>
            /// Enum TradePaired for "TradePaired"
            /// </summary>
            [EnumMember(Value = "TradePaired")]
            TradePaired,
            
            /// <summary>
            /// Enum DeskFee for "DeskFee"
            /// </summary>
            [EnumMember(Value = "DeskFee")]
            DeskFee,
            
            /// <summary>
            /// Enum EntitlementSubscription for "EntitlementSubscription"
            /// </summary>
            [EnumMember(Value = "EntitlementSubscription")]
            EntitlementSubscription,
            
            /// <summary>
            /// Enum NewSession for "NewSession"
            /// </summary>
            [EnumMember(Value = "NewSession")]
            NewSession,
            
            /// <summary>
            /// Enum ManualAdjustment for "ManualAdjustment"
            /// </summary>
            [EnumMember(Value = "ManualAdjustment")]
            ManualAdjustment,
            
            /// <summary>
            /// Enum FundTransaction for "FundTransaction"
            /// </summary>
            [EnumMember(Value = "FundTransaction")]
            FundTransaction,
            
            /// <summary>
            /// Enum NfaFee for "NfaFee"
            /// </summary>
            [EnumMember(Value = "NfaFee")]
            NfaFee,
            
            /// <summary>
            /// Enum AutomaticReconciliation for "AutomaticReconciliation"
            /// </summary>
            [EnumMember(Value = "AutomaticReconciliation")]
            AutomaticReconciliation,
            
            /// <summary>
            /// Enum ExchangeFee for "ExchangeFee"
            /// </summary>
            [EnumMember(Value = "ExchangeFee")]
            ExchangeFee,
            
            /// <summary>
            /// Enum OrderRoutingFee for "OrderRoutingFee"
            /// </summary>
            [EnumMember(Value = "OrderRoutingFee")]
            OrderRoutingFee,
            
            /// <summary>
            /// Enum Commission for "Commission"
            /// </summary>
            [EnumMember(Value = "Commission")]
            Commission,
            
            /// <summary>
            /// Enum IPFee for "IPFee"
            /// </summary>
            [EnumMember(Value = "IPFee")]
            IPFee,
            
            /// <summary>
            /// Enum CancelledPairedTrade for "CancelledPairedTrade"
            /// </summary>
            [EnumMember(Value = "CancelledPairedTrade")]
            CancelledPairedTrade
        }

        /// <summary>
        /// AutomaticReconciliation, BrokerageFee, CancelledPairedTrade, ClearingFee, Commission, DeskFee, EntitlementSubscription, ExchangeFee, FundTransaction, FundTransactionFee, IPFee, LiquidationFee, ManualAdjustment, MarketDataSubscription, NewSession, NfaFee, OptionsTrade, OrderRoutingFee, TradePaired, TradovateSubscription
        /// </summary>
        /// <value>AutomaticReconciliation, BrokerageFee, CancelledPairedTrade, ClearingFee, Commission, DeskFee, EntitlementSubscription, ExchangeFee, FundTransaction, FundTransactionFee, IPFee, LiquidationFee, ManualAdjustment, MarketDataSubscription, NewSession, NfaFee, OptionsTrade, OrderRoutingFee, TradePaired, TradovateSubscription</value>
        [DataMember(Name="cashChangeType", EmitDefaultValue=false)]
        public CashChangeTypeEnum? CashChangeType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CashBalanceLog" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CashBalanceLog() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CashBalanceLog" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="AccountId">id of Account (required).</param>
        /// <param name="Timestamp">Timestamp (required).</param>
        /// <param name="TradeDate">TradeDate (required).</param>
        /// <param name="CurrencyId">id of Currency (required).</param>
        /// <param name="Amount">Amount (required).</param>
        /// <param name="RealizedPnL">RealizedPnL.</param>
        /// <param name="WeekRealizedPnL">WeekRealizedPnL.</param>
        /// <param name="CashChangeType">AutomaticReconciliation, BrokerageFee, CancelledPairedTrade, ClearingFee, Commission, DeskFee, EntitlementSubscription, ExchangeFee, FundTransaction, FundTransactionFee, IPFee, LiquidationFee, ManualAdjustment, MarketDataSubscription, NewSession, NfaFee, OptionsTrade, OrderRoutingFee, TradePaired, TradovateSubscription (required).</param>
        /// <param name="FillPairId">id of FillPair.</param>
        /// <param name="FillId">id of Fill.</param>
        /// <param name="FundTransactionId">id of FundTransaction.</param>
        /// <param name="Comment">Comment.</param>
        /// <param name="Delta">Delta (required).</param>
        public CashBalanceLog(int? Id = null, int? AccountId = null, DateTime? Timestamp = null, TradeDate TradeDate = null, int? CurrencyId = null, double? Amount = null, double? RealizedPnL = null, double? WeekRealizedPnL = null, CashChangeTypeEnum? CashChangeType = null, int? FillPairId = null, int? FillId = null, int? FundTransactionId = null, string Comment = null, double? Delta = null)
        {
            // to ensure "AccountId" is required (not null)
            if (AccountId == null)
            {
                throw new InvalidDataException("AccountId is a required property for CashBalanceLog and cannot be null");
            }
            else
            {
                this.AccountId = AccountId;
            }
            // to ensure "Timestamp" is required (not null)
            if (Timestamp == null)
            {
                throw new InvalidDataException("Timestamp is a required property for CashBalanceLog and cannot be null");
            }
            else
            {
                this.Timestamp = Timestamp;
            }
            // to ensure "TradeDate" is required (not null)
            if (TradeDate == null)
            {
                throw new InvalidDataException("TradeDate is a required property for CashBalanceLog and cannot be null");
            }
            else
            {
                this.TradeDate = TradeDate;
            }
            // to ensure "CurrencyId" is required (not null)
            if (CurrencyId == null)
            {
                throw new InvalidDataException("CurrencyId is a required property for CashBalanceLog and cannot be null");
            }
            else
            {
                this.CurrencyId = CurrencyId;
            }
            // to ensure "Amount" is required (not null)
            if (Amount == null)
            {
                throw new InvalidDataException("Amount is a required property for CashBalanceLog and cannot be null");
            }
            else
            {
                this.Amount = Amount;
            }
            // to ensure "CashChangeType" is required (not null)
            if (CashChangeType == null)
            {
                throw new InvalidDataException("CashChangeType is a required property for CashBalanceLog and cannot be null");
            }
            else
            {
                this.CashChangeType = CashChangeType;
            }
            // to ensure "Delta" is required (not null)
            if (Delta == null)
            {
                throw new InvalidDataException("Delta is a required property for CashBalanceLog and cannot be null");
            }
            else
            {
                this.Delta = Delta;
            }
            this.Id = Id;
            this.RealizedPnL = RealizedPnL;
            this.WeekRealizedPnL = WeekRealizedPnL;
            this.FillPairId = FillPairId;
            this.FillId = FillId;
            this.FundTransactionId = FundTransactionId;
            this.Comment = Comment;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// id of Account
        /// </summary>
        /// <value>id of Account</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public int? AccountId { get; set; }
        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }
        /// <summary>
        /// Gets or Sets TradeDate
        /// </summary>
        [DataMember(Name="tradeDate", EmitDefaultValue=false)]
        public TradeDate TradeDate { get; set; }
        /// <summary>
        /// id of Currency
        /// </summary>
        /// <value>id of Currency</value>
        [DataMember(Name="currencyId", EmitDefaultValue=false)]
        public int? CurrencyId { get; set; }
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public double? Amount { get; set; }
        /// <summary>
        /// Gets or Sets RealizedPnL
        /// </summary>
        [DataMember(Name="realizedPnL", EmitDefaultValue=false)]
        public double? RealizedPnL { get; set; }
        /// <summary>
        /// Gets or Sets WeekRealizedPnL
        /// </summary>
        [DataMember(Name="weekRealizedPnL", EmitDefaultValue=false)]
        public double? WeekRealizedPnL { get; set; }
        /// <summary>
        /// id of FillPair
        /// </summary>
        /// <value>id of FillPair</value>
        [DataMember(Name="fillPairId", EmitDefaultValue=false)]
        public int? FillPairId { get; set; }
        /// <summary>
        /// id of Fill
        /// </summary>
        /// <value>id of Fill</value>
        [DataMember(Name="fillId", EmitDefaultValue=false)]
        public int? FillId { get; set; }
        /// <summary>
        /// id of FundTransaction
        /// </summary>
        /// <value>id of FundTransaction</value>
        [DataMember(Name="fundTransactionId", EmitDefaultValue=false)]
        public int? FundTransactionId { get; set; }
        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }
        /// <summary>
        /// Gets or Sets Delta
        /// </summary>
        [DataMember(Name="delta", EmitDefaultValue=false)]
        public double? Delta { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CashBalanceLog {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  TradeDate: ").Append(TradeDate).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  RealizedPnL: ").Append(RealizedPnL).Append("\n");
            sb.Append("  WeekRealizedPnL: ").Append(WeekRealizedPnL).Append("\n");
            sb.Append("  CashChangeType: ").Append(CashChangeType).Append("\n");
            sb.Append("  FillPairId: ").Append(FillPairId).Append("\n");
            sb.Append("  FillId: ").Append(FillId).Append("\n");
            sb.Append("  FundTransactionId: ").Append(FundTransactionId).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Delta: ").Append(Delta).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as CashBalanceLog);
        }

        /// <summary>
        /// Returns true if CashBalanceLog instances are equal
        /// </summary>
        /// <param name="other">Instance of CashBalanceLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CashBalanceLog other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    this.TradeDate == other.TradeDate ||
                    this.TradeDate != null &&
                    this.TradeDate.Equals(other.TradeDate)
                ) && 
                (
                    this.CurrencyId == other.CurrencyId ||
                    this.CurrencyId != null &&
                    this.CurrencyId.Equals(other.CurrencyId)
                ) && 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.RealizedPnL == other.RealizedPnL ||
                    this.RealizedPnL != null &&
                    this.RealizedPnL.Equals(other.RealizedPnL)
                ) && 
                (
                    this.WeekRealizedPnL == other.WeekRealizedPnL ||
                    this.WeekRealizedPnL != null &&
                    this.WeekRealizedPnL.Equals(other.WeekRealizedPnL)
                ) && 
                (
                    this.CashChangeType == other.CashChangeType ||
                    this.CashChangeType != null &&
                    this.CashChangeType.Equals(other.CashChangeType)
                ) && 
                (
                    this.FillPairId == other.FillPairId ||
                    this.FillPairId != null &&
                    this.FillPairId.Equals(other.FillPairId)
                ) && 
                (
                    this.FillId == other.FillId ||
                    this.FillId != null &&
                    this.FillId.Equals(other.FillId)
                ) && 
                (
                    this.FundTransactionId == other.FundTransactionId ||
                    this.FundTransactionId != null &&
                    this.FundTransactionId.Equals(other.FundTransactionId)
                ) && 
                (
                    this.Comment == other.Comment ||
                    this.Comment != null &&
                    this.Comment.Equals(other.Comment)
                ) && 
                (
                    this.Delta == other.Delta ||
                    this.Delta != null &&
                    this.Delta.Equals(other.Delta)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                if (this.TradeDate != null)
                    hash = hash * 59 + this.TradeDate.GetHashCode();
                if (this.CurrencyId != null)
                    hash = hash * 59 + this.CurrencyId.GetHashCode();
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.RealizedPnL != null)
                    hash = hash * 59 + this.RealizedPnL.GetHashCode();
                if (this.WeekRealizedPnL != null)
                    hash = hash * 59 + this.WeekRealizedPnL.GetHashCode();
                if (this.CashChangeType != null)
                    hash = hash * 59 + this.CashChangeType.GetHashCode();
                if (this.FillPairId != null)
                    hash = hash * 59 + this.FillPairId.GetHashCode();
                if (this.FillId != null)
                    hash = hash * 59 + this.FillId.GetHashCode();
                if (this.FundTransactionId != null)
                    hash = hash * 59 + this.FundTransactionId.GetHashCode();
                if (this.Comment != null)
                    hash = hash * 59 + this.Comment.GetHashCode();
                if (this.Delta != null)
                    hash = hash * 59 + this.Delta.GetHashCode();
                return hash;
            }
        }
    }

}
