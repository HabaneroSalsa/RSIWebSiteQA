using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSIWebSiteQA.TextLogging
{
    public class QALog
    {
        static System.Collections.Specialized.NameValueCollection appSettings = ConfigurationManager.AppSettings;
        static string LogFile = System.IO.Path.Combine(appSettings["LogDirectory"] == null ? Environment.CurrentDirectory : appSettings["LogDirectory"],
           appSettings["LogPrefix"] == null ? "NUnitTest" : appSettings["LogPrefix"] + string.Format("_{0:yyyyMMddHHmmss}.log", DateTime.Now));

        static QALog()
        {
            QALog.QATextLog("Log file location: {0}", QALog.LogFileLocation);
        }

        public static string LogFileLocation
        {
            get
            {
                return LogFile;
            }
        }

        public static void QATextLog(string str)
        {
            StackTrace st = new StackTrace();
            StackFrame sf = st.GetFrame(1);
            QATextLog(sf.GetMethod().Name, str, null);
        }

        // Logging definition start
        public static void QATextLog(string tag, string str)
        {
            StackTrace st = new StackTrace();
            StackFrame sf = st.GetFrame(1);
            QATextLog(tag + "(" + sf.GetMethod().Name + ")", str, null);
        }

        public static void QATextLog(string method, string str, params object[] para)
        {

            string str2;
            if (("" + method).Length > 0)
            {
                str2 = string.Format("[{0:yyyy-MM-dd HH:mm:ss.ffff} {1}] ", DateTime.Now, method) + str;
            }
            else
            {
                str2 = string.Format("[{0:yyyy-MM-dd HH:mm:ss.ffff}] ", DateTime.Now) + str;
            }
            Console.WriteLine(str2, para);
            if (para != null)
            {
                Debug.WriteLine(str2, para);
                try
                {
                    System.IO.File.AppendAllText(LogFile, string.Format(str2, para) + Environment.NewLine);
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                }
            }
            else
            {
                Debug.WriteLine(str2);
                try
                {
                    System.IO.File.AppendAllText(LogFile, str2 + Environment.NewLine);
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                }
            }
            return;
        }
        // Logging definition end
    }
}
