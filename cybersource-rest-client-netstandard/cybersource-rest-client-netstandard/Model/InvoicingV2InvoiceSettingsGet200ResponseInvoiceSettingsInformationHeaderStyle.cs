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
    /// InvoicingV2InvoiceSettingsGet200ResponseInvoiceSettingsInformationHeaderStyle
    /// </summary>
    [DataContract]
    public partial class InvoicingV2InvoiceSettingsGet200ResponseInvoiceSettingsInformationHeaderStyle :  IEquatable<InvoicingV2InvoiceSettingsGet200ResponseInvoiceSettingsInformationHeaderStyle>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicingV2InvoiceSettingsGet200ResponseInvoiceSettingsInformationHeaderStyle" /> class.
        /// </summary>
        /// <param name="FontColor">The invoice font color. The format is a valid hexadecimal code prefixed with &#x60;#&#x60;, such as &#x60;#000000&#x60; for black..</param>
        /// <param name="BackgroundColor">The invoice background color. The format is a valid hexadecimal code prefixed with &#x60;#&#x60;, such as &#x60;#ffffff&#x60; for white..</param>
        public InvoicingV2InvoiceSettingsGet200ResponseInvoiceSettingsInformationHeaderStyle(string FontColor = default(string), string BackgroundColor = default(string))
        {
            this.FontColor = FontColor;
            this.BackgroundColor = BackgroundColor;
        }
        
        /// <summary>
        /// The invoice font color. The format is a valid hexadecimal code prefixed with &#x60;#&#x60;, such as &#x60;#000000&#x60; for black.
        /// </summary>
        /// <value>The invoice font color. The format is a valid hexadecimal code prefixed with &#x60;#&#x60;, such as &#x60;#000000&#x60; for black.</value>
        [DataMember(Name="fontColor", EmitDefaultValue=false)]
        public string FontColor { get; set; }

        /// <summary>
        /// The invoice background color. The format is a valid hexadecimal code prefixed with &#x60;#&#x60;, such as &#x60;#ffffff&#x60; for white.
        /// </summary>
        /// <value>The invoice background color. The format is a valid hexadecimal code prefixed with &#x60;#&#x60;, such as &#x60;#ffffff&#x60; for white.</value>
        [DataMember(Name="backgroundColor", EmitDefaultValue=false)]
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoicingV2InvoiceSettingsGet200ResponseInvoiceSettingsInformationHeaderStyle {\n");
            sb.Append("  FontColor: ").Append(FontColor).Append("\n");
            sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
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
            return this.Equals(obj as InvoicingV2InvoiceSettingsGet200ResponseInvoiceSettingsInformationHeaderStyle);
        }

        /// <summary>
        /// Returns true if InvoicingV2InvoiceSettingsGet200ResponseInvoiceSettingsInformationHeaderStyle instances are equal
        /// </summary>
        /// <param name="other">Instance of InvoicingV2InvoiceSettingsGet200ResponseInvoiceSettingsInformationHeaderStyle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoicingV2InvoiceSettingsGet200ResponseInvoiceSettingsInformationHeaderStyle other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FontColor == other.FontColor ||
                    this.FontColor != null &&
                    this.FontColor.Equals(other.FontColor)
                ) && 
                (
                    this.BackgroundColor == other.BackgroundColor ||
                    this.BackgroundColor != null &&
                    this.BackgroundColor.Equals(other.BackgroundColor)
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
                if (this.FontColor != null)
                    hash = hash * 59 + this.FontColor.GetHashCode();
                if (this.BackgroundColor != null)
                    hash = hash * 59 + this.BackgroundColor.GetHashCode();
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
