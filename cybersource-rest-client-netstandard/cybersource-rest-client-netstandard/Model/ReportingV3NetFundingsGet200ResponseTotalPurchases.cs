/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// ReportingV3NetFundingsGet200ResponseTotalPurchases
    /// </summary>
    [DataContract]
    public partial class ReportingV3NetFundingsGet200ResponseTotalPurchases :  IEquatable<ReportingV3NetFundingsGet200ResponseTotalPurchases>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingV3NetFundingsGet200ResponseTotalPurchases" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReportingV3NetFundingsGet200ResponseTotalPurchases() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingV3NetFundingsGet200ResponseTotalPurchases" /> class.
        /// </summary>
        /// <param name="Currency">Valid ISO 4217 ALPHA-3 currency code (required).</param>
        /// <param name="Value">Value (required).</param>
        public ReportingV3NetFundingsGet200ResponseTotalPurchases(string Currency = default(string), string Value = default(string))
        {
            this.Currency = Currency;
            this.Value = Value;
        }
        
        /// <summary>
        /// Valid ISO 4217 ALPHA-3 currency code
        /// </summary>
        /// <value>Valid ISO 4217 ALPHA-3 currency code</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportingV3NetFundingsGet200ResponseTotalPurchases {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as ReportingV3NetFundingsGet200ResponseTotalPurchases);
        }

        /// <summary>
        /// Returns true if ReportingV3NetFundingsGet200ResponseTotalPurchases instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportingV3NetFundingsGet200ResponseTotalPurchases to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingV3NetFundingsGet200ResponseTotalPurchases other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
