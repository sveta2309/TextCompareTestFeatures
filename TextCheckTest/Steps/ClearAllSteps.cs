using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TextCheckTest.POM;

namespace TextCheckTest.Steps
{
    [Binding]
    public class ClearAllSteps
    {
        public IWebDriver driver;
        public MainPageModel mainPageModel;
        [BeforeScenario]

        public void TheSiteIsOpenInTheGoogleChrome()
        {
            driver = BaseDriver.GetDriver();
            mainPageModel = BaseDriver.GetMainPageModel();
            driver.Url = "https://text-compare.com";
        }
       
        [AfterScenario]
        public void CloseBrowser()
        {
            driver.Quit();
            BaseDriver.RemoveDriver();
        }
    }
}
