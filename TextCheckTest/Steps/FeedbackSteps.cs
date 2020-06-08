using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TextCheckTest.POM;

namespace TextCheckTest.Steps
{
    [Binding]
    public class FeedbackSteps
    {
        public IWebDriver driver;
        public FeedbackPageModel feedbackPageModel;
        [BeforeScenario]

        public void TheSiteIsOpenInTheGoogleChrome()
        {
            driver = BaseDriver.GetDriver();
            feedbackPageModel = BaseDriver.GetFeedbackPageModel();
            driver.Url = "https://text-compare.com";
        }
        [When(@"I entered (.*) to the (.*)")]
        public void WhenIEnteredAbyzToTheMessageField(string text, string field)
        {
            IWebElement el = null;
            switch(field)
            {
                case "message field":
                    el = driver.FindElement(feedbackPageModel.messageFieldId);
                    break;
                case "the email field":
                    el = driver.FindElement(feedbackPageModel.emailFieldId);
                    break;
            }
            el.SendKeys(text);
        }
        [AfterScenario]
        public void CloseBrowser()
        {
            driver.Quit();
            BaseDriver.RemoveDriver();
        }
    }
}
