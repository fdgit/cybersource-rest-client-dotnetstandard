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
    /// Contains the result of risk assessment.
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsPost201ResponseRiskInformation :  IEquatable<PtsV2PaymentsPost201ResponseRiskInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsPost201ResponseRiskInformation" /> class.
        /// </summary>
        /// <param name="Profile">Profile.</param>
        /// <param name="Rules">Rules.</param>
        /// <param name="InfoCodes">InfoCodes.</param>
        /// <param name="Velocity">Velocity.</param>
        /// <param name="CasePriority">You receive this field only if you subscribe to the Enhanced Case Management service. The priority level ranges from 1 (highest) to 5 (lowest); the default value is 3. If you do not assign a priority to your rules or to your profiles, the default value is given to the order.  For all possible values, see the &#x60;decision_case_priority&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). .</param>
        /// <param name="LocalTime">The customer&#39;s local time (&#x60;hh:mm:ss&#x60;), which is calculated from the transaction request time and the customer&#39;s billing address.  For details, see the &#x60;score_time_local&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) .</param>
        /// <param name="Score">Score.</param>
        /// <param name="IpAddress">IpAddress.</param>
        /// <param name="Providers">Providers.</param>
        /// <param name="Travel">Travel.</param>
        public PtsV2PaymentsPost201ResponseRiskInformation(PtsV2PaymentsPost201ResponseRiskInformationProfile Profile = default(PtsV2PaymentsPost201ResponseRiskInformationProfile), List<PtsV2PaymentsPost201ResponseRiskInformationRules> Rules = default(List<PtsV2PaymentsPost201ResponseRiskInformationRules>), PtsV2PaymentsPost201ResponseRiskInformationInfoCodes InfoCodes = default(PtsV2PaymentsPost201ResponseRiskInformationInfoCodes), PtsV2PaymentsPost201ResponseRiskInformationVelocity Velocity = default(PtsV2PaymentsPost201ResponseRiskInformationVelocity), int? CasePriority = default(int?), string LocalTime = default(string), PtsV2PaymentsPost201ResponseRiskInformationScore Score = default(PtsV2PaymentsPost201ResponseRiskInformationScore), PtsV2PaymentsPost201ResponseRiskInformationIpAddress IpAddress = default(PtsV2PaymentsPost201ResponseRiskInformationIpAddress), PtsV2PaymentsPost201ResponseRiskInformationProviders Providers = default(PtsV2PaymentsPost201ResponseRiskInformationProviders), PtsV2PaymentsPost201ResponseRiskInformationTravel Travel = default(PtsV2PaymentsPost201ResponseRiskInformationTravel))
        {
            this.Profile = Profile;
            this.Rules = Rules;
            this.InfoCodes = InfoCodes;
            this.Velocity = Velocity;
            this.CasePriority = CasePriority;
            this.LocalTime = LocalTime;
            this.Score = Score;
            this.IpAddress = IpAddress;
            this.Providers = Providers;
            this.Travel = Travel;
        }
        
        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [DataMember(Name="profile", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseRiskInformationProfile Profile { get; set; }

        /// <summary>
        /// Gets or Sets Rules
        /// </summary>
        [DataMember(Name="rules", EmitDefaultValue=false)]
        public List<PtsV2PaymentsPost201ResponseRiskInformationRules> Rules { get; set; }

        /// <summary>
        /// Gets or Sets InfoCodes
        /// </summary>
        [DataMember(Name="infoCodes", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseRiskInformationInfoCodes InfoCodes { get; set; }

        /// <summary>
        /// Gets or Sets Velocity
        /// </summary>
        [DataMember(Name="velocity", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseRiskInformationVelocity Velocity { get; set; }

        /// <summary>
        /// You receive this field only if you subscribe to the Enhanced Case Management service. The priority level ranges from 1 (highest) to 5 (lowest); the default value is 3. If you do not assign a priority to your rules or to your profiles, the default value is given to the order.  For all possible values, see the &#x60;decision_case_priority&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). 
        /// </summary>
        /// <value>You receive this field only if you subscribe to the Enhanced Case Management service. The priority level ranges from 1 (highest) to 5 (lowest); the default value is 3. If you do not assign a priority to your rules or to your profiles, the default value is given to the order.  For all possible values, see the &#x60;decision_case_priority&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). </value>
        [DataMember(Name="casePriority", EmitDefaultValue=false)]
        public int? CasePriority { get; set; }

        /// <summary>
        /// The customer&#39;s local time (&#x60;hh:mm:ss&#x60;), which is calculated from the transaction request time and the customer&#39;s billing address.  For details, see the &#x60;score_time_local&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) 
        /// </summary>
        /// <value>The customer&#39;s local time (&#x60;hh:mm:ss&#x60;), which is calculated from the transaction request time and the customer&#39;s billing address.  For details, see the &#x60;score_time_local&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) </value>
        [DataMember(Name="localTime", EmitDefaultValue=false)]
        public string LocalTime { get; set; }

        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseRiskInformationScore Score { get; set; }

        /// <summary>
        /// Gets or Sets IpAddress
        /// </summary>
        [DataMember(Name="ipAddress", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseRiskInformationIpAddress IpAddress { get; set; }

        /// <summary>
        /// Gets or Sets Providers
        /// </summary>
        [DataMember(Name="providers", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseRiskInformationProviders Providers { get; set; }

        /// <summary>
        /// Gets or Sets Travel
        /// </summary>
        [DataMember(Name="travel", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseRiskInformationTravel Travel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsPost201ResponseRiskInformation {\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
            sb.Append("  InfoCodes: ").Append(InfoCodes).Append("\n");
            sb.Append("  Velocity: ").Append(Velocity).Append("\n");
            sb.Append("  CasePriority: ").Append(CasePriority).Append("\n");
            sb.Append("  LocalTime: ").Append(LocalTime).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  Providers: ").Append(Providers).Append("\n");
            sb.Append("  Travel: ").Append(Travel).Append("\n");
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
            return this.Equals(obj as PtsV2PaymentsPost201ResponseRiskInformation);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsPost201ResponseRiskInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsPost201ResponseRiskInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsPost201ResponseRiskInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Profile == other.Profile ||
                    this.Profile != null &&
                    this.Profile.Equals(other.Profile)
                ) && 
                (
                    this.Rules == other.Rules ||
                    this.Rules != null &&
                    this.Rules.SequenceEqual(other.Rules)
                ) && 
                (
                    this.InfoCodes == other.InfoCodes ||
                    this.InfoCodes != null &&
                    this.InfoCodes.Equals(other.InfoCodes)
                ) && 
                (
                    this.Velocity == other.Velocity ||
                    this.Velocity != null &&
                    this.Velocity.Equals(other.Velocity)
                ) && 
                (
                    this.CasePriority == other.CasePriority ||
                    this.CasePriority != null &&
                    this.CasePriority.Equals(other.CasePriority)
                ) && 
                (
                    this.LocalTime == other.LocalTime ||
                    this.LocalTime != null &&
                    this.LocalTime.Equals(other.LocalTime)
                ) && 
                (
                    this.Score == other.Score ||
                    this.Score != null &&
                    this.Score.Equals(other.Score)
                ) && 
                (
                    this.IpAddress == other.IpAddress ||
                    this.IpAddress != null &&
                    this.IpAddress.Equals(other.IpAddress)
                ) && 
                (
                    this.Providers == other.Providers ||
                    this.Providers != null &&
                    this.Providers.Equals(other.Providers)
                ) && 
                (
                    this.Travel == other.Travel ||
                    this.Travel != null &&
                    this.Travel.Equals(other.Travel)
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
                if (this.Profile != null)
                    hash = hash * 59 + this.Profile.GetHashCode();
                if (this.Rules != null)
                    hash = hash * 59 + this.Rules.GetHashCode();
                if (this.InfoCodes != null)
                    hash = hash * 59 + this.InfoCodes.GetHashCode();
                if (this.Velocity != null)
                    hash = hash * 59 + this.Velocity.GetHashCode();
                if (this.CasePriority != null)
                    hash = hash * 59 + this.CasePriority.GetHashCode();
                if (this.LocalTime != null)
                    hash = hash * 59 + this.LocalTime.GetHashCode();
                if (this.Score != null)
                    hash = hash * 59 + this.Score.GetHashCode();
                if (this.IpAddress != null)
                    hash = hash * 59 + this.IpAddress.GetHashCode();
                if (this.Providers != null)
                    hash = hash * 59 + this.Providers.GetHashCode();
                if (this.Travel != null)
                    hash = hash * 59 + this.Travel.GetHashCode();
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
            // LocalTime (string) maxLength
            if(this.LocalTime != null && this.LocalTime.Length >= 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LocalTime, length must be less than or equal to 255.", new [] { "LocalTime" });
            }

            yield break;
        }
    }

}
