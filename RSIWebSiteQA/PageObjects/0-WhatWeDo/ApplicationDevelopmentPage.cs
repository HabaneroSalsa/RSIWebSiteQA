using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSIWebSiteQA.PageObjects._0_WhatWeDo
{
    class ApplicationDevelopmentPage
    {
        private IWebDriver driver;
                   
        [FindsBy(How = How.CssSelector, Using = ".nine.columns>h1")]
        private IWebElement ADTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='post-4231']/div/h1/span")]
        private IWebElement ADMainTopicTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='post-4231']/div/h4/span")]
        private IWebElement ADSubTopicTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='post-4231']/div/p[1]")]
        private IWebElement ADParagraph1 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='post-4231']/div/p[2]")]
        private IWebElement ADParagraph2 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='post-4231']/div/p[3]")]
        private IWebElement ADParagraph3 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='post-4231']/div/p[4]")]
        private IWebElement ADParagraph4 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='post-4231']/div/p[5]")]
        private IWebElement ADParagraph5 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='post-4231']/div/p[6]")]
        private IWebElement ADParagraph6 { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".entry>p>a")]
        private IWebElement ContactUsLink { get; set; }

        [FindsBy(How = How.Id, Using = "java")]
        private IWebElement JavaExpander { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='post-4231']/div/div/div[2]")]
        private IWebElement JavaText { get; set; }

        [FindsBy(How = How.Id, Using = "net")]
        private IWebElement DotNetExpander { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='post-4231']/div/div/div[4]")]
        private IWebElement DotNetText { get; set; }

        [FindsBy(How = How.Id, Using = "mobile")]
        private IWebElement MobileExpander { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='post-4231']/div/div/div[6]")]
        private IWebElement MobileText { get; set; }

        [FindsBy(How = How.Id, Using = "web")]
        private IWebElement WebExpander { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='post-4231']/div/div/div[8]")]
        private IWebElement WebText { get; set; }

        [FindsBy(How = How.Id, Using = "php")]
        private IWebElement PHPExpander { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='post-4231']/div/div/div[10]")]
        private IWebElement PHPText { get; set; }

        public ApplicationDevelopmentPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);           
        }

        public string GetADTitle()
        {
            string aDTitile = ADTitle.Text;
            return aDTitile;
        }

        public string GetADMainTopicTitle()
        {
            string aDMainTitile = ADMainTopicTitle.Text;
            return aDMainTitile;
        }

        public string GetADSubTopicTitle()
        {
            string aDSubTitile = ADSubTopicTitle.Text;
            return aDSubTitile;
        }

        public string GetADParagraph1Text()
        {
            string aDParagraph1Text = ADParagraph1.Text;
            return aDParagraph1Text;
        }
    
        public string GetADParagraph2Text()
        {
            string aDParagraph2Text = ADParagraph2.Text;
            return aDParagraph2Text;
        }

        public string GetADParagraph3Text()
        {
            string aDParagraph3Text = ADParagraph3.Text;
            return aDParagraph3Text;
        }

        public string GetADParagraph4Text()
        {
            string aDParagraph4Text = ADParagraph4.Text;
            return aDParagraph4Text;
        }

        public string GetADParagraph5Text()
        {
            string aDParagraph5Text = ADParagraph5.Text;
            return aDParagraph5Text;
        }

        public string GetADParagraph6Text()
        {
            string aDParagraph6Text = ADParagraph6.Text;
            return aDParagraph6Text;
        }

        public void ClickJavaExpander()
        {
            
            JavaExpander.Click();
            var clicker = new Actions(driver);
            clicker.SendKeys("^{end}");
        }

        public void ClickDotNetExpander()
        {
            //var clicker = new Actions(driver);
            //clicker.SendKeys("^{end}");
            DotNetExpander.Click();
        }

        public void ClickMobileExpander()
        {
            //var clicker = new Actions(driver);
            //clicker.SendKeys("^{end}");
            MobileExpander.Click();
        }

        public void ClickWebExpander()
        {
            //var clicker = new Actions(driver);
            //clicker.SendKeys("^{end}");
            WebExpander.Click();
        }

        public void ClickPHPExpander()
        {
            //var clicker = new Actions(driver);
            //clicker.SendKeys("^{end}");
            PHPExpander.Click();
        }
    }
}
