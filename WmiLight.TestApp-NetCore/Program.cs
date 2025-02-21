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

            using (WmiConnection connection = new WmiConnection(/*@"\\MACHINENAME\root\cimv2", cred, opt*/))
            {
                uint proceccIs = StartCmd(connection);

                Console.WriteLine($"Another console started (ProcessId: {proceccIs})");

                foreach (WmiObject process in connection.CreateQuery("SELECT * FROM Win32_Process"))
                {
                    Console.Write($"#{process.GetPropertyValue<uint>("ProcessId")} - {process["Name"]}");

                    if (process.GetPropertyValue<uint>("ProcessId") == proceccIs)
                    {
                        using (WmiMethod terminateMethod = process.GetMethod("Terminate"))
                        {
                            WmiMethodParameters parameters = terminateMethod.CreateInParameters();
                            parameters.SetPropertyValue("Reason", 20);

                            uint result = process.ExecuteMethod<uint>(terminateMethod, parameters, out WmiMethodParameters terminateOutParameters2);

                            if (result != 0)
                                throw new Exception($"Win32_Process::Terminate(...) failed with {result}");
                        }

                        Console.WriteLine(" -> killed !!!!!!!!!!!!!!!");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }

                Console.WriteLine("");

                const string notificationQuery = "SELECT * FROM __InstanceCreationEvent WITHIN 2 WHERE TargetInstance ISA 'Win32_Process'";

                using (WmiEventSubscription sub = connection.CreateEventSubscription(notificationQuery, x => Console.WriteLine("Process '{0}' started", x.GetPropertyValue<WmiObject>("TargetInstance").GetPropertyValue<string>("Name"))))
                {
                    Console.WriteLine("Observing starting processes. Press any key to stop observing...");
                    Console.ReadKey();
                }
            }

            Console.Write("Press Any Key To Exit...");
            Console.ReadKey();
        }
        private static uint StartCmd(WmiConnection connection)
        {
            using (WmiMethod createMethod = connection.GetMethod("Win32_Process", "Create"))
            {
                using (WmiMethodParameters createMethodParams = createMethod.CreateInParameters())
                {
                    createMethodParams.SetPropertyValue("CommandLine", "cmd.exe");

                    uint result = connection.ExecuteMethod<uint>(createMethod, createMethodParams, out WmiMethodParameters outParams);

                    if (result != 0)
                        throw new Exception($"Win32_Process::Create(...) failed with {result}");

                    return outParams.GetPropertyValue<uint>("ProcessId");
                }
            }
        }
    }
}