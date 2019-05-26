using Microsoft.VisualStudio.TestTools.UnitTesting;
using Specflow.Steps.WebApi;
using TechTalk.SpecFlow;

namespace MyApi.Tests
{
    [Binding]
    [Scope(Feature = "MyApiSteps")]
    public class MyApiSteps : WebApiSpecs
    {
        private static readonly WebApiSpecsConfig _config = new WebApiSpecsConfig { BaseUrl = "https://reqres.in" };
        public MyApiSteps(TestContext testContext) : base(testContext, _config) { }
    }
}
