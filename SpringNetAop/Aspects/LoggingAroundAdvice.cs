using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AopAlliance.Intercept;
using SpringNetAop.SpringNetHelp;

namespace SpringNetAop.Aspects
{
    public class LoggingAroundAdvice : IMethodInterceptor
    {
        public object Invoke(IMethodInvocation invocation)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"拦截的文法名为 '{invocation.Method.Name}'");
            object returnValue = null;
            try
            {
                returnValue = invocation.Proceed();
            }
            catch
            {
                // ignored
            }
            stringBuilder.Append($"当前返回值为 : returned '{returnValue}'");
            GetLogger.Logger.Info(stringBuilder.ToString());
            return returnValue;
        }
    }
}
