namespace WmiLight.UnitTests
{
    [TestClass]
    public class Win32_OperatingSystem
    {
        [TestMethod]
        public void Win32_OperatingSystem_GetRelated_With_Win32_ComputerSystem_Returns_1_Win32_ComputerSystem()
        {
            uint operatingSystemCount = 0, computerSystemCount = 0;

            using (WmiConnection connection = new WmiConnection())
            {
                foreach (WmiObject Win32_OperatingSystem in connection.CreateQuery("SELECT * FROM Win32_OperatingSystem"))
                {
                    operatingSystemCount++;

                    string csName = Win32_OperatingSystem.GetPropertyValue<string>("CSName");

                    foreach (WmiObject Win32_ComputerSystem in connection.CreateQueryForRelated(Win32_OperatingSystem, "Win32_ComputerSystem"))
                    {
                        computerSystemCount++;

                        string name = Win32_ComputerSystem.GetPropertyValue<string>("Name");

                        Assert.AreEqual(csName, name);
                    }
                }
            }

            Assert.AreEqual(1u, operatingSystemCount, "No operating system found.");

            Assert.AreEqual(1u, computerSystemCount, "No related computer system found.");
        }

        [TestMethod]
        public void Win32_OperatingSystem_GetRelated_Without_Related_Class_Returns_Multiple_Instance()
        {
            uint operatingSystemCount = 0, relatedCount = 0;

            using (WmiConnection connection = new WmiConnection())
            {
                foreach (WmiObject Win32_OperatingSystem in connection.CreateQuery("SELECT * FROM Win32_OperatingSystem"))
                {
                    operatingSystemCount++;

                    foreach (WmiObject Win32_ComputerSystem in connection.CreateQueryForRelated(Win32_OperatingSystem))
                    {
                        relatedCount++;
                    }
                }
            }

            Assert.AreEqual(1u, operatingSystemCount, "No operating system found.");

            Assert.AreNotEqual(0u, relatedCount, "No relates object found.");
            Assert.AreNotEqual(1u, relatedCount, "There must be more than 1 related object.");
        }
    }
}