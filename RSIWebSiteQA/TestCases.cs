﻿    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Interactions;
    using OpenQA.Selenium.Support.UI;
    using RelevantCodes.ExtentReports;
    using RSIWebSiteQA.PageObjects;
    using RSIWebSiteQA.PageObjects._0_WhatWeDo;
    using RSIWebSiteQA.TextLogging;
    using RSIWebSiteQA.Reports;
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
    [TestFixture]  
    public class TestCases
    {            
        private IWebDriver driver;
        ExtentReports extent;
        
        [OneTimeSetUp]
        public void TestSetUp()
        {            
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10)); // wait up to 10 seconds for an element to become present in the DOM
            driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(10)); // up to 10 second wait for javascript elements to be visible and enabled/clickable
            QALog.QATextLog("Test Suite started");
            string HTMLLogFile = QALog.ReportFileLocation;
            extent = new ExtentReports(HTMLLogFile, true, DisplayOrder.NewestFirst);     
            extent.AddSystemInfo("Selenium Version", "2.53.0")
                  .AddSystemInfo("NUnit Version", "3.2.0")
                  .AddSystemInfo("Environment", "Local")
                  .AddSystemInfo("Browser", "Chrome");     
        }

        [OneTimeTearDown]
        public void TestTearDown()
        {
            //driver.Close();
            QALog.QATextLog("Test Suite finished");
            extent.Flush();
            extent.Close();
        }

        [Test, Order(100)]
        public void PageHeaderTest()
        {
            QALog.QATextLog("PageHeaderTest started");
            var casePageHeaderTest = extent.StartTest("Page Header Test");
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var pageHeader = new PageHeader(driver);         
            pageHeader.ClickLinkedInHeader();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            LogReportAssert.Commit(casePageHeaderTest, "https://www.linkedin.com/company/rural-sourcing-inc-", 
                driver.Url, "ClickLinkedInHeader loaded ", "ReportText");
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            pageHeader.ClickTwitterHeader();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            LogReportAssert.Commit(casePageHeaderTest, "https://twitter.com/RuralSourcing", 
                driver.Url, "ClickTwitterHeader loaded ", "ReportText");
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            pageHeader.ClickFacebookHeader();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            LogReportAssert.Commit(casePageHeaderTest, "https://www.facebook.com/RuralSourcing", 
                driver.Url, "ClickFacebookHeader loaded ", "ReportText");
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            pageHeader.ClickYouTubeHeader();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            LogReportAssert.Commit(casePageHeaderTest, "https://www.youtube.com/channel/UC2Na3fMBAKpuBN50d641oag", 
                driver.Url, "ClickYouTubeHeader loaded ", "ReportText");
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            pageHeader.ClickRSSHeader();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            LogReportAssert.Commit(casePageHeaderTest, "http://www.ruralsourcing.com/rsi-rss-feed", 
                driver.Url, "ClickRSSHeader loaded ", "ReportText");
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            pageHeader.ClickRSIHeaderLogo();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            LogReportAssert.Commit(casePageHeaderTest, "http://www.ruralsourcing.com/", 
                driver.Url, "ClickRSIHeaderLogo loaded ", "ReportText");
            QALog.QATextLog("PageHeaderTest completed");
            casePageHeaderTest.Log(LogStatus.Info, "PageHeaderTest completed");
            extent.EndTest(casePageHeaderTest);
        }

        [Test, Order(100)]
        public void PageFooterTest()
        {
            QALog.QATextLog("PageFooterTest started");
            var casePageFooterTest = extent.StartTest("Page Footer Test");
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var pageFooter = new PageFooter(driver);
            bool footerLogoDisplayed = pageFooter.RSIFooterLogodisplayed();
            LogReportAssert.Commit(casePageFooterTest, "True", footerLogoDisplayed.ToString(), 
                "footerLogoDisplayed is ", "ReportText");
            string footerImageSize = pageFooter.GetFooterLogoSize();
            LogReportAssert.Commit(casePageFooterTest, "182 x 72", footerImageSize, 
                "footerImageSize is ", "ReportText");
            string footerText = pageFooter.GetFooterText();
            LogReportAssert.Commit(casePageFooterTest, "Copyright 2016 Rural Sourcing Inc., All rights reserved.", footerText, 
                "footerText is ", "ReportText");
            string hQText = pageFooter.GetHQText();
            LogReportAssert.Commit(casePageFooterTest, "Headquarters|Rural Sourcing Inc.|817 West Peachtree St.|Suite 550|Atlanta, GA 30308|(877) 887-4774",
                hQText, "hQTest is ", "ReportText");
            casePageFooterTest.Log(LogStatus.Info, "PageFooterTest completed");
            QALog.QATextLog("PageFooterTest completed");
            extent.EndTest(casePageFooterTest);
        }

        [Test, Order(101)]
        public void MainMenuStripTest()
        {
            QALog.QATextLog("MainMenuStripTest started");
            var caseMainMenuStripTest = extent.StartTest("Main Menu Strip Test");
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.ClickWhatWeDoMenu();
            LogReportAssert.Commit(caseMainMenuStripTest, "http://www.ruralsourcing.com/what-we-do/", 
                driver.Url, "ClickWhatWeDoMenu loaded ", "ReportText");
            mainMenu.ClickSmarterOutsourcingMenu();
            LogReportAssert.Commit(caseMainMenuStripTest, "http://www.ruralsourcing.com/smarter-outsourcing/", 
                driver.Url, "ClickSmarterOutsourcingMenu loaded ", "ReportText");
            mainMenu.ClickResultsMenu();
            LogReportAssert.Commit(caseMainMenuStripTest, "http://www.ruralsourcing.com/results/", 
                driver.Url, "ClickResultsMenu loaded ", "ReportText");
            mainMenu.ClickAboutRSIMenu();
            LogReportAssert.Commit(caseMainMenuStripTest, "http://www.ruralsourcing.com/about-rsi/", 
                driver.Url, "ClickAboutRSIMenu loaded ", "ReportText");
            mainMenu.ClickBlogMenu();
            LogReportAssert.Commit(caseMainMenuStripTest, "http://blog.ruralsourcing.com/", 
                driver.Url, "ClickBlogMenu loaded ", "ReportText");
            mainMenu.ClickCareersMenu();
            LogReportAssert.Commit(caseMainMenuStripTest, "http://www.ruralsourcing.com/careers/", 
                driver.Url, "ClickCareersMenu loaded ", "ReportText");
            mainMenu.ClickAppMenu();
            LogReportAssert.Commit(caseMainMenuStripTest, "http://www.ruralsourcing.com/app/", 
                driver.Url, "ClickAppMenu loaded ", "ReportText");
            mainMenu.ClickContactMenu();
            LogReportAssert.Commit(caseMainMenuStripTest, "http://www.ruralsourcing.com/contact/", 
                driver.Url, "ClickContactMenu loaded ", "ReportText");
            mainMenu.ClickApplyNowMenu();
            LogReportAssert.Commit(caseMainMenuStripTest, "http://www.ruralsourcing.com/careers/job-search/", 
                driver.Url, "ClickApplyNowMenu loaded ", "ReportText");
            caseMainMenuStripTest.Log(LogStatus.Info, "MainMenuStripTest completed");
            QALog.QATextLog("MainMenuStripTest completed");
            extent.EndTest(caseMainMenuStripTest);
        }

        [Test, Order(103)]
        public void WhatWeDoAppDevSubMenuTest()
        {
            QALog.QATextLog("WhatWeDoAppDevSubMenuTest started");
            var caseWhatWeDoAppDevSubMenuTest = extent.StartTest("What We Do App Dev SubMenu Test");
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.TestWWDAppDevJava();
            LogReportAssert.Commit(caseWhatWeDoAppDevSubMenuTest, "http://www.ruralsourcing.com/what-we-do/application-development/#java", 
                driver.Url, "ClickWWDAppDevJava loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDAppDevDotNET();
            LogReportAssert.Commit(caseWhatWeDoAppDevSubMenuTest, "http://www.ruralsourcing.com/what-we-do/application-development/#net", 
                driver.Url, "ClickWWDAppDevDotNET loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDAppDevMobile();
            LogReportAssert.Commit(caseWhatWeDoAppDevSubMenuTest, "http://www.ruralsourcing.com/what-we-do/application-development/#mobile", 
                driver.Url, "ClickWWDAppDevMobile loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDAppDevWeb();
            LogReportAssert.Commit(caseWhatWeDoAppDevSubMenuTest, "http://www.ruralsourcing.com/what-we-do/application-development/#web", 
                driver.Url, "ClickWWDAppDevWeb loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDAppDevPHP();
            LogReportAssert.Commit(caseWhatWeDoAppDevSubMenuTest, "http://www.ruralsourcing.com/what-we-do/application-development/#php", 
                driver.Url, "ClickBClickWWDAppDevPHPlogMenu loaded ", "ReportText");
            caseWhatWeDoAppDevSubMenuTest.Log(LogStatus.Info, "WhatWeDoAppDevSubMenuTest completed");
            QALog.QATextLog("WhatWeDoAppDevSubMenuTest completed");
            extent.EndTest(caseWhatWeDoAppDevSubMenuTest);
        }

        [Test, Order(103)]
        public void WhatWeDoAppManSubMenuTest()
        {
            QALog.QATextLog("WhatWeDoAppManSubMenuTest started");
            var caseWhatWeDoAppManSubMenuTest = extent.StartTest("What We Do App Man SubMenu Test");
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.TestWWDAppManCAS();
            LogReportAssert.Commit(caseWhatWeDoAppManSubMenuTest, "http://www.ruralsourcing.com/what-we-do/application-management/#cas", 
                driver.Url, "ClickWWDAppManCAS loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDAppManSAP();
            LogReportAssert.Commit(caseWhatWeDoAppManSubMenuTest, "http://www.ruralsourcing.com/what-we-do/application-management/#sap", 
                driver.Url, "ClickWWDAppManSAP loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDAppManOracle();
            LogReportAssert.Commit(caseWhatWeDoAppManSubMenuTest, "http://www.ruralsourcing.com/what-we-do/application-management/#oracle", 
                driver.Url, "ClickWWDAppManOracle loaded ", "ReportText");
            driver.Navigate().Back();            
            mainMenu.TestWWDAppManLIMS();
            LogReportAssert.Commit(caseWhatWeDoAppManSubMenuTest, "http://www.ruralsourcing.com/what-we-do/application-management/#lims", 
                driver.Url, "ClickWWDAppManLIMS loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDAppManDatabase();
            LogReportAssert.Commit(caseWhatWeDoAppManSubMenuTest, "http://www.ruralsourcing.com/what-we-do/application-management/#database", 
                driver.Url, "ClickWWDAppManDatabase loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDAppManSalesforce();
            LogReportAssert.Commit(caseWhatWeDoAppManSubMenuTest, "http://www.ruralsourcing.com/what-we-do/application-management/#salesforce", 
                driver.Url, "ClickWWDAppManSalesforce loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDAppManSharepoint();
            LogReportAssert.Commit(caseWhatWeDoAppManSubMenuTest, "http://www.ruralsourcing.com/what-we-do/application-management/#sharepoint", 
                driver.Url, "ClickWWDAppManSharepoint loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDAppManTrackWise();
            LogReportAssert.Commit(caseWhatWeDoAppManSubMenuTest, "http://www.ruralsourcing.com/what-we-do/application-management/#trackwise", 
                driver.Url, "ClickWWDAppManSharepoint loaded ", "ReportText");
            caseWhatWeDoAppManSubMenuTest.Log(LogStatus.Info, "WhatWeDoAppManSubMenuTest completed");
            QALog.QATextLog("WhatWeDoAppManSubMenuTest completed");
            extent.EndTest(caseWhatWeDoAppManSubMenuTest);
        }

        [Test, Order(103)]
        public void WhatWeDoQASubMenuTest()
        {
            QALog.QATextLog("WhatWeDoQASubMenuTest started");
            var caseWhatWeDoQASubMenuTest = extent.StartTest("What We Do QA SubMenu Test");
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.TestWWDQAAutomation();
            LogReportAssert.Commit(caseWhatWeDoQASubMenuTest, "http://www.ruralsourcing.com/what-we-do/quality-assurance/#qa-automation", 
                driver.Url, "ClickWWDQAAutomation loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDQAStrategy();
            LogReportAssert.Commit(caseWhatWeDoQASubMenuTest, "http://www.ruralsourcing.com/what-we-do/quality-assurance/#qa-strategy", 
                driver.Url, "ClickWWDQAStrategy loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDQASWTesting();
            LogReportAssert.Commit(caseWhatWeDoQASubMenuTest, "http://www.ruralsourcing.com/what-we-do/quality-assurance/#software-testing", 
                driver.Url, "ClickWWDQASWTesting loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDQASWPerfTest();
            LogReportAssert.Commit(caseWhatWeDoQASubMenuTest, "http://www.ruralsourcing.com/what-we-do/quality-assurance/#performance-testing", 
                driver.Url, "ClickWWDAppManLIMS loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDQAMobileTest();
            LogReportAssert.Commit(caseWhatWeDoQASubMenuTest, "http://www.ruralsourcing.com/what-we-do/quality-assurance/#mobile-testing", 
                driver.Url, "ClickWWDQAMobileTest loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDQAValidation();
            LogReportAssert.Commit(caseWhatWeDoQASubMenuTest, "http://www.ruralsourcing.com/what-we-do/quality-assurance/#validation", 
                driver.Url, "ClickWWDQAValidation loaded ", "ReportText");
            caseWhatWeDoQASubMenuTest.Log(LogStatus.Info, "WhatWeDoQASubMenuTest completed");
            QALog.QATextLog("WhatWeDoQASubMenuTest completed");
            extent.EndTest(caseWhatWeDoQASubMenuTest);
        }

        [Test, Order(103)]
        public void WhatWeDoBIAnalyticsSubMenuTest()
        {
            QALog.QATextLog("WhatWeDoBIAnalyticsSubMenuTest started");
            var caseWhatWeDoBIAnalyticsSubMenuTest = extent.StartTest("What We Do BI Analytics SubMenu Test");
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.TestWWDBIAnalyticsMicroStrategy();
            LogReportAssert.Commit(caseWhatWeDoBIAnalyticsSubMenuTest, "http://www.ruralsourcing.com/what-we-do/business-intelligenceanalytics/#micro-strategy", 
                driver.Url, "ClickWWDBIAnalyticsMicroStrategy loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDBIAnalyticsInformatica();
            LogReportAssert.Commit(caseWhatWeDoBIAnalyticsSubMenuTest, "http://www.ruralsourcing.com/what-we-do/business-intelligenceanalytics/#informatica", 
                driver.Url, "ClickWWDBIAnalyticsInformatica loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDBIAnalyticsSAPHANA();
            LogReportAssert.Commit(caseWhatWeDoBIAnalyticsSubMenuTest, "http://www.ruralsourcing.com/what-we-do/business-intelligenceanalytics/#sap-hana", 
                driver.Url, "ClickWWDBIAnalyticsSAPHANA loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDBIAnalyticsMSBI();
            LogReportAssert.Commit(caseWhatWeDoBIAnalyticsSubMenuTest, "http://www.ruralsourcing.com/what-we-do/business-intelligenceanalytics/#microsoft-bi", 
                driver.Url, "ClickWWDBIAnalyticsMSBI loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDBIAnalyticsReporting();
            LogReportAssert.Commit(caseWhatWeDoBIAnalyticsSubMenuTest, "http://www.ruralsourcing.com/what-we-do/business-intelligenceanalytics/#reporting", 
                driver.Url, "ClickWWDBIAnalyticsReporting loaded ", "ReportText");
            caseWhatWeDoBIAnalyticsSubMenuTest.Log(LogStatus.Info, "WhatWeDoBIAnalyticsSubMenuTest completed");
            QALog.QATextLog("WhatWeDoBIAnalyticsSubMenuTest completed");
            extent.EndTest(caseWhatWeDoBIAnalyticsSubMenuTest);
        }

        [Test, Order(102)]
        public void WhatWeDoMenuTest()
        {
            QALog.QATextLog("WhatWeDoMenuTest started");
            var caseWhatWeDoMenuTest = extent.StartTest("What We Do Menu Test");
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.TestWWDOverview();
            LogReportAssert.Commit(caseWhatWeDoMenuTest, "http://www.ruralsourcing.com/what-we-do/", 
                driver.Url, "ClickWWDOverview loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDAppDevSubMenu();
            LogReportAssert.Commit(caseWhatWeDoMenuTest, "http://www.ruralsourcing.com/what-we-do/application-development/", 
                driver.Url, "ClickWWDAppDevSubMenu loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDAppManSubMenu();
            LogReportAssert.Commit(caseWhatWeDoMenuTest, "http://www.ruralsourcing.com/what-we-do/application-management/", 
                driver.Url, "ClickWWDAppManSubMenu loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDQASubMenu();
            LogReportAssert.Commit(caseWhatWeDoMenuTest, "http://www.ruralsourcing.com/what-we-do/quality-assurance/", 
                driver.Url, "ClickWWDQASubMenu loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDBIAnalyticsSubMenu();
            LogReportAssert.Commit(caseWhatWeDoMenuTest, "http://www.ruralsourcing.com/what-we-do/business-intelligenceanalytics/", 
                driver.Url, "ClickWWDBIAnalyticsSubMenu loaded ", "ReportText");
            driver.Navigate().Back();
            caseWhatWeDoMenuTest.Log(LogStatus.Info, "WhatWeDoMenuTest completed");
            QALog.QATextLog("WhatWeDoMenuTest completed");
            extent.EndTest(caseWhatWeDoMenuTest);
        }

        [Test, Order(104)]
        public void SmarterOutsourcingMenuTest()
        {
            QALog.QATextLog("SmarterOutsourcingMenuTest started");
            var caseSmarterOutsourcingMenuTest = extent.StartTest("Smarter Outsourcing Menu Test");
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.TestSOOverview();
            LogReportAssert.Commit(caseSmarterOutsourcingMenuTest, "http://www.ruralsourcing.com/smarter-outsourcing/", 
                driver.Url, "ClickSOOverview loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestSOBenefits();
            LogReportAssert.Commit(caseSmarterOutsourcingMenuTest, "http://www.ruralsourcing.com/smarter-outsourcing/value-comparison/", 
                driver.Url, "ClickSOBenefits loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestSOWhattoExpect();
            LogReportAssert.Commit(caseSmarterOutsourcingMenuTest, "http://www.ruralsourcing.com/smarter-outsourcing/what-to-expect/", 
                driver.Url, "ClickSOWhattoExpect loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestSOFAQ();
            LogReportAssert.Commit(caseSmarterOutsourcingMenuTest, "http://www.ruralsourcing.com/smarter-outsourcing/frequently-asked-questions/", 
                driver.Url, "ClickSOFAQ loaded ", "ReportText");
            caseSmarterOutsourcingMenuTest.Log(LogStatus.Info, "SmarterOutsourcingMenuTest completed");
            QALog.QATextLog("SmarterOutsourcingMenuTest completed");
            extent.EndTest(caseSmarterOutsourcingMenuTest);
        }

        [Test, Order(105)]
        public void AboutRSIMenuTest()
        {
            QALog.QATextLog("AboutRSIMenuTest started");
            var caseAboutRSIMenuTest = extent.StartTest("About RSI Menu Test");
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.TestAROverview();
            LogReportAssert.Commit(caseAboutRSIMenuTest, "http://www.ruralsourcing.com/about-rsi/", 
                driver.Url, "ClickAROverview loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestARDevCenters();
            LogReportAssert.Commit(caseAboutRSIMenuTest, "http://www.ruralsourcing.com/about-rsi/development-centers/", 
                driver.Url, "ClickARDevCentersSubMenu loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestARCommunity();
            LogReportAssert.Commit(caseAboutRSIMenuTest, "http://www.ruralsourcing.com/about-rsi/community/", 
                driver.Url, "ClickARCommunity loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestAROurPartners();
            LogReportAssert.Commit(caseAboutRSIMenuTest, "http://www.ruralsourcing.com/about-rsi/partners/", 
                driver.Url, "ClickAROurPartners loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestAROurLeadership();
            LogReportAssert.Commit(caseAboutRSIMenuTest, "http://www.ruralsourcing.com/about-rsi/leadership/", 
                driver.Url, "ClickAROurLeadership loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestARBoardOfDirectors();
            LogReportAssert.Commit(caseAboutRSIMenuTest, "http://www.ruralsourcing.com/about-rsi/board-of-directors/", 
                driver.Url, "ClickARBoardOfDirectors loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestARPressReleases();
            LogReportAssert.Commit(caseAboutRSIMenuTest, "http://www.ruralsourcing.com/press-releases/", 
                driver.Url, "ClickARPressReleases loaded ", "ReportText");
            driver.Navigate().Back(); 
            mainMenu.TestARNews();
            LogReportAssert.Commit(caseAboutRSIMenuTest, "http://www.ruralsourcing.com/news/", 
                driver.Url, "ClickARNews loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestARAwards();
            LogReportAssert.Commit(caseAboutRSIMenuTest, "http://www.ruralsourcing.com/about-rsi/awards/", 
                driver.Url, "ClickARAwards loaded ", "ReportText");
            caseAboutRSIMenuTest.Log(LogStatus.Info, "AboutRSIMenuTest completed");
            QALog.QATextLog("AboutRSIMenuTest completed");
            extent.EndTest(caseAboutRSIMenuTest);
        }

        [Test, Order(106)]
        public void AboutRSIDevCentersSubMenuTest()
        {
            QALog.QATextLog("AboutRSIDevCentersSubMenuTest started");
            var caseAboutRSIDevCentersSubMenuTest = extent.StartTest("About RSI Dev Centers Menu Test");
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.TestARDCOurLocations();
            LogReportAssert.Commit(caseAboutRSIDevCentersSubMenuTest, "http://www.ruralsourcing.com/about-rsi/development-centers/", 
                driver.Url, "ClickARDCOurLocations loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestARDCAlabama();
            LogReportAssert.Commit(caseAboutRSIDevCentersSubMenuTest, "http://www.ruralsourcing.com/about-rsi/development-centers/alabama/", 
                driver.Url, "ClickARDCAlabama loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestARDCArkansas();
            LogReportAssert.Commit(caseAboutRSIDevCentersSubMenuTest, "http://www.ruralsourcing.com/about-rsi/development-centers/arkansas/", 
                driver.Url, "ClickARDCArkansas loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestARDCGeorgia();
            LogReportAssert.Commit(caseAboutRSIDevCentersSubMenuTest, "http://www.ruralsourcing.com/about-rsi/development-centers/georgia/", 
                driver.Url, "ClickARDCGeorgia loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestARDCNewMexico();
            LogReportAssert.Commit(caseAboutRSIDevCentersSubMenuTest, "http://www.ruralsourcing.com/about-rsi/development-centers/new-mexico/", 
                driver.Url, "ClickARDCNewMexico loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestARDCWheresNext();
            LogReportAssert.Commit(caseAboutRSIDevCentersSubMenuTest, "http://www.ruralsourcing.com/about-rsi/development-centers/wheres-next/", 
                driver.Url, "ClickARDCWheresNext loaded ", "ReportText");
            caseAboutRSIDevCentersSubMenuTest.Log(LogStatus.Info, "AboutRSIDevCentersSubMenuTest completed");
            QALog.QATextLog("AboutRSIDevCentersSubMenuTest completed");
            extent.EndTest(caseAboutRSIDevCentersSubMenuTest);
        }

        [Test, Order(107)]
        public void CareersMenuTest()
        {
            QALog.QATextLog("CareersMenuTest started");
            var caseCareersMenuTest = extent.StartTest("Careers Menu Test");
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.TestCareersMenuOverview();
            LogReportAssert.Commit(caseCareersMenuTest, "http://www.ruralsourcing.com/careers/", 
                driver.Url, "ClickCMOverview loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestCareersMenuJobSearch();
            LogReportAssert.Commit(caseCareersMenuTest, "http://www.ruralsourcing.com/careers/job-search/", 
                driver.Url, "ClickCMJobSearch loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestCareersMenuApplication();
            LogReportAssert.Commit(caseCareersMenuTest, "http://www.ruralsourcing.com/careers/job-search/application/", 
                driver.Url, "ClickCMApplication loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestCareersMenuYourBenefits();
            LogReportAssert.Commit(caseCareersMenuTest, "http://www.ruralsourcing.com/careers/#benefits", 
                driver.Url, "ClickCMYourBenefits loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestCareersMenuTraining();
            LogReportAssert.Commit(caseCareersMenuTest, "http://www.ruralsourcing.com/careers/#training", 
                driver.Url, "ClickCMTraining loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestCareersMenuUniPartner();
            LogReportAssert.Commit(caseCareersMenuTest, "http://www.ruralsourcing.com/careers/#partnerships", 
                driver.Url, "ClickCMUniPartner loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestCareersMenuRSICulture();
            LogReportAssert.Commit(caseCareersMenuTest, "http://www.ruralsourcing.com/careers/#culture", 
                driver.Url, "ClickCMRSICulture loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestCareersMenuCareerEvents();
            LogReportAssert.Commit(caseCareersMenuTest, "http://www.ruralsourcing.com/career-events/", 
                driver.Url, "ClickCMCareerEvents loaded ", "ReportText");
            driver.Navigate().Back();
            caseCareersMenuTest.Log(LogStatus.Info, "CareersMenuTest completed");
            QALog.QATextLog("CareersMenuTest completed");
            extent.EndTest(caseCareersMenuTest);
        }

        [Test, Order(108)]
        public void WhatWeDoOverviewPageTest()
        {
            // get text from both fields in the slide and validate
            // get topic title text and validate
            // get text from the 3 paragraphs and validate
            // expand each subtopic and validate the contained text
            // Test FAQ
            // Testing search will be a separate case 

            QALog.QATextLog("WhatWeDoOverviewPageTest started");
            var caseWhatWeDoOverviewPageTest = extent.StartTest("What We Do Overview Page Test");
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            var overviewPage = new OverviewPage(driver);
            mainMenu.HoverWhatWeDo();
            mainMenu.ClickWWDOverview();
            LogReportAssert.Commit(caseWhatWeDoOverviewPageTest, "http://www.ruralsourcing.com/what-we-do/",
                driver.Url, "ClickWWDOverview loaded ", "ReportText");
            LogReportAssert.Commit(caseWhatWeDoOverviewPageTest, "Domestic sourcing is...", overviewPage.GetSlideText1(), "GetSlideText1 is: ", "");
            LogReportAssert.Commit(caseWhatWeDoOverviewPageTest, "The smarter way to grow.", overviewPage.GetSlideText2(), "GetSlideText2 is: ", "");
            LogReportAssert.Commit(caseWhatWeDoOverviewPageTest, "Agile development. Speed to market.", overviewPage.GetTopicTitle(), "GetTopicTitle is: ", "");
            LogReportAssert.Commit(caseWhatWeDoOverviewPageTest, "From software application development to ongoing support and maintenance of critical business applications, RSI offers a wide range of highly specialized IT services for companies across a variety of industries. We also provide QA Testing and Business Intelligence and Analytics services.", overviewPage.GetTopicParagraph1(), "GetTopicParagraph1 is: ", "");
            LogReportAssert.Commit(caseWhatWeDoOverviewPageTest, "RSI provides a high-level of customer service and a cost-effective alternative to offshore IT outsourcing, where they can benefit from common time zones. The cost of ownership between domestic sourcing and outsourcing overseas is quite comparable.", overviewPage.GetTopicParagraph2(), "GetTopicParagraph2 is: ", "");
            LogReportAssert.Commit(caseWhatWeDoOverviewPageTest, "Contact us today to discover how domestic insourcing can benefit your organization.", overviewPage.GetTopicParagraph3(), "GetTopicParagraph3 is: ", "");
            LogReportAssert.Commit(caseWhatWeDoOverviewPageTest, "Recommended Reading", overviewPage.GetLinkListTitle(), "GetLinkListTitle is: ", "");
            LogReportAssert.Commit(caseWhatWeDoOverviewPageTest, "Seven facts you may not have considered about domestic sourcing", overviewPage.GetFAQLinkText(), "GetFAQLinkText is: ", "");
            overviewPage.ClickAppDevExpander();
            LogReportAssert.Commit(caseWhatWeDoOverviewPageTest, "RSI relies on the Agile development methodology to guide our application development process. Agile enables us to be flexible when building new applications, supporting or enhancing existing applications, or replatforming antiquated systems onto robust, scalable and modern platforms.", overviewPage.GetAppDevText(), "GetAppDevText is: ", "");
            overviewPage.ClickAppManExpander();
            LogReportAssert.Commit(caseWhatWeDoOverviewPageTest, "Our clients select RSI to assist to help them manage the costs and complexities of enhancing and supporting enterprise applications such as SAP®, CAS® and Oracle®.", overviewPage.GetAppManText(), "GetAppManText is: ", "");
            overviewPage.ClickQAExpander();
            LogReportAssert.Commit(caseWhatWeDoOverviewPageTest, "Through our domestic sourcing model, RSI is able to provide superior testing services that go live faster without sacrificing quality. Our testing services include ERP Testing, Security & Privacy Testing, Automated Testing, Script Use Case Development, Script Use Case Execution, Usability, and Documentation. Our QA team relies heavily on Agile practices and is involved from the beginning of every project in order to ensure any bugs or errors are discovered or even avoided in the early stages.", overviewPage.GetQAText(), "GetQAText is: ", "");
            overviewPage.ClickBIExpander();
            LogReportAssert.Commit(caseWhatWeDoOverviewPageTest, "Our experienced consultants provide domestic sourcing services to meet ever-changing client Business Intelligence and Analytics needs, such as SAP Net Weaver BW, BusinessObjects, and Microsoft SQL Server Reporting Services.", overviewPage.GetBIText(), "GetBIText is: ", "");
            caseWhatWeDoOverviewPageTest.Log(LogStatus.Info, "WhatWeDoOverviewPageTest completed");
            QALog.QATextLog("WhatWeDoOverviewPageTest completed");
            extent.EndTest(caseWhatWeDoOverviewPageTest);
        }

        [Test, Order(109)]
        public void ApplicationDevelopmentPageTest()
        {
            QALog.QATextLog("ApplicationDevelopmentPageTest started");
            var caseApplicationDevelopmentPageTest = extent.StartTest("Application Development Page Test");
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            var overviewPage = new OverviewPage(driver);
            var appDevPage  = new ApplicationDevelopmentPage(driver);
            mainMenu.HoverWhatWeDo();
            mainMenu.ClickWWDAppDevSubMenu();
            LogReportAssert.Commit(caseApplicationDevelopmentPageTest, "http://www.ruralsourcing.com/what-we-do/application-development/",
                driver.Url, "ClickWWDAppDevSubMenu loaded ", "");
            LogReportAssert.Commit(caseApplicationDevelopmentPageTest, "Application Development", appDevPage.GetADTitle(), "GetADTitle is ", "");
            LogReportAssert.Commit(caseApplicationDevelopmentPageTest, "Delivering results", appDevPage.GetADMainTopicTitle(), "GetADMainTopicTitle is ", "");
            LogReportAssert.Commit(caseApplicationDevelopmentPageTest, "Companies across the United States have turned to Rural Sourcing, Inc. to guide them through the often complex realm of software and application development.", appDevPage.GetADParagraph1Text(), "GetADParagraph1Text is ", "");
            LogReportAssert.Commit(caseApplicationDevelopmentPageTest, "RSI relies on the Agile and Scrum software development methodologies. Our approach to application development means our teams are light, nimble and are always working toward the next benchmark. Agile allows us to be flexible when building new applications, supporting or enhancing existing applications, or replatforming antiquated systems onto robust, scalable and modern platforms.", appDevPage.GetADParagraph2Text(), "GetADParagraph2Text is ", "");
            LogReportAssert.Commit(caseApplicationDevelopmentPageTest, "Our developers stay up-to-date on all of the major platforms, including .NET, J2EE, PHP, iOS, Objective C, PL/SQL, Visual Basic, JavaScript, HTML5 and the latest mobile trends. Our clients benefit from the latest technologies.", appDevPage.GetADParagraph3Text(), "GetADParagraph3Text is ", "");
            LogReportAssert.Commit(caseApplicationDevelopmentPageTest, "Our process", appDevPage.GetADSubTopicTitle(), "GetADSubTopicTitle is ", "");
            LogReportAssert.Commit(caseApplicationDevelopmentPageTest, "Our flexible service model allows clients to choose the optimal approach to meet demand. These options range from fully outsourced support with SLA driven management to flexible hour blocks for specified time periods.", appDevPage.GetADParagraph4Text(), "GetADParagraph4Text is ", "");
            LogReportAssert.Commit(caseApplicationDevelopmentPageTest, "In certain cases, RSI’s clients are able to complement their in-house teams with RSI expertise. Our support provides the additional support necessary to reduce costs while maintaining high customer service levels. RSI also enables companies to focus on new ventures and projects while our team maintains the current production system.", appDevPage.GetADParagraph5Text(), "GetADParagraph5Text is ", "");
            LogReportAssert.Commit(caseApplicationDevelopmentPageTest, "Contact us today to learn more about our Application Development services and how our team can benefit your organization.", appDevPage.GetADParagraph6Text(), "GetADParagraph6Text is ", "");
            appDevPage.ClickJavaExpander();
          
            appDevPage.ClickDotNetExpander();
            appDevPage.ClickMobileExpander();
            appDevPage.ClickWebExpander();
            appDevPage.ClickPHPExpander();

            caseApplicationDevelopmentPageTest.Log(LogStatus.Info, "ApplicationDevelopmentPageTest completed");
            QALog.QATextLog("ApplicationDevelopmentPageTest completed");
            extent.EndTest(caseApplicationDevelopmentPageTest);
        
        }

    }
}
