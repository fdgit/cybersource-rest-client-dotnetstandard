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
    /// Tmsv2customersObjectInformation
    /// </summary>
    [DataContract]
    public partial class Tmsv2customersObjectInformation :  IEquatable<Tmsv2customersObjectInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tmsv2customersObjectInformation" /> class.
        /// </summary>
        /// <param name="Title">Name or title of the customer. .</param>
        /// <param name="Comment">Comments that you can make about the customer. .</param>
        public Tmsv2customersObjectInformation(string Title = default(string), string Comment = default(string))
        {
            this.Title = Title;
            this.Comment = Comment;
        }
        
        /// <summary>
        /// Name or title of the customer. 
        /// </summary>
        /// <value>Name or title of the customer. </value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Comments that you can make about the customer. 
        /// </summary>
        /// <value>Comments that you can make about the customer. </value>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tmsv2customersObjectInformation {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
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
            return this.Equals(obj as Tmsv2customersObjectInformation);
        }

        /// <summary>
        /// Returns true if Tmsv2customersObjectInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Tmsv2customersObjectInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tmsv2customersObjectInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.Comment == other.Comment ||
                    this.Comment != null &&
                    this.Comment.Equals(other.Comment)
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
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Comment != null)
                    hash = hash * 59 + this.Comment.GetHashCode();
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
            // Title (string) maxLength
            if(this.Title != null && this.Title.Length >= 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be less than or equal to 60.", new [] { "Title" });
            }

            // Comment (string) maxLength
            if(this.Comment != null && this.Comment.Length >= 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Comment, length must be less than or equal to 150.", new [] { "Comment" });
            }

            yield break;
        }
    }

}
