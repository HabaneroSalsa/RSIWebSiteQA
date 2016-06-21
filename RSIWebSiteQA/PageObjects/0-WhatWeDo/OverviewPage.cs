using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSIWebSiteQA.PageObjects._0_WhatWeDo
{
    class OverviewPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.CssSelector, Using = ".textwidget>a")]
        private IWebElement FAQLink { get; set; }

        [FindsBy(How = How.Id, Using = "s")]
        private IWebElement SearchField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='post-4219']/div/div/div[1]/a")]
        private IWebElement AppDevExpander { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='post-4219']/div/div/div[2]")]
        private IWebElement AppDevText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='post-4219']/div/div/div[3]/a")]
        private IWebElement AppManExpander { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='post-4219']/div/div/div[4]")]
        private IWebElement AppManText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='post-4219']/div/div/div[5]/a")]
        private IWebElement QAExpander { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='post-4219']/div/div/div[6]")]
        private IWebElement QAText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='post-4219']/div/div/div[7]/a")]
        private IWebElement BIExpander { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='post-4219']/div/div/div[8]")]
        private IWebElement BIText { get; set; }

        public OverviewPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void ClickFAQLink()
        {
            FAQLink.Click();
        }

        public void TypeSearchCriteria(string Searchtext)
        {
            SearchField.SendKeys(Searchtext);
        }

        public void ClickAppDevExpander()
        {
            AppDevExpander.Click();
        }

        public string GetAppDevText()
        {
            string appDevText = AppDevText.Text;
            return appDevText;
        }

        public void ClickAppManExpander()
        {
            AppManExpander.Click();
        }

            public string GetAppManText()
        {
            string appManText = AppManText.Text;
            return appManText;
        }

        public void ClickQAExpander()
        {
            QAExpander.Click();
        }

        public string GetQAText()
        {
            string qAText = QAText.Text;
            return qAText;
        }

        public void ClickBIExpander()
        {
            QAExpander.Click();
        }

        public string GetBIText()
        {
            string bIText = BIText.Text;
            return bIText;
        }
    }
}
