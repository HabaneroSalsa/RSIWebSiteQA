using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSIWebSiteQA.TextLogging;

namespace RSIWebSiteQA
{
    public class LogReportAssert
    {
        // data sent here: Assert expected / actual criteria
        //                 Values for log data
        //                 Values for report data
        // if assert criteria is true
        // then
        // append relevant log file success data
        // append relevant report success data 
        // else 
        // append relevant log file fail data
        // append relevant report fail data 
        // perform the assert
        // return data back?
        public static void Commit(string ExpectedAssert, string ActualAssert, string LogText, string ReportText)
        {
            if (ExpectedAssert == ActualAssert)
            {
                QALog.QATextLog("PASS: " + LogText + ActualAssert);
                // Reporting engine: case pass
                NUnit.Framework.Assert.AreEqual(ExpectedAssert, ActualAssert);
            }
            else
            {
                QALog.QATextLog("FAIL: " + LogText + "\"" + ActualAssert + "\".  Expected: " + "\"" + ExpectedAssert + "\"");
                // Reporting engine: case fail
                NUnit.Framework.Assert.AreEqual(ExpectedAssert, ActualAssert);
            }
        }

    }
}
