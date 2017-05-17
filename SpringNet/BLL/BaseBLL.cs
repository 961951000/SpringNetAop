using SpringNet.BLL.Interface;

namespace SpringNet.BLL
{
    public abstract class BaseBll : IUserOperateBll
    {
        public abstract string UserLogin(string username);
    }
}