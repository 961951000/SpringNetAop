using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpringNet.UI;

namespace SpringNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var ui = new UserOperateUi();
            ui.UserLogin("");
            Console.WriteLine("END...");
            Console.ReadLine();
        }
    }
}
