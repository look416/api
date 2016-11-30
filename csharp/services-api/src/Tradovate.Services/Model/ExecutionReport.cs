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
    /// ExecutionReport
    /// </summary>
    [DataContract]
    public partial class ExecutionReport :  IEquatable<ExecutionReport>
    {
        /// <summary>
        /// Canceled, Completed, DoneForDay, Expired, New, OrderStatus, PendingCancel, PendingNew, PendingReplace, Rejected, Replaced, Stopped, Suspended, Trade, TradeCancel, TradeCorrect
        /// </summary>
        /// <value>Canceled, Completed, DoneForDay, Expired, New, OrderStatus, PendingCancel, PendingNew, PendingReplace, Rejected, Replaced, Stopped, Suspended, Trade, TradeCancel, TradeCorrect</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExecTypeEnum
        {
            
            /// <summary>
            /// Enum Suspended for "Suspended"
            /// </summary>
            [EnumMember(Value = "Suspended")]
            Suspended,
            
            /// <summary>
            /// Enum Stopped for "Stopped"
            /// </summary>
            [EnumMember(Value = "Stopped")]
            Stopped,
            
            /// <summary>
            /// Enum Replaced for "Replaced"
            /// </summary>
            [EnumMember(Value = "Replaced")]
            Replaced,
            
            /// <summary>
            /// Enum PendingReplace for "PendingReplace"
            /// </summary>
            [EnumMember(Value = "PendingReplace")]
            PendingReplace,
            
            /// <summary>
            /// Enum OrderStatus for "OrderStatus"
            /// </summary>
            [EnumMember(Value = "OrderStatus")]
            OrderStatus,
            
            /// <summary>
            /// Enum TradeCancel for "TradeCancel"
            /// </summary>
            [EnumMember(Value = "TradeCancel")]
            TradeCancel,
            
            /// <summary>
            /// Enum Completed for "Completed"
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed,
            
            /// <summary>
            /// Enum Trade for "Trade"
            /// </summary>
            [EnumMember(Value = "Trade")]
            Trade,
            
            /// <summary>
            /// Enum PendingCancel for "PendingCancel"
            /// </summary>
            [EnumMember(Value = "PendingCancel")]
            PendingCancel,
            
            /// <summary>
            /// Enum Expired for "Expired"
            /// </summary>
            [EnumMember(Value = "Expired")]
            Expired,
            
            /// <summary>
            /// Enum TradeCorrect for "TradeCorrect"
            /// </summary>
            [EnumMember(Value = "TradeCorrect")]
            TradeCorrect,
            
            /// <summary>
            /// Enum New for "New"
            /// </summary>
            [EnumMember(Value = "New")]
            New,
            
            /// <summary>
            /// Enum Canceled for "Canceled"
            /// </summary>
            [EnumMember(Value = "Canceled")]
            Canceled,
            
            /// <summary>
            /// Enum DoneForDay for "DoneForDay"
            /// </summary>
            [EnumMember(Value = "DoneForDay")]
            DoneForDay,
            
            /// <summary>
            /// Enum Rejected for "Rejected"
            /// </summary>
            [EnumMember(Value = "Rejected")]
            Rejected,
            
            /// <summary>
            /// Enum PendingNew for "PendingNew"
            /// </summary>
            [EnumMember(Value = "PendingNew")]
            PendingNew
        }

        /// <summary>
        /// Canceled, Completed, Expired, Filled, PendingCancel, PendingNew, PendingReplace, Rejected, Suspended, Unknown, Working
        /// </summary>
        /// <value>Canceled, Completed, Expired, Filled, PendingCancel, PendingNew, PendingReplace, Rejected, Suspended, Unknown, Working</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrdStatusEnum
        {
            
            /// <summary>
            /// Enum Suspended for "Suspended"
            /// </summary>
            [EnumMember(Value = "Suspended")]
            Suspended,
            
            /// <summary>
            /// Enum Filled for "Filled"
            /// </summary>
            [EnumMember(Value = "Filled")]
            Filled,
            
            /// <summary>
            /// Enum PendingReplace for "PendingReplace"
            /// </summary>
            [EnumMember(Value = "PendingReplace")]
            PendingReplace,
            
            /// <summary>
            /// Enum Working for "Working"
            /// </summary>
            [EnumMember(Value = "Working")]
            Working,
            
            /// <summary>
            /// Enum Completed for "Completed"
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed,
            
            /// <summary>
            /// Enum PendingCancel for "PendingCancel"
            /// </summary>
            [EnumMember(Value = "PendingCancel")]
            PendingCancel,
            
            /// <summary>
            /// Enum Expired for "Expired"
            /// </summary>
            [EnumMember(Value = "Expired")]
            Expired,
            
            /// <summary>
            /// Enum Canceled for "Canceled"
            /// </summary>
            [EnumMember(Value = "Canceled")]
            Canceled,
            
            /// <summary>
            /// Enum Rejected for "Rejected"
            /// </summary>
            [EnumMember(Value = "Rejected")]
            Rejected,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum PendingNew for "PendingNew"
            /// </summary>
            [EnumMember(Value = "PendingNew")]
            PendingNew
        }

        /// <summary>
        /// Buy, Sell
        /// </summary>
        /// <value>Buy, Sell</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            
            /// <summary>
            /// Enum Buy for "Buy"
            /// </summary>
            [EnumMember(Value = "Buy")]
            Buy,
            
            /// <summary>
            /// Enum Sell for "Sell"
            /// </summary>
            [EnumMember(Value = "Sell")]
            Sell
        }

        /// <summary>
        /// AccountClosed, AdvancedTrailingStopUnsupported, AnotherCommandPending, BackMonthProhibited, ExecutionProviderNotConfigured, ExecutionProviderUnavailable, InvalidContract, InvalidPrice, LiquidationOnly, LiquidationOnlyBeforeExpiration, MaxOrderQtyIsNotSpecified, MaxOrderQtyLimitReached, MaxPosLimitMisconfigured, MaxPosLimitReached, MaxTotalPosLimitReached, MultipleAccountPlanRequired, NoQuote, NotEnoughLiquidity, OtherExecutionRelated, ParentRejected, RiskCheckTimeout, SessionClosed, Success, TooLate, TradingLocked, TrailingStopNonOrderQtyModify, Unauthorized, UnknownReason, Unsupported
        /// </summary>
        /// <value>AccountClosed, AdvancedTrailingStopUnsupported, AnotherCommandPending, BackMonthProhibited, ExecutionProviderNotConfigured, ExecutionProviderUnavailable, InvalidContract, InvalidPrice, LiquidationOnly, LiquidationOnlyBeforeExpiration, MaxOrderQtyIsNotSpecified, MaxOrderQtyLimitReached, MaxPosLimitMisconfigured, MaxPosLimitReached, MaxTotalPosLimitReached, MultipleAccountPlanRequired, NoQuote, NotEnoughLiquidity, OtherExecutionRelated, ParentRejected, RiskCheckTimeout, SessionClosed, Success, TooLate, TradingLocked, TrailingStopNonOrderQtyModify, Unauthorized, UnknownReason, Unsupported</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RejectReasonEnum
        {
            
            /// <summary>
            /// Enum Unsupported for "Unsupported"
            /// </summary>
            [EnumMember(Value = "Unsupported")]
            Unsupported,
            
            /// <summary>
            /// Enum InvalidPrice for "InvalidPrice"
            /// </summary>
            [EnumMember(Value = "InvalidPrice")]
            InvalidPrice,
            
            /// <summary>
            /// Enum NoQuote for "NoQuote"
            /// </summary>
            [EnumMember(Value = "NoQuote")]
            NoQuote,
            
            /// <summary>
            /// Enum MaxPosLimitMisconfigured for "MaxPosLimitMisconfigured"
            /// </summary>
            [EnumMember(Value = "MaxPosLimitMisconfigured")]
            MaxPosLimitMisconfigured,
            
            /// <summary>
            /// Enum TooLate for "TooLate"
            /// </summary>
            [EnumMember(Value = "TooLate")]
            TooLate,
            
            /// <summary>
            /// Enum AnotherCommandPending for "AnotherCommandPending"
            /// </summary>
            [EnumMember(Value = "AnotherCommandPending")]
            AnotherCommandPending,
            
            /// <summary>
            /// Enum MultipleAccountPlanRequired for "MultipleAccountPlanRequired"
            /// </summary>
            [EnumMember(Value = "MultipleAccountPlanRequired")]
            MultipleAccountPlanRequired,
            
            /// <summary>
            /// Enum ExecutionProviderNotConfigured for "ExecutionProviderNotConfigured"
            /// </summary>
            [EnumMember(Value = "ExecutionProviderNotConfigured")]
            ExecutionProviderNotConfigured,
            
            /// <summary>
            /// Enum AccountClosed for "AccountClosed"
            /// </summary>
            [EnumMember(Value = "AccountClosed")]
            AccountClosed,
            
            /// <summary>
            /// Enum BackMonthProhibited for "BackMonthProhibited"
            /// </summary>
            [EnumMember(Value = "BackMonthProhibited")]
            BackMonthProhibited,
            
            /// <summary>
            /// Enum NotEnoughLiquidity for "NotEnoughLiquidity"
            /// </summary>
            [EnumMember(Value = "NotEnoughLiquidity")]
            NotEnoughLiquidity,
            
            /// <summary>
            /// Enum UnknownReason for "UnknownReason"
            /// </summary>
            [EnumMember(Value = "UnknownReason")]
            UnknownReason,
            
            /// <summary>
            /// Enum SessionClosed for "SessionClosed"
            /// </summary>
            [EnumMember(Value = "SessionClosed")]
            SessionClosed,
            
            /// <summary>
            /// Enum OtherExecutionRelated for "OtherExecutionRelated"
            /// </summary>
            [EnumMember(Value = "OtherExecutionRelated")]
            OtherExecutionRelated,
            
            /// <summary>
            /// Enum LiquidationOnly for "LiquidationOnly"
            /// </summary>
            [EnumMember(Value = "LiquidationOnly")]
            LiquidationOnly,
            
            /// <summary>
            /// Enum MaxTotalPosLimitReached for "MaxTotalPosLimitReached"
            /// </summary>
            [EnumMember(Value = "MaxTotalPosLimitReached")]
            MaxTotalPosLimitReached,
            
            /// <summary>
            /// Enum LiquidationOnlyBeforeExpiration for "LiquidationOnlyBeforeExpiration"
            /// </summary>
            [EnumMember(Value = "LiquidationOnlyBeforeExpiration")]
            LiquidationOnlyBeforeExpiration,
            
            /// <summary>
            /// Enum Unauthorized for "Unauthorized"
            /// </summary>
            [EnumMember(Value = "Unauthorized")]
            Unauthorized,
            
            /// <summary>
            /// Enum AdvancedTrailingStopUnsupported for "AdvancedTrailingStopUnsupported"
            /// </summary>
            [EnumMember(Value = "AdvancedTrailingStopUnsupported")]
            AdvancedTrailingStopUnsupported,
            
            /// <summary>
            /// Enum RiskCheckTimeout for "RiskCheckTimeout"
            /// </summary>
            [EnumMember(Value = "RiskCheckTimeout")]
            RiskCheckTimeout,
            
            /// <summary>
            /// Enum ParentRejected for "ParentRejected"
            /// </summary>
            [EnumMember(Value = "ParentRejected")]
            ParentRejected,
            
            /// <summary>
            /// Enum MaxPosLimitReached for "MaxPosLimitReached"
            /// </summary>
            [EnumMember(Value = "MaxPosLimitReached")]
            MaxPosLimitReached,
            
            /// <summary>
            /// Enum MaxOrderQtyIsNotSpecified for "MaxOrderQtyIsNotSpecified"
            /// </summary>
            [EnumMember(Value = "MaxOrderQtyIsNotSpecified")]
            MaxOrderQtyIsNotSpecified,
            
            /// <summary>
            /// Enum MaxOrderQtyLimitReached for "MaxOrderQtyLimitReached"
            /// </summary>
            [EnumMember(Value = "MaxOrderQtyLimitReached")]
            MaxOrderQtyLimitReached,
            
            /// <summary>
            /// Enum InvalidContract for "InvalidContract"
            /// </summary>
            [EnumMember(Value = "InvalidContract")]
            InvalidContract,
            
            /// <summary>
            /// Enum Success for "Success"
            /// </summary>
            [EnumMember(Value = "Success")]
            Success,
            
            /// <summary>
            /// Enum TradingLocked for "TradingLocked"
            /// </summary>
            [EnumMember(Value = "TradingLocked")]
            TradingLocked,
            
            /// <summary>
            /// Enum TrailingStopNonOrderQtyModify for "TrailingStopNonOrderQtyModify"
            /// </summary>
            [EnumMember(Value = "TrailingStopNonOrderQtyModify")]
            TrailingStopNonOrderQtyModify,
            
            /// <summary>
            /// Enum ExecutionProviderUnavailable for "ExecutionProviderUnavailable"
            /// </summary>
            [EnumMember(Value = "ExecutionProviderUnavailable")]
            ExecutionProviderUnavailable
        }

        /// <summary>
        /// Canceled, Completed, DoneForDay, Expired, New, OrderStatus, PendingCancel, PendingNew, PendingReplace, Rejected, Replaced, Stopped, Suspended, Trade, TradeCancel, TradeCorrect
        /// </summary>
        /// <value>Canceled, Completed, DoneForDay, Expired, New, OrderStatus, PendingCancel, PendingNew, PendingReplace, Rejected, Replaced, Stopped, Suspended, Trade, TradeCancel, TradeCorrect</value>
        [DataMember(Name="execType", EmitDefaultValue=false)]
        public ExecTypeEnum? ExecType { get; set; }
        /// <summary>
        /// Canceled, Completed, Expired, Filled, PendingCancel, PendingNew, PendingReplace, Rejected, Suspended, Unknown, Working
        /// </summary>
        /// <value>Canceled, Completed, Expired, Filled, PendingCancel, PendingNew, PendingReplace, Rejected, Suspended, Unknown, Working</value>
        [DataMember(Name="ordStatus", EmitDefaultValue=false)]
        public OrdStatusEnum? OrdStatus { get; set; }
        /// <summary>
        /// Buy, Sell
        /// </summary>
        /// <value>Buy, Sell</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// AccountClosed, AdvancedTrailingStopUnsupported, AnotherCommandPending, BackMonthProhibited, ExecutionProviderNotConfigured, ExecutionProviderUnavailable, InvalidContract, InvalidPrice, LiquidationOnly, LiquidationOnlyBeforeExpiration, MaxOrderQtyIsNotSpecified, MaxOrderQtyLimitReached, MaxPosLimitMisconfigured, MaxPosLimitReached, MaxTotalPosLimitReached, MultipleAccountPlanRequired, NoQuote, NotEnoughLiquidity, OtherExecutionRelated, ParentRejected, RiskCheckTimeout, SessionClosed, Success, TooLate, TradingLocked, TrailingStopNonOrderQtyModify, Unauthorized, UnknownReason, Unsupported
        /// </summary>
        /// <value>AccountClosed, AdvancedTrailingStopUnsupported, AnotherCommandPending, BackMonthProhibited, ExecutionProviderNotConfigured, ExecutionProviderUnavailable, InvalidContract, InvalidPrice, LiquidationOnly, LiquidationOnlyBeforeExpiration, MaxOrderQtyIsNotSpecified, MaxOrderQtyLimitReached, MaxPosLimitMisconfigured, MaxPosLimitReached, MaxTotalPosLimitReached, MultipleAccountPlanRequired, NoQuote, NotEnoughLiquidity, OtherExecutionRelated, ParentRejected, RiskCheckTimeout, SessionClosed, Success, TooLate, TradingLocked, TrailingStopNonOrderQtyModify, Unauthorized, UnknownReason, Unsupported</value>
        [DataMember(Name="rejectReason", EmitDefaultValue=false)]
        public RejectReasonEnum? RejectReason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionReport" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExecutionReport() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionReport" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="CommandId">id of Command (required).</param>
        /// <param name="Name">Name (required).</param>
        /// <param name="AccountId">id of Account (required).</param>
        /// <param name="ContractId">id of Contract (required).</param>
        /// <param name="Timestamp">Timestamp (required).</param>
        /// <param name="TradeDate">TradeDate.</param>
        /// <param name="OrderId">id of Order (required).</param>
        /// <param name="ExecType">Canceled, Completed, DoneForDay, Expired, New, OrderStatus, PendingCancel, PendingNew, PendingReplace, Rejected, Replaced, Stopped, Suspended, Trade, TradeCancel, TradeCorrect (required).</param>
        /// <param name="ExecRefId">ExecRefId.</param>
        /// <param name="OrdStatus">Canceled, Completed, Expired, Filled, PendingCancel, PendingNew, PendingReplace, Rejected, Suspended, Unknown, Working.</param>
        /// <param name="Action">Buy, Sell (required).</param>
        /// <param name="CumQty">CumQty.</param>
        /// <param name="AvgPx">AvgPx.</param>
        /// <param name="LastQty">LastQty.</param>
        /// <param name="LastPx">LastPx.</param>
        /// <param name="RejectReason">AccountClosed, AdvancedTrailingStopUnsupported, AnotherCommandPending, BackMonthProhibited, ExecutionProviderNotConfigured, ExecutionProviderUnavailable, InvalidContract, InvalidPrice, LiquidationOnly, LiquidationOnlyBeforeExpiration, MaxOrderQtyIsNotSpecified, MaxOrderQtyLimitReached, MaxPosLimitMisconfigured, MaxPosLimitReached, MaxTotalPosLimitReached, MultipleAccountPlanRequired, NoQuote, NotEnoughLiquidity, OtherExecutionRelated, ParentRejected, RiskCheckTimeout, SessionClosed, Success, TooLate, TradingLocked, TrailingStopNonOrderQtyModify, Unauthorized, UnknownReason, Unsupported.</param>
        /// <param name="Text">Text.</param>
        /// <param name="ExchangeOrderId">ExchangeOrderId.</param>
        public ExecutionReport(int? Id = null, int? CommandId = null, string Name = null, int? AccountId = null, int? ContractId = null, DateTime? Timestamp = null, TradeDate TradeDate = null, int? OrderId = null, ExecTypeEnum? ExecType = null, string ExecRefId = null, OrdStatusEnum? OrdStatus = null, ActionEnum? Action = null, int? CumQty = null, double? AvgPx = null, int? LastQty = null, double? LastPx = null, RejectReasonEnum? RejectReason = null, string Text = null, string ExchangeOrderId = null)
        {
            // to ensure "CommandId" is required (not null)
            if (CommandId == null)
            {
                throw new InvalidDataException("CommandId is a required property for ExecutionReport and cannot be null");
            }
            else
            {
                this.CommandId = CommandId;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for ExecutionReport and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "AccountId" is required (not null)
            if (AccountId == null)
            {
                throw new InvalidDataException("AccountId is a required property for ExecutionReport and cannot be null");
            }
            else
            {
                this.AccountId = AccountId;
            }
            // to ensure "ContractId" is required (not null)
            if (ContractId == null)
            {
                throw new InvalidDataException("ContractId is a required property for ExecutionReport and cannot be null");
            }
            else
            {
                this.ContractId = ContractId;
            }
            // to ensure "Timestamp" is required (not null)
            if (Timestamp == null)
            {
                throw new InvalidDataException("Timestamp is a required property for ExecutionReport and cannot be null");
            }
            else
            {
                this.Timestamp = Timestamp;
            }
            // to ensure "OrderId" is required (not null)
            if (OrderId == null)
            {
                throw new InvalidDataException("OrderId is a required property for ExecutionReport and cannot be null");
            }
            else
            {
                this.OrderId = OrderId;
            }
            // to ensure "ExecType" is required (not null)
            if (ExecType == null)
            {
                throw new InvalidDataException("ExecType is a required property for ExecutionReport and cannot be null");
            }
            else
            {
                this.ExecType = ExecType;
            }
            // to ensure "Action" is required (not null)
            if (Action == null)
            {
                throw new InvalidDataException("Action is a required property for ExecutionReport and cannot be null");
            }
            else
            {
                this.Action = Action;
            }
            this.Id = Id;
            this.TradeDate = TradeDate;
            this.ExecRefId = ExecRefId;
            this.OrdStatus = OrdStatus;
            this.CumQty = CumQty;
            this.AvgPx = AvgPx;
            this.LastQty = LastQty;
            this.LastPx = LastPx;
            this.RejectReason = RejectReason;
            this.Text = Text;
            this.ExchangeOrderId = ExchangeOrderId;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// id of Command
        /// </summary>
        /// <value>id of Command</value>
        [DataMember(Name="commandId", EmitDefaultValue=false)]
        public int? CommandId { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// id of Account
        /// </summary>
        /// <value>id of Account</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public int? AccountId { get; set; }
        /// <summary>
        /// id of Contract
        /// </summary>
        /// <value>id of Contract</value>
        [DataMember(Name="contractId", EmitDefaultValue=false)]
        public int? ContractId { get; set; }
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
        /// id of Order
        /// </summary>
        /// <value>id of Order</value>
        [DataMember(Name="orderId", EmitDefaultValue=false)]
        public int? OrderId { get; set; }
        /// <summary>
        /// Gets or Sets ExecRefId
        /// </summary>
        [DataMember(Name="execRefId", EmitDefaultValue=false)]
        public string ExecRefId { get; set; }
        /// <summary>
        /// Gets or Sets CumQty
        /// </summary>
        [DataMember(Name="cumQty", EmitDefaultValue=false)]
        public int? CumQty { get; set; }
        /// <summary>
        /// Gets or Sets AvgPx
        /// </summary>
        [DataMember(Name="avgPx", EmitDefaultValue=false)]
        public double? AvgPx { get; set; }
        /// <summary>
        /// Gets or Sets LastQty
        /// </summary>
        [DataMember(Name="lastQty", EmitDefaultValue=false)]
        public int? LastQty { get; set; }
        /// <summary>
        /// Gets or Sets LastPx
        /// </summary>
        [DataMember(Name="lastPx", EmitDefaultValue=false)]
        public double? LastPx { get; set; }
        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }
        /// <summary>
        /// Gets or Sets ExchangeOrderId
        /// </summary>
        [DataMember(Name="exchangeOrderId", EmitDefaultValue=false)]
        public string ExchangeOrderId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecutionReport {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CommandId: ").Append(CommandId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  ContractId: ").Append(ContractId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  TradeDate: ").Append(TradeDate).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  ExecType: ").Append(ExecType).Append("\n");
            sb.Append("  ExecRefId: ").Append(ExecRefId).Append("\n");
            sb.Append("  OrdStatus: ").Append(OrdStatus).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  CumQty: ").Append(CumQty).Append("\n");
            sb.Append("  AvgPx: ").Append(AvgPx).Append("\n");
            sb.Append("  LastQty: ").Append(LastQty).Append("\n");
            sb.Append("  LastPx: ").Append(LastPx).Append("\n");
            sb.Append("  RejectReason: ").Append(RejectReason).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  ExchangeOrderId: ").Append(ExchangeOrderId).Append("\n");
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
            return this.Equals(obj as ExecutionReport);
        }

        /// <summary>
        /// Returns true if ExecutionReport instances are equal
        /// </summary>
        /// <param name="other">Instance of ExecutionReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExecutionReport other)
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
                    this.CommandId == other.CommandId ||
                    this.CommandId != null &&
                    this.CommandId.Equals(other.CommandId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
                (
                    this.ContractId == other.ContractId ||
                    this.ContractId != null &&
                    this.ContractId.Equals(other.ContractId)
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
                    this.OrderId == other.OrderId ||
                    this.OrderId != null &&
                    this.OrderId.Equals(other.OrderId)
                ) && 
                (
                    this.ExecType == other.ExecType ||
                    this.ExecType != null &&
                    this.ExecType.Equals(other.ExecType)
                ) && 
                (
                    this.ExecRefId == other.ExecRefId ||
                    this.ExecRefId != null &&
                    this.ExecRefId.Equals(other.ExecRefId)
                ) && 
                (
                    this.OrdStatus == other.OrdStatus ||
                    this.OrdStatus != null &&
                    this.OrdStatus.Equals(other.OrdStatus)
                ) && 
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) && 
                (
                    this.CumQty == other.CumQty ||
                    this.CumQty != null &&
                    this.CumQty.Equals(other.CumQty)
                ) && 
                (
                    this.AvgPx == other.AvgPx ||
                    this.AvgPx != null &&
                    this.AvgPx.Equals(other.AvgPx)
                ) && 
                (
                    this.LastQty == other.LastQty ||
                    this.LastQty != null &&
                    this.LastQty.Equals(other.LastQty)
                ) && 
                (
                    this.LastPx == other.LastPx ||
                    this.LastPx != null &&
                    this.LastPx.Equals(other.LastPx)
                ) && 
                (
                    this.RejectReason == other.RejectReason ||
                    this.RejectReason != null &&
                    this.RejectReason.Equals(other.RejectReason)
                ) && 
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) && 
                (
                    this.ExchangeOrderId == other.ExchangeOrderId ||
                    this.ExchangeOrderId != null &&
                    this.ExchangeOrderId.Equals(other.ExchangeOrderId)
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
                if (this.CommandId != null)
                    hash = hash * 59 + this.CommandId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.ContractId != null)
                    hash = hash * 59 + this.ContractId.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                if (this.TradeDate != null)
                    hash = hash * 59 + this.TradeDate.GetHashCode();
                if (this.OrderId != null)
                    hash = hash * 59 + this.OrderId.GetHashCode();
                if (this.ExecType != null)
                    hash = hash * 59 + this.ExecType.GetHashCode();
                if (this.ExecRefId != null)
                    hash = hash * 59 + this.ExecRefId.GetHashCode();
                if (this.OrdStatus != null)
                    hash = hash * 59 + this.OrdStatus.GetHashCode();
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                if (this.CumQty != null)
                    hash = hash * 59 + this.CumQty.GetHashCode();
                if (this.AvgPx != null)
                    hash = hash * 59 + this.AvgPx.GetHashCode();
                if (this.LastQty != null)
                    hash = hash * 59 + this.LastQty.GetHashCode();
                if (this.LastPx != null)
                    hash = hash * 59 + this.LastPx.GetHashCode();
                if (this.RejectReason != null)
                    hash = hash * 59 + this.RejectReason.GetHashCode();
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                if (this.ExchangeOrderId != null)
                    hash = hash * 59 + this.ExchangeOrderId.GetHashCode();
                return hash;
            }
        }
    }

}
