using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit.Testing._101;

using RestSharp;


namespace Unit.Test._101.Tests
{
    [TestClass]
    public class NumbersClientTests
    {
        [TestMethod] //Naming Conventions: MethodName_TestingScenario_ExpectedResult
        public void GetRandomFact_ReturnsARandomFactAsString_ReturnsAString()
        {
            //SETUP
            var client = new NumbersClient();
            
            //EXECUTION
            var fact = client.GetRandomFact();

            //ASSERTIONS
            Assert.IsFalse(String.IsNullOrEmpty(fact));
        }
    }
}
