using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace RSIWebSiteQA.PageObjects
{
    class PageHeader
    {
        private IWebDriver driver;

        [FindsBy(How = How.CssSelector, Using = ".logo_standard")]
        private IWebElement HeaderLogo { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".social-linkedin>a")]
        private IWebElement HeaderLinkedIn { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".social-twitter>a")]
        private IWebElement HeaderTwitter { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".social-facebook>a")]
        private IWebElement HeaderFacebook { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".social-youtube>a")]
        private IWebElement HeaderYouTube { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".social-rss>a")]
        private IWebElement HeaderRSS { get; set; }

        public PageHeader(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void ClickRSIHeaderLogo()
        {
            HeaderLogo.Click();
        }

        public void GetHeaderLogoSize()
        {
            var HLSize = HeaderLogo.Size;
        }

        public void ClickLinkedInHeader()
        {
            HeaderLinkedIn.Click();
        }

        public void ClickTwitterHeader()
        {
            HeaderTwitter.Click();
        }

        public void ClickFacebookHeader()
        {
            HeaderFacebook.Click();
        }

        public void ClickYouTubeHeader()
        {
            HeaderYouTube.Click();
        }

        public void ClickRSSHeader()
        {
            HeaderRSS.Click();
        }


    }
}
