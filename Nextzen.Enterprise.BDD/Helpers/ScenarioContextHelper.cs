
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TechTalk.SpecFlow;

public static class ScenarioContextHelper
{
    public static ScenarioContext RegisterChromeDriver(this ScenarioContext scenarioContext, 
        int implicitTimeout=30, 
        ChromeOptions? options = null) {
        scenarioContext.ScenarioContainer.RegisterFactoryAs<IWebDriver>((scenarioContainer) => { 

            ChromeDriver driver = (options == null) ? new ChromeDriver() : new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitTimeout);
            return driver;
        });

        return scenarioContext;
    }

    public static ScenarioContext RegisterConfiguration(this ScenarioContext scenarioContext) {
        scenarioContext.ScenarioContainer.RegisterFactoryAs<IConfiguration>((scenarioContainer) => {
            IConfigurationBuilder configBuilder = new ConfigurationBuilder().
            SetBasePath(Directory.GetCurrentDirectory()).
            AddJsonFile("appSettings.json", optional: true, reloadOnChange: true);

            return configBuilder.Build();
        });
        return scenarioContext;
    }
}
