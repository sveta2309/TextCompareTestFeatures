using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TextCheckTest.POM;

namespace TextCheckTest.Steps
{
    [Binding]
    public class SiteLogoSteps
    {
        public IWebDriver driver;
        public MainPageModel mainPageModel;
        [Given(@"The site is open in the Google Chrome")]
        public void GivenTheSiteIsOpenInTheGoogleChrome()
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
