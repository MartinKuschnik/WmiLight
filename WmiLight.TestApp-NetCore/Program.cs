using System;
using System.Net;

namespace WmiLight.TestApp_NetCore
{
    internal class Program
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

                Console.WriteLine("");

                const string notificationQuery = "SELECT * FROM __InstanceCreationEvent WITHIN 2 WHERE TargetInstance ISA 'Win32_Process'";

                using (WmiEventSubscription sub = conncetion.CreateEventSubscription(notificationQuery, x => Console.WriteLine("Process '{0}' started", x.GetPropertyValue<WmiObject>("TargetInstance").GetPropertyValue<string>("Name"))))
                {
                    Console.WriteLine("Observing starting processes. Press any key to stop observing...");
                    Console.ReadKey();
                }
            }

            Console.Write("Press Any Key To Exit...");
            Console.ReadKey();
        }
    }
}