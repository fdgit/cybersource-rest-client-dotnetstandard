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
    /// InvoicingV2InvoiceSettingsGet200ResponseInvoiceSettingsInformation
    /// </summary>
    [DataContract]
    public partial class InvoicingV2InvoiceSettingsGet200ResponseInvoiceSettingsInformation :  IEquatable<InvoicingV2InvoiceSettingsGet200ResponseInvoiceSettingsInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicingV2InvoiceSettingsGet200ResponseInvoiceSettingsInformation" /> class.
        /// </summary>
        /// <param name="MerchantLogo">The image file, which must be encoded in Base64 format. Supported file formats are &#x60;png&#x60;, &#x60;jpg&#x60;, and &#x60;gif&#x60;. The image file size restriction is 1 MB..</param>
        /// <param name="MerchantDisplayName">The merchant&#39;s display name shown on the invoice..</param>
        /// <param name="CustomEmailMessage">The content of the email message that we send to your customers..</param>
        /// <param name="EnableReminders">Whether you would like us to send an auto-generated reminder email to your invoice recipients. Currently, this reminder email is sent five days before the invoice is due and one day after it is past due..</param>
        /// <param name="HeaderStyle">HeaderStyle.</param>
        /// <param name="DeliveryLanguage">The language of the email that we send to your customers. Possible values are &#x60;zh-CN&#x60;, &#x60;zh-TW&#x60;, &#x60;en-US&#x60;, &#x60;fr-FR&#x60;, &#x60;de-DE&#x60;, &#x60;ja-JP&#x60;, &#x60;pt-BR&#x60;, &#x60;ru-RU&#x60; and &#x60;es-419&#x60;..</param>
        /// <param name="DefaultCurrencyCode">Currency used for the order. Use the three-character [ISO Standard Currency Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf)  #### Used by **Authorization** Required field.  **Authorization Reversal** For an authorization reversal (&#x60;reversalInformation&#x60;) or a capture (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60;), you must use the same currency that you used in your payment authorization request.  #### PIN Debit Currency for the amount you requested for the PIN debit purchase. This value is returned for partial authorizations. The issuing bank can approve a partial amount if the balance on the debit card is less than the requested transaction amount. For the possible values, see the [ISO Standard Currency Codes](https://developer.cybersource.com/library/documentation/sbc/quickref/currencies.pdf). Returned by PIN debit purchase.  For PIN debit reversal requests, you must use the same currency that was used for the PIN debit purchase or PIN debit credit that you are reversing. For the possible values, see the [ISO Standard Currency Codes](https://developer.cybersource.com/library/documentation/sbc/quickref/currencies.pdf).  Required field for PIN Debit purchase and PIN Debit credit requests. Optional field for PIN Debit reversal requests.  #### GPX This field is optional for reversing an authorization or credit.  #### DCC for First Data Your local currency. For details, see the &#x60;currency&#x60; field description in [Dynamic Currency Conversion For First Data Using the SCMP API](http://apps.cybersource.com/library/documentation/dev_guides/DCC_FirstData_SCMP/DCC_FirstData_SCMP_API.pdf).  #### Tax Calculation Required for international tax and value added tax only. Optional for U.S. and Canadian taxes. Your local currency. .</param>
        /// <param name="PayerAuthentication3DSVersion">The 3D Secure payer authentication version or status for a merchant&#39;s invoice payments. Possible values are: - &#x60;1&#x60; - &#x60;2&#x60; - &#x60;None&#x60; - &#x60;Disabled&#x60; .</param>
        public InvoicingV2InvoiceSettingsGet200ResponseInvoiceSettingsInformation(string MerchantLogo = default(string), string MerchantDisplayName = default(string), string CustomEmailMessage = default(string), bool? EnableReminders = default(bool?), InvoicingV2InvoiceSettingsGet200ResponseInvoiceSettingsInformationHeaderStyle HeaderStyle = default(InvoicingV2InvoiceSettingsGet200ResponseInvoiceSettingsInformationHeaderStyle), string DeliveryLanguage = default(string), string DefaultCurrencyCode = default(string), string PayerAuthentication3DSVersion = default(string))
        {
            this.MerchantLogo = MerchantLogo;
            this.MerchantDisplayName = MerchantDisplayName;
            this.CustomEmailMessage = CustomEmailMessage;
            this.EnableReminders = EnableReminders;
            this.HeaderStyle = HeaderStyle;
            this.DeliveryLanguage = DeliveryLanguage;
            this.DefaultCurrencyCode = DefaultCurrencyCode;
            this.PayerAuthentication3DSVersion = PayerAuthentication3DSVersion;
        }
        
        /// <summary>
        /// The image file, which must be encoded in Base64 format. Supported file formats are &#x60;png&#x60;, &#x60;jpg&#x60;, and &#x60;gif&#x60;. The image file size restriction is 1 MB.
        /// </summary>
        /// <value>The image file, which must be encoded in Base64 format. Supported file formats are &#x60;png&#x60;, &#x60;jpg&#x60;, and &#x60;gif&#x60;. The image file size restriction is 1 MB.</value>
        [DataMember(Name="merchantLogo", EmitDefaultValue=false)]
        public string MerchantLogo { get; set; }

        /// <summary>
        /// The merchant&#39;s display name shown on the invoice.
        /// </summary>
        /// <value>The merchant&#39;s display name shown on the invoice.</value>
        [DataMember(Name="merchantDisplayName", EmitDefaultValue=false)]
        public string MerchantDisplayName { get; set; }

        /// <summary>
        /// The content of the email message that we send to your customers.
        /// </summary>
        /// <value>The content of the email message that we send to your customers.</value>
        [DataMember(Name="customEmailMessage", EmitDefaultValue=false)]
        public string CustomEmailMessage { get; set; }

        /// <summary>
        /// Whether you would like us to send an auto-generated reminder email to your invoice recipients. Currently, this reminder email is sent five days before the invoice is due and one day after it is past due.
        /// </summary>
        /// <value>Whether you would like us to send an auto-generated reminder email to your invoice recipients. Currently, this reminder email is sent five days before the invoice is due and one day after it is past due.</value>
        [DataMember(Name="enableReminders", EmitDefaultValue=false)]
        public bool? EnableReminders { get; set; }

        /// <summary>
        /// Gets or Sets HeaderStyle
        /// </summary>
        [DataMember(Name="headerStyle", EmitDefaultValue=false)]
        public InvoicingV2InvoiceSettingsGet200ResponseInvoiceSettingsInformationHeaderStyle HeaderStyle { get; set; }

        /// <summary>
        /// The language of the email that we send to your customers. Possible values are &#x60;zh-CN&#x60;, &#x60;zh-TW&#x60;, &#x60;en-US&#x60;, &#x60;fr-FR&#x60;, &#x60;de-DE&#x60;, &#x60;ja-JP&#x60;, &#x60;pt-BR&#x60;, &#x60;ru-RU&#x60; and &#x60;es-419&#x60;.
        /// </summary>
        /// <value>The language of the email that we send to your customers. Possible values are &#x60;zh-CN&#x60;, &#x60;zh-TW&#x60;, &#x60;en-US&#x60;, &#x60;fr-FR&#x60;, &#x60;de-DE&#x60;, &#x60;ja-JP&#x60;, &#x60;pt-BR&#x60;, &#x60;ru-RU&#x60; and &#x60;es-419&#x60;.</value>
        [DataMember(Name="deliveryLanguage", EmitDefaultValue=false)]
        public string DeliveryLanguage { get; set; }

        /// <summary>
        /// Currency used for the order. Use the three-character [ISO Standard Currency Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf)  #### Used by **Authorization** Required field.  **Authorization Reversal** For an authorization reversal (&#x60;reversalInformation&#x60;) or a capture (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60;), you must use the same currency that you used in your payment authorization request.  #### PIN Debit Currency for the amount you requested for the PIN debit purchase. This value is returned for partial authorizations. The issuing bank can approve a partial amount if the balance on the debit card is less than the requested transaction amount. For the possible values, see the [ISO Standard Currency Codes](https://developer.cybersource.com/library/documentation/sbc/quickref/currencies.pdf). Returned by PIN debit purchase.  For PIN debit reversal requests, you must use the same currency that was used for the PIN debit purchase or PIN debit credit that you are reversing. For the possible values, see the [ISO Standard Currency Codes](https://developer.cybersource.com/library/documentation/sbc/quickref/currencies.pdf).  Required field for PIN Debit purchase and PIN Debit credit requests. Optional field for PIN Debit reversal requests.  #### GPX This field is optional for reversing an authorization or credit.  #### DCC for First Data Your local currency. For details, see the &#x60;currency&#x60; field description in [Dynamic Currency Conversion For First Data Using the SCMP API](http://apps.cybersource.com/library/documentation/dev_guides/DCC_FirstData_SCMP/DCC_FirstData_SCMP_API.pdf).  #### Tax Calculation Required for international tax and value added tax only. Optional for U.S. and Canadian taxes. Your local currency. 
        /// </summary>
        /// <value>Currency used for the order. Use the three-character [ISO Standard Currency Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf)  #### Used by **Authorization** Required field.  **Authorization Reversal** For an authorization reversal (&#x60;reversalInformation&#x60;) or a capture (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60;), you must use the same currency that you used in your payment authorization request.  #### PIN Debit Currency for the amount you requested for the PIN debit purchase. This value is returned for partial authorizations. The issuing bank can approve a partial amount if the balance on the debit card is less than the requested transaction amount. For the possible values, see the [ISO Standard Currency Codes](https://developer.cybersource.com/library/documentation/sbc/quickref/currencies.pdf). Returned by PIN debit purchase.  For PIN debit reversal requests, you must use the same currency that was used for the PIN debit purchase or PIN debit credit that you are reversing. For the possible values, see the [ISO Standard Currency Codes](https://developer.cybersource.com/library/documentation/sbc/quickref/currencies.pdf).  Required field for PIN Debit purchase and PIN Debit credit requests. Optional field for PIN Debit reversal requests.  #### GPX This field is optional for reversing an authorization or credit.  #### DCC for First Data Your local currency. For details, see the &#x60;currency&#x60; field description in [Dynamic Currency Conversion For First Data Using the SCMP API](http://apps.cybersource.com/library/documentation/dev_guides/DCC_FirstData_SCMP/DCC_FirstData_SCMP_API.pdf).  #### Tax Calculation Required for international tax and value added tax only. Optional for U.S. and Canadian taxes. Your local currency. </value>
        [DataMember(Name="defaultCurrencyCode", EmitDefaultValue=false)]
        public string DefaultCurrencyCode { get; set; }

        /// <summary>
        /// The 3D Secure payer authentication version or status for a merchant&#39;s invoice payments. Possible values are: - &#x60;1&#x60; - &#x60;2&#x60; - &#x60;None&#x60; - &#x60;Disabled&#x60; 
        /// </summary>
        /// <value>The 3D Secure payer authentication version or status for a merchant&#39;s invoice payments. Possible values are: - &#x60;1&#x60; - &#x60;2&#x60; - &#x60;None&#x60; - &#x60;Disabled&#x60; </value>
        [DataMember(Name="payerAuthentication3DSVersion", EmitDefaultValue=false)]
        public string PayerAuthentication3DSVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoicingV2InvoiceSettingsGet200ResponseInvoiceSettingsInformation {\n");
            sb.Append("  MerchantLogo: ").Append(MerchantLogo).Append("\n");
            sb.Append("  MerchantDisplayName: ").Append(MerchantDisplayName).Append("\n");
            sb.Append("  CustomEmailMessage: ").Append(CustomEmailMessage).Append("\n");
            sb.Append("  EnableReminders: ").Append(EnableReminders).Append("\n");
            sb.Append("  HeaderStyle: ").Append(HeaderStyle).Append("\n");
            sb.Append("  DeliveryLanguage: ").Append(DeliveryLanguage).Append("\n");
            sb.Append("  DefaultCurrencyCode: ").Append(DefaultCurrencyCode).Append("\n");
            sb.Append("  PayerAuthentication3DSVersion: ").Append(PayerAuthentication3DSVersion).Append("\n");
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
            return this.Equals(obj as InvoicingV2InvoiceSettingsGet200ResponseInvoiceSettingsInformation);
        }

        /// <summary>
        /// Returns true if InvoicingV2InvoiceSettingsGet200ResponseInvoiceSettingsInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of InvoicingV2InvoiceSettingsGet200ResponseInvoiceSettingsInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoicingV2InvoiceSettingsGet200ResponseInvoiceSettingsInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MerchantLogo == other.MerchantLogo ||
                    this.MerchantLogo != null &&
                    this.MerchantLogo.Equals(other.MerchantLogo)
                ) && 
                (
                    this.MerchantDisplayName == other.MerchantDisplayName ||
                    this.MerchantDisplayName != null &&
                    this.MerchantDisplayName.Equals(other.MerchantDisplayName)
                ) && 
                (
                    this.CustomEmailMessage == other.CustomEmailMessage ||
                    this.CustomEmailMessage != null &&
                    this.CustomEmailMessage.Equals(other.CustomEmailMessage)
                ) && 
                (
                    this.EnableReminders == other.EnableReminders ||
                    this.EnableReminders != null &&
                    this.EnableReminders.Equals(other.EnableReminders)
                ) && 
                (
                    this.HeaderStyle == other.HeaderStyle ||
                    this.HeaderStyle != null &&
                    this.HeaderStyle.Equals(other.HeaderStyle)
                ) && 
                (
                    this.DeliveryLanguage == other.DeliveryLanguage ||
                    this.DeliveryLanguage != null &&
                    this.DeliveryLanguage.Equals(other.DeliveryLanguage)
                ) && 
                (
                    this.DefaultCurrencyCode == other.DefaultCurrencyCode ||
                    this.DefaultCurrencyCode != null &&
                    this.DefaultCurrencyCode.Equals(other.DefaultCurrencyCode)
                ) && 
                (
                    this.PayerAuthentication3DSVersion == other.PayerAuthentication3DSVersion ||
                    this.PayerAuthentication3DSVersion != null &&
                    this.PayerAuthentication3DSVersion.Equals(other.PayerAuthentication3DSVersion)
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
                if (this.MerchantLogo != null)
                    hash = hash * 59 + this.MerchantLogo.GetHashCode();
                if (this.MerchantDisplayName != null)
                    hash = hash * 59 + this.MerchantDisplayName.GetHashCode();
                if (this.CustomEmailMessage != null)
                    hash = hash * 59 + this.CustomEmailMessage.GetHashCode();
                if (this.EnableReminders != null)
                    hash = hash * 59 + this.EnableReminders.GetHashCode();
                if (this.HeaderStyle != null)
                    hash = hash * 59 + this.HeaderStyle.GetHashCode();
                if (this.DeliveryLanguage != null)
                    hash = hash * 59 + this.DeliveryLanguage.GetHashCode();
                if (this.DefaultCurrencyCode != null)
                    hash = hash * 59 + this.DefaultCurrencyCode.GetHashCode();
                if (this.PayerAuthentication3DSVersion != null)
                    hash = hash * 59 + this.PayerAuthentication3DSVersion.GetHashCode();
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
            // MerchantLogo (string) maxLength
            if(this.MerchantLogo != null && this.MerchantLogo.Length >= 10000000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantLogo, length must be less than or equal to 10000000.", new [] { "MerchantLogo" });
            }

            // MerchantDisplayName (string) maxLength
            if(this.MerchantDisplayName != null && this.MerchantDisplayName.Length >= 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantDisplayName, length must be less than or equal to 100.", new [] { "MerchantDisplayName" });
            }

            // CustomEmailMessage (string) maxLength
            if(this.CustomEmailMessage != null && this.CustomEmailMessage.Length >= 2000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomEmailMessage, length must be less than or equal to 2000.", new [] { "CustomEmailMessage" });
            }

            // DeliveryLanguage (string) maxLength
            if(this.DeliveryLanguage != null && this.DeliveryLanguage.Length >= 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DeliveryLanguage, length must be less than or equal to 6.", new [] { "DeliveryLanguage" });
            }

            // DefaultCurrencyCode (string) maxLength
            if(this.DefaultCurrencyCode != null && this.DefaultCurrencyCode.Length >= 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DefaultCurrencyCode, length must be less than or equal to 3.", new [] { "DefaultCurrencyCode" });
            }

            // PayerAuthentication3DSVersion (string) maxLength
            if(this.PayerAuthentication3DSVersion != null && this.PayerAuthentication3DSVersion.Length >= 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PayerAuthentication3DSVersion, length must be less than or equal to 8.", new [] { "PayerAuthentication3DSVersion" });
            }

            yield break;
        }
    }

}
