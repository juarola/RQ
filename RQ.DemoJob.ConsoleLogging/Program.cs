using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RQ.DemoJob.ConsoleLogging
{
    /// <summary>
    /// Simple demo app to exercise rq-platforms ability 
    /// to handle and log large(-ish) amounts of stdout and 
    /// stderr data.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var str = "";

            TextWriter tw;

            if (args.Any() && args[0] == "e")
            {
                str = "Computer says no..." + Environment.NewLine;
                tw = Console.Error;
            }
            else
            {
                str = "Everything is fine" + Environment.NewLine;
                tw = Console.Out;
            }

            var sb = new StringBuilder();

            for (int i = 0; i < 10000000; i++)
            {
                sb.Append(str);
            }

            tw.Write(sb.ToString());
        }
    }
}
