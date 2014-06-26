using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using System.IO;
using log4net.Config;

namespace CommonLib
{
    public class LogHelper
    {
        public LogHelper()
        { }
        private static ILog _log;
        public static ILog log
        {
            get
            {
                if (_log == null)
                {
                    //通过当前方法名获取当前类名
                    _log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
                }
                return _log;
            }
        }

        public static void LogDebug(string strMessage)
        {

                log.Debug(strMessage);
 
        }
        public static void LogError(string strMessage)
        {

                log.Error(strMessage);
        
        }
        public static void LogInfo(string strMessage)
        {

                log.Info(strMessage);
        
        }
    }
}
