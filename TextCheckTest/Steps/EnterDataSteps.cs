using System;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TextCheckTest.POM;

namespace TextCheckTest.Steps
{
    [Binding]
    public class EnterDataSteps
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
        [When(@"I enter (.*) to the (.*)")]
        public void WhenIEnterToThe(string data, int fieldNumber)
        {
            IWebElement field = null;
            switch (fieldNumber)
            {
                case 1:
                    field = driver.FindElement(mainPageModel.firstTextFieldId);
                    break;
                case 2:
                    field = driver.FindElement(mainPageModel.secondTextFieldId);
                    break;
            }
            field.SendKeys(data);
        }

        [Then(@"the (.*) in the (.*) should be on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(string result, int fieldNumber)
        {
            IWebElement el = null;
            switch (fieldNumber)
            {
                case 1:
                    el = driver.FindElement(mainPageModel.firstTextFieldId);
                    break;
                case 2:
                    el = driver.FindElement(mainPageModel.secondTextFieldId);
                    break;
            }
            Assert.AreEqual(result, el.Text);
        }
        [AfterScenario]
        public void CloseBrowser()
        {
            driver.Quit();
            BaseDriver.RemoveDriver();
        }


    }
}
