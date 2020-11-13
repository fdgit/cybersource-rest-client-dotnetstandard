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
    /// key information 
    /// </summary>
    [DataContract]
    public partial class KmsV2KeysSymDeletesPost200ResponseKeyInformation :  IEquatable<KmsV2KeysSymDeletesPost200ResponseKeyInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KmsV2KeysSymDeletesPost200ResponseKeyInformation" /> class.
        /// </summary>
        /// <param name="OrganizationId">Merchant Id .</param>
        /// <param name="KeyId">Key serial number .</param>
        /// <param name="Status">The status of the key.  Possible values:  - FAILED  - ACTIVE  - INACTIVE  - EXPIRED .</param>
        /// <param name="Message">message in case of failed key .</param>
        /// <param name="ErrorInformation">ErrorInformation.</param>
        public KmsV2KeysSymDeletesPost200ResponseKeyInformation(string OrganizationId = default(string), string KeyId = default(string), string Status = default(string), string Message = default(string), KmsV2KeysSymPost201ResponseErrorInformation ErrorInformation = default(KmsV2KeysSymPost201ResponseErrorInformation))
        {
            this.OrganizationId = OrganizationId;
            this.KeyId = KeyId;
            this.Status = Status;
            this.Message = Message;
            this.ErrorInformation = ErrorInformation;
        }
        
        /// <summary>
        /// Merchant Id 
        /// </summary>
        /// <value>Merchant Id </value>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Key serial number 
        /// </summary>
        /// <value>Key serial number </value>
        [DataMember(Name="keyId", EmitDefaultValue=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// The status of the key.  Possible values:  - FAILED  - ACTIVE  - INACTIVE  - EXPIRED 
        /// </summary>
        /// <value>The status of the key.  Possible values:  - FAILED  - ACTIVE  - INACTIVE  - EXPIRED </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// message in case of failed key 
        /// </summary>
        /// <value>message in case of failed key </value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets ErrorInformation
        /// </summary>
        [DataMember(Name="errorInformation", EmitDefaultValue=false)]
        public KmsV2KeysSymPost201ResponseErrorInformation ErrorInformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KmsV2KeysSymDeletesPost200ResponseKeyInformation {\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  KeyId: ").Append(KeyId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  ErrorInformation: ").Append(ErrorInformation).Append("\n");
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
            return this.Equals(obj as KmsV2KeysSymDeletesPost200ResponseKeyInformation);
        }

        /// <summary>
        /// Returns true if KmsV2KeysSymDeletesPost200ResponseKeyInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of KmsV2KeysSymDeletesPost200ResponseKeyInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KmsV2KeysSymDeletesPost200ResponseKeyInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OrganizationId == other.OrganizationId ||
                    this.OrganizationId != null &&
                    this.OrganizationId.Equals(other.OrganizationId)
                ) && 
                (
                    this.KeyId == other.KeyId ||
                    this.KeyId != null &&
                    this.KeyId.Equals(other.KeyId)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.ErrorInformation == other.ErrorInformation ||
                    this.ErrorInformation != null &&
                    this.ErrorInformation.Equals(other.ErrorInformation)
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
                if (this.OrganizationId != null)
                    hash = hash * 59 + this.OrganizationId.GetHashCode();
                if (this.KeyId != null)
                    hash = hash * 59 + this.KeyId.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.ErrorInformation != null)
                    hash = hash * 59 + this.ErrorInformation.GetHashCode();
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
