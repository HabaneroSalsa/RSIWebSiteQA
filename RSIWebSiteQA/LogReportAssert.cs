using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSIWebSiteQA.TextLogging;
using RelevantCodes.ExtentReports;

namespace RSIWebSiteQA
{
    public class LogReportAssert
    {
        public static void Commit(ExtentTest testCase, string ExpectedAssert, string ActualAssert, string LogText, string ReportText)
        {
            if (ExpectedAssert == ActualAssert)
            {
                QALog.QATextLog("PASS: " + LogText + ActualAssert);
                // Reporting engine: case pass
                testCase.Log(LogStatus.Pass, LogText + ActualAssert);
                NUnit.Framework.Assert.AreEqual(ExpectedAssert, ActualAssert);
            }
            else
            {
                QALog.QATextLog("FAIL: " + LogText + "\"" + ActualAssert + "\".  Expected: " + "\"" + ExpectedAssert + "\"");
                // Reporting engine: case fail
                testCase.Log(LogStatus.Fail, LogText + ActualAssert);
                NUnit.Framework.Assert.AreEqual(ExpectedAssert, ActualAssert);
            }
        }

    }
}
