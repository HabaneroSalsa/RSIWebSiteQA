using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RelevantCodes.ExtentReports;
using RSIWebSiteQA.TextLogging;

namespace RSIWebSiteQA.Reports
{
    class QAReport
    {
        //private ExtentReports extent;

        //public Reporting(ExtentReports extent)
        //{
        //    this.extent = extent;
        //}

        //public void InitReport(string SuiteName)
        //{
        //    // Report engine setup
        //    string HTMLLogFile = QALog.ReportFileLocation;
        //    var extent = new ExtentReports(HTMLLogFile, false, DisplayOrder.NewestFirst);
        //    extent.AddSystemInfo("Selenium Version", "2.53.0")
        //          .AddSystemInfo("NUnit Version", "3.2.0")
        //          .AddSystemInfo("Dapper Version", "1.4.2")
        //          .AddSystemInfo("Environment", "Local")
        //          .AddSystemInfo("Browser", "Chrome");
        //    var testSuite = extent.StartTest(SuiteName, "<b>" + string.Format("[{0:yyyy-MM-dd HH:mm:ss.ffff}] ", DateTime.Now) +
        //        "Suite Objective:</b><br/>Validate all menu links.<br/>Validate all page loads.<br/>Validate all page controls and content.");
        //    testSuite.AssignCategory("Functional", "Regression", "Training")
        //             .AssignAuthor("Rick Johnson")
        //             .Log(LogStatus.Info, "Log file location:<br/>" + HTMLLogFile);
        //    //return testSuite;
        //}
    }
}

     //public OverviewPage(IWebDriver driver)
     //   {
     //       this.driver = driver;
     //       PageFactory.InitElements(driver, this);
     //   }
