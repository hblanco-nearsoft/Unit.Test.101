using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit.Testing._101;

using RestSharp;


namespace Unit.Test._101.Tests
{
    [TestClass]
    public class NumbersClientTests
    {
        private class MockNumbersAdapter : INumberAdapter
        {
            public string Execute(RestSharp.RestRequest request)
            {
                return "The Unit Test class is awesome";
            }
        }

        private class MockNumbersAdapterFactory : INumbersAdapterFactory
        {
            public INumberAdapter Create(int type)
            {
                return new MockNumbersAdapter();
            }
        }

        [TestCategory("Algo"), TestMethod] //Naming Conventions: MethodName_TestingScenario_ExpectedResult
        public void GetRandomFact_ReturnsARandomFactAsString_ReturnsAString()
        {
            //SETUP
            var mockFactory = new MockNumbersAdapterFactory();
            var client = new NumbersClient(mockFactory);
            
            //EXECUTION
            var fact = client.GetRandomFact();
             
            //ASSERTIONS
            Assert.AreEqual(fact, "The Unit Test class is awesome");
        }
    }
}
