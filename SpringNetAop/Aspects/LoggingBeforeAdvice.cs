using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Spring.Aop;
using SpringNetAop.SpringNetHelp;

namespace SpringNetAop.Aspects
{
    public class LoggingBeforeAdvice : IMethodBeforeAdvice
    {
        public void Before(MethodInfo method, object[] args, object target)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("前置通知  方法名: {0}", method.Name);
            stringBuilder.AppendFormat("目标类名称      : {0}", target);
            stringBuilder.Append("参数如下  : ");
            if (args != null)
            {
                foreach (object arg in args)
                {
                    stringBuilder.Append("\t: " + arg);
                }
            }
            GetLogger.Logger.Info(stringBuilder.ToString());
        }
    }
}
