using Nextzen.Enterprise.BDD;

namespace OpenQA.Selenium
{
    public abstract class BasePage : BaseObject
    {
        TestContext Context { get; set; }
        IWebDriver Driver => Context.Driver;
        
        public BasePage(TestContext context) : base(context.Configuration, context.ScenarioContext, context.FeatureContext)
        {
            Context = context;
        }
    }
}
