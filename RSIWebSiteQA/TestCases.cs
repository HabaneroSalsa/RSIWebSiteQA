using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions; //  var act = new Actions(driver);  AWESOME
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using RSIWebSiteQA.PageObjects;
using RSIWebSiteQA.TextLogging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Connect to site
// Validate Header ✓
// Validate Footer ✓
// Validate Main Menu Strip  ✓
// Validate Each Menu ✓*
// Validate Each Sub-Menu ✓*
// Validate Home/Landing page
// Validate Smarter Outsourcing page
// Validate Results page
// Validate About RSI page
// Validate Blog page
// Validate Careers page
// Validate App page
// Validate Contact page
// Validate Apply Now page

namespace RSIWebSiteQA
{
    class TestCases
    {
        [Test]
        public void PageHeaderTest()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            IWebDriver driver = new ChromeDriver(options);
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
            driver.Close();
            QALog.QATextLog("PageHeaderTest complete");
        }

        [Test]
        public void PageFooterTest()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            IWebDriver driver = new ChromeDriver(options);
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
            driver.Close();
            QALog.QATextLog("PageFooterTest complete");
        }

        [Test]
        public void MainMenuStripTest()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            IWebDriver driver = new ChromeDriver(options);
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
            driver.Close();
            QALog.QATextLog("MainMenuStripTest complete");
        }

        [Test]
        public void WhatWeDoAppDevSubMenuTest()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            IWebDriver driver = new ChromeDriver(options);
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.TestWWDAppDevJava();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/application-development/#java", driver.Url);
            QALog.QATextLog("ClickWWDAppDevJava loaded " + driver.Url);
            // Later Implement validation of text block in target 
            driver.Navigate().Back();
            mainMenu.TestWWDAppDevDotNET();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/application-development/#net", driver.Url);
            QALog.QATextLog("ClickWWDAppDevDotNET loaded " + driver.Url);
            // Later Implement validation of text block in target 
            driver.Navigate().Back();
            mainMenu.TestWWDAppDevMobile();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/application-development/#mobile", driver.Url);
            QALog.QATextLog("ClickWWDAppDevMobile loaded " + driver.Url);
            // Later Implement validation of text block in target 
            driver.Navigate().Back();
            mainMenu.TestWWDAppDevWeb();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/application-development/#web", driver.Url);
            QALog.QATextLog("ClickWWDAppDevWeb loaded " + driver.Url);
            // Later Implement validation of text block in target 
            driver.Navigate().Back();
            mainMenu.TestWWDAppDevPHP();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/application-development/#php", driver.Url);
            QALog.QATextLog("ClickWWDAppDevPHP loaded " + driver.Url);
            driver.Close();
            QALog.QATextLog("WhatWeDoAppDevSubMenuTest complete");
        }

        [Test]
        public void WhatWeDoAppManSubMenuTest()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            IWebDriver driver = new ChromeDriver(options);
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.TestWWDAppManCAS();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/application-management/#cas", driver.Url);
            QALog.QATextLog("ClickWWDAppManCAS loaded " + driver.Url);
            // Later Implement validation of text block in target
            driver.Navigate().Back();
            mainMenu.TestWWDAppManSAP();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/application-management/#sap", driver.Url);
            QALog.QATextLog("ClickWWDAppManSAP loaded " + driver.Url);
           // Later Implement validation of text block in target
            driver.Navigate().Back();
            mainMenu.TestWWDAppManOracle();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/application-management/#oracle", driver.Url);
            QALog.QATextLog("ClickWWDAppManOracle loaded " + driver.Url);
            // Later Implement validation of text block in target
            driver.Navigate().Back();
            mainMenu.TestWWDAppManLIMS();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/application-management/#lims", driver.Url);
            QALog.QATextLog("ClickWWDAppManLIMS loaded " + driver.Url);
            // Later Implement validation of text block in target
            driver.Navigate().Back();
            mainMenu.TestWWDAppManDatabase();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/application-management/#database", driver.Url);
            QALog.QATextLog("ClickWWDAppManDatabase loaded " + driver.Url);
            // Later Implement validation of text block in target
            driver.Navigate().Back();
            mainMenu.TestWWDAppManSalesforce();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/application-management/#salesforce", driver.Url);
            QALog.QATextLog("ClickWWDAppManSalesforce loaded " + driver.Url);
            // Later Implement validation of text block in target
            driver.Navigate().Back();
            mainMenu.TestWWDAppManSharepoint();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/application-management/#sharepoint", driver.Url);
            QALog.QATextLog("ClickWWDAppManSharepoint loaded " + driver.Url);
            // Later Implement validation of text block in target
            driver.Navigate().Back();
            mainMenu.TestWWDAppManTrackWise();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/application-management/#trackwise", driver.Url);
            QALog.QATextLog("ClickWWDAppManSharepoint loaded " + driver.Url);
            driver.Close();
            QALog.QATextLog("WhatWeDoAppManSubMenuTest complete");
        }
        
        [Test]
        public void WhatWeDoQASubMenuTest()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            IWebDriver driver = new ChromeDriver(options);
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.TestWWDQAAutomation();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/quality-assurance/#qa-automation", driver.Url);
            QALog.QATextLog("ClickWWDQAAutomation loaded " + driver.Url);
            // Later Implement validation of text block in target
            driver.Navigate().Back();
            mainMenu.TestWWDQAStrategy();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/quality-assurance/#qa-strategy", driver.Url);
            QALog.QATextLog("ClickWWDQAStrategy loaded " + driver.Url);
            // Later Implement validation of text block in target
            driver.Navigate().Back();
            mainMenu.TestWWDQASWTesting();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/quality-assurance/#software-testing", driver.Url);
            QALog.QATextLog("ClickWWDQASWTesting loaded " + driver.Url);
            // Later Implement validation of text block in target
            driver.Navigate().Back();
            mainMenu.TestWWDQASWPerfTest();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/quality-assurance/#performance-testing", driver.Url);
            QALog.QATextLog("ClickWWDQASWPerfTest loaded " + driver.Url);
            // Later Implement validation of text block in target
            driver.Navigate().Back();
            mainMenu.TestWWDQAMobileTest();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/quality-assurance/#mobile-testing", driver.Url);
            QALog.QATextLog("ClickWWDQAMobileTest loaded " + driver.Url);
            // Later Implement validation of text block in target
            driver.Navigate().Back();
            mainMenu.TestWWDQAValidation();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/quality-assurance/#validation", driver.Url);
            QALog.QATextLog("ClickWWDQAValidation loaded " + driver.Url);
            // Later Implement validation of text block in target
            driver.Close();
            QALog.QATextLog("WhatWeDoQASubMenuTest complete");
        }

        [Test]
        public void WhatWeDoBIAnalyticsSubMenuTest()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            IWebDriver driver = new ChromeDriver(options);
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.TestWWDBIAnalyticsMicroStrategy();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/business-intelligenceanalytics/#micro-strategy", driver.Url);
            QALog.QATextLog("ClickWWDBIAnalyticsMicroStrategy loaded " + driver.Url);
            // Later Implement validation of text block in target
            driver.Navigate().Back();
            mainMenu.TestWWDBIAnalyticsInformatica();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/business-intelligenceanalytics/#informatica", driver.Url);
            QALog.QATextLog("ClickWWDBIAnalyticsInformatica loaded " + driver.Url);
            // Later Implement validation of text block in target
            driver.Navigate().Back();
            mainMenu.TestWWDBIAnalyticsSAPHANA();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/business-intelligenceanalytics/#sap-hana", driver.Url);
            QALog.QATextLog("ClickWWDBIAnalyticsSAPHANA loaded " + driver.Url);
            // Later Implement validation of text block in target
            driver.Navigate().Back();
            mainMenu.TestWWDBIAnalyticsMSBI();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/business-intelligenceanalytics/#microsoft-bi", driver.Url);
            QALog.QATextLog("ClickWWDBIAnalyticsMSBI loaded " + driver.Url);
            // Later Implement validation of text block in target
            driver.Navigate().Back();
            mainMenu.TestWWDBIAnalyticsReporting();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/business-intelligenceanalytics/#reporting", driver.Url);
            QALog.QATextLog("ClickWWDBIAnalyticsReporting loaded " + driver.Url);
            // Later Implement validation of text block in target
            driver.Close();
            QALog.QATextLog("WhatWeDoBIAnalyticsSubMenuTest complete");
        }

        [Test]
        public void WhatWeDoMenuTest()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            IWebDriver driver = new ChromeDriver(options);
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
            mainMenu.HoverWhatWeDo();
            mainMenu.ClickWWDAppDevSubMenu();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/application-development/", driver.Url);
            QALog.QATextLog("ClickWWDAppDevSubMenu loaded " + driver.Url);
            // Later Implement validation of text block in target
            driver.Navigate().Back();
            mainMenu.HoverWhatWeDo();
            mainMenu.ClickWWDAppManSubMenu();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/application-management/", driver.Url);
            QALog.QATextLog("ClickWWDAppManSubMenu loaded " + driver.Url);
            // Later Implement validation of text block in target
            driver.Navigate().Back();
            mainMenu.HoverWhatWeDo();
            mainMenu.ClickWWDQASubMenu();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/quality-assurance/", driver.Url);
            QALog.QATextLog("ClickWWDQASubMenu loaded " + driver.Url);
            // Later Implement validation of text block in target
            driver.Navigate().Back();
            mainMenu.HoverWhatWeDo();
            mainMenu.ClickWWDBIAnalyticsSubMenu();
            Assert.AreEqual("http://www.ruralsourcing.com/what-we-do/business-intelligenceanalytics/", driver.Url);
            QALog.QATextLog("ClickWWDBIAnalyticsSubMenu loaded " + driver.Url);
            // Later Implement validation of text block in target
            driver.Navigate().Back();
            driver.Close();
            QALog.QATextLog("WhatWeDoMenuTest complete");
        }

        [Test]
        public void SmarterOutsourcingMenuTest()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            IWebDriver driver = new ChromeDriver(options);
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var mainMenu = new MainMenu(driver);
        }
    }
}
