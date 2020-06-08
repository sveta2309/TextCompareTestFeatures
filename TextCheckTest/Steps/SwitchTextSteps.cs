using System;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TextCheckTest.POM;

namespace TextCheckTest.Steps
{
    [Binding]
    public class SwitchTextSteps
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
       
        
        [Then(@"field_(.*) must contain (.*) and field_(.*) must contain (.*)")]
        public void ThenField_MustContainAndField_MustContain(int firstFieldNumber, string firstResult, int SecondFieldNumber, string secondResult)
        {
            IWebElement firstField = driver.FindElement(mainPageModel.firstTextFieldId);
            IWebElement secondField = driver.FindElement(mainPageModel.secondTextFieldId);
            if(firstField.Text==firstResult && secondField.Text==secondResult)
            {
                Assert.Pass();
            }

        }
        [AfterScenario]
        public void CloseBrowser()
        {
            driver.Quit();
            BaseDriver.RemoveDriver();
        }
    }
}
