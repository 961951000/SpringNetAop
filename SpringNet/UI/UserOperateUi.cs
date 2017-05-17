using SpringNet.BLL.Interface;
using SpringNet.UI.Interface;

namespace SpringNet.UI
{
    public class UserOperateUi : IUserOperateUi
    {
        public string UserLogin(string username)
        {
            IUserOperateBll command = (IUserOperateBll)SpringNetAop.SpringNetHelp.GetAppContext.ApplicationContext.GetObject("ServiceCommand");
            return command.UserLogin(username);
        }
    }
}
