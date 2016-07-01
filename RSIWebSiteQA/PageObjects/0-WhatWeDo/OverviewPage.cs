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
    class OverviewPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "slide-43-layer-1")]
        private IWebElement SlideText1 { get; set; }

        [FindsBy(How = How.Id, Using = "slide-43-layer-2")]
        private IWebElement SlideText2 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='post-4219']/div/h2/span")]
        private IWebElement TopicTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='post-4219']/div/p[1]")]
        private IWebElement TopicParagraph1 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='post-4219']/div/p[2]")]
        private IWebElement TopicParagraph2 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='post-4219']/div/p[3]")]
        private IWebElement TopicParagraph3 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='text-9']/h3/span")]
        private IWebElement LinkListTitle { get; set; }

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

        public string GetSlideText1()
        {
            string slideText1 = SlideText1.Text;
            return slideText1;
        }

        public string GetSlideText2()
        {
            string slideText2 = SlideText2.Text;
            return slideText2;
        }

        public string GetTopicTitle()
        {
            string topicTitle = TopicTitle.Text;
            return topicTitle;
        }

        public string GetTopicParagraph1()
        {
            string topicParagraph1 = TopicParagraph1.Text;
            return topicParagraph1;
        }

        public string GetTopicParagraph2()
        {
            string topicParagraph2 = TopicParagraph2.Text;
            return topicParagraph2;
        }


        public string GetTopicParagraph3()
        {
            string topicParagraph3 = TopicParagraph3.Text;
            return topicParagraph3;
        }

        public string GetLinkListTitle()
        {
            string linkListTitle = LinkListTitle.Text;
            return linkListTitle;
        }

        public string GetFAQLinkText()
        {
            string getFAQLinkText = FAQLink.Text;
            return getFAQLinkText;
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
            BIExpander.Click();
        }

        public string GetBIText()
        {
            string bIText = BIText.Text;
            return bIText;
        }
    }
}
