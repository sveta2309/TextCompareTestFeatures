using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TextCheckTest.POM;

namespace TextCheckTest.Steps
{
    [Binding]
    public class EditTextSteps
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
        [When(@"I press Space in the field_(.*)")]
        public void WhenIPressSpace(int fieldNumber)
        {
            IWebElement el = null;
            switch(fieldNumber)
            {
                case 1:
                    el = driver.FindElement(mainPageModel.firstTextFieldId);
                    break;
                case 2:
                    el = driver.FindElement(mainPageModel.secondTextFieldId);
                    break;
            }       
            el.SendKeys(Keys.Space);
        }
        
      
        
        [When(@"I press Enter in the field_(.*)")]
        public void WhenIPressEnter(int fieldNumber)
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
            el.SendKeys(Keys.Enter);
        }
        [AfterScenario]
        public void CloseBrowser()
        {
            driver.Quit();
            BaseDriver.RemoveDriver();
        }
    }
}
