using SpringNet.DAL;
using SpringNetAop.Attributes;
using SpringNetAop.SpringNetHelp;

namespace SpringNet.BLL
{
    public class UserOperateBll : BaseBll
    {
        [LoggingAttributes]
        public override string UserLogin(string username)
        {
            //throw new Exception("我是BLL层异常内容啊");
            var userOperatedal = (UserOperateDal)GetAppContext.ApplicationContext.GetObject("UserOperateDal");
            return userOperatedal.UserLogin(username);
        }
    }
}
