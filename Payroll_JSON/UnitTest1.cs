using NUnit.Framework;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Net;

namespace Payroll_JSON
{
    public class Tests
    {
         //initializing the client
        RestClient restClient;
        [SetUp]
        public void Setup()
        {
            restClient = new RestClient("http://localhost:4000");
        }
        //gets the employee detail from server
        public IRestResponse GetAllEmployee()
        {
            RestRequest request = new RestRequest("/employees", Method.Get);
            IRestResponse response = (IRestResponse)restClient.Execute(request);
            return response;
        }
        //retrieve from json server
        [Test]
        public void TestMethod_ToTest_RetrieveAllData_JSONServer()
        {
            IRestResponse response = GetAllEmployee();
            List<Employee> list = JsonConvert.DeserializeObject<List<Employee>>(response.Content);
            Assert.AreEqual(6, list.Count);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            foreach (var mem in list)
                System.Console.WriteLine(mem.id + " " + mem.first_name + " " + mem.last_name + " " + mem.email);
        }
    }
}