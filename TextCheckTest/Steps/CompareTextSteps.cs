using System;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TextCheckTest.POM;

namespace TextCheckTest.Steps
{
    [Binding]
    public class CompareTextSteps
    {
        public IWebDriver driver;
        public MainPageModel mainPageModel;
        public AboutPageModel aboutPageModel;
        public FeedbackPageModel feedbackPageModel;
        [BeforeScenario]

        public void TheSiteIsOpenInTheGoogleChrome()
        {
            driver = BaseDriver.GetDriver();
            mainPageModel = BaseDriver.GetMainPageModel();
            aboutPageModel = BaseDriver.GetAboutPageModel();
            feedbackPageModel = BaseDriver.GetFeedbackPageModel();
            driver.Url = "https://text-compare.com";
        }
        [When(@"I write (.*) in the first field")]
        public void WhenIWriteInTheFirstField(string text)
        {
            IWebElement field = driver.FindElement(mainPageModel.firstTextFieldId);
            field.SendKeys(text);
        }

        [When(@"I write (.*) in the second field")]
        public void WhenIWriteInTheSecondField(string text)
        {
            IWebElement field = driver.FindElement(mainPageModel.secondTextFieldId);
            field.SendKeys(text);
        }



        [Then(@"the (.*) should be on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(string result)
        {
            IWebElement el = null;
            switch (result)
            {
                case "site logo":
                    el = driver.FindElement(mainPageModel.mainLogoId);
                    Assert.AreEqual("Text Compare!", el.Text);
                    break;
                case "Identical message":
                    el = driver.FindElement(mainPageModel.messageIdenticalXPath);
                    Assert.AreEqual("The two texts are identical!", el.Text);
                    break;
                case "Empty message":
                    el = driver.FindElement(mainPageModel.messageEmptyFieldXPath);
                    Assert.AreEqual("No text to compare makes my life easy! Cheers ;-)", el.Text);
                    break;
                case "information":
                    el = driver.FindElement(aboutPageModel.informationFieldXPath);
                    Assert.AreEqual("Text Compare! is an online diff tool that allows you to easily make a text comparison and find the differences between two texts. Just paste the two texts and hit the compare button. The two texts are shown side by side, with differences highlighted. It highlights not the entire line which contains a difference, but only the difference itself. For larger texts, it also has links that allow you to jump from one difference to the next.", el.Text);
                    break;
                case "error message":
                    el = driver.FindElement(feedbackPageModel.errorMessageXPath);
                    Assert.AreEqual("Sorry, can't send your feedback like this.", el.Text);
                    break;
                case "sucsess send message":
                    el = driver.FindElement(feedbackPageModel.successMessageXPath);
                    Assert.AreEqual("Your feedback has been sent! Thanks!", el.Text);
                    break;



            }

        }
        [Then(@"two fields with differencies should be on the screen")]
        public void ThenTwoFieldsWithDifferenciesShouldBeOnTheScreen()
        {
            IWebElement firstEl = driver.FindElement(mainPageModel.firstDifferenceFieldXPath);
            IWebElement secondEl = driver.FindElement(mainPageModel.secondDifferenceFieldXPath);
            if (firstEl.Text == "123" && secondEl.Text == "1234")
            {
                Assert.Pass();
            }
        }

        [When(@"I clicked field_(.*)")]
        public void WhenIClickField_(int fieldNumber)
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
