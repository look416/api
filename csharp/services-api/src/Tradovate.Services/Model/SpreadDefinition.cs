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
    /// SpreadDefinition
    /// </summary>
    [DataContract]
    public partial class SpreadDefinition :  IEquatable<SpreadDefinition>
    {
        /// <summary>
        /// Bundle, BundleSpread, Butterfly, CalendarSpread, Condor, Crack, DoubleButterfly, General, IntercommoditySpread, LaggedIntercommoditySpread, Pack, PackButterfly, PackSpread, ReducedTickCalendarSpread, ReverseIntercommoditySpread, ReverseSpread, Strip, TreasuryIntercommoditySpread
        /// </summary>
        /// <value>Bundle, BundleSpread, Butterfly, CalendarSpread, Condor, Crack, DoubleButterfly, General, IntercommoditySpread, LaggedIntercommoditySpread, Pack, PackButterfly, PackSpread, ReducedTickCalendarSpread, ReverseIntercommoditySpread, ReverseSpread, Strip, TreasuryIntercommoditySpread</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SpreadTypeEnum
        {
            
            /// <summary>
            /// Enum ReverseIntercommoditySpread for "ReverseIntercommoditySpread"
            /// </summary>
            [EnumMember(Value = "ReverseIntercommoditySpread")]
            ReverseIntercommoditySpread,
            
            /// <summary>
            /// Enum Strip for "Strip"
            /// </summary>
            [EnumMember(Value = "Strip")]
            Strip,
            
            /// <summary>
            /// Enum ReducedTickCalendarSpread for "ReducedTickCalendarSpread"
            /// </summary>
            [EnumMember(Value = "ReducedTickCalendarSpread")]
            ReducedTickCalendarSpread,
            
            /// <summary>
            /// Enum TreasuryIntercommoditySpread for "TreasuryIntercommoditySpread"
            /// </summary>
            [EnumMember(Value = "TreasuryIntercommoditySpread")]
            TreasuryIntercommoditySpread,
            
            /// <summary>
            /// Enum LaggedIntercommoditySpread for "LaggedIntercommoditySpread"
            /// </summary>
            [EnumMember(Value = "LaggedIntercommoditySpread")]
            LaggedIntercommoditySpread,
            
            /// <summary>
            /// Enum DoubleButterfly for "DoubleButterfly"
            /// </summary>
            [EnumMember(Value = "DoubleButterfly")]
            DoubleButterfly,
            
            /// <summary>
            /// Enum BundleSpread for "BundleSpread"
            /// </summary>
            [EnumMember(Value = "BundleSpread")]
            BundleSpread,
            
            /// <summary>
            /// Enum PackButterfly for "PackButterfly"
            /// </summary>
            [EnumMember(Value = "PackButterfly")]
            PackButterfly,
            
            /// <summary>
            /// Enum ReverseSpread for "ReverseSpread"
            /// </summary>
            [EnumMember(Value = "ReverseSpread")]
            ReverseSpread,
            
            /// <summary>
            /// Enum Pack for "Pack"
            /// </summary>
            [EnumMember(Value = "Pack")]
            Pack,
            
            /// <summary>
            /// Enum Crack for "Crack"
            /// </summary>
            [EnumMember(Value = "Crack")]
            Crack,
            
            /// <summary>
            /// Enum General for "General"
            /// </summary>
            [EnumMember(Value = "General")]
            General,
            
            /// <summary>
            /// Enum Condor for "Condor"
            /// </summary>
            [EnumMember(Value = "Condor")]
            Condor,
            
            /// <summary>
            /// Enum PackSpread for "PackSpread"
            /// </summary>
            [EnumMember(Value = "PackSpread")]
            PackSpread,
            
            /// <summary>
            /// Enum CalendarSpread for "CalendarSpread"
            /// </summary>
            [EnumMember(Value = "CalendarSpread")]
            CalendarSpread,
            
            /// <summary>
            /// Enum Bundle for "Bundle"
            /// </summary>
            [EnumMember(Value = "Bundle")]
            Bundle,
            
            /// <summary>
            /// Enum Butterfly for "Butterfly"
            /// </summary>
            [EnumMember(Value = "Butterfly")]
            Butterfly,
            
            /// <summary>
            /// Enum IntercommoditySpread for "IntercommoditySpread"
            /// </summary>
            [EnumMember(Value = "IntercommoditySpread")]
            IntercommoditySpread
        }

        /// <summary>
        /// Bundle, BundleSpread, Butterfly, CalendarSpread, Condor, Crack, DoubleButterfly, General, IntercommoditySpread, LaggedIntercommoditySpread, Pack, PackButterfly, PackSpread, ReducedTickCalendarSpread, ReverseIntercommoditySpread, ReverseSpread, Strip, TreasuryIntercommoditySpread
        /// </summary>
        /// <value>Bundle, BundleSpread, Butterfly, CalendarSpread, Condor, Crack, DoubleButterfly, General, IntercommoditySpread, LaggedIntercommoditySpread, Pack, PackButterfly, PackSpread, ReducedTickCalendarSpread, ReverseIntercommoditySpread, ReverseSpread, Strip, TreasuryIntercommoditySpread</value>
        [DataMember(Name="spreadType", EmitDefaultValue=false)]
        public SpreadTypeEnum? SpreadType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SpreadDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SpreadDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SpreadDefinition" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Timestamp">Timestamp (required).</param>
        /// <param name="SpreadType">Bundle, BundleSpread, Butterfly, CalendarSpread, Condor, Crack, DoubleButterfly, General, IntercommoditySpread, LaggedIntercommoditySpread, Pack, PackButterfly, PackSpread, ReducedTickCalendarSpread, ReverseIntercommoditySpread, ReverseSpread, Strip, TreasuryIntercommoditySpread (required).</param>
        /// <param name="Uds">Uds (required).</param>
        public SpreadDefinition(int? Id = null, DateTime? Timestamp = null, SpreadTypeEnum? SpreadType = null, bool? Uds = null)
        {
            // to ensure "Timestamp" is required (not null)
            if (Timestamp == null)
            {
                throw new InvalidDataException("Timestamp is a required property for SpreadDefinition and cannot be null");
            }
            else
            {
                this.Timestamp = Timestamp;
            }
            // to ensure "SpreadType" is required (not null)
            if (SpreadType == null)
            {
                throw new InvalidDataException("SpreadType is a required property for SpreadDefinition and cannot be null");
            }
            else
            {
                this.SpreadType = SpreadType;
            }
            // to ensure "Uds" is required (not null)
            if (Uds == null)
            {
                throw new InvalidDataException("Uds is a required property for SpreadDefinition and cannot be null");
            }
            else
            {
                this.Uds = Uds;
            }
            this.Id = Id;
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
        /// Gets or Sets Uds
        /// </summary>
        [DataMember(Name="uds", EmitDefaultValue=false)]
        public bool? Uds { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpreadDefinition {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  SpreadType: ").Append(SpreadType).Append("\n");
            sb.Append("  Uds: ").Append(Uds).Append("\n");
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
            return this.Equals(obj as SpreadDefinition);
        }

        /// <summary>
        /// Returns true if SpreadDefinition instances are equal
        /// </summary>
        /// <param name="other">Instance of SpreadDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpreadDefinition other)
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
                    this.SpreadType == other.SpreadType ||
                    this.SpreadType != null &&
                    this.SpreadType.Equals(other.SpreadType)
                ) && 
                (
                    this.Uds == other.Uds ||
                    this.Uds != null &&
                    this.Uds.Equals(other.Uds)
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
                if (this.SpreadType != null)
                    hash = hash * 59 + this.SpreadType.GetHashCode();
                if (this.Uds != null)
                    hash = hash * 59 + this.Uds.GetHashCode();
                return hash;
            }
        }
    }

}
