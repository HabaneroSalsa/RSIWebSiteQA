    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Interactions; //  var act = new Actions(driver);  AWESOME
    using OpenQA.Selenium.Support.UI;
    using RelevantCodes.ExtentReports;
    using RSIWebSiteQA.PageObjects;
    using RSIWebSiteQA.PageObjects._0_WhatWeDo;
    using RSIWebSiteQA.TextLogging;
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
// Test Scope
// Connect to site
// Validate Header ✓
// Validate Footer ✓
// Validate Main Menu Strip  ✓
// Validate Each Top Menu ✓
// Validate Each Dropdown Menu ✓
// Validate Each Sub-Menu ✓
// Validate What We Do pages
//      Overview
//      Application Development
//          Java
//          .NET
//           Mobile
//           Web
//           PHP
//      Application Management
//          CAS
//          SAP
//          Oracle
//          LIMS
//          Database
//          Salesforce
//          Sharepoint
//          TracKWise
//      Quality Assurance
//          QA Automation
//          QA Strategy
//          Software Testing
//          Performance Testing
//          Mobile Testing
//          Validation
//      Business Intelligence & Analytics
//          MicroStrategy
//          Informatica
//          SAP HANA
//          Microsoft BI
//          Reporting
// Validate Smarter Outsourcing pages
//      Overview
//      Benefits
//      What To Expect
//      FAQ        
// Validate Results page
// Validate About RSI pages
//      Overview
//      Development Centers
//          Our Locations
//          Alabama
//          Arkansas
//          Georgia
//          New Mexico
//          Where's Next?
//      Community
//      Our Partners
//      Our Leadership Team
//      Board of Directors
//      Press Releases
//      News
//      Awards
// Validate Blog page
// Validate Careers pages
//      Overview
//      Job Search
//      Application
//      Your Benefits
//      Training
//      University partnerships
//      RSI Culture
//      Career Events
// Validate App page
// Validate Contact page
// Validate Apply Now page

namespace RSIWebSiteQA
{
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
    [TestFixture]  
    public class TestCases
    {
            
        private IWebDriver driver;

        public TestCases() { }

        [OneTimeSetUp]
        public void TestInit()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            driver = new ChromeDriver(options);

        }

        [Test]
        public void PageHeaderTest()
        {
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var pageHeader = new PageHeader(driver);
            // LinkedIn link
            pageHeader.ClickLinkedInHeader();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            // Validate Linkedin Page Success
            Assert.AreEqual("https://www.linkedin.com/company/rural-sourcing-inc-", driver.Url);
            QALog.QATextLog("ClickLinkedInHeader loaded " + driver.Url);
            driver.Close(); // Close new tab
            driver.SwitchTo().Window(driver.WindowHandles.First());
            // Twitter link
            pageHeader.ClickTwitterHeader();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            // Validate Twitter page success 
            Assert.AreEqual("https://twitter.com/RuralSourcing", driver.Url);
            QALog.QATextLog("ClickTwitterHeader loaded " + driver.Url);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            // Facebook link
            pageHeader.ClickFacebookHeader();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            // Validate Facebook page success 
            Assert.AreEqual("https://www.facebook.com/RuralSourcing", driver.Url);
            QALog.QATextLog("ClickFacebookHeader loaded " + driver.Url);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            // Youtube link
            pageHeader.ClickYouTubeHeader();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            // Validate YouTube page success 
            Assert.AreEqual("https://www.youtube.com/channel/UC2Na3fMBAKpuBN50d641oag", driver.Url);
            QALog.QATextLog("ClickYouTubeHeader loaded " + driver.Url);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            // RSS link
            pageHeader.ClickRSSHeader();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            // Validate RSS page success 
            Assert.AreEqual("http://www.ruralsourcing.com/rsi-rss-feed", driver.Url);
            QALog.QATextLog("ClickRSSHeader loaded " + driver.Url);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            // RSI image link
            pageHeader.ClickRSIHeaderLogo();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            // Validate RSI page success 
            Assert.AreEqual("http://www.ruralsourcing.com/", driver.Url);
            QALog.QATextLog("ClickRSIHeaderLogo loaded " + driver.Url);
            //driver.Close();  Do not close primary session
            QALog.QATextLog("PageHeaderTest complete");
        }

        [Test]
        public void PageFooterTest()
        {
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var pageFooter = new PageFooter(driver);
            bool footerLogoDisplayed = pageFooter.RSIFooterLogodisplayed();
            Assert.AreEqual(true, footerLogoDisplayed);
            QALog.QATextLog(this.GetType().ToString(),"footerLogoDisplayed is " + footerLogoDisplayed);
            string footerImageSize = pageFooter.GetFooterLogoSize();
            Assert.AreEqual("182 x 72", footerImageSize);
            QALog.QATextLog(this.GetType().ToString(), "footerImageSize is " + footerImageSize);
            string footerText = pageFooter.GetFooterText();
            Assert.AreEqual("Copyright 2016 Rural Sourcing Inc., All rights reserved.", footerText);
            QALog.QATextLog(this.GetType().ToString(), "footerText is " + footerText);
            string hQText = pageFooter.GetHQText();
            Assert.AreEqual("Headquarters|Rural Sourcing Inc.|817 West Peachtree St.|Suite 550|Atlanta, GA 30308|(877) 887-4774", hQText);
            QALog.QATextLog(this.GetType().ToString(), "hQTest is " + hQText);
            //driver.Close();  Do not close primary session
            QALog.QATextLog("PageFooterTest complete");
        }

        [Test]
        public void MainMenuStripTest()
        {
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.ClickWhatWeDoMenu();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/", driver.Url);
            QALog.QATextLog("ClickWhatWeDoMenu loaded " + driver.Url);
            mainMenu.ClickSmarterOutsourcingMenu();
            Assert.AreEqual("http://www.ruralsourcing.com/smarter-outsourcing/", driver.Url);
            QALog.QATextLog("ClickSmarterOutsourcingMenu loaded " + driver.Url);
            mainMenu.ClickResultsMenu();
            Assert.AreEqual("http://www.ruralsourcing.com/results/", driver.Url);
            QALog.QATextLog("ClickResultsMenu loaded " + driver.Url);
            mainMenu.ClickAboutRSIMenu();
            Assert.AreEqual("http://www.ruralsourcing.com/about-rsi/", driver.Url);
            QALog.QATextLog("ClickAboutRSIMenu loaded " + driver.Url);
            mainMenu.ClickBlogMenu();
            Assert.AreEqual("http://blog.ruralsourcing.com/", driver.Url);
            QALog.QATextLog("ClickBlogMenu loaded " + driver.Url);
            mainMenu.ClickCareersMenu();
            Assert.AreEqual("http://www.ruralsourcing.com/careers/", driver.Url);
            QALog.QATextLog("ClickCareersMenu loaded " + driver.Url);
            mainMenu.ClickAppMenu();
            Assert.AreEqual("http://www.ruralsourcing.com/app/", driver.Url);
            QALog.QATextLog("ClickAppMenu loaded " + driver.Url);
            mainMenu.ClickContactMenu();
            Assert.AreEqual("http://www.ruralsourcing.com/contact/", driver.Url);
            QALog.QATextLog("ClickContactMenu loaded " + driver.Url);
            mainMenu.ClickApplyNowMenu();
            Assert.AreEqual("http://www.ruralsourcing.com/careers/job-search/", driver.Url);
            QALog.QATextLog("ClickApplyNowMenu loaded " + driver.Url);
            //driver.Close();  Do not close primary session
            QALog.QATextLog("MainMenuStripTest complete");
        }

        [Test]
        public void WhatWeDoAppDevSubMenuTest()
        {
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.TestWWDAppDevJava();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/application-development/#java", driver.Url);
            QALog.QATextLog("ClickWWDAppDevJava loaded " + driver.Url); 
            driver.Navigate().Back();
            mainMenu.TestWWDAppDevDotNET();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/application-development/#net", driver.Url);
            QALog.QATextLog("ClickWWDAppDevDotNET loaded " + driver.Url); 
            driver.Navigate().Back();
            mainMenu.TestWWDAppDevMobile();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/application-development/#mobile", driver.Url);
            QALog.QATextLog("ClickWWDAppDevMobile loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestWWDAppDevWeb();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/application-development/#web", driver.Url);
            QALog.QATextLog("ClickWWDAppDevWeb loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestWWDAppDevPHP();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/application-development/#php", driver.Url);
            QALog.QATextLog("ClickWWDAppDevPHP loaded " + driver.Url);
            //driver.Close();  Do not close primary session
            QALog.QATextLog("WhatWeDoAppDevSubMenuTest complete");
        }

        [Test]
        public void WhatWeDoAppManSubMenuTest()
        {
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.TestWWDAppManCAS();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/application-management/#cas", driver.Url);
            QALog.QATextLog("ClickWWDAppManCAS loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestWWDAppManSAP();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/application-management/#sap", driver.Url);
            QALog.QATextLog("ClickWWDAppManSAP loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestWWDAppManOracle();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/application-management/#oracle", driver.Url);
            QALog.QATextLog("ClickWWDAppManOracle loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestWWDAppManLIMS();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/application-management/#lims", driver.Url);
            QALog.QATextLog("ClickWWDAppManLIMS loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestWWDAppManDatabase();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/application-management/#database", driver.Url);
            QALog.QATextLog("ClickWWDAppManDatabase loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestWWDAppManSalesforce();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/application-management/#salesforce", driver.Url);
            QALog.QATextLog("ClickWWDAppManSalesforce loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestWWDAppManSharepoint();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/application-management/#sharepoint", driver.Url);
            QALog.QATextLog("ClickWWDAppManSharepoint loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestWWDAppManTrackWise();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/application-management/#trackwise", driver.Url);
            QALog.QATextLog("ClickWWDAppManSharepoint loaded " + driver.Url);
            //driver.Close();  Do not close primary session
            QALog.QATextLog("WhatWeDoAppManSubMenuTest complete");
        }

        [Test]
        public void WhatWeDoQASubMenuTest()
        {
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.TestWWDQAAutomation();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/quality-assurance/#qa-automation", driver.Url);
            QALog.QATextLog("ClickWWDQAAutomation loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestWWDQAStrategy();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/quality-assurance/#qa-strategy", driver.Url);
            QALog.QATextLog("ClickWWDQAStrategy loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestWWDQASWTesting();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/quality-assurance/#software-testing", driver.Url);
            QALog.QATextLog("ClickWWDQASWTesting loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestWWDQASWPerfTest();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/quality-assurance/#performance-testing", driver.Url);
            QALog.QATextLog("ClickWWDQASWPerfTest loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestWWDQAMobileTest();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/quality-assurance/#mobile-testing", driver.Url);
            QALog.QATextLog("ClickWWDQAMobileTest loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestWWDQAValidation();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/quality-assurance/#validation", driver.Url);
            QALog.QATextLog("ClickWWDQAValidation loaded " + driver.Url);
            //driver.Close();  Do not close primary session
            QALog.QATextLog("WhatWeDoQASubMenuTest complete");
        }

        [Test]
        public void WhatWeDoBIAnalyticsSubMenuTest()
        {
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.TestWWDBIAnalyticsMicroStrategy();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/business-intelligenceanalytics/#micro-strategy", driver.Url);
            QALog.QATextLog("ClickWWDBIAnalyticsMicroStrategy loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestWWDBIAnalyticsInformatica();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/business-intelligenceanalytics/#informatica", driver.Url);
            QALog.QATextLog("ClickWWDBIAnalyticsInformatica loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestWWDBIAnalyticsSAPHANA();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/business-intelligenceanalytics/#sap-hana", driver.Url);
            QALog.QATextLog("ClickWWDBIAnalyticsSAPHANA loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestWWDBIAnalyticsMSBI();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/business-intelligenceanalytics/#microsoft-bi", driver.Url);
            QALog.QATextLog("ClickWWDBIAnalyticsMSBI loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestWWDBIAnalyticsReporting();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/business-intelligenceanalytics/#reporting", driver.Url);
            QALog.QATextLog("ClickWWDBIAnalyticsReporting loaded " + driver.Url);
            //driver.Close();  Do not close primary session
            QALog.QATextLog("WhatWeDoBIAnalyticsSubMenuTest complete");
        }

        [Test]
        public void WhatWeDoMenuTest()
        {
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.TestWWDOverview();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/", driver.Url);
            QALog.QATextLog("ClickWWDOverview loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestWWDAppDevSubMenu();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/application-development/", driver.Url);
            QALog.QATextLog("ClickWWDAppDevSubMenu loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestWWDAppManSubMenu();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/application-management/", driver.Url);
            QALog.QATextLog("ClickWWDAppManSubMenu loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestWWDQASubMenu();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/quality-assurance/", driver.Url);
            QALog.QATextLog("ClickWWDQASubMenu loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestWWDBIAnalyticsSubMenu();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/business-intelligenceanalytics/", driver.Url);
            QALog.QATextLog("ClickWWDBIAnalyticsSubMenu loaded " + driver.Url);
            driver.Navigate().Back();
            //driver.Close();  Do not close primary session
            QALog.QATextLog("WhatWeDoMenuTest complete");
        }

        [Test]
        public void SmarterOutsourcingMenuTest()
        {
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.TestSOOverview();
            Assert.AreEqual("http://www.ruralsourcing.com/smarter-outsourcing/", driver.Url);
            QALog.QATextLog("ClickSOOverview loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestSOBenefits();
            Assert.AreEqual("http://www.ruralsourcing.com/smarter-outsourcing/value-comparison/", driver.Url);
            QALog.QATextLog("ClickSOBenefits loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestSOWhattoExpect();
            Assert.AreEqual("http://www.ruralsourcing.com/smarter-outsourcing/what-to-expect/", driver.Url);
            QALog.QATextLog("ClickSOWhattoExpect loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestSOFAQ();
            Assert.AreEqual("http://www.ruralsourcing.com/smarter-outsourcing/frequently-asked-questions/", driver.Url);
            QALog.QATextLog("ClickSOFAQ loaded " + driver.Url);
            //driver.Close();  Do not close primary session
            QALog.QATextLog("SmarterOutsourcingMenuTest complete");
        }

        [Test]
        public void AboutRSIMenuTest()
        {
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.TestAROverview();
            Assert.AreEqual("http://www.ruralsourcing.com/about-rsi/", driver.Url);
            QALog.QATextLog("ClickAROverview loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestARDevCenters();
            Assert.AreEqual("http://www.ruralsourcing.com/about-rsi/development-centers/", driver.Url);
            QALog.QATextLog("ClickARDevCentersSubMenu loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestARCommunity();
            Assert.AreEqual("http://www.ruralsourcing.com/about-rsi/community/", driver.Url);
            QALog.QATextLog("ClickARCommunity loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestAROurPartners();
            Assert.AreEqual("http://www.ruralsourcing.com/about-rsi/partners/", driver.Url);
            QALog.QATextLog("ClickAROurPartners loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestAROurLeadership();
            Assert.AreEqual("http://www.ruralsourcing.com/about-rsi/leadership/", driver.Url);
            QALog.QATextLog("ClickAROurLeadership loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestARBoardOfDirectors();
            Assert.AreEqual("http://www.ruralsourcing.com/about-rsi/board-of-directors/", driver.Url);
            QALog.QATextLog("ClickARBoardOfDirectors loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestARPressReleases();
            Assert.AreEqual("http://www.ruralsourcing.com/press-releases/", driver.Url);
            QALog.QATextLog("ClickARPressReleases loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestARNews();
            Assert.AreEqual("http://www.ruralsourcing.com/news/", driver.Url);
            QALog.QATextLog("ClickARNews loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestARAwards();
            Assert.AreEqual("http://www.ruralsourcing.com/about-rsi/awards/", driver.Url);
            QALog.QATextLog("ClickARAwards loaded " + driver.Url);
            //driver.Close();  Do not close primary session
            QALog.QATextLog("AboutRSIMenuTest complete");          
        }

        [Test]
        public void AboutRSIDevCentersSubMenuTest()
        {
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.TestARDCOurLocations();
            Assert.AreEqual("http://www.ruralsourcing.com/about-rsi/development-centers/", driver.Url);
            QALog.QATextLog("ClickARDCOurLocations loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestARDCAlabama();
            Assert.AreEqual("http://www.ruralsourcing.com/about-rsi/development-centers/alabama/", driver.Url);
            QALog.QATextLog("ClickARDCAlabama loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestARDCArkansas();
            Assert.AreEqual("http://www.ruralsourcing.com/about-rsi/development-centers/arkansas/", driver.Url);
            QALog.QATextLog("ClickARDCArkansas loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestARDCGeorgia();
            Assert.AreEqual("http://www.ruralsourcing.com/about-rsi/development-centers/georgia/", driver.Url);
            QALog.QATextLog("ClickARDCGeorgia loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestARDCNewMexico();
            Assert.AreEqual("http://www.ruralsourcing.com/about-rsi/development-centers/new-mexico/", driver.Url);
            QALog.QATextLog("ClickARDCNewMexico loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestARDCWheresNext();
            Assert.AreEqual("http://www.ruralsourcing.com/about-rsi/development-centers/wheres-next/", driver.Url);
            QALog.QATextLog("ClickARDCWheresNext loaded " + driver.Url);
            //driver.Close();  Do not close primary session
            QALog.QATextLog("AboutRSIDevCentersSubMenuTest complete");   
        }

        [Test]
        public void CareersMenuTest()
        {
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.TestCareersMenuOverview();
            Assert.AreEqual("http://www.ruralsourcing.com/careers/", driver.Url);
            QALog.QATextLog("ClickCMOverview loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestCareersMenuJobSearch();
            Assert.AreEqual("http://www.ruralsourcing.com/careers/job-search/", driver.Url);
            QALog.QATextLog("ClickCMJobSearch loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestCareersMenuApplication();
            Assert.AreEqual("http://www.ruralsourcing.com/careers/job-search/application/", driver.Url);
            QALog.QATextLog("ClickCMApplication loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestCareersMenuYourBenefits();
            Assert.AreEqual("http://www.ruralsourcing.com/careers/#benefits", driver.Url);
            QALog.QATextLog("ClickCMYourBenefits loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestCareersMenuTraining();
            Assert.AreEqual("http://www.ruralsourcing.com/careers/#training", driver.Url);
            QALog.QATextLog("ClickCMTraining loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestCareersMenuUniPartner();
            Assert.AreEqual("http://www.ruralsourcing.com/careers/#partnerships", driver.Url);
            QALog.QATextLog("ClickCMUniPartner loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestCareersMenuRSICulture();
            Assert.AreEqual("http://www.ruralsourcing.com/careers/#culture", driver.Url);
            QALog.QATextLog("ClickCMRSICulture loaded " + driver.Url);
            driver.Navigate().Back();
            mainMenu.TestCareersMenuCareerEvents();
            Assert.AreEqual("http://www.ruralsourcing.com/career-events/", driver.Url);
            QALog.QATextLog("ClickCMCareerEvents loaded " + driver.Url);
            driver.Navigate().Back();
            //driver.Close();  Do not close primary session
            QALog.QATextLog("CareersMenuTest complete"); 
        }

        [Test]
        public void WhatWeDoOverviewPageTest()
        {
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            var overviewPage = new OverviewPage(driver);
        }
    }
}
