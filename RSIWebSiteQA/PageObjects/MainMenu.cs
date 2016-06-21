using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSIWebSiteQA.PageObjects
{
    class MainMenu
    {
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "mega-menu-item-6446")]
        private IWebElement WhatWeDoMenu { get; set; }

        [FindsBy(How = How.Id, Using = "mega-menu-item-6452")]
        private IWebElement SmarterOutsourcingMenu { get; set; }

        [FindsBy(How = How.Id, Using = "mega-menu-item-6457")]
        private IWebElement ResultsMenu { get; set; }

        [FindsBy(How = How.Id, Using = "mega-menu-item-6458")]
        private IWebElement AboutRSIMenu { get; set; }

        [FindsBy(How = How.Id, Using = "mega-menu-item-6474")]
        private IWebElement BlogMenu { get; set; }

        [FindsBy(How = How.LinkText, Using = "Careers")]  // The mega-menu-item-6475 locator is not valid from the Blog page
        private IWebElement CareersMenu { get; set; }

        [FindsBy(How = How.Id, Using = "mega-menu-item-6485")]
        private IWebElement AppMenu { get; set; }

        [FindsBy(How = How.Id, Using = "mega-menu-item-6486")]
        private IWebElement ContactMenu { get; set; }

        [FindsBy(How = How.Id, Using = "mega-menu-item-6502")]
        private IWebElement ApplyNowMenu { get; set; }

        public MainMenu(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void ClickWhatWeDoMenu()
        {
            WhatWeDoMenu.Click();
        }

        public void ClickSmarterOutsourcingMenu()
        {
            SmarterOutsourcingMenu.Click();
        }

        public void ClickResultsMenu()
        {
            ResultsMenu.Click();
        }

        public void ClickAboutRSIMenu()
        {
            AboutRSIMenu.Click();
        }

        public void ClickBlogMenu()
        {
            BlogMenu.Click();
        }

        public void ClickCareersMenu()
        {
            CareersMenu.Click();
        }

        public void ClickAppMenu()
        {
            AppMenu.Click();
        }

        public void ClickContactMenu()
        {
            ContactMenu.Click();
        }

        public void ClickApplyNowMenu()
        {
            ApplyNowMenu.Click();
        }
    }
}
