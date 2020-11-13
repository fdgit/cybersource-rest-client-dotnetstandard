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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using CyberSource.Client;
using CyberSource.Api;
using CyberSource.Model;

namespace CyberSource.Test
{
    /// <summary>
    ///  Class for testing PayoutsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PayoutsApiTests
    {
        private PayoutsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PayoutsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PayoutsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PayoutsApi
            //Assert.IsInstanceOfType(typeof(PayoutsApi), instance, "instance is a PayoutsApi");
        }

        
        /// <summary>
        /// Test OctCreatePayment
        /// </summary>
        [Test]
        public void OctCreatePaymentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OctCreatePaymentRequest octCreatePaymentRequest = null;
            //var response = instance.OctCreatePayment(octCreatePaymentRequest);
            //Assert.IsInstanceOf<PtsV2PayoutsPost201Response> (response, "response is PtsV2PayoutsPost201Response");
        }
        
    }

}
