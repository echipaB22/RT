using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScreenScraping.Core.Model
{
    public class ConsoleLogger
    {
        public void Log(string message)
        {
            Console.Out.WriteLine(String.Format("[{0:d/M/yyyy HH:mm:ss}] {1}", DateTime.Now, message));
        }
    }
}