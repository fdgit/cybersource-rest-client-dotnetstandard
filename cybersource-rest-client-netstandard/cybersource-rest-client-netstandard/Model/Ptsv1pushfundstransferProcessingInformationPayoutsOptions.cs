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
    /// Ptsv1pushfundstransferProcessingInformationPayoutsOptions
    /// </summary>
    [DataContract]
    public partial class Ptsv1pushfundstransferProcessingInformationPayoutsOptions :  IEquatable<Ptsv1pushfundstransferProcessingInformationPayoutsOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv1pushfundstransferProcessingInformationPayoutsOptions" /> class.
        /// </summary>
        /// <param name="SourceCurrency">Use a 3-character alpha currency code for source currency of the funds transfer.  Yellow Pepper Supported for cross border funds transfers.  ISO standard currencies: http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf .</param>
        /// <param name="DestinationCurrency">Use a 3-character alpha currency code for destination currency of the funds transfer.  Yellow Pepper Supported for cross border funds transfers.  ISO standard currencies: http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf .</param>
        public Ptsv1pushfundstransferProcessingInformationPayoutsOptions(string SourceCurrency = default(string), string DestinationCurrency = default(string))
        {
            this.SourceCurrency = SourceCurrency;
            this.DestinationCurrency = DestinationCurrency;
        }
        
        /// <summary>
        /// Use a 3-character alpha currency code for source currency of the funds transfer.  Yellow Pepper Supported for cross border funds transfers.  ISO standard currencies: http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf 
        /// </summary>
        /// <value>Use a 3-character alpha currency code for source currency of the funds transfer.  Yellow Pepper Supported for cross border funds transfers.  ISO standard currencies: http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf </value>
        [DataMember(Name="sourceCurrency", EmitDefaultValue=false)]
        public string SourceCurrency { get; set; }

        /// <summary>
        /// Use a 3-character alpha currency code for destination currency of the funds transfer.  Yellow Pepper Supported for cross border funds transfers.  ISO standard currencies: http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf 
        /// </summary>
        /// <value>Use a 3-character alpha currency code for destination currency of the funds transfer.  Yellow Pepper Supported for cross border funds transfers.  ISO standard currencies: http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf </value>
        [DataMember(Name="destinationCurrency", EmitDefaultValue=false)]
        public string DestinationCurrency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv1pushfundstransferProcessingInformationPayoutsOptions {\n");
            sb.Append("  SourceCurrency: ").Append(SourceCurrency).Append("\n");
            sb.Append("  DestinationCurrency: ").Append(DestinationCurrency).Append("\n");
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
            return this.Equals(obj as Ptsv1pushfundstransferProcessingInformationPayoutsOptions);
        }

        /// <summary>
        /// Returns true if Ptsv1pushfundstransferProcessingInformationPayoutsOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv1pushfundstransferProcessingInformationPayoutsOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv1pushfundstransferProcessingInformationPayoutsOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SourceCurrency == other.SourceCurrency ||
                    this.SourceCurrency != null &&
                    this.SourceCurrency.Equals(other.SourceCurrency)
                ) && 
                (
                    this.DestinationCurrency == other.DestinationCurrency ||
                    this.DestinationCurrency != null &&
                    this.DestinationCurrency.Equals(other.DestinationCurrency)
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
                if (this.SourceCurrency != null)
                    hash = hash * 59 + this.SourceCurrency.GetHashCode();
                if (this.DestinationCurrency != null)
                    hash = hash * 59 + this.DestinationCurrency.GetHashCode();
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
