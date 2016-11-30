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
    /// UserAccountRiskParameter
    /// </summary>
    [DataContract]
    public partial class UserAccountRiskParameter :  IEquatable<UserAccountRiskParameter>
    {
        /// <summary>
        /// Futures, Options, Spread
        /// </summary>
        /// <value>Futures, Options, Spread</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProductTypeEnum
        {
            
            /// <summary>
            /// Enum Futures for "Futures"
            /// </summary>
            [EnumMember(Value = "Futures")]
            Futures,
            
            /// <summary>
            /// Enum Options for "Options"
            /// </summary>
            [EnumMember(Value = "Options")]
            Options,
            
            /// <summary>
            /// Enum Spread for "Spread"
            /// </summary>
            [EnumMember(Value = "Spread")]
            Spread
        }

        /// <summary>
        /// Inactive, Locked, ReadyForContracts, ReadyToTrade, Verified
        /// </summary>
        /// <value>Inactive, Locked, ReadyForContracts, ReadyToTrade, Verified</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProductVerificationStatusEnum
        {
            
            /// <summary>
            /// Enum ReadyToTrade for "ReadyToTrade"
            /// </summary>
            [EnumMember(Value = "ReadyToTrade")]
            ReadyToTrade,
            
            /// <summary>
            /// Enum Inactive for "Inactive"
            /// </summary>
            [EnumMember(Value = "Inactive")]
            Inactive,
            
            /// <summary>
            /// Enum Verified for "Verified"
            /// </summary>
            [EnumMember(Value = "Verified")]
            Verified,
            
            /// <summary>
            /// Enum Locked for "Locked"
            /// </summary>
            [EnumMember(Value = "Locked")]
            Locked,
            
            /// <summary>
            /// Enum ReadyForContracts for "ReadyForContracts"
            /// </summary>
            [EnumMember(Value = "ReadyForContracts")]
            ReadyForContracts
        }

        /// <summary>
        /// Futures, Options, Spread
        /// </summary>
        /// <value>Futures, Options, Spread</value>
        [DataMember(Name="productType", EmitDefaultValue=false)]
        public ProductTypeEnum? ProductType { get; set; }
        /// <summary>
        /// Inactive, Locked, ReadyForContracts, ReadyToTrade, Verified
        /// </summary>
        /// <value>Inactive, Locked, ReadyForContracts, ReadyToTrade, Verified</value>
        [DataMember(Name="productVerificationStatus", EmitDefaultValue=false)]
        public ProductVerificationStatusEnum? ProductVerificationStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAccountRiskParameter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserAccountRiskParameter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAccountRiskParameter" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="ContractId">id of Contract.</param>
        /// <param name="ProductId">id of Product.</param>
        /// <param name="ExchangeId">id of Exchange.</param>
        /// <param name="ProductType">Futures, Options, Spread.</param>
        /// <param name="RiskDiscountContractGroupId">id of RiskDiscountContractGroup.</param>
        /// <param name="ProductVerificationStatus">Inactive, Locked, ReadyForContracts, ReadyToTrade, Verified.</param>
        /// <param name="ContractGroupId">id of ContractGroup.</param>
        /// <param name="MaxOpeningOrderQty">MaxOpeningOrderQty.</param>
        /// <param name="MaxClosingOrderQty">MaxClosingOrderQty.</param>
        /// <param name="MaxBackMonth">MaxBackMonth.</param>
        /// <param name="PreExpirationDays">PreExpirationDays.</param>
        /// <param name="MarginPercentage">MarginPercentage.</param>
        /// <param name="MarginDollarValue">MarginDollarValue.</param>
        /// <param name="HardLimit">HardLimit.</param>
        /// <param name="UserAccountPositionLimitId">id of UserAccountPositionLimit (required).</param>
        public UserAccountRiskParameter(int? Id = null, int? ContractId = null, int? ProductId = null, int? ExchangeId = null, ProductTypeEnum? ProductType = null, int? RiskDiscountContractGroupId = null, ProductVerificationStatusEnum? ProductVerificationStatus = null, int? ContractGroupId = null, int? MaxOpeningOrderQty = null, int? MaxClosingOrderQty = null, int? MaxBackMonth = null, int? PreExpirationDays = null, double? MarginPercentage = null, double? MarginDollarValue = null, bool? HardLimit = null, int? UserAccountPositionLimitId = null)
        {
            // to ensure "UserAccountPositionLimitId" is required (not null)
            if (UserAccountPositionLimitId == null)
            {
                throw new InvalidDataException("UserAccountPositionLimitId is a required property for UserAccountRiskParameter and cannot be null");
            }
            else
            {
                this.UserAccountPositionLimitId = UserAccountPositionLimitId;
            }
            this.Id = Id;
            this.ContractId = ContractId;
            this.ProductId = ProductId;
            this.ExchangeId = ExchangeId;
            this.ProductType = ProductType;
            this.RiskDiscountContractGroupId = RiskDiscountContractGroupId;
            this.ProductVerificationStatus = ProductVerificationStatus;
            this.ContractGroupId = ContractGroupId;
            this.MaxOpeningOrderQty = MaxOpeningOrderQty;
            this.MaxClosingOrderQty = MaxClosingOrderQty;
            this.MaxBackMonth = MaxBackMonth;
            this.PreExpirationDays = PreExpirationDays;
            this.MarginPercentage = MarginPercentage;
            this.MarginDollarValue = MarginDollarValue;
            this.HardLimit = HardLimit;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// id of Contract
        /// </summary>
        /// <value>id of Contract</value>
        [DataMember(Name="contractId", EmitDefaultValue=false)]
        public int? ContractId { get; set; }
        /// <summary>
        /// id of Product
        /// </summary>
        /// <value>id of Product</value>
        [DataMember(Name="productId", EmitDefaultValue=false)]
        public int? ProductId { get; set; }
        /// <summary>
        /// id of Exchange
        /// </summary>
        /// <value>id of Exchange</value>
        [DataMember(Name="exchangeId", EmitDefaultValue=false)]
        public int? ExchangeId { get; set; }
        /// <summary>
        /// id of RiskDiscountContractGroup
        /// </summary>
        /// <value>id of RiskDiscountContractGroup</value>
        [DataMember(Name="riskDiscountContractGroupId", EmitDefaultValue=false)]
        public int? RiskDiscountContractGroupId { get; set; }
        /// <summary>
        /// id of ContractGroup
        /// </summary>
        /// <value>id of ContractGroup</value>
        [DataMember(Name="contractGroupId", EmitDefaultValue=false)]
        public int? ContractGroupId { get; set; }
        /// <summary>
        /// Gets or Sets MaxOpeningOrderQty
        /// </summary>
        [DataMember(Name="maxOpeningOrderQty", EmitDefaultValue=false)]
        public int? MaxOpeningOrderQty { get; set; }
        /// <summary>
        /// Gets or Sets MaxClosingOrderQty
        /// </summary>
        [DataMember(Name="maxClosingOrderQty", EmitDefaultValue=false)]
        public int? MaxClosingOrderQty { get; set; }
        /// <summary>
        /// Gets or Sets MaxBackMonth
        /// </summary>
        [DataMember(Name="maxBackMonth", EmitDefaultValue=false)]
        public int? MaxBackMonth { get; set; }
        /// <summary>
        /// Gets or Sets PreExpirationDays
        /// </summary>
        [DataMember(Name="preExpirationDays", EmitDefaultValue=false)]
        public int? PreExpirationDays { get; set; }
        /// <summary>
        /// Gets or Sets MarginPercentage
        /// </summary>
        [DataMember(Name="marginPercentage", EmitDefaultValue=false)]
        public double? MarginPercentage { get; set; }
        /// <summary>
        /// Gets or Sets MarginDollarValue
        /// </summary>
        [DataMember(Name="marginDollarValue", EmitDefaultValue=false)]
        public double? MarginDollarValue { get; set; }
        /// <summary>
        /// Gets or Sets HardLimit
        /// </summary>
        [DataMember(Name="hardLimit", EmitDefaultValue=false)]
        public bool? HardLimit { get; set; }
        /// <summary>
        /// id of UserAccountPositionLimit
        /// </summary>
        /// <value>id of UserAccountPositionLimit</value>
        [DataMember(Name="userAccountPositionLimitId", EmitDefaultValue=false)]
        public int? UserAccountPositionLimitId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAccountRiskParameter {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ContractId: ").Append(ContractId).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  ExchangeId: ").Append(ExchangeId).Append("\n");
            sb.Append("  ProductType: ").Append(ProductType).Append("\n");
            sb.Append("  RiskDiscountContractGroupId: ").Append(RiskDiscountContractGroupId).Append("\n");
            sb.Append("  ProductVerificationStatus: ").Append(ProductVerificationStatus).Append("\n");
            sb.Append("  ContractGroupId: ").Append(ContractGroupId).Append("\n");
            sb.Append("  MaxOpeningOrderQty: ").Append(MaxOpeningOrderQty).Append("\n");
            sb.Append("  MaxClosingOrderQty: ").Append(MaxClosingOrderQty).Append("\n");
            sb.Append("  MaxBackMonth: ").Append(MaxBackMonth).Append("\n");
            sb.Append("  PreExpirationDays: ").Append(PreExpirationDays).Append("\n");
            sb.Append("  MarginPercentage: ").Append(MarginPercentage).Append("\n");
            sb.Append("  MarginDollarValue: ").Append(MarginDollarValue).Append("\n");
            sb.Append("  HardLimit: ").Append(HardLimit).Append("\n");
            sb.Append("  UserAccountPositionLimitId: ").Append(UserAccountPositionLimitId).Append("\n");
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
            return this.Equals(obj as UserAccountRiskParameter);
        }

        /// <summary>
        /// Returns true if UserAccountRiskParameter instances are equal
        /// </summary>
        /// <param name="other">Instance of UserAccountRiskParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAccountRiskParameter other)
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
                    this.ContractId == other.ContractId ||
                    this.ContractId != null &&
                    this.ContractId.Equals(other.ContractId)
                ) && 
                (
                    this.ProductId == other.ProductId ||
                    this.ProductId != null &&
                    this.ProductId.Equals(other.ProductId)
                ) && 
                (
                    this.ExchangeId == other.ExchangeId ||
                    this.ExchangeId != null &&
                    this.ExchangeId.Equals(other.ExchangeId)
                ) && 
                (
                    this.ProductType == other.ProductType ||
                    this.ProductType != null &&
                    this.ProductType.Equals(other.ProductType)
                ) && 
                (
                    this.RiskDiscountContractGroupId == other.RiskDiscountContractGroupId ||
                    this.RiskDiscountContractGroupId != null &&
                    this.RiskDiscountContractGroupId.Equals(other.RiskDiscountContractGroupId)
                ) && 
                (
                    this.ProductVerificationStatus == other.ProductVerificationStatus ||
                    this.ProductVerificationStatus != null &&
                    this.ProductVerificationStatus.Equals(other.ProductVerificationStatus)
                ) && 
                (
                    this.ContractGroupId == other.ContractGroupId ||
                    this.ContractGroupId != null &&
                    this.ContractGroupId.Equals(other.ContractGroupId)
                ) && 
                (
                    this.MaxOpeningOrderQty == other.MaxOpeningOrderQty ||
                    this.MaxOpeningOrderQty != null &&
                    this.MaxOpeningOrderQty.Equals(other.MaxOpeningOrderQty)
                ) && 
                (
                    this.MaxClosingOrderQty == other.MaxClosingOrderQty ||
                    this.MaxClosingOrderQty != null &&
                    this.MaxClosingOrderQty.Equals(other.MaxClosingOrderQty)
                ) && 
                (
                    this.MaxBackMonth == other.MaxBackMonth ||
                    this.MaxBackMonth != null &&
                    this.MaxBackMonth.Equals(other.MaxBackMonth)
                ) && 
                (
                    this.PreExpirationDays == other.PreExpirationDays ||
                    this.PreExpirationDays != null &&
                    this.PreExpirationDays.Equals(other.PreExpirationDays)
                ) && 
                (
                    this.MarginPercentage == other.MarginPercentage ||
                    this.MarginPercentage != null &&
                    this.MarginPercentage.Equals(other.MarginPercentage)
                ) && 
                (
                    this.MarginDollarValue == other.MarginDollarValue ||
                    this.MarginDollarValue != null &&
                    this.MarginDollarValue.Equals(other.MarginDollarValue)
                ) && 
                (
                    this.HardLimit == other.HardLimit ||
                    this.HardLimit != null &&
                    this.HardLimit.Equals(other.HardLimit)
                ) && 
                (
                    this.UserAccountPositionLimitId == other.UserAccountPositionLimitId ||
                    this.UserAccountPositionLimitId != null &&
                    this.UserAccountPositionLimitId.Equals(other.UserAccountPositionLimitId)
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
                if (this.ContractId != null)
                    hash = hash * 59 + this.ContractId.GetHashCode();
                if (this.ProductId != null)
                    hash = hash * 59 + this.ProductId.GetHashCode();
                if (this.ExchangeId != null)
                    hash = hash * 59 + this.ExchangeId.GetHashCode();
                if (this.ProductType != null)
                    hash = hash * 59 + this.ProductType.GetHashCode();
                if (this.RiskDiscountContractGroupId != null)
                    hash = hash * 59 + this.RiskDiscountContractGroupId.GetHashCode();
                if (this.ProductVerificationStatus != null)
                    hash = hash * 59 + this.ProductVerificationStatus.GetHashCode();
                if (this.ContractGroupId != null)
                    hash = hash * 59 + this.ContractGroupId.GetHashCode();
                if (this.MaxOpeningOrderQty != null)
                    hash = hash * 59 + this.MaxOpeningOrderQty.GetHashCode();
                if (this.MaxClosingOrderQty != null)
                    hash = hash * 59 + this.MaxClosingOrderQty.GetHashCode();
                if (this.MaxBackMonth != null)
                    hash = hash * 59 + this.MaxBackMonth.GetHashCode();
                if (this.PreExpirationDays != null)
                    hash = hash * 59 + this.PreExpirationDays.GetHashCode();
                if (this.MarginPercentage != null)
                    hash = hash * 59 + this.MarginPercentage.GetHashCode();
                if (this.MarginDollarValue != null)
                    hash = hash * 59 + this.MarginDollarValue.GetHashCode();
                if (this.HardLimit != null)
                    hash = hash * 59 + this.HardLimit.GetHashCode();
                if (this.UserAccountPositionLimitId != null)
                    hash = hash * 59 + this.UserAccountPositionLimitId.GetHashCode();
                return hash;
            }
        }
    }

}