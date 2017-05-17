using Spring.Context;
using Spring.Context.Support;

namespace SpringNetAop.SpringNetHelp
{
    public class GetAppContext
    {
        public static IApplicationContext ApplicationContext => new XmlApplicationContext("~/Config/Objects.xml");
    }
}
