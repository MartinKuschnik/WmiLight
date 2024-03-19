using System.Management;

namespace WmiLight.UnitTests
{
	[TestClass]
	public class Win32_WinSAT
	{
        [TestMethod]
        public void Win32_WinSAT_CPUScore_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_WinSAT"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_WinSAT"))
            {
                WmiAssert.AreEqual<System.Single>(msObject, wmiObject, "CPUScore");
            }
        }

        [TestMethod]
        public void Win32_WinSAT_CPUScore_Is_Single()
        {
            const string PropertyName = "CPUScore";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_WinSAT"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<System.Single>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.Single>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.Single genericValue = wmiObject.GetPropertyValue<System.Single>(PropertyName);
            }
        }

        [TestMethod]
        public void Win32_WinSAT_D3DScore_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_WinSAT"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_WinSAT"))
            {
                WmiAssert.AreEqual<System.Single>(msObject, wmiObject, "D3DScore");
            }
        }

        [TestMethod]
        public void Win32_WinSAT_D3DScore_Is_Single()
        {
            const string PropertyName = "D3DScore";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_WinSAT"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<System.Single>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.Single>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.Single genericValue = wmiObject.GetPropertyValue<System.Single>(PropertyName);
            }
        }

        [TestMethod]
        public void Win32_WinSAT_DiskScore_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_WinSAT"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_WinSAT"))
            {
                WmiAssert.AreEqual<System.Single>(msObject, wmiObject, "DiskScore");
            }
        }

        [TestMethod]
        public void Win32_WinSAT_DiskScore_Is_Single()
        {
            const string PropertyName = "DiskScore";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_WinSAT"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<System.Single>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.Single>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.Single genericValue = wmiObject.GetPropertyValue<System.Single>(PropertyName);
            }
        }

        [TestMethod]
        public void Win32_WinSAT_GraphicsScore_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_WinSAT"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_WinSAT"))
            {
                WmiAssert.AreEqual<System.Single>(msObject, wmiObject, "GraphicsScore");
            }
        }

        [TestMethod]
        public void Win32_WinSAT_GraphicsScore_Is_Single()
        {
            const string PropertyName = "GraphicsScore";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_WinSAT"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<System.Single>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.Single>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.Single genericValue = wmiObject.GetPropertyValue<System.Single>(PropertyName);
            }
        }

        [TestMethod]
        public void Win32_WinSAT_MemoryScore_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_WinSAT"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_WinSAT"))
            {
                WmiAssert.AreEqual<System.Single>(msObject, wmiObject, "MemoryScore");
            }
        }

        [TestMethod]
        public void Win32_WinSAT_MemoryScore_Is_Single()
        {
            const string PropertyName = "MemoryScore";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_WinSAT"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<System.Single>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.Single>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.Single genericValue = wmiObject.GetPropertyValue<System.Single>(PropertyName);
            }
        }

        [TestMethod]
        public void Win32_WinSAT_TimeTaken_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_WinSAT"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_WinSAT"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "TimeTaken");
            }
        }

        [TestMethod]
        public void Win32_WinSAT_TimeTaken_Is_String()
        {
            const string PropertyName = "TimeTaken";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_WinSAT"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<System.String>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.String>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.String genericValue = wmiObject.GetPropertyValue<System.String>(PropertyName);
            }
        }

        [TestMethod]
        public void Win32_WinSAT_WinSATAssessmentState_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_WinSAT"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_WinSAT"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "WinSATAssessmentState");
            }
        }

        [TestMethod]
        public void Win32_WinSAT_WinSATAssessmentState_Is_UInt32()
        {
            const string PropertyName = "WinSATAssessmentState";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_WinSAT"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<System.UInt32>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.UInt32>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.UInt32 genericValue = wmiObject.GetPropertyValue<System.UInt32>(PropertyName);
            }
        }

        [TestMethod]
        public void Win32_WinSAT_WinSPRLevel_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_WinSAT"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_WinSAT"))
            {
                WmiAssert.AreEqual<System.Single>(msObject, wmiObject, "WinSPRLevel");
            }
        }

        [TestMethod]
        public void Win32_WinSAT_WinSPRLevel_Is_Single()
        {
            const string PropertyName = "WinSPRLevel";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_WinSAT"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<System.Single>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.Single>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.Single genericValue = wmiObject.GetPropertyValue<System.Single>(PropertyName);
            }
        }
	}
}