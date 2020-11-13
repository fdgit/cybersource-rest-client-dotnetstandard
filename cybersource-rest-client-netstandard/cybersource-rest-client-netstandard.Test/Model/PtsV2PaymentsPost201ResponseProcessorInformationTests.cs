/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using CyberSource.Api;
using CyberSource.Model;
using CyberSource.Client;
using System.Reflection;

namespace CyberSource.Test
{
    /// <summary>
    ///  Class for testing PtsV2PaymentsPost201ResponseProcessorInformation
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class PtsV2PaymentsPost201ResponseProcessorInformationTests
    {
        // TODO uncomment below to declare an instance variable for PtsV2PaymentsPost201ResponseProcessorInformation
        //private PtsV2PaymentsPost201ResponseProcessorInformation instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of PtsV2PaymentsPost201ResponseProcessorInformation
            //instance = new PtsV2PaymentsPost201ResponseProcessorInformation();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PtsV2PaymentsPost201ResponseProcessorInformation
        /// </summary>
        [Test]
        public void PtsV2PaymentsPost201ResponseProcessorInformationInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" PtsV2PaymentsPost201ResponseProcessorInformation
            //Assert.IsInstanceOfType<PtsV2PaymentsPost201ResponseProcessorInformation> (instance, "variable 'instance' is a PtsV2PaymentsPost201ResponseProcessorInformation");
        }

        /// <summary>
        /// Test the property 'AuthIndicator'
        /// </summary>
        [Test]
        public void AuthIndicatorTest()
        {
            // TODO unit test for the property 'AuthIndicator'
        }
        /// <summary>
        /// Test the property 'ApprovalCode'
        /// </summary>
        [Test]
        public void ApprovalCodeTest()
        {
            // TODO unit test for the property 'ApprovalCode'
        }
        /// <summary>
        /// Test the property 'TransactionId'
        /// </summary>
        [Test]
        public void TransactionIdTest()
        {
            // TODO unit test for the property 'TransactionId'
        }
        /// <summary>
        /// Test the property 'NetworkTransactionId'
        /// </summary>
        [Test]
        public void NetworkTransactionIdTest()
        {
            // TODO unit test for the property 'NetworkTransactionId'
        }
        /// <summary>
        /// Test the property 'ProviderTransactionId'
        /// </summary>
        [Test]
        public void ProviderTransactionIdTest()
        {
            // TODO unit test for the property 'ProviderTransactionId'
        }
        /// <summary>
        /// Test the property 'ResponseCode'
        /// </summary>
        [Test]
        public void ResponseCodeTest()
        {
            // TODO unit test for the property 'ResponseCode'
        }
        /// <summary>
        /// Test the property 'ResponseCodeSource'
        /// </summary>
        [Test]
        public void ResponseCodeSourceTest()
        {
            // TODO unit test for the property 'ResponseCodeSource'
        }
        /// <summary>
        /// Test the property 'ResponseDetails'
        /// </summary>
        [Test]
        public void ResponseDetailsTest()
        {
            // TODO unit test for the property 'ResponseDetails'
        }
        /// <summary>
        /// Test the property 'ResponseCategoryCode'
        /// </summary>
        [Test]
        public void ResponseCategoryCodeTest()
        {
            // TODO unit test for the property 'ResponseCategoryCode'
        }
        /// <summary>
        /// Test the property 'ForwardedAcquirerCode'
        /// </summary>
        [Test]
        public void ForwardedAcquirerCodeTest()
        {
            // TODO unit test for the property 'ForwardedAcquirerCode'
        }
        /// <summary>
        /// Test the property 'Avs'
        /// </summary>
        [Test]
        public void AvsTest()
        {
            // TODO unit test for the property 'Avs'
        }
        /// <summary>
        /// Test the property 'CardVerification'
        /// </summary>
        [Test]
        public void CardVerificationTest()
        {
            // TODO unit test for the property 'CardVerification'
        }
        /// <summary>
        /// Test the property 'MerchantAdvice'
        /// </summary>
        [Test]
        public void MerchantAdviceTest()
        {
            // TODO unit test for the property 'MerchantAdvice'
        }
        /// <summary>
        /// Test the property 'ElectronicVerificationResults'
        /// </summary>
        [Test]
        public void ElectronicVerificationResultsTest()
        {
            // TODO unit test for the property 'ElectronicVerificationResults'
        }
        /// <summary>
        /// Test the property 'AchVerification'
        /// </summary>
        [Test]
        public void AchVerificationTest()
        {
            // TODO unit test for the property 'AchVerification'
        }
        /// <summary>
        /// Test the property 'Customer'
        /// </summary>
        [Test]
        public void CustomerTest()
        {
            // TODO unit test for the property 'Customer'
        }
        /// <summary>
        /// Test the property 'ConsumerAuthenticationResponse'
        /// </summary>
        [Test]
        public void ConsumerAuthenticationResponseTest()
        {
            // TODO unit test for the property 'ConsumerAuthenticationResponse'
        }
        /// <summary>
        /// Test the property 'SystemTraceAuditNumber'
        /// </summary>
        [Test]
        public void SystemTraceAuditNumberTest()
        {
            // TODO unit test for the property 'SystemTraceAuditNumber'
        }
        /// <summary>
        /// Test the property 'PaymentAccountReferenceNumber'
        /// </summary>
        [Test]
        public void PaymentAccountReferenceNumberTest()
        {
            // TODO unit test for the property 'PaymentAccountReferenceNumber'
        }
        /// <summary>
        /// Test the property 'TransactionIntegrityCode'
        /// </summary>
        [Test]
        public void TransactionIntegrityCodeTest()
        {
            // TODO unit test for the property 'TransactionIntegrityCode'
        }
        /// <summary>
        /// Test the property 'AmexVerbalAuthReferenceNumber'
        /// </summary>
        [Test]
        public void AmexVerbalAuthReferenceNumberTest()
        {
            // TODO unit test for the property 'AmexVerbalAuthReferenceNumber'
        }
        /// <summary>
        /// Test the property 'MasterCardServiceCode'
        /// </summary>
        [Test]
        public void MasterCardServiceCodeTest()
        {
            // TODO unit test for the property 'MasterCardServiceCode'
        }
        /// <summary>
        /// Test the property 'MasterCardServiceReplyCode'
        /// </summary>
        [Test]
        public void MasterCardServiceReplyCodeTest()
        {
            // TODO unit test for the property 'MasterCardServiceReplyCode'
        }
        /// <summary>
        /// Test the property 'MasterCardAuthenticationType'
        /// </summary>
        [Test]
        public void MasterCardAuthenticationTypeTest()
        {
            // TODO unit test for the property 'MasterCardAuthenticationType'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Routing'
        /// </summary>
        [Test]
        public void RoutingTest()
        {
            // TODO unit test for the property 'Routing'
        }
        /// <summary>
        /// Test the property 'MerchantNumber'
        /// </summary>
        [Test]
        public void MerchantNumberTest()
        {
            // TODO unit test for the property 'MerchantNumber'
        }

    }

}
