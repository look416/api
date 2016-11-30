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
    /// MarketDataSubscriptionPlan
    /// </summary>
    [DataContract]
    public partial class MarketDataSubscriptionPlan :  IEquatable<MarketDataSubscriptionPlan>
    {
        /// <summary>
        /// DOM, Top
        /// </summary>
        /// <value>DOM, Top</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DataTypeEnum
        {
            
            /// <summary>
            /// Enum Top for "Top"
            /// </summary>
            [EnumMember(Value = "Top")]
            Top,
            
            /// <summary>
            /// Enum DOM for "DOM"
            /// </summary>
            [EnumMember(Value = "DOM")]
            DOM
        }

        /// <summary>
        /// Either, NonProfessional, Professional
        /// </summary>
        /// <value>Either, NonProfessional, Professional</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProfessionalEnum
        {
            
            /// <summary>
            /// Enum NonProfessional for "NonProfessional"
            /// </summary>
            [EnumMember(Value = "NonProfessional")]
            NonProfessional,
            
            /// <summary>
            /// Enum Professional for "Professional"
            /// </summary>
            [EnumMember(Value = "Professional")]
            Professional,
            
            /// <summary>
            /// Enum Either for "Either"
            /// </summary>
            [EnumMember(Value = "Either")]
            Either
        }

        /// <summary>
        /// DOM, Top
        /// </summary>
        /// <value>DOM, Top</value>
        [DataMember(Name="dataType", EmitDefaultValue=false)]
        public DataTypeEnum? DataType { get; set; }
        /// <summary>
        /// Either, NonProfessional, Professional
        /// </summary>
        /// <value>Either, NonProfessional, Professional</value>
        [DataMember(Name="professional", EmitDefaultValue=false)]
        public ProfessionalEnum? Professional { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketDataSubscriptionPlan" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MarketDataSubscriptionPlan() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketDataSubscriptionPlan" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name (required).</param>
        /// <param name="Title">Title (required).</param>
        /// <param name="Price">Price (required).</param>
        /// <param name="StartDate">StartDate.</param>
        /// <param name="DiscontinuedDate">DiscontinuedDate.</param>
        /// <param name="ExchangeScopeId">id of MarketDataSubscriptionExchangeScope (required).</param>
        /// <param name="DataType">DOM, Top (required).</param>
        /// <param name="Professional">Either, NonProfessional, Professional (required).</param>
        public MarketDataSubscriptionPlan(int? Id = null, string Name = null, string Title = null, double? Price = null, TradeDate StartDate = null, TradeDate DiscontinuedDate = null, int? ExchangeScopeId = null, DataTypeEnum? DataType = null, ProfessionalEnum? Professional = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for MarketDataSubscriptionPlan and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Title" is required (not null)
            if (Title == null)
            {
                throw new InvalidDataException("Title is a required property for MarketDataSubscriptionPlan and cannot be null");
            }
            else
            {
                this.Title = Title;
            }
            // to ensure "Price" is required (not null)
            if (Price == null)
            {
                throw new InvalidDataException("Price is a required property for MarketDataSubscriptionPlan and cannot be null");
            }
            else
            {
                this.Price = Price;
            }
            // to ensure "ExchangeScopeId" is required (not null)
            if (ExchangeScopeId == null)
            {
                throw new InvalidDataException("ExchangeScopeId is a required property for MarketDataSubscriptionPlan and cannot be null");
            }
            else
            {
                this.ExchangeScopeId = ExchangeScopeId;
            }
            // to ensure "DataType" is required (not null)
            if (DataType == null)
            {
                throw new InvalidDataException("DataType is a required property for MarketDataSubscriptionPlan and cannot be null");
            }
            else
            {
                this.DataType = DataType;
            }
            // to ensure "Professional" is required (not null)
            if (Professional == null)
            {
                throw new InvalidDataException("Professional is a required property for MarketDataSubscriptionPlan and cannot be null");
            }
            else
            {
                this.Professional = Professional;
            }
            this.Id = Id;
            this.StartDate = StartDate;
            this.DiscontinuedDate = DiscontinuedDate;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public double? Price { get; set; }
        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public TradeDate StartDate { get; set; }
        /// <summary>
        /// Gets or Sets DiscontinuedDate
        /// </summary>
        [DataMember(Name="discontinuedDate", EmitDefaultValue=false)]
        public TradeDate DiscontinuedDate { get; set; }
        /// <summary>
        /// id of MarketDataSubscriptionExchangeScope
        /// </summary>
        /// <value>id of MarketDataSubscriptionExchangeScope</value>
        [DataMember(Name="exchangeScopeId", EmitDefaultValue=false)]
        public int? ExchangeScopeId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MarketDataSubscriptionPlan {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  DiscontinuedDate: ").Append(DiscontinuedDate).Append("\n");
            sb.Append("  ExchangeScopeId: ").Append(ExchangeScopeId).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  Professional: ").Append(Professional).Append("\n");
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
            return this.Equals(obj as MarketDataSubscriptionPlan);
        }

        /// <summary>
        /// Returns true if MarketDataSubscriptionPlan instances are equal
        /// </summary>
        /// <param name="other">Instance of MarketDataSubscriptionPlan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarketDataSubscriptionPlan other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.Price == other.Price ||
                    this.Price != null &&
                    this.Price.Equals(other.Price)
                ) && 
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) && 
                (
                    this.DiscontinuedDate == other.DiscontinuedDate ||
                    this.DiscontinuedDate != null &&
                    this.DiscontinuedDate.Equals(other.DiscontinuedDate)
                ) && 
                (
                    this.ExchangeScopeId == other.ExchangeScopeId ||
                    this.ExchangeScopeId != null &&
                    this.ExchangeScopeId.Equals(other.ExchangeScopeId)
                ) && 
                (
                    this.DataType == other.DataType ||
                    this.DataType != null &&
                    this.DataType.Equals(other.DataType)
                ) && 
                (
                    this.Professional == other.Professional ||
                    this.Professional != null &&
                    this.Professional.Equals(other.Professional)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Price != null)
                    hash = hash * 59 + this.Price.GetHashCode();
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                if (this.DiscontinuedDate != null)
                    hash = hash * 59 + this.DiscontinuedDate.GetHashCode();
                if (this.ExchangeScopeId != null)
                    hash = hash * 59 + this.ExchangeScopeId.GetHashCode();
                if (this.DataType != null)
                    hash = hash * 59 + this.DataType.GetHashCode();
                if (this.Professional != null)
                    hash = hash * 59 + this.Professional.GetHashCode();
                return hash;
            }
        }
    }

}
