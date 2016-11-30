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
    /// OpenDemoAccount
    /// </summary>
    [DataContract]
    public partial class OpenDemoAccount :  IEquatable<OpenDemoAccount>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenDemoAccount" /> class.
        /// </summary>
        /// <param name="TemplateAccountId">id of Account.</param>
        /// <param name="Name">Name.</param>
        /// <param name="InitialBalance">InitialBalance.</param>
        public OpenDemoAccount(int? TemplateAccountId = null, string Name = null, double? InitialBalance = null)
        {
            this.TemplateAccountId = TemplateAccountId;
            this.Name = Name;
            this.InitialBalance = InitialBalance;
        }
        
        /// <summary>
        /// id of Account
        /// </summary>
        /// <value>id of Account</value>
        [DataMember(Name="templateAccountId", EmitDefaultValue=false)]
        public int? TemplateAccountId { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets InitialBalance
        /// </summary>
        [DataMember(Name="initialBalance", EmitDefaultValue=false)]
        public double? InitialBalance { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpenDemoAccount {\n");
            sb.Append("  TemplateAccountId: ").Append(TemplateAccountId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  InitialBalance: ").Append(InitialBalance).Append("\n");
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
            return this.Equals(obj as OpenDemoAccount);
        }

        /// <summary>
        /// Returns true if OpenDemoAccount instances are equal
        /// </summary>
        /// <param name="other">Instance of OpenDemoAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenDemoAccount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TemplateAccountId == other.TemplateAccountId ||
                    this.TemplateAccountId != null &&
                    this.TemplateAccountId.Equals(other.TemplateAccountId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.InitialBalance == other.InitialBalance ||
                    this.InitialBalance != null &&
                    this.InitialBalance.Equals(other.InitialBalance)
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
                if (this.TemplateAccountId != null)
                    hash = hash * 59 + this.TemplateAccountId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.InitialBalance != null)
                    hash = hash * 59 + this.InitialBalance.GetHashCode();
                return hash;
            }
        }
    }

}
