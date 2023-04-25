

using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;

namespace OpenQA.Selenium
{
    public class TestContext
    {
        public TestContext(IWebDriver driver, 
            IConfiguration configuration, 
            ScenarioContext scenarioContext, 
            FeatureContext featureContext) {
            Driver = driver;
            Configuration = configuration;
            ScenarioContext = scenarioContext;
            FeatureContext = featureContext;
        }
        public ScenarioContext ScenarioContext { get; set; }
        public FeatureContext FeatureContext { get; set; }
        public IWebDriver Driver { get; set; }
        public IConfiguration Configuration { get; set; }
        
    }
}
