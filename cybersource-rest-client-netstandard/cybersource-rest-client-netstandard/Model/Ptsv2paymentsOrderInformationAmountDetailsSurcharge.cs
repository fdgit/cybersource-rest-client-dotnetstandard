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
    /// Ptsv2paymentsOrderInformationAmountDetailsSurcharge
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsOrderInformationAmountDetailsSurcharge :  IEquatable<Ptsv2paymentsOrderInformationAmountDetailsSurcharge>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsOrderInformationAmountDetailsSurcharge" /> class.
        /// </summary>
        /// <param name="Amount">The surcharge amount is included in the total transaction amount but is passed in a separate field to the issuer and acquirer for tracking. The issuer can provide information about the surcharge amount to the customer.  If the amount is positive, then it is a debit for the customer. If the amount is negative, then it is a credit for the customer.  **NOTE**: This field is supported only for CyberSource through VisaNet (CtV) for Payouts. For CtV, the maximum string length is 8.  #### PIN debit Surcharge amount that you are charging the customer for this transaction. If you include a surcharge amount in the request, you must also include the surcharge amount in the value for &#x60;orderInformation.amountDetails.totalAmount&#x60;.  Optional field for transactions that use PIN debit credit or PIN debit purchase. .</param>
        /// <param name="Description">Merchant-defined field for describing the surcharge amount..</param>
        public Ptsv2paymentsOrderInformationAmountDetailsSurcharge(string Amount = default(string), string Description = default(string))
        {
            this.Amount = Amount;
            this.Description = Description;
        }
        
        /// <summary>
        /// The surcharge amount is included in the total transaction amount but is passed in a separate field to the issuer and acquirer for tracking. The issuer can provide information about the surcharge amount to the customer.  If the amount is positive, then it is a debit for the customer. If the amount is negative, then it is a credit for the customer.  **NOTE**: This field is supported only for CyberSource through VisaNet (CtV) for Payouts. For CtV, the maximum string length is 8.  #### PIN debit Surcharge amount that you are charging the customer for this transaction. If you include a surcharge amount in the request, you must also include the surcharge amount in the value for &#x60;orderInformation.amountDetails.totalAmount&#x60;.  Optional field for transactions that use PIN debit credit or PIN debit purchase. 
        /// </summary>
        /// <value>The surcharge amount is included in the total transaction amount but is passed in a separate field to the issuer and acquirer for tracking. The issuer can provide information about the surcharge amount to the customer.  If the amount is positive, then it is a debit for the customer. If the amount is negative, then it is a credit for the customer.  **NOTE**: This field is supported only for CyberSource through VisaNet (CtV) for Payouts. For CtV, the maximum string length is 8.  #### PIN debit Surcharge amount that you are charging the customer for this transaction. If you include a surcharge amount in the request, you must also include the surcharge amount in the value for &#x60;orderInformation.amountDetails.totalAmount&#x60;.  Optional field for transactions that use PIN debit credit or PIN debit purchase. </value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// Merchant-defined field for describing the surcharge amount.
        /// </summary>
        /// <value>Merchant-defined field for describing the surcharge amount.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsOrderInformationAmountDetailsSurcharge {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsOrderInformationAmountDetailsSurcharge);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsOrderInformationAmountDetailsSurcharge instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsOrderInformationAmountDetailsSurcharge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsOrderInformationAmountDetailsSurcharge other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
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
            // Amount (string) maxLength
            if(this.Amount != null && this.Amount.Length >= 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Amount, length must be less than or equal to 15.", new [] { "Amount" });
            }

            yield break;
        }
    }

}
