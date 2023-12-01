using System;
using System.Net;

namespace WmiLight.TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Win32_Process:");
            Console.WriteLine("------------------------");

            var opt = new WmiConnectionOptions() { EnablePackageEncryption = true };
            var cred = new NetworkCredential("USERNAME", "PASSWORD", "DOMAIN");

            using (WmiConnection conncetion = new WmiConnection(/*@"\\MACHINENAME\root\cimv2", cred, opt*/))
            {
                foreach (WmiObject process in conncetion.CreateQuery("SELECT * FROM Win32_Process"))
                {
                    Console.WriteLine($"#{process.GetPropertyValue<uint>("ProcessId")} - {process["Name"]}");
                }
            }

            Console.WriteLine("");

            Console.Write("Press Any Key To Exit...");
            Console.ReadKey();
        }
    }
}
