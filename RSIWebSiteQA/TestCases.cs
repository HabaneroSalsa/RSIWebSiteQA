    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Interactions;
    using OpenQA.Selenium.Support.UI;
    using RelevantCodes.ExtentReports;
    using RSIWebSiteQA.PageObjects;
    using RSIWebSiteQA.PageObjects._0_WhatWeDo;
    using RSIWebSiteQA.TextLogging;
    //using RSIWebSiteQA.Reporting;
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

        public TestCases() { }

        [OneTimeSetUp]
        public void TestSetUp()
        {
            QALog.QATextLog("Test Suite started");
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            driver = new ChromeDriver(options);
                       
            string HTMLLogFile = QALog.ReportFileLocation;
            var extent = new ExtentReports(HTMLLogFile, false, DisplayOrder.NewestFirst);
            extent.AddSystemInfo("Selenium Version", "2.53.0")
                  .AddSystemInfo("NUnit Version", "3.2.0")
                  .AddSystemInfo("Dapper Version", "1.4.2")
                  .AddSystemInfo("Environment", "Local")
                  .AddSystemInfo("Browser", "Chrome");
            var testSuite = extent.StartTest("RSIWebSiteQA <b>" + string.Format("[{0:yyyy-MM-dd HH:mm:ss.ffff}] ", DateTime.Now) +
                "<br/>Suite Objective:</b><br/>Validate all menu links.<br/>Validate all page loads.<br/>Validate all page controls and content.");
            testSuite.AssignCategory("Functional", "Regression", "Training")
                     .AssignAuthor("Rick Johnson")
                     .Log(LogStatus.Info, "Log file location:<br/>" + HTMLLogFile);

            testSuite.Log(LogStatus.Pass, "TEST LOG");
            extent.EndTest(testSuite); 
            extent.Flush();
            extent.Close();
            
        }

        [OneTimeTearDown]
        public void TestTearDown()
        {
            driver.Close();
            QALog.QATextLog("Test Suite finished");
            // Finish off report with extent.Flush
           
            //extent.EndTest(testSuite); 
            //extent.Flush();
            //extent.Close();
        }

        [Test, Order(100)]
        public void PageHeaderTest()
        {
            //var casePageHeaderTest = extent.StartTest("Page Header Test");
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var pageHeader = new PageHeader(driver);         
            pageHeader.ClickLinkedInHeader();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            LogReportAssert.Commit("https://www.linkedin.com/company/rural-sourcing-inc-", driver.Url, "ClickLinkedInHeader loaded ", "ReportText");
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            pageHeader.ClickTwitterHeader();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            LogReportAssert.Commit("https://twitter.com/RuralSourcing", driver.Url, "ClickTwitterHeader loaded ", "ReportText");
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            pageHeader.ClickFacebookHeader();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            LogReportAssert.Commit("https://www.facebook.com/RuralSourcing", driver.Url, "ClickFacebookHeader loaded ", "ReportText");
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            pageHeader.ClickYouTubeHeader();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            LogReportAssert.Commit("https://www.youtube.com/channel/UC2Na3fMBAKpuBN50d641oag", driver.Url, "ClickYouTubeHeader loaded ", "ReportText");
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            pageHeader.ClickRSSHeader();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            LogReportAssert.Commit("http://www.ruralsourcing.com/rsi-rss-feed", driver.Url, "ClickRSSHeader loaded ", "ReportText");
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            pageHeader.ClickRSIHeaderLogo();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            LogReportAssert.Commit("http://www.ruralsourcing.com/", driver.Url, "ClickRSIHeaderLogo loaded ", "ReportText");
            QALog.QATextLog("PageHeaderTest complete");
        }

        [Test, Order(100)]
        public void PageFooterTest()
        {
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var pageFooter = new PageFooter(driver);
            bool footerLogoDisplayed = pageFooter.RSIFooterLogodisplayed();
            LogReportAssert.Commit("True", footerLogoDisplayed.ToString(), "footerLogoDisplayed is ", "ReportText");
            string footerImageSize = pageFooter.GetFooterLogoSize();
            LogReportAssert.Commit("182 x 72", footerImageSize, "footerImageSize is ", "ReportText");
            string footerText = pageFooter.GetFooterText();
            LogReportAssert.Commit("Copyright 2016 Rural Sourcing Inc., All rights reserved.", footerText, "footerText is ", "ReportText");
            string hQText = pageFooter.GetHQText();
            LogReportAssert.Commit("Headquarters|Rural Sourcing Inc.|817 West Peachtree St.|Suite 550|Atlanta, GA 30308|(877) 887-4774", hQText, "hQTest is ", "ReportText");
            QALog.QATextLog("PageFooterTest complete");
        }

        [Test, Order(101)]
        public void MainMenuStripTest()
        {
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.ClickWhatWeDoMenu();
            LogReportAssert.Commit("http://www.ruralsourcing.com/what-we-do/", driver.Url, "ClickWhatWeDoMenu loaded ", "ReportText");
            mainMenu.ClickSmarterOutsourcingMenu();
            LogReportAssert.Commit("http://www.ruralsourcing.com/smarter-outsourcing/", driver.Url, "ClickSmarterOutsourcingMenu loaded ", "ReportText");
            mainMenu.ClickResultsMenu();
            LogReportAssert.Commit("http://www.ruralsourcing.com/results/", driver.Url, "ClickResultsMenu loaded ", "ReportText");
            mainMenu.ClickAboutRSIMenu();
            LogReportAssert.Commit("http://www.ruralsourcing.com/about-rsi/", driver.Url, "ClickAboutRSIMenu loaded ", "ReportText");
            mainMenu.ClickBlogMenu();
            LogReportAssert.Commit("http://blog.ruralsourcing.com/", driver.Url, "ClickBlogMenu loaded ", "ReportText");
            mainMenu.ClickCareersMenu();
            LogReportAssert.Commit("http://www.ruralsourcing.com/careers/", driver.Url, "ClickCareersMenu loaded ", "ReportText");
            mainMenu.ClickAppMenu();
            LogReportAssert.Commit("http://www.ruralsourcing.com/app/", driver.Url, "ClickAppMenu loaded ", "ReportText");
            mainMenu.ClickContactMenu();
            LogReportAssert.Commit("http://www.ruralsourcing.com/contact/", driver.Url, "ClickContactMenu loaded ", "ReportText");
            mainMenu.ClickApplyNowMenu();
            LogReportAssert.Commit("http://www.ruralsourcing.com/careers/job-search/", driver.Url, "ClickApplyNowMenu loaded ", "ReportText");
            QALog.QATextLog("MainMenuStripTest complete");
        }

        [Test, Order(103)]
        public void WhatWeDoAppDevSubMenuTest()
        {
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.TestWWDAppDevJava();
            LogReportAssert.Commit("http://www.ruralsourcing.com/what-we-do/application-development/#java", driver.Url, "ClickWWDAppDevJava loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDAppDevDotNET();
            LogReportAssert.Commit("http://www.ruralsourcing.com/what-we-do/application-development/#net", driver.Url, "ClickWWDAppDevDotNET loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDAppDevMobile();
            LogReportAssert.Commit("http://www.ruralsourcing.com/what-we-do/application-development/#mobile", driver.Url, "ClickWWDAppDevMobile loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDAppDevWeb();
            LogReportAssert.Commit("http://www.ruralsourcing.com/what-we-do/application-development/#web", driver.Url, "ClickWWDAppDevWeb loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDAppDevPHP();
            LogReportAssert.Commit("http://www.ruralsourcing.com/what-we-do/application-development/#php", driver.Url, "ClickBClickWWDAppDevPHPlogMenu loaded ", "ReportText");
            QALog.QATextLog("WhatWeDoAppDevSubMenuTest complete");
        }

        [Test, Order(103)]
        public void WhatWeDoAppManSubMenuTest()
        {
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.TestWWDAppManCAS();
            LogReportAssert.Commit("http://www.ruralsourcing.com/what-we-do/application-management/#cas", driver.Url, "ClickWWDAppManCAS loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDAppManSAP();
            LogReportAssert.Commit("http://www.ruralsourcing.com/what-we-do/application-management/#sap", driver.Url, "ClickWWDAppManSAP loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDAppManOracle();
            LogReportAssert.Commit("http://www.ruralsourcing.com/what-we-do/application-management/#oracle", driver.Url, "ClickWWDAppManOracle loaded ", "ReportText");
            driver.Navigate().Back();            
            mainMenu.TestWWDAppManLIMS();
            LogReportAssert.Commit("http://www.ruralsourcing.com/what-we-do/application-management/#lims", driver.Url, "ClickWWDAppManLIMS loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDAppManDatabase();
            LogReportAssert.Commit("http://www.ruralsourcing.com/what-we-do/application-management/#database", driver.Url, "ClickWWDAppManDatabase loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDAppManSalesforce();
            LogReportAssert.Commit("http://www.ruralsourcing.com/what-we-do/application-management/#salesforce", driver.Url, "ClickWWDAppManSalesforce loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDAppManSharepoint();
            LogReportAssert.Commit("http://www.ruralsourcing.com/what-we-do/application-management/#sharepoint", driver.Url, "ClickWWDAppManSharepoint loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDAppManTrackWise();
            LogReportAssert.Commit("http://www.ruralsourcing.com/what-we-do/application-management/#trackwise", driver.Url, "ClickWWDAppManSharepoint loaded ", "ReportText");
            QALog.QATextLog("WhatWeDoAppManSubMenuTest complete");
        }

        [Test, Order(103)]
        public void WhatWeDoQASubMenuTest()
        {
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.TestWWDQAAutomation();
            LogReportAssert.Commit("http://www.ruralsourcing.com/what-we-do/quality-assurance/#qa-automation", driver.Url, "ClickWWDQAAutomation loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDQAStrategy();
            LogReportAssert.Commit("http://www.ruralsourcing.com/what-we-do/quality-assurance/#qa-strategy", driver.Url, "ClickWWDQAStrategy loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDQASWTesting();
            LogReportAssert.Commit("http://www.ruralsourcing.com/what-we-do/quality-assurance/#software-testing", driver.Url, "ClickWWDQASWTesting loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDQASWPerfTest();
            LogReportAssert.Commit("http://www.ruralsourcing.com/what-we-do/quality-assurance/#performance-testing", driver.Url, "ClickWWDAppManLIMS loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDQAMobileTest();
            LogReportAssert.Commit("http://www.ruralsourcing.com/what-we-do/quality-assurance/#mobile-testing", driver.Url, "ClickWWDQAMobileTest loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDQAValidation();
            LogReportAssert.Commit("http://www.ruralsourcing.com/what-we-do/quality-assurance/#validation", driver.Url, "ClickWWDQAValidation loaded ", "ReportText");
            QALog.QATextLog("WhatWeDoQASubMenuTest complete");
        }

        [Test, Order(103)]
        public void WhatWeDoBIAnalyticsSubMenuTest()
        {
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.TestWWDBIAnalyticsMicroStrategy();
            LogReportAssert.Commit("http://www.ruralsourcing.com/what-we-do/business-intelligenceanalytics/#micro-strategy", driver.Url, "ClickWWDBIAnalyticsMicroStrategy loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDBIAnalyticsInformatica();
            LogReportAssert.Commit("http://www.ruralsourcing.com/what-we-do/business-intelligenceanalytics/#informatica", driver.Url, "ClickWWDBIAnalyticsInformatica loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDBIAnalyticsSAPHANA();
            LogReportAssert.Commit("http://www.ruralsourcing.com/what-we-do/business-intelligenceanalytics/#sap-hana", driver.Url, "ClickWWDBIAnalyticsSAPHANA loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDBIAnalyticsMSBI();
            LogReportAssert.Commit("http://www.ruralsourcing.com/what-we-do/business-intelligenceanalytics/#microsoft-bi", driver.Url, "ClickWWDBIAnalyticsMSBI loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDBIAnalyticsReporting();
            LogReportAssert.Commit("http://www.ruralsourcing.com/what-we-do/business-intelligenceanalytics/#reporting", driver.Url, "ClickWWDBIAnalyticsReporting loaded ", "ReportText");
            QALog.QATextLog("WhatWeDoBIAnalyticsSubMenuTest complete");
        }

        [Test, Order(102)]
        public void WhatWeDoMenuTest()
        {
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.TestWWDOverview();
            LogReportAssert.Commit("http://www.ruralsourcing.com/what-we-do/", driver.Url, "ClickWWDOverview loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDAppDevSubMenu();
            LogReportAssert.Commit("http://www.ruralsourcing.com/what-we-do/application-development/", driver.Url, "ClickWWDAppDevSubMenu loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDAppManSubMenu();
            LogReportAssert.Commit("http://www.ruralsourcing.com/what-we-do/application-management/", driver.Url, "ClickWWDAppManSubMenu loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDQASubMenu();
            LogReportAssert.Commit("http://www.ruralsourcing.com/what-we-do/quality-assurance/", driver.Url, "ClickWWDQASubMenu loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestWWDBIAnalyticsSubMenu();
            LogReportAssert.Commit("http://www.ruralsourcing.com/what-we-do/business-intelligenceanalytics/", driver.Url, "ClickWWDBIAnalyticsSubMenu loaded ", "ReportText");
            driver.Navigate().Back();
            QALog.QATextLog("WhatWeDoMenuTest complete");
        }

        [Test, Order(104)]
        public void SmarterOutsourcingMenuTest()
        {
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.TestSOOverview();
            LogReportAssert.Commit("http://www.ruralsourcing.com/smarter-outsourcing/", driver.Url, "ClickSOOverview loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestSOBenefits();
            LogReportAssert.Commit("http://www.ruralsourcing.com/smarter-outsourcing/value-comparison/", driver.Url, "ClickSOBenefits loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestSOWhattoExpect();
            LogReportAssert.Commit("http://www.ruralsourcing.com/smarter-outsourcing/what-to-expect/", driver.Url, "ClickSOWhattoExpect loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestSOFAQ();
            LogReportAssert.Commit("http://www.ruralsourcing.com/smarter-outsourcing/frequently-asked-questions/", driver.Url, "ClickSOFAQ loaded ", "ReportText");
            QALog.QATextLog("SmarterOutsourcingMenuTest complete");
        }

        [Test, Order(105)]
        public void AboutRSIMenuTest()
        {
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.TestAROverview();
            LogReportAssert.Commit("http://www.ruralsourcing.com/about-rsi/", driver.Url, "ClickAROverview loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestARDevCenters();
            LogReportAssert.Commit("http://www.ruralsourcing.com/about-rsi/development-centers/", driver.Url, "ClickARDevCentersSubMenu loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestARCommunity();
            LogReportAssert.Commit("http://www.ruralsourcing.com/about-rsi/community/", driver.Url, "ClickARCommunity loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestAROurPartners();
            LogReportAssert.Commit("http://www.ruralsourcing.com/about-rsi/partners/", driver.Url, "ClickAROurPartners loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestAROurLeadership();
            LogReportAssert.Commit("http://www.ruralsourcing.com/about-rsi/leadership/", driver.Url, "ClickAROurLeadership loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestARBoardOfDirectors();
            LogReportAssert.Commit("http://www.ruralsourcing.com/about-rsi/board-of-directors/", driver.Url, "ClickARBoardOfDirectors loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestARPressReleases();
            LogReportAssert.Commit("http://www.ruralsourcing.com/press-releases/", driver.Url, "ClickARPressReleases loaded ", "ReportText");
            driver.Navigate().Back(); 
            mainMenu.TestARNews();
            LogReportAssert.Commit("http://www.ruralsourcing.com/news/", driver.Url, "ClickARNews loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestARAwards();
            LogReportAssert.Commit("http://www.ruralsourcing.com/about-rsi/awards/", driver.Url, "ClickARAwards loaded ", "ReportText");
            QALog.QATextLog("AboutRSIMenuTest complete");          
        }

        [Test, Order(106)]
        public void AboutRSIDevCentersSubMenuTest()
        {
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.TestARDCOurLocations();
            LogReportAssert.Commit("http://www.ruralsourcing.com/about-rsi/development-centers/", driver.Url, "ClickARDCOurLocations loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestARDCAlabama();
            LogReportAssert.Commit("http://www.ruralsourcing.com/about-rsi/development-centers/alabama/", driver.Url, "ClickARDCAlabama loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestARDCArkansas();
            LogReportAssert.Commit("http://www.ruralsourcing.com/about-rsi/development-centers/arkansas/", driver.Url, "ClickARDCArkansas loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestARDCGeorgia();
            LogReportAssert.Commit("http://www.ruralsourcing.com/about-rsi/development-centers/georgia/", driver.Url, "ClickARDCGeorgia loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestARDCNewMexico();
            LogReportAssert.Commit("http://www.ruralsourcing.com/about-rsi/development-centers/new-mexico/", driver.Url, "ClickARDCNewMexico loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestARDCWheresNext();
            LogReportAssert.Commit("http://www.ruralsourcing.com/about-rsi/development-centers/wheres-next/", driver.Url, "ClickARDCWheresNext loaded ", "ReportText");
            QALog.QATextLog("AboutRSIDevCentersSubMenuTest complete");   
        }

        [Test, Order(107)]
        public void CareersMenuTest()
        {
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.TestCareersMenuOverview();
            LogReportAssert.Commit("http://www.ruralsourcing.com/careers/", driver.Url, "ClickCMOverview loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestCareersMenuJobSearch();
            LogReportAssert.Commit("http://www.ruralsourcing.com/careers/job-search/", driver.Url, "ClickCMJobSearch loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestCareersMenuApplication();
            LogReportAssert.Commit("http://www.ruralsourcing.com/careers/job-search/application/", driver.Url, "ClickCMApplication loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestCareersMenuYourBenefits();
            LogReportAssert.Commit("http://www.ruralsourcing.com/careers/#benefits", driver.Url, "ClickCMYourBenefits loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestCareersMenuTraining();
            LogReportAssert.Commit("http://www.ruralsourcing.com/careers/#training", driver.Url, "ClickCMTraining loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestCareersMenuUniPartner();
            LogReportAssert.Commit("http://www.ruralsourcing.com/careers/#partnerships", driver.Url, "ClickCMUniPartner loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestCareersMenuRSICulture();
            LogReportAssert.Commit("http://www.ruralsourcing.com/careers/#culture", driver.Url, "ClickCMRSICulture loaded ", "ReportText");
            driver.Navigate().Back();
            mainMenu.TestCareersMenuCareerEvents();
            LogReportAssert.Commit("http://www.ruralsourcing.com/career-events/", driver.Url, "ClickCMCareerEvents loaded ", "ReportText");
            driver.Navigate().Back();
            QALog.QATextLog("CareersMenuTest complete"); 
        }

        [Test, Order(108)]
        public void WhatWeDoOverviewPageTest()
        {
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            var overviewPage = new OverviewPage(driver);
            QALog.QATextLog("WhatWeDoOverviewPageTest complete");
        }
    }
}
