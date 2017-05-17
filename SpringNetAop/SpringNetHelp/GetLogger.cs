using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]
namespace SpringNetAop.SpringNetHelp
{
    public class GetLogger
    {
        public static ILog Logger=> LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        /*public static ILog CreateLogger()
        {
            if (Logger != null) return Logger;
            Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
            log4net.Config.XmlConfigurator.Configure(new System.IO.FileInfo("Log4Net.config"));
            return Logger;
        }*/
    }
}
