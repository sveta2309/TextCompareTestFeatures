using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TextCheckTest.POM;

namespace TextCheckTest.Steps
{
    [Binding]
    public class ClickOnButton
    {
        public IWebDriver driver;
        public MainPageModel mainPageModel;
        public FeedbackPageModel feedbackPageModel;
        public AboutPageModel aboutPageModel;
        [BeforeScenario]

        public void TheSiteIsOpenInTheGoogleChrome()
        {
            driver = BaseDriver.GetDriver();
            mainPageModel = BaseDriver.GetMainPageModel();
            feedbackPageModel = BaseDriver.GetFeedbackPageModel();
            driver.Url = "https://text-compare.com";
        }
        [When(@"I click (.*)")]
        public void WhenIClickEditText(string button)
        {
            IWebElement el = null;
            switch (button)
            {
                case "ClearAll button":
                    el = driver.FindElement(mainPageModel.clearAllButtonXPath);
                    break;
                case "Compare button":
                    el = driver.FindElement(mainPageModel.compareButtonId);
                    break;
                case "Switch button":
                    el = driver.FindElement(mainPageModel.switchButtonId);
                    break;
                case "Edit text":
                    el = driver.FindElement(mainPageModel.editTextDropDownMenuXPath);
                    break;
                case "Remove excess white space":
                    el = driver.FindElement(mainPageModel.removeExcessWhiteSpaceID);
                    break;
                case "To lowercase":
                    el = driver.FindElement(mainPageModel.toLowerCaseButtonId);
                    break;
                case "Replace line breaks with spaces":
                    el = driver.FindElement(mainPageModel.replaceLineBreaksID);
                    break;
                case "Sort lines":
                    el = driver.FindElement(mainPageModel.sortLinesButtonID);
                    break;
                case "About":
                    el = driver.FindElement(mainPageModel.aboutXPath);
                    break;
                case "Feedback":
                    el = driver.FindElement(mainPageModel.feedbackXPath);
                    break;
                case "Send feedback button":
                    el = driver.FindElement(feedbackPageModel.sendFeedbackButtonId);
                    break;
            }
            el.Click();
        }

        [AfterScenario]
        public void CloseBrowser()
        {
            driver.Quit();
            BaseDriver.RemoveDriver();
        }
     
        

    }
}
