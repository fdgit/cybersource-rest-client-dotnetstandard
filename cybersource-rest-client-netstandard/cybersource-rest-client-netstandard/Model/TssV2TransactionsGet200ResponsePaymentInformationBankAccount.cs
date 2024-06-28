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
    /// TssV2TransactionsGet200ResponsePaymentInformationBankAccount
    /// </summary>
    [DataContract]
    public partial class TssV2TransactionsGet200ResponsePaymentInformationBankAccount :  IEquatable<TssV2TransactionsGet200ResponsePaymentInformationBankAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2TransactionsGet200ResponsePaymentInformationBankAccount" /> class.
        /// </summary>
        /// <param name="Suffix">Last four digits of the customer&#39;s payment account number. .</param>
        /// <param name="Prefix">Bank Identification Number (BIN). This is the initial four to six numbers on a credit card account number. .</param>
        /// <param name="CheckNumber">Check number.  Chase Paymentech Solutions - Optional. CyberSource ACH Service - Not used. RBS WorldPay Atlanta - Optional on debits. Required on credits. TeleCheck - Strongly recommended on debit requests. Optional on credits. .</param>
        /// <param name="Type">Account type.  Possible values:  - **C**: Checking.  - **G**: General ledger. This value is supported only on Wells Fargo ACH.  - **S**: Savings (U.S. dollars only).  - **X**: Corporate checking (U.S. dollars only). .</param>
        /// <param name="Name">Name used on the bank account. You can use this field only when scoring a direct debit transaction .</param>
        /// <param name="CheckDigit">Code used to validate the customer&#39;s account number. Required for some countries if you do not or are not allowed to provide the IBAN instead. You may use this field only when scoring a direct debit transaction. .</param>
        /// <param name="EncoderId">Identifier for the bank that provided the customer&#39;s encoded account number.  To obtain the bank identifier, contact your processor. .</param>
        public TssV2TransactionsGet200ResponsePaymentInformationBankAccount(string Suffix = default(string), string Prefix = default(string), string CheckNumber = default(string), string Type = default(string), string Name = default(string), string CheckDigit = default(string), string EncoderId = default(string))
        {
            this.Suffix = Suffix;
            this.Prefix = Prefix;
            this.CheckNumber = CheckNumber;
            this.Type = Type;
            this.Name = Name;
            this.CheckDigit = CheckDigit;
            this.EncoderId = EncoderId;
        }
        
        /// <summary>
        /// Last four digits of the customer&#39;s payment account number. 
        /// </summary>
        /// <value>Last four digits of the customer&#39;s payment account number. </value>
        [DataMember(Name="suffix", EmitDefaultValue=false)]
        public string Suffix { get; set; }

        /// <summary>
        /// Bank Identification Number (BIN). This is the initial four to six numbers on a credit card account number. 
        /// </summary>
        /// <value>Bank Identification Number (BIN). This is the initial four to six numbers on a credit card account number. </value>
        [DataMember(Name="prefix", EmitDefaultValue=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// Check number.  Chase Paymentech Solutions - Optional. CyberSource ACH Service - Not used. RBS WorldPay Atlanta - Optional on debits. Required on credits. TeleCheck - Strongly recommended on debit requests. Optional on credits. 
        /// </summary>
        /// <value>Check number.  Chase Paymentech Solutions - Optional. CyberSource ACH Service - Not used. RBS WorldPay Atlanta - Optional on debits. Required on credits. TeleCheck - Strongly recommended on debit requests. Optional on credits. </value>
        [DataMember(Name="checkNumber", EmitDefaultValue=false)]
        public string CheckNumber { get; set; }

        /// <summary>
        /// Account type.  Possible values:  - **C**: Checking.  - **G**: General ledger. This value is supported only on Wells Fargo ACH.  - **S**: Savings (U.S. dollars only).  - **X**: Corporate checking (U.S. dollars only). 
        /// </summary>
        /// <value>Account type.  Possible values:  - **C**: Checking.  - **G**: General ledger. This value is supported only on Wells Fargo ACH.  - **S**: Savings (U.S. dollars only).  - **X**: Corporate checking (U.S. dollars only). </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Name used on the bank account. You can use this field only when scoring a direct debit transaction 
        /// </summary>
        /// <value>Name used on the bank account. You can use this field only when scoring a direct debit transaction </value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Code used to validate the customer&#39;s account number. Required for some countries if you do not or are not allowed to provide the IBAN instead. You may use this field only when scoring a direct debit transaction. 
        /// </summary>
        /// <value>Code used to validate the customer&#39;s account number. Required for some countries if you do not or are not allowed to provide the IBAN instead. You may use this field only when scoring a direct debit transaction. </value>
        [DataMember(Name="checkDigit", EmitDefaultValue=false)]
        public string CheckDigit { get; set; }

        /// <summary>
        /// Identifier for the bank that provided the customer&#39;s encoded account number.  To obtain the bank identifier, contact your processor. 
        /// </summary>
        /// <value>Identifier for the bank that provided the customer&#39;s encoded account number.  To obtain the bank identifier, contact your processor. </value>
        [DataMember(Name="encoderId", EmitDefaultValue=false)]
        public string EncoderId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2TransactionsGet200ResponsePaymentInformationBankAccount {\n");
            sb.Append("  Suffix: ").Append(Suffix).Append("\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            sb.Append("  CheckNumber: ").Append(CheckNumber).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CheckDigit: ").Append(CheckDigit).Append("\n");
            sb.Append("  EncoderId: ").Append(EncoderId).Append("\n");
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
            return this.Equals(obj as TssV2TransactionsGet200ResponsePaymentInformationBankAccount);
        }

        /// <summary>
        /// Returns true if TssV2TransactionsGet200ResponsePaymentInformationBankAccount instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2TransactionsGet200ResponsePaymentInformationBankAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2TransactionsGet200ResponsePaymentInformationBankAccount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Suffix == other.Suffix ||
                    this.Suffix != null &&
                    this.Suffix.Equals(other.Suffix)
                ) && 
                (
                    this.Prefix == other.Prefix ||
                    this.Prefix != null &&
                    this.Prefix.Equals(other.Prefix)
                ) && 
                (
                    this.CheckNumber == other.CheckNumber ||
                    this.CheckNumber != null &&
                    this.CheckNumber.Equals(other.CheckNumber)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.CheckDigit == other.CheckDigit ||
                    this.CheckDigit != null &&
                    this.CheckDigit.Equals(other.CheckDigit)
                ) && 
                (
                    this.EncoderId == other.EncoderId ||
                    this.EncoderId != null &&
                    this.EncoderId.Equals(other.EncoderId)
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
                if (this.Suffix != null)
                    hash = hash * 59 + this.Suffix.GetHashCode();
                if (this.Prefix != null)
                    hash = hash * 59 + this.Prefix.GetHashCode();
                if (this.CheckNumber != null)
                    hash = hash * 59 + this.CheckNumber.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.CheckDigit != null)
                    hash = hash * 59 + this.CheckDigit.GetHashCode();
                if (this.EncoderId != null)
                    hash = hash * 59 + this.EncoderId.GetHashCode();
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
