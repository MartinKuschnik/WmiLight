using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading;
using WmiLight.Wbem;

namespace WmiLight.TestApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Win32_Process:");
            Console.WriteLine("------------------------");

            var opt = new WmiConnectionOptions();
            opt.EnablePackageEncryption = true;

            //using (WmiConnection conncetion = new WmiConnection(@"\\SERVER\root\cimv2", new NetworkCredential("Administrator", "***", "MyDomain"), opt))
            using (WmiConnection conncetion = new WmiConnection())
            {
                foreach (WmiObject process in conncetion.CreateQuery("SELECT * FROM Win32_Process"))
                {
                    Console.WriteLine(process["Name"]);
                }
            }

            Console.WriteLine("");

            Console.Write("Press Any Key To Exit...");
            Console.ReadKey();
        }
    }
}
