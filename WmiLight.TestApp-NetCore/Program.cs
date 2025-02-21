using System;
using System.Net;

namespace WmiLight.TestApp_NetCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (WmiConnection connection = new WmiConnection(/*@"\\MACHINENAME\root\cimv2", cred, opt*/))
            {
                string notificationQuery = "SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 2";

                using (WmiEventSubscription sub = connection.CreateEventSubscription(notificationQuery, x => Console.WriteLine("DeviceChangeEvent '{0}' received.", x.Class)))
                {
                    Console.WriteLine("Observing USB plug and unplug events. Press any key to stop observing...");
                    Console.ReadKey();
                }

                Console.Write("Press Any Key To Exit...");
                Console.ReadKey();
            }
        }
    }
}