using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSIWebSiteQA.PageObjects
{
    public class PageFooter
    {
        private IWebDriver driver;

        [FindsBy(How = How.CssSelector, Using = ".textwidget>img")]
        private IWebElement FooterLogo { get; set; }
        
        [FindsBy(How = How.CssSelector, Using = ".copyright-text.eight.columns")]
        private IWebElement FooterText { get; set; }

        public PageFooter(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void ClickRSIFooterLogo()
        {
            FooterLogo.Click();
        }

        public void GetFooterLogoSize()
        {
            var HLSize = FooterLogo.Size;
        }

        public void GetFooterText()
        {
            var TextFooter = FooterText.Text;
        }
 
    }
}

