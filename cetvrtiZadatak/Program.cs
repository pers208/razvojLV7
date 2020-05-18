using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treciZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger consoleLogger = new ConsoleLogger();
            ILogger fileLogger = new FileLogger("txtfile");
            SimpleSystemDataProvider simpleSystemDataProvider = new SystemDataProvider();
            simpleSystemDataProvider.Attach(consoleLogger);
            simpleSystemDataProvider.Attach(fileLogger);
            simpleSystemDataProvider.Notify();
        }
    }
}
