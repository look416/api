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
    /// CashBalanceSnapshot
    /// </summary>
    [DataContract]
    public partial class CashBalanceSnapshot :  IEquatable<CashBalanceSnapshot>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CashBalanceSnapshot" /> class.
        /// </summary>
        /// <param name="ErrorText">Non-empty if the request failed.</param>
        /// <param name="TotalCashValue">TotalCashValue.</param>
        /// <param name="TotalPnL">TotalPnL.</param>
        /// <param name="InitialMargin">InitialMargin.</param>
        /// <param name="MaintenanceMargin">MaintenanceMargin.</param>
        /// <param name="NetLiq">NetLiq.</param>
        public CashBalanceSnapshot(string ErrorText = null, double? TotalCashValue = null, double? TotalPnL = null, double? InitialMargin = null, double? MaintenanceMargin = null, double? NetLiq = null)
        {
            this.ErrorText = ErrorText;
            this.TotalCashValue = TotalCashValue;
            this.TotalPnL = TotalPnL;
            this.InitialMargin = InitialMargin;
            this.MaintenanceMargin = MaintenanceMargin;
            this.NetLiq = NetLiq;
        }
        
        /// <summary>
        /// Non-empty if the request failed
        /// </summary>
        /// <value>Non-empty if the request failed</value>
        [DataMember(Name="errorText", EmitDefaultValue=false)]
        public string ErrorText { get; set; }
        /// <summary>
        /// Gets or Sets TotalCashValue
        /// </summary>
        [DataMember(Name="totalCashValue", EmitDefaultValue=false)]
        public double? TotalCashValue { get; set; }
        /// <summary>
        /// Gets or Sets TotalPnL
        /// </summary>
        [DataMember(Name="totalPnL", EmitDefaultValue=false)]
        public double? TotalPnL { get; set; }
        /// <summary>
        /// Gets or Sets InitialMargin
        /// </summary>
        [DataMember(Name="initialMargin", EmitDefaultValue=false)]
        public double? InitialMargin { get; set; }
        /// <summary>
        /// Gets or Sets MaintenanceMargin
        /// </summary>
        [DataMember(Name="maintenanceMargin", EmitDefaultValue=false)]
        public double? MaintenanceMargin { get; set; }
        /// <summary>
        /// Gets or Sets NetLiq
        /// </summary>
        [DataMember(Name="netLiq", EmitDefaultValue=false)]
        public double? NetLiq { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CashBalanceSnapshot {\n");
            sb.Append("  ErrorText: ").Append(ErrorText).Append("\n");
            sb.Append("  TotalCashValue: ").Append(TotalCashValue).Append("\n");
            sb.Append("  TotalPnL: ").Append(TotalPnL).Append("\n");
            sb.Append("  InitialMargin: ").Append(InitialMargin).Append("\n");
            sb.Append("  MaintenanceMargin: ").Append(MaintenanceMargin).Append("\n");
            sb.Append("  NetLiq: ").Append(NetLiq).Append("\n");
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
            return this.Equals(obj as CashBalanceSnapshot);
        }

        /// <summary>
        /// Returns true if CashBalanceSnapshot instances are equal
        /// </summary>
        /// <param name="other">Instance of CashBalanceSnapshot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CashBalanceSnapshot other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ErrorText == other.ErrorText ||
                    this.ErrorText != null &&
                    this.ErrorText.Equals(other.ErrorText)
                ) && 
                (
                    this.TotalCashValue == other.TotalCashValue ||
                    this.TotalCashValue != null &&
                    this.TotalCashValue.Equals(other.TotalCashValue)
                ) && 
                (
                    this.TotalPnL == other.TotalPnL ||
                    this.TotalPnL != null &&
                    this.TotalPnL.Equals(other.TotalPnL)
                ) && 
                (
                    this.InitialMargin == other.InitialMargin ||
                    this.InitialMargin != null &&
                    this.InitialMargin.Equals(other.InitialMargin)
                ) && 
                (
                    this.MaintenanceMargin == other.MaintenanceMargin ||
                    this.MaintenanceMargin != null &&
                    this.MaintenanceMargin.Equals(other.MaintenanceMargin)
                ) && 
                (
                    this.NetLiq == other.NetLiq ||
                    this.NetLiq != null &&
                    this.NetLiq.Equals(other.NetLiq)
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
                if (this.ErrorText != null)
                    hash = hash * 59 + this.ErrorText.GetHashCode();
                if (this.TotalCashValue != null)
                    hash = hash * 59 + this.TotalCashValue.GetHashCode();
                if (this.TotalPnL != null)
                    hash = hash * 59 + this.TotalPnL.GetHashCode();
                if (this.InitialMargin != null)
                    hash = hash * 59 + this.InitialMargin.GetHashCode();
                if (this.MaintenanceMargin != null)
                    hash = hash * 59 + this.MaintenanceMargin.GetHashCode();
                if (this.NetLiq != null)
                    hash = hash * 59 + this.NetLiq.GetHashCode();
                return hash;
            }
        }
    }

}
