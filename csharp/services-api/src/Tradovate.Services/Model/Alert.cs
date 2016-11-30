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
    /// Alert
    /// </summary>
    [DataContract]
    public partial class Alert :  IEquatable<Alert>
    {
        /// <summary>
        /// Active, Expired, Failed, Inactive, TriggeredOut
        /// </summary>
        /// <value>Active, Expired, Failed, Inactive, TriggeredOut</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Active for "Active"
            /// </summary>
            [EnumMember(Value = "Active")]
            Active,
            
            /// <summary>
            /// Enum Inactive for "Inactive"
            /// </summary>
            [EnumMember(Value = "Inactive")]
            Inactive,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed,
            
            /// <summary>
            /// Enum Expired for "Expired"
            /// </summary>
            [EnumMember(Value = "Expired")]
            Expired,
            
            /// <summary>
            /// Enum TriggeredOut for "TriggeredOut"
            /// </summary>
            [EnumMember(Value = "TriggeredOut")]
            TriggeredOut
        }

        /// <summary>
        /// Active, Expired, Failed, Inactive, TriggeredOut
        /// </summary>
        /// <value>Active, Expired, Failed, Inactive, TriggeredOut</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Alert" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Alert() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Alert" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Timestamp">Timestamp (required).</param>
        /// <param name="UserId">id of User (required).</param>
        /// <param name="Status">Active, Expired, Failed, Inactive, TriggeredOut (required).</param>
        /// <param name="Expression">Expression (required).</param>
        /// <param name="ValidUntil">ValidUntil.</param>
        /// <param name="TriggerLimits">TriggerLimits.</param>
        /// <param name="TriggeredCounter">TriggeredCounter.</param>
        /// <param name="Failure">Failure.</param>
        /// <param name="Message">Message.</param>
        public Alert(int? Id = null, DateTime? Timestamp = null, int? UserId = null, StatusEnum? Status = null, string Expression = null, DateTime? ValidUntil = null, int? TriggerLimits = null, int? TriggeredCounter = null, string Failure = null, string Message = null)
        {
            // to ensure "Timestamp" is required (not null)
            if (Timestamp == null)
            {
                throw new InvalidDataException("Timestamp is a required property for Alert and cannot be null");
            }
            else
            {
                this.Timestamp = Timestamp;
            }
            // to ensure "UserId" is required (not null)
            if (UserId == null)
            {
                throw new InvalidDataException("UserId is a required property for Alert and cannot be null");
            }
            else
            {
                this.UserId = UserId;
            }
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for Alert and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            // to ensure "Expression" is required (not null)
            if (Expression == null)
            {
                throw new InvalidDataException("Expression is a required property for Alert and cannot be null");
            }
            else
            {
                this.Expression = Expression;
            }
            this.Id = Id;
            this.ValidUntil = ValidUntil;
            this.TriggerLimits = TriggerLimits;
            this.TriggeredCounter = TriggeredCounter;
            this.Failure = Failure;
            this.Message = Message;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }
        /// <summary>
        /// id of User
        /// </summary>
        /// <value>id of User</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }
        /// <summary>
        /// Gets or Sets Expression
        /// </summary>
        [DataMember(Name="expression", EmitDefaultValue=false)]
        public string Expression { get; set; }
        /// <summary>
        /// Gets or Sets ValidUntil
        /// </summary>
        [DataMember(Name="validUntil", EmitDefaultValue=false)]
        public DateTime? ValidUntil { get; set; }
        /// <summary>
        /// Gets or Sets TriggerLimits
        /// </summary>
        [DataMember(Name="triggerLimits", EmitDefaultValue=false)]
        public int? TriggerLimits { get; set; }
        /// <summary>
        /// Gets or Sets TriggeredCounter
        /// </summary>
        [DataMember(Name="triggeredCounter", EmitDefaultValue=false)]
        public int? TriggeredCounter { get; set; }
        /// <summary>
        /// Gets or Sets Failure
        /// </summary>
        [DataMember(Name="failure", EmitDefaultValue=false)]
        public string Failure { get; set; }
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Alert {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Expression: ").Append(Expression).Append("\n");
            sb.Append("  ValidUntil: ").Append(ValidUntil).Append("\n");
            sb.Append("  TriggerLimits: ").Append(TriggerLimits).Append("\n");
            sb.Append("  TriggeredCounter: ").Append(TriggeredCounter).Append("\n");
            sb.Append("  Failure: ").Append(Failure).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(obj as Alert);
        }

        /// <summary>
        /// Returns true if Alert instances are equal
        /// </summary>
        /// <param name="other">Instance of Alert to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Alert other)
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
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Expression == other.Expression ||
                    this.Expression != null &&
                    this.Expression.Equals(other.Expression)
                ) && 
                (
                    this.ValidUntil == other.ValidUntil ||
                    this.ValidUntil != null &&
                    this.ValidUntil.Equals(other.ValidUntil)
                ) && 
                (
                    this.TriggerLimits == other.TriggerLimits ||
                    this.TriggerLimits != null &&
                    this.TriggerLimits.Equals(other.TriggerLimits)
                ) && 
                (
                    this.TriggeredCounter == other.TriggeredCounter ||
                    this.TriggeredCounter != null &&
                    this.TriggeredCounter.Equals(other.TriggeredCounter)
                ) && 
                (
                    this.Failure == other.Failure ||
                    this.Failure != null &&
                    this.Failure.Equals(other.Failure)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
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
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Expression != null)
                    hash = hash * 59 + this.Expression.GetHashCode();
                if (this.ValidUntil != null)
                    hash = hash * 59 + this.ValidUntil.GetHashCode();
                if (this.TriggerLimits != null)
                    hash = hash * 59 + this.TriggerLimits.GetHashCode();
                if (this.TriggeredCounter != null)
                    hash = hash * 59 + this.TriggeredCounter.GetHashCode();
                if (this.Failure != null)
                    hash = hash * 59 + this.Failure.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                return hash;
            }
        }
    }

}
