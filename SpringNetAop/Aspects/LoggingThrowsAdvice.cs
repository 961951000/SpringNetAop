using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Spring.Aop;
using Common.Logging;
using SpringNetAop.SpringNetHelp;

namespace SpringNetAop.Aspects
{
    public class LoggingThrowsAdvice : IThrowsAdvice
    {


        public void AfterThrowing(Exception ex)
        {
            Console.WriteLine(ex);
            Console.WriteLine(GetLogger.Logger.IsErrorEnabled);
            GetLogger.Logger.Error($"异常的内容为: {ex}");
        }
    }
}
