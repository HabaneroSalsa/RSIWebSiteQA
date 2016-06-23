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

        [FindsBy(How = How.XPath, Using = ".//*[@id='text-2']/div")]
        private IWebElement HQText { get; set; }


        public PageFooter(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public bool RSIFooterLogodisplayed()
        {
            var footerLogoDisplayed = FooterLogo.Displayed;
            return footerLogoDisplayed;
        }

        public string GetFooterLogoSize()
        {
            var FLSize = FooterLogo.Size;
            return FLSize.Width.ToString() + " x " + FLSize.Height.ToString();
        }

        public string GetFooterText()
        {
            var footerText = FooterText.Text;
            return footerText;
        }

        public string GetHQText()
        {
            var hQText = HQText.Text.Replace(System.Environment.NewLine, "|");
            return hQText;
        }
 
    }
}

