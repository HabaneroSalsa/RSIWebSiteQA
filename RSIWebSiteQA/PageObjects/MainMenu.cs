using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace RSIWebSiteQA.PageObjects
{
    class MainMenu
    {
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "mega-menu-item-6446")]
        private IWebElement WhatWeDoMenu { get; set; }
            [FindsBy(How = How.Id, Using = "mega-menu-item-6451")]
            private IWebElement WWDOverview { get; set; }
            [FindsBy(How = How.Id, Using = "mega-menu-item-6447")]
            private IWebElement WWDAppDevSubMenu { get; set; }
                [FindsBy(How = How.Id, Using = "mega-menu-item-6513")]
                private IWebElement WWDAppDevJava { get; set; }
                [FindsBy(How = How.Id, Using = "mega-menu-item-6514")]
                private IWebElement WWDAppDevDotNET { get; set; }
                [FindsBy(How = How.Id, Using = "mega-menu-item-6515")]
                private IWebElement WWDAppDevMobile { get; set; }
                [FindsBy(How = How.Id, Using = "mega-menu-item-6516")]
                private IWebElement WWDAppDevWeb { get; set; }
                [FindsBy(How = How.Id, Using = "mega-menu-item-6517")]
                private IWebElement WWDAppDevPHP { get; set; }
            [FindsBy(How = How.Id, Using = "mega-menu-item-6448")]
            private IWebElement WWDAppManSubMenu { get; set; }
                [FindsBy(How = How.Id, Using = "mega-menu-item-6518")]
                private IWebElement WWDAppManCAS { get; set; }
                [FindsBy(How = How.Id, Using = "mega-menu-item-6519")]
                private IWebElement WWDAppManSAP { get; set; }
                [FindsBy(How = How.Id, Using = "mega-menu-item-6520")]
                private IWebElement WWDAppManOracle { get; set; }
                [FindsBy(How = How.Id, Using = "mega-menu-item-6521")]
                private IWebElement WWDAppManLIMS { get; set; }
                [FindsBy(How = How.Id, Using = "mega-menu-item-6522")]
                private IWebElement WWDAppManDatabase { get; set; }
                [FindsBy(How = How.Id, Using = "mega-menu-item-6597")]
                private IWebElement WWDAppManSalesforce { get; set; }
                [FindsBy(How = How.Id, Using = "mega-menu-item-6523")]
                private IWebElement WWDAppManSharepoint { get; set; }
                [FindsBy(How = How.Id, Using = "mega-menu-item-6524")]
                private IWebElement WWDAppManTrackWise { get; set; }
            [FindsBy(How = How.Id, Using = "mega-menu-item-6450")]
            private IWebElement WWDQASubMenu { get; set; }
                [FindsBy(How = How.Id, Using = "mega-menu-item-6525")]
                private IWebElement WWDQAAutomation { get; set; }
                [FindsBy(How = How.Id, Using = "mega-menu-item-6526")]
                private IWebElement WWDQAStrategy { get; set; }
                [FindsBy(How = How.Id, Using = "mega-menu-item-6527")]
                private IWebElement WWDQASWTesting { get; set; }
                [FindsBy(How = How.Id, Using = "mega-menu-item-6528")]
                private IWebElement WWDQASWPerfTest { get; set; }
                [FindsBy(How = How.Id, Using = "mega-menu-item-6529")]
                private IWebElement WWDQAMobileTest { get; set; }
                [FindsBy(How = How.Id, Using = "mega-menu-item-6530")]
                private IWebElement WWDQAValidation { get; set; }
            [FindsBy(How = How.Id, Using = "mega-menu-item-6449")]
            private IWebElement WWDBIAnalyticsSubMenu { get; set; }
                [FindsBy(How = How.Id, Using = "mega-menu-item-6531")]
                private IWebElement WWDBIAnalyticsMicroStrategy { get; set; }
                [FindsBy(How = How.Id, Using = "mega-menu-item-6532")]
                private IWebElement WWDBIAnalyticsInformatica { get; set; }
                [FindsBy(How = How.Id, Using = "mega-menu-item-6533")]
                private IWebElement WWDBIAnalyticsSAPHANA { get; set; }
                [FindsBy(How = How.Id, Using = "mega-menu-item-6534")]
                private IWebElement WWDBIAnalyticsMSBI { get; set; }
                [FindsBy(How = How.Id, Using = "mega-menu-item-6535")]
                private IWebElement WWDBIAnalyticsReporting { get; set; }

        [FindsBy(How = How.Id, Using = "mega-menu-item-6452")]
        private IWebElement SmarterOutsourcingMenu { get; set; }
            [FindsBy(How = How.Id, Using = "mega-menu-item-6456")]
            private IWebElement SOOverview { get; set; }
            [FindsBy(How = How.Id, Using = "mega-menu-item-6453")]
            private IWebElement SOBenefits { get; set; }
            [FindsBy(How = How.Id, Using = "mega-menu-item-6455")]
            private IWebElement SOWhattoExpect { get; set; }
            [FindsBy(How = How.Id, Using = "mega-menu-item-6454")]
            private IWebElement SOFAQ { get; set; }

        [FindsBy(How = How.Id, Using = "mega-menu-item-6457")]
        private IWebElement ResultsMenu { get; set; }

        [FindsBy(How = How.Id, Using = "mega-menu-item-6458")]
        private IWebElement AboutRSIMenu { get; set; }
            [FindsBy(How = How.Id, Using = "mega-menu-item-6468")]
            private IWebElement AROverview { get; set; }
            [FindsBy(How = How.Id, Using = "mega-menu-item-6462")]
            private IWebElement ARDevCentersSubMenu { get; set; }
                [FindsBy(How = How.Id, Using = "mega-menu-item-6469")]
                private IWebElement ARDCOurLocations { get; set; }
                [FindsBy(How = How.Id, Using = "mega-menu-item-6463")]
                private IWebElement ARDCAlabama { get; set; }
                [FindsBy(How = How.Id, Using = "mega-menu-item-6464")]
                private IWebElement ARDCArkansas { get; set; }
                [FindsBy(How = How.Id, Using = "mega-menu-item-6465")]
                private IWebElement ARDCGeorgia { get; set; }
                [FindsBy(How = How.Id, Using = "mega-menu-item-6472")]
                private IWebElement ARDCNewMexico { get; set; }
                [FindsBy(How = How.Id, Using = "mega-menu-item-6484")]
                private IWebElement ARDCWheresNext { get; set; }
            [FindsBy(How = How.Id, Using = "mega-menu-item-6461")]
            private IWebElement ARCommunity { get; set; }
            [FindsBy(How = How.Id, Using = "mega-menu-item-6467")]
            private IWebElement AROurPartners { get; set; }
            [FindsBy(How = How.Id, Using = "mega-menu-item-6466")]
            private IWebElement AROurLeadership { get; set; }
            [FindsBy(How = How.Id, Using = "mega-menu-item-6460")]
            private IWebElement ARBoardOfDirectors { get; set; }
            [FindsBy(How = How.Id, Using = "mega-menu-item-6470")]
            private IWebElement ARPressReleases { get; set; }
            [FindsBy(How = How.Id, Using = "mega-menu-item-6471")]
            private IWebElement ARNews { get; set; }
            [FindsBy(How = How.Id, Using = "mega-menu-item-6459")]
            private IWebElement ARAwards { get; set; }

        [FindsBy(How = How.Id, Using = "mega-menu-item-6474")]
        private IWebElement BlogMenu { get; set; }

        [FindsBy(How = How.LinkText, Using = "Careers")]  // The mega-menu-item-6475 locator is not valid from the Blog page
        private IWebElement CareersMenu { get; set; }
            [FindsBy(How = How.Id, Using = "mega-menu-item-6478")]
            private IWebElement CMOverview { get; set; }
            [FindsBy(How = How.Id, Using = "mega-menu-item-6501")]
            private IWebElement CMJobSearch { get; set; }
            [FindsBy(How = How.Id, Using = "mega-menu-item-6503")]
            private IWebElement CMApplication { get; set; }
            [FindsBy(How = How.Id, Using = "mega-menu-item-6481")]
            private IWebElement CMYourBenefits { get; set; }
            [FindsBy(How = How.Id, Using = "mega-menu-item-6479")]
            private IWebElement CMTraining { get; set; }
            [FindsBy(How = How.Id, Using = "mega-menu-item-6480")]
            private IWebElement CMUniPartner { get; set; }
            [FindsBy(How = How.Id, Using = "mega-menu-item-6482")]
            private IWebElement CMRSICulture { get; set; }
            [FindsBy(How = How.Id, Using = "mega-menu-item-6483")]
            private IWebElement CMcareerEvents { get; set; }

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


        //public static Func<IWebDriver, IWebElement> ElementIsClickable(By locator)
        //{
        //    return driver =>
        //    {
        //        var element = driver.FindElement(locator);
        //        return (element != null && element.Displayed && element.Enabled) ? element : null;
        //    };
        //}


        public void HoverWhatWeDo()
        {
            Actions builder = new Actions(driver);
            Actions hoverMainMenu = builder.MoveToElement(WhatWeDoMenu);
            hoverMainMenu.Build().Perform();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            var clickableElement = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(WWDBIAnalyticsSubMenu.GetAttribute("id"))));
        }

        public void HoverWWDAppDevSubMenu()
        {
            Actions builder = new Actions(driver);
            Actions hoverWWDAppDevSubMenu = builder.MoveToElement(WWDAppDevSubMenu);
            hoverWWDAppDevSubMenu.Build().Perform();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            var clickableElement = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(WWDAppDevPHP.GetAttribute("id"))));
        }

        public void HoverWWDAppManSubMenu()
        {
            Actions builder = new Actions(driver);
            Actions hoverWWDAppManSubMenu = builder.MoveToElement(WWDAppManSubMenu);
            hoverWWDAppManSubMenu.Build().Perform();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            var clickableElement = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(WWDAppManTrackWise.GetAttribute("id"))));
        }

        public void HoverWWDQASubMenu()
        {
            Actions builder = new Actions(driver);
            Actions hoverWWDQASubMenu = builder.MoveToElement(WWDQASubMenu);
            hoverWWDQASubMenu.Build().Perform();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            var clickableElement = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(WWDQAValidation.GetAttribute("id"))));
        }

        public void HoverWWDBIAnalyticsSubMenu()
        {
            Actions builder = new Actions(driver);
            Actions hoverWWDBIAnalyticsSubMenu = builder.MoveToElement(WWDBIAnalyticsSubMenu);
            hoverWWDBIAnalyticsSubMenu.Build().Perform();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            var clickableElement = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(WWDBIAnalyticsReporting.GetAttribute("id"))));
        }
       
        public void HoverSmarterOutsourcingMenu()
        {
            Actions builder = new Actions(driver);
            Actions hoverSmarterOutsourcingMenu = builder.MoveToElement(SmarterOutsourcingMenu);
            hoverSmarterOutsourcingMenu.Build().Perform();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            var clickableElement = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(SOFAQ.GetAttribute("id"))));
        }

        public void HoverAboutRSIMenu()
        {
            Actions builder = new Actions(driver);
            Actions hoverAboutRSIMenu = builder.MoveToElement(AboutRSIMenu);
            hoverAboutRSIMenu.Build().Perform();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            var clickableElement = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(ARAwards.GetAttribute("id"))));
        }

        public void HoverARDevCentersSubMenu()
        {
            Actions builder = new Actions(driver);
            Actions hoverARDevCentersSubMenu = builder.MoveToElement(ARDevCentersSubMenu);
            hoverARDevCentersSubMenu.Build().Perform();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            var clickableElement = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(ARDCWheresNext.GetAttribute("id"))));
        }

        public void HoverCareersMenu()
        {
            Actions builder = new Actions(driver);
            Actions hoverCareersMenu = builder.MoveToElement(CareersMenu);
            hoverCareersMenu.Build().Perform();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            var clickableElement = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(CMcareerEvents.GetAttribute("id"))));
        }

        public void ClickWWDOverview()
        {
            WWDOverview.Click();
        }

        public void ClickWWDAppDevJava()
        {
            WWDAppDevJava.Click();
        }

        public void ClickWWDAppDevDotNET()
        {
            WWDAppDevDotNET.Click();
        }

        public void ClickWWDAppDevMobile()
        {
            WWDAppDevMobile.Click();
        }

        public void ClickWWDAppDevWeb()
        {
            WWDAppDevWeb.Click();
        }

        public void ClickWWDAppDevPHP()
        {
            WWDAppDevPHP.Click();
        }

        public void ClickWWDAppManCAS()
        {
            WWDAppManCAS.Click();
        }

        public void ClickWWDAppManSAP()
        {
            WWDAppManSAP.Click();
        }

        public void ClickWWDAppManOracle()
        {
            WWDAppManOracle.Click();
        }

        public void ClickWWDAppManLIMS()
        {
            WWDAppManLIMS.Click();
        }

        public void ClickWWDAppManDatabase()
        {
            WWDAppManDatabase.Click();
        }

        public void ClickWWDAppManSalesforce()
        {
            WWDAppManSalesforce.Click();
        }

        public void ClickWWDAppManSharepoint()
        {
            WWDAppManSharepoint.Click();
        }

        public void ClickWWDAppManTrackWise()
        {
            WWDAppManTrackWise.Click();
        }

        public void ClickWWDQAAutomation()
        {
            WWDQAAutomation.Click();
        }

        public void ClickWWDQAStrategy()
        {
            WWDQAStrategy.Click();
        }

        public void ClickWWDQASWTesting()
        {
            WWDQASWTesting.Click();
        }

        public void ClickWWDQASWPerfTest()
        {
            WWDQASWPerfTest.Click();
        }

        public void ClickWWDQAMobileTest()
        {
            WWDQAMobileTest.Click();
        }

        public void ClickWWDQAValidation()
        {
            WWDQAValidation.Click();
        }

        public void ClickWWDBIAnalyticsMicroStrategy()
        {
            WWDBIAnalyticsMicroStrategy.Click();
        }

        public void ClickWWDBIAnalyticsInformatica()
        {
            WWDBIAnalyticsInformatica.Click();
        }

        public void ClickWWDBIAnalyticsSAPHANA()
        {
            WWDBIAnalyticsSAPHANA.Click();
        }

        public void ClickWWDBIAnalyticsMSBI()
        {
            WWDBIAnalyticsMSBI.Click();
        }

        public void ClickWWDBIAnalyticsReporting()
        {
            WWDBIAnalyticsReporting.Click();
        }

        public void ClickWWDAppDevSubMenu()
        {
            WWDAppDevSubMenu.Click();
        }

        public void ClickWWDAppManSubMenu()
        {
            WWDAppManSubMenu.Click();
        }

        public void ClickWWDQASubMenu()
        {
            WWDQASubMenu.Click();
        }

        public void ClickWWDBIAnalyticsSubMenu()
        {
            WWDBIAnalyticsSubMenu.Click();
        }

        public void TestWWDAppDevJava()
        {
            HoverWhatWeDo();
            HoverWWDAppDevSubMenu();
            ClickWWDAppDevJava();
        }

        public void TestWWDAppDevDotNET()
        {
            HoverWhatWeDo();
            HoverWWDAppDevSubMenu();
            ClickWWDAppDevDotNET();
        }

        public void TestWWDAppDevMobile()
        {
            HoverWhatWeDo();
            HoverWWDAppDevSubMenu();
            ClickWWDAppDevMobile();
        }

        public void TestWWDAppDevWeb()
        {
            HoverWhatWeDo();
            HoverWWDAppDevSubMenu();
            ClickWWDAppDevWeb();
        }

        public void TestWWDAppDevPHP()
        {
            HoverWhatWeDo();
            HoverWWDAppDevSubMenu();
            ClickWWDAppDevPHP();
        }

        public void TestWWDAppManCAS()
        {
            HoverWhatWeDo();
            HoverWWDAppManSubMenu();
            ClickWWDAppManCAS();
        }

        public void TestWWDAppManSAP()
        {
            HoverWhatWeDo();
            HoverWWDAppManSubMenu();
            ClickWWDAppManSAP();
        }

        public void TestWWDAppManOracle()
        {
            HoverWhatWeDo();
            HoverWWDAppManSubMenu();
            ClickWWDAppManOracle();
        }

        public void TestWWDAppManLIMS()
        {
            HoverWhatWeDo();
            HoverWWDAppManSubMenu();
            ClickWWDAppManLIMS();
        }

        public void TestWWDAppManDatabase()
        {
            HoverWhatWeDo();
            HoverWWDAppManSubMenu();
            ClickWWDAppManDatabase();
        }

        public void TestWWDAppManSalesforce()
        {
            HoverWhatWeDo();
            HoverWWDAppManSubMenu();
            ClickWWDAppManSalesforce();
        }

        public void TestWWDAppManSharepoint()
        {
            HoverWhatWeDo();
            HoverWWDAppManSubMenu();
            ClickWWDAppManSharepoint();
        }

        public void TestWWDAppManTrackWise()
        {
            HoverWhatWeDo();
            HoverWWDAppManSubMenu();
            ClickWWDAppManTrackWise();
        }

        public void TestWWDQAAutomation()
        {
            HoverWhatWeDo();
            HoverWWDQASubMenu();
            ClickWWDQAAutomation();
        }

        public void TestWWDQAStrategy()
        {
            HoverWhatWeDo();
            HoverWWDQASubMenu();
            ClickWWDQAStrategy();
        }

        public void TestWWDQASWTesting()
        {
            HoverWhatWeDo();
            HoverWWDQASubMenu();
            ClickWWDQASWTesting();
        }

        public void TestWWDQASWPerfTest()
        {
            HoverWhatWeDo();
            HoverWWDQASubMenu();
            ClickWWDQASWPerfTest();
        }

        public void TestWWDQAMobileTest()
        {
            HoverWhatWeDo();
            HoverWWDQASubMenu();
            ClickWWDQAMobileTest();
        }

        public void TestWWDQAValidation()
        {
            HoverWhatWeDo();
            HoverWWDQASubMenu();
            ClickWWDQAValidation();
        }

        public void TestWWDBIAnalyticsMicroStrategy()
        {
            HoverWhatWeDo();
            HoverWWDBIAnalyticsSubMenu();
            ClickWWDBIAnalyticsMicroStrategy();
        }

        public void TestWWDBIAnalyticsInformatica()
        {
            HoverWhatWeDo();
            HoverWWDBIAnalyticsSubMenu();
            ClickWWDBIAnalyticsInformatica();
        }

        public void TestWWDBIAnalyticsSAPHANA()
        {
            HoverWhatWeDo();
            HoverWWDBIAnalyticsSubMenu();
            ClickWWDBIAnalyticsSAPHANA();
        }

        public void TestWWDBIAnalyticsMSBI()
        {
            HoverWhatWeDo();
            HoverWWDBIAnalyticsSubMenu();
            ClickWWDBIAnalyticsMSBI();
        }

        public void TestWWDBIAnalyticsReporting()
        {
            HoverWhatWeDo();
            HoverWWDBIAnalyticsSubMenu();
            ClickWWDBIAnalyticsReporting();
        }

        public void TestWWDOverview()
        {
            HoverWhatWeDo();
            WWDOverview.Click();
        }

        public void TestWWDAppDevSubMenu()
        {
            HoverWhatWeDo();
            ClickWWDAppDevSubMenu();
        }

        public void TestWWDAppManSubMenu()
        {
            HoverWhatWeDo();
            ClickWWDAppManSubMenu();
        }

        public void TestWWDQASubMenu()
        {
            HoverWhatWeDo();
            ClickWWDQASubMenu();
        }

        public void TestWWDBIAnalyticsSubMenu()
        {
            HoverWhatWeDo();
            ClickWWDBIAnalyticsSubMenu();
        }

        public void ClickSOOverview()
        {
            SOOverview.Click();
        }

        public void ClickSOBenefits()
        {
            SOBenefits.Click();
        }

        public void ClickSOWhattoExpect()
        {
            SOWhattoExpect.Click();
        }

        public void ClickSOFAQ()
        {
            SOFAQ.Click();
        }

        public void TestSOOverview()
        {
            HoverSmarterOutsourcingMenu();
            ClickSOOverview();
        }

        public void TestSOBenefits()
        {
            HoverSmarterOutsourcingMenu();
            ClickSOBenefits();
        }

        public void TestSOWhattoExpect()
        {
            HoverSmarterOutsourcingMenu();
            ClickSOWhattoExpect();
        }
        public void TestSOFAQ()
        {
            HoverSmarterOutsourcingMenu();
            ClickSOFAQ();
        }

        public void ClickAROverview()
        {
            AROverview.Click();
        }

        public void ClickARDevCentersSubMenu()
        {
            ARDevCentersSubMenu.Click();
        }

        public void ClickARCommunity()
        {
            ARCommunity.Click();
        }

        public void ClickAROurPartners()
        {
            AROurPartners.Click();
        }

        public void ClickAROurLeadership()
        {
            AROurLeadership.Click();
        }

        public void ClickARBoardOfDirectors()
        { 
            ARBoardOfDirectors.Click();
        }

        public void ClickARPressReleases()
        {
            ARPressReleases.Click();
        }

        public void ClickARNews()
        {
            ARNews.Click();
        }

        public void ClickARAwards()
        {
            ARAwards.Click();
        }

        public void ClickARDCOurLocations()
        { 
            ARDCOurLocations.Click();
        }

        public void ClickARDCAlabama()
        {
            ARDCAlabama.Click();
        }

        public void ClickARDCArkansas()
        {
            ARDCArkansas.Click();
        }

        public void ClickARDCGeorgia()
        {
            ARDCGeorgia.Click();
        }

        public void ClickARDCNewMexico()
        {
            ARDCNewMexico.Click();
        }

        public void ClickARDCWheresNext()
        {
            ARDCWheresNext.Click();
        }

        public void TestAROverview()
        {
            HoverAboutRSIMenu();
            ClickAROverview();
        }

        public void TestARDevCenters()
        {
            HoverAboutRSIMenu();
            ClickARDevCentersSubMenu();
        }

        public void TestARCommunity()
        {
            HoverAboutRSIMenu();
            ClickARCommunity();
        }

        public void TestAROurPartners()
        { 
            HoverAboutRSIMenu();
            ClickAROurPartners();
        }

        public void TestAROurLeadership()
        {
            HoverAboutRSIMenu();
            ClickAROurLeadership();
        }

        public void TestARBoardOfDirectors()
        {
            HoverAboutRSIMenu();
            ClickARBoardOfDirectors();
        }

        public void TestARPressReleases()
        {
            HoverAboutRSIMenu();
            ClickARPressReleases();
        }

        public void TestARNews()
        {
            HoverAboutRSIMenu();
            ClickARNews();
        }

        public void TestARAwards()
        {
            HoverAboutRSIMenu();
            ClickARAwards();
        }

        public void TestARDCOurLocations()
        {
            HoverAboutRSIMenu();
            HoverARDevCentersSubMenu();
            ClickARDCOurLocations();
        }

        public void TestARDCAlabama()
        {
            HoverAboutRSIMenu();
            HoverARDevCentersSubMenu();
            ClickARDCAlabama();
        }

        public void TestARDCArkansas()
        {
            HoverAboutRSIMenu();
            HoverARDevCentersSubMenu();
            ClickARDCArkansas();
        }

        public void TestARDCGeorgia()
        {
            HoverAboutRSIMenu();
            HoverARDevCentersSubMenu();
            ClickARDCGeorgia();
        }

        public void TestARDCNewMexico()
        {
            HoverAboutRSIMenu();
            HoverARDevCentersSubMenu();
            ClickARDCNewMexico();          
        }

        public void TestARDCWheresNext()
        {
            HoverAboutRSIMenu();
            HoverARDevCentersSubMenu();
            ClickARDCWheresNext();
        }

        public void ClickCMOverview()
        {
            CMOverview.Click();
        }

        public void ClickCMJobSearch()
        {
            CMJobSearch.Click();
        }

        public void ClickCMApplication()
        {
            CMApplication.Click();
        }

        public void ClickCMYourBenefits()
        {
            CMYourBenefits.Click();
        }

        public void ClickCMTraining()
        {
            CMTraining.Click();
        }

        public void ClickCMUniPartner()
        {
            CMUniPartner.Click();
        }

        public void ClickCMRSICulture()
        {
            CMRSICulture.Click();
        }

        public void ClickCMCareerEvents()
        {
            CMcareerEvents.Click();
        }

        public void TestCareersMenuOverview()
        {
            HoverCareersMenu();
            ClickCMOverview();
        }

        public void TestCareersMenuJobSearch()
        {
            HoverCareersMenu();
            ClickCMJobSearch();
        }

        public void TestCareersMenuApplication()
        {
            HoverCareersMenu();
            ClickCMApplication();
        }

        public void TestCareersMenuYourBenefits()
        {
            HoverCareersMenu();
            ClickCMYourBenefits();
        }

        public void TestCareersMenuTraining()
        {
            HoverCareersMenu();
            ClickCMTraining();
        }

        public void TestCareersMenuUniPartner()
        {
            HoverCareersMenu();
            ClickCMUniPartner();
        }

        public void TestCareersMenuRSICulture()
        {
            HoverCareersMenu();
            ClickCMRSICulture();
        }

        public void TestCareersMenuCareerEvents()
        {
            HoverCareersMenu();
            ClickCMCareerEvents();
        }
    }
}
