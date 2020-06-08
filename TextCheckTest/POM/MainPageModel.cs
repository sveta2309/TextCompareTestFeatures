using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TextCheckTest.POM
{
    public class MainPageModel
    {
        public By mainLogoId = By.Id("logo");
        public By firstTextFieldId = By.Id("inputText1");
        public By secondTextFieldId = By.Id("inputText2");
        public By compareButtonId = By.Id("compareButton");
        public By clearAllButtonXPath = By.XPath("/html/body/div[2]/form/div/table/tbody/tr/td[3]/button");
        public By switchButtonId = By.Id("switchButton");
        public By editTextDropDownMenuXPath = By.XPath("/html/body/div[2]/form/div/table/tbody/tr/td[1]/button[1]");
        public By aboutXPath = By.XPath("/html/body/div[3]/div[2]/div[1]/a");
        public By feedbackXPath = By.XPath("/html/body/div[3]/div[2]/div[2]/a");
        public By messageIdenticalXPath = By.XPath("/html/body/div[2]/span");
        public By messageEmptyFieldXPath=By.XPath("/html/body/div[2]/span");
        public By firstDifferenceFieldXPath = By.XPath("/html/body/div[2]/table/tbody/tr/td[3]/pre");
        public By secondDifferenceFieldXPath = By.XPath("/html/body/div[2]/table/tbody/tr/td[6]/pre/span");
        public By toLowerCaseButtonId = By.Id("toLowerCaseButton");
        public By sortLinesButtonID = By.Id("sortLinesButton");
        public By replaceLineBreaksID = By.Id("replaceLineBreaks");
        public By removeExcessWhiteSpaceID = By.Id("removeExcessWhiteSpace");
    }
}
