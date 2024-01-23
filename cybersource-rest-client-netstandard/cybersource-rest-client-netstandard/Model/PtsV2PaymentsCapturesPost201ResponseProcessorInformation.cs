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
    /// PtsV2PaymentsCapturesPost201ResponseProcessorInformation
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsCapturesPost201ResponseProcessorInformation :  IEquatable<PtsV2PaymentsCapturesPost201ResponseProcessorInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsCapturesPost201ResponseProcessorInformation" /> class.
        /// </summary>
        /// <param name="TransactionId">Processor transaction ID.  This value identifies the transaction on a host system. This value is supported only for Moneris. It contains this information:   - Terminal used to process the transaction  - Shift during which the transaction took place  - Batch number  - Transaction number within the batch  You must store this value. If you give the customer a receipt, display this value on the receipt.  Example For the value 66012345001069003:   - Terminal ID &#x3D; 66012345  - Shift number &#x3D; 001  - Batch number &#x3D; 069  - Transaction number &#x3D; 003 .</param>
        /// <param name="NetworkTransactionId">Network Transaction Identifier Applicable for online capture transactions only. .</param>
        public PtsV2PaymentsCapturesPost201ResponseProcessorInformation(string TransactionId = default(string), string NetworkTransactionId = default(string))
        {
            this.TransactionId = TransactionId;
            this.NetworkTransactionId = NetworkTransactionId;
        }
        
        /// <summary>
        /// Processor transaction ID.  This value identifies the transaction on a host system. This value is supported only for Moneris. It contains this information:   - Terminal used to process the transaction  - Shift during which the transaction took place  - Batch number  - Transaction number within the batch  You must store this value. If you give the customer a receipt, display this value on the receipt.  Example For the value 66012345001069003:   - Terminal ID &#x3D; 66012345  - Shift number &#x3D; 001  - Batch number &#x3D; 069  - Transaction number &#x3D; 003 
        /// </summary>
        /// <value>Processor transaction ID.  This value identifies the transaction on a host system. This value is supported only for Moneris. It contains this information:   - Terminal used to process the transaction  - Shift during which the transaction took place  - Batch number  - Transaction number within the batch  You must store this value. If you give the customer a receipt, display this value on the receipt.  Example For the value 66012345001069003:   - Terminal ID &#x3D; 66012345  - Shift number &#x3D; 001  - Batch number &#x3D; 069  - Transaction number &#x3D; 003 </value>
        [DataMember(Name="transactionId", EmitDefaultValue=false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Network Transaction Identifier Applicable for online capture transactions only. 
        /// </summary>
        /// <value>Network Transaction Identifier Applicable for online capture transactions only. </value>
        [DataMember(Name="networkTransactionId", EmitDefaultValue=false)]
        public string NetworkTransactionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsCapturesPost201ResponseProcessorInformation {\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  NetworkTransactionId: ").Append(NetworkTransactionId).Append("\n");
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
            return this.Equals(obj as PtsV2PaymentsCapturesPost201ResponseProcessorInformation);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsCapturesPost201ResponseProcessorInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsCapturesPost201ResponseProcessorInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsCapturesPost201ResponseProcessorInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TransactionId == other.TransactionId ||
                    this.TransactionId != null &&
                    this.TransactionId.Equals(other.TransactionId)
                ) && 
                (
                    this.NetworkTransactionId == other.NetworkTransactionId ||
                    this.NetworkTransactionId != null &&
                    this.NetworkTransactionId.Equals(other.NetworkTransactionId)
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
                if (this.TransactionId != null)
                    hash = hash * 59 + this.TransactionId.GetHashCode();
                if (this.NetworkTransactionId != null)
                    hash = hash * 59 + this.NetworkTransactionId.GetHashCode();
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
