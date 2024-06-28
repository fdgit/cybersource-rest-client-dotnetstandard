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
    /// Accountupdaterv1batchesIncludedTokens
    /// </summary>
    [DataContract]
    public partial class Accountupdaterv1batchesIncludedTokens :  IEquatable<Accountupdaterv1batchesIncludedTokens>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Accountupdaterv1batchesIncludedTokens" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Accountupdaterv1batchesIncludedTokens() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Accountupdaterv1batchesIncludedTokens" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="ExpirationMonth">ExpirationMonth.</param>
        /// <param name="ExpirationYear">ExpirationYear.</param>
        public Accountupdaterv1batchesIncludedTokens(string Id = default(string), string ExpirationMonth = default(string), string ExpirationYear = default(string))
        {
            this.Id = Id;
            this.ExpirationMonth = ExpirationMonth;
            this.ExpirationYear = ExpirationYear;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationMonth
        /// </summary>
        [DataMember(Name="expirationMonth", EmitDefaultValue=false)]
        public string ExpirationMonth { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationYear
        /// </summary>
        [DataMember(Name="expirationYear", EmitDefaultValue=false)]
        public string ExpirationYear { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Accountupdaterv1batchesIncludedTokens {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ExpirationMonth: ").Append(ExpirationMonth).Append("\n");
            sb.Append("  ExpirationYear: ").Append(ExpirationYear).Append("\n");
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
            return this.Equals(obj as Accountupdaterv1batchesIncludedTokens);
        }

        /// <summary>
        /// Returns true if Accountupdaterv1batchesIncludedTokens instances are equal
        /// </summary>
        /// <param name="other">Instance of Accountupdaterv1batchesIncludedTokens to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Accountupdaterv1batchesIncludedTokens other)
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
                    this.ExpirationMonth == other.ExpirationMonth ||
                    this.ExpirationMonth != null &&
                    this.ExpirationMonth.Equals(other.ExpirationMonth)
                ) && 
                (
                    this.ExpirationYear == other.ExpirationYear ||
                    this.ExpirationYear != null &&
                    this.ExpirationYear.Equals(other.ExpirationYear)
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
                if (this.ExpirationMonth != null)
                    hash = hash * 59 + this.ExpirationMonth.GetHashCode();
                if (this.ExpirationYear != null)
                    hash = hash * 59 + this.ExpirationYear.GetHashCode();
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
