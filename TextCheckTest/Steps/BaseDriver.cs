using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextCheckTest.POM;

namespace TextCheckTest.Steps
{
    public static class BaseDriver
    {
        public static IWebDriver driver;
        public static MainPageModel mainPageModel;
        public static FeedbackPageModel feedbackPageModel;
        public static AboutPageModel aboutPageModel;


        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                driver = new ChromeDriver("C:\\Users\\sveta\\Desktop");
            }
            return driver;

        }
        public static MainPageModel GetMainPageModel()
        {
            mainPageModel = new MainPageModel();
            return mainPageModel;
        }
        public static FeedbackPageModel GetFeedbackPageModel()
        {
            feedbackPageModel = new FeedbackPageModel();
            return feedbackPageModel;
        }
        public static AboutPageModel GetAboutPageModel()
        {
            aboutPageModel = new AboutPageModel();
            return aboutPageModel;
        }

        public static void RemoveDriver()
        {
            driver = null;
        }

    }


}


