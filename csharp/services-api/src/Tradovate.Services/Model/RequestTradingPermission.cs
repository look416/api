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
    /// RequestTradingPermission
    /// </summary>
    [DataContract]
    public partial class RequestTradingPermission :  IEquatable<RequestTradingPermission>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestTradingPermission" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RequestTradingPermission() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestTradingPermission" /> class.
        /// </summary>
        /// <param name="AccountId">id of Account (required).</param>
        /// <param name="CtaContact">CtaContact (required).</param>
        /// <param name="CtaEmail">CtaEmail (required).</param>
        public RequestTradingPermission(int? AccountId = null, string CtaContact = null, string CtaEmail = null)
        {
            // to ensure "AccountId" is required (not null)
            if (AccountId == null)
            {
                throw new InvalidDataException("AccountId is a required property for RequestTradingPermission and cannot be null");
            }
            else
            {
                this.AccountId = AccountId;
            }
            // to ensure "CtaContact" is required (not null)
            if (CtaContact == null)
            {
                throw new InvalidDataException("CtaContact is a required property for RequestTradingPermission and cannot be null");
            }
            else
            {
                this.CtaContact = CtaContact;
            }
            // to ensure "CtaEmail" is required (not null)
            if (CtaEmail == null)
            {
                throw new InvalidDataException("CtaEmail is a required property for RequestTradingPermission and cannot be null");
            }
            else
            {
                this.CtaEmail = CtaEmail;
            }
        }
        
        /// <summary>
        /// id of Account
        /// </summary>
        /// <value>id of Account</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public int? AccountId { get; set; }
        /// <summary>
        /// Gets or Sets CtaContact
        /// </summary>
        [DataMember(Name="ctaContact", EmitDefaultValue=false)]
        public string CtaContact { get; set; }
        /// <summary>
        /// Gets or Sets CtaEmail
        /// </summary>
        [DataMember(Name="ctaEmail", EmitDefaultValue=false)]
        public string CtaEmail { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestTradingPermission {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  CtaContact: ").Append(CtaContact).Append("\n");
            sb.Append("  CtaEmail: ").Append(CtaEmail).Append("\n");
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
            return this.Equals(obj as RequestTradingPermission);
        }

        /// <summary>
        /// Returns true if RequestTradingPermission instances are equal
        /// </summary>
        /// <param name="other">Instance of RequestTradingPermission to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestTradingPermission other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
                (
                    this.CtaContact == other.CtaContact ||
                    this.CtaContact != null &&
                    this.CtaContact.Equals(other.CtaContact)
                ) && 
                (
                    this.CtaEmail == other.CtaEmail ||
                    this.CtaEmail != null &&
                    this.CtaEmail.Equals(other.CtaEmail)
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
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.CtaContact != null)
                    hash = hash * 59 + this.CtaContact.GetHashCode();
                if (this.CtaEmail != null)
                    hash = hash * 59 + this.CtaEmail.GetHashCode();
                return hash;
            }
        }
    }

}