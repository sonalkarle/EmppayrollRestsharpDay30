using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;

namespace Emppayrollrest
{
    public class TEST
    {
        RestClient client;
        [SetUp]
        public void Setup()
        {
            client = new RestClient("http://localhost:3000");
        }
        /// <summary>
        /// UC1: Retrive the data from the json file
        /// </summary>
        /// <returns></returns>
        private IRestResponse getEmpoylee()
        {
            RestRequest request = new RestRequest("/Emppayroll", Method.GET);
            IRestResponse response = client.Execute(request);
            return response;
        }
        /// <summary>
        /// UC2: Get count of the person in the file
        /// </summary>
        [Test]
        public void Return_GivenEmployeeList()
        {
            IRestResponse response = getEmpoylee();
            Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);
            List<Employee> list = JsonConvert.DeserializeObject<List<Employee>>(response.Content);
            Assert.AreEqual(13, list.Count);
            
        }
        
       
        
       
        
    }
}