using System;
using SpringNetAop.Attributes;
using SpringNet.DAL.Interface;

namespace SpringNet.DAL
{
    public class UserOperateDal : IUserOperateDal
    {
        [LoggingAttributes]
        public string UserLogin(string username)
        {
            throw new Exception("我是DAL层的异常");
        }
    }
}
