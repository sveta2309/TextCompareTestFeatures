using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TextCheckTest.POM
{
    public class FeedbackPageModel
    {
        public By messageFieldId = By.Id("id_message");
        public By emailFieldId = By.Id("id_email_address");
        public By sendFeedbackButtonId = By.Id("sendFeedbackButton");
        public By errorMessageXPath = By.XPath("/html/body/div[2]/div");
        public By successMessageXPath = By.XPath("/html/body/div[2]/div");
    }
}
