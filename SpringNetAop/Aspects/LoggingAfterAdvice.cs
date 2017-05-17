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
    public class LoggingAfterAdvice : IAfterReturningAdvice
    {
        public void AfterReturning(object returnValue, MethodInfo method, object[] args, object target)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("后置通知 方法名称为 : {0}", method.Name);
            stringBuilder.AppendFormat("    目标类为     : {0}", target);
            stringBuilder.Append("    参数如下  : ");
            if (args != null)
            {
                foreach (object arg in args)
                {
                    stringBuilder.Append("\t: " + arg);
                }
            }
            stringBuilder.Append("返回值为 : " + returnValue);
            GetLogger.Logger.Info(stringBuilder.ToString());
        }
    }
}
