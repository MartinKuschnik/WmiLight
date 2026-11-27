using System;
using System.Diagnostics;
using System.Threading;

namespace WmiLight.UnitTests
{
    [TestClass]
    public class WmiEventSubscriptionTests
    {
        [TestMethod]
        public void WmiEventSubscription_Receives_Event_And_Can_Be_Disposed()
        {
            using (ManualResetEventSlim received = new ManualResetEventSlim())
            using (WmiConnection connection = new WmiConnection())
            {
                // __InstanceCreationEvent polls every second (WITHIN 1), so the started process must live longer than that.
                const string query = "SELECT * FROM __InstanceCreationEvent WITHIN 1 WHERE TargetInstance ISA 'Win32_Process' AND TargetInstance.Name = 'PING.EXE'";

                // Covers CreateEventSinkStub, ExecNotificationQueryAsync and (on Dispose) CancelAsyncCall.
                using (WmiEventSubscription subscription = connection.CreateEventSubscription(query, x => received.Set()))
                {
                    using (Process? process = Process.Start(new ProcessStartInfo("ping.exe", "-n 4 127.0.0.1") { CreateNoWindow = true, UseShellExecute = false }))
                    {
                        if (process == null)
                            throw new InvalidOperationException("Failed to start ping.exe process.");

                        // Collect while waiting, so that anything the native event sink relies on but nobody keeps alive would be lost.
                        for (int i = 0; i < 150 && !received.IsSet; i++)
                        {
                            GC.Collect();
                            GC.WaitForPendingFinalizers();

                            received.Wait(100);
                        }

                        process.WaitForExit();
                    }
                }

                Assert.IsTrue(received.IsSet, "No event received.");
            }
        }
    }
}
