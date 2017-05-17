using Spring.Aop.Framework;
using SpringNet.DAL;
using SpringNet.DAL.Interface;
using SpringNetAop.Aspects;
using SpringNetAop.Attributes;
using SpringNetAop.SpringNetHelp;

namespace SpringNet.BLL
{
    public class UserOperateBll : BaseBll
    {
        [LoggingAttributes]
        public override string UserLogin(string username)
        {
            /*ProxyFactory factory = new ProxyFactory(new UserOperateDal());
            factory.AddAdvice(new LoggingAroundAdvice());
            factory.AddAdvice(new LoggingBeforeAdvice());
            factory.AddAdvice(new LoggingAfterAdvice());
            factory.AddAdvice(new LoggingThrowsAdvice());
            IUserOperateDal service = (IUserOperateDal)factory.GetProxy();
            object result = service.UserLogin(username);*/
            //throw new Exception("我是BLL层异常内容啊");
            var userOperatedal = (UserOperateDal)GetAppContext.ApplicationContext.GetObject("UserOperateDal");
            return userOperatedal.UserLogin(username);
        }
    }
}
