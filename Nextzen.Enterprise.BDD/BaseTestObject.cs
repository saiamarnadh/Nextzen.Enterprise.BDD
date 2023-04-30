
using Microsoft.Extensions.Configuration;

namespace Nextzen.Enterprise.BDD
{
    public abstract class BaseObject
    {hbhboijpnjm
        public BaseObject(IConfiguration configuration, 
            ScenarioContext scenarioContext, 
            FeatureContext featureContext) {
            Configuration = configuration;
            ScenarioContext = scenarioContext;
            FeatureContext = featureContext;
        }
        public IConfiguration Configuration { get; set; }
        public ScenarioContext ScenarioContext { get; set; }
        public FeatureContext FeatureContext { get; set; }

    }
}
