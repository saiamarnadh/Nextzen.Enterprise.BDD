
using OpenQA.Selenium.Support.UI;

namespace OpenQA.Selenium;
blah blah blah
public static class WebDriverHelper
{
    public static bool highlightElements = true;
    public const int defaultTimeout = 30;

    public static IWebElement FindElement(
        this IWebDriver Driver, 
        By locator, 
        int timeOutInSeconds = defaultTimeout, 
        string? errorMessage = null) {


        IWebElement? resultElement = null;
        var currentImplicitTimeout = Driver.Manage().Timeouts().ImplicitWait;
        Driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
        WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeOutInSeconds));

        try
        {
            //Finding the element
            resultElement = wait.Until(x => x.FindElement(locator));
        }
        catch{
            //Throwing error message
            if (errorMessage != null) { throw new Exception(errorMessage); }
            throw;
        }
        finally {
            Driver.Manage().Timeouts().ImplicitWait = currentImplicitTimeout;
        }

        //Highlighting the elements
        if (highlightElements) {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].style.outline='3px solid #ff6347'", resultElement);
        }
        return resultElement;
    }
}
