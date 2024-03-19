using System.Management;

namespace WmiLight.UnitTests
{
	[TestClass]
	public class Win32_Process
	{
        [TestMethod]
        public void Win32_Process_Caption_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "Caption");
            }
        }

        [TestMethod]
        public void Win32_Process_Caption_Is_String()
        {
            const string PropertyName = "Caption";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
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
        public void Win32_Process_CreationClassName_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "CreationClassName");
            }
        }

        [TestMethod]
        public void Win32_Process_CreationClassName_Is_String()
        {
            const string PropertyName = "CreationClassName";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
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
        public void Win32_Process_CreationDate_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "CreationDate");
            }
        }

        [TestMethod]
        public void Win32_Process_CreationDate_Is_String()
        {
            const string PropertyName = "CreationDate";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
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
        public void Win32_Process_CSCreationClassName_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "CSCreationClassName");
            }
        }

        [TestMethod]
        public void Win32_Process_CSCreationClassName_Is_String()
        {
            const string PropertyName = "CSCreationClassName";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
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
        public void Win32_Process_CSName_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "CSName");
            }
        }

        [TestMethod]
        public void Win32_Process_CSName_Is_String()
        {
            const string PropertyName = "CSName";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
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
        public void Win32_Process_Description_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "Description");
            }
        }

        [TestMethod]
        public void Win32_Process_Description_Is_String()
        {
            const string PropertyName = "Description";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
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
        public void Win32_Process_Handle_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "Handle");
            }
        }

        [TestMethod]
        public void Win32_Process_Handle_Is_String()
        {
            const string PropertyName = "Handle";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
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
        public void Win32_Process_HandleCount_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "HandleCount");
            }
        }

        [TestMethod]
        public void Win32_Process_HandleCount_Is_UInt32()
        {
            const string PropertyName = "HandleCount";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
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
        public void Win32_Process_KernelModeTime_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.UInt64>(msObject, wmiObject, "KernelModeTime");
            }
        }

        [TestMethod]
        public void Win32_Process_KernelModeTime_Is_UInt64()
        {
            const string PropertyName = "KernelModeTime";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<System.UInt64>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.UInt64>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.UInt64 genericValue = wmiObject.GetPropertyValue<System.UInt64>(PropertyName);
            }
        }

        [TestMethod]
        public void Win32_Process_Name_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "Name");
            }
        }

        [TestMethod]
        public void Win32_Process_Name_Is_String()
        {
            const string PropertyName = "Name";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
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
        public void Win32_Process_OSCreationClassName_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "OSCreationClassName");
            }
        }

        [TestMethod]
        public void Win32_Process_OSCreationClassName_Is_String()
        {
            const string PropertyName = "OSCreationClassName";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
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
        public void Win32_Process_OSName_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "OSName");
            }
        }

        [TestMethod]
        public void Win32_Process_OSName_Is_String()
        {
            const string PropertyName = "OSName";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
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
        public void Win32_Process_OtherOperationCount_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.UInt64>(msObject, wmiObject, "OtherOperationCount");
            }
        }

        [TestMethod]
        public void Win32_Process_OtherOperationCount_Is_UInt64()
        {
            const string PropertyName = "OtherOperationCount";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<System.UInt64>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.UInt64>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.UInt64 genericValue = wmiObject.GetPropertyValue<System.UInt64>(PropertyName);
            }
        }

        [TestMethod]
        public void Win32_Process_OtherTransferCount_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.UInt64>(msObject, wmiObject, "OtherTransferCount");
            }
        }

        [TestMethod]
        public void Win32_Process_OtherTransferCount_Is_UInt64()
        {
            const string PropertyName = "OtherTransferCount";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<System.UInt64>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.UInt64>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.UInt64 genericValue = wmiObject.GetPropertyValue<System.UInt64>(PropertyName);
            }
        }

        [TestMethod]
        public void Win32_Process_PageFaults_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "PageFaults");
            }
        }

        [TestMethod]
        public void Win32_Process_PageFaults_Is_UInt32()
        {
            const string PropertyName = "PageFaults";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
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
        public void Win32_Process_PageFileUsage_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "PageFileUsage");
            }
        }

        [TestMethod]
        public void Win32_Process_PageFileUsage_Is_UInt32()
        {
            const string PropertyName = "PageFileUsage";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
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
        public void Win32_Process_ParentProcessId_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "ParentProcessId");
            }
        }

        [TestMethod]
        public void Win32_Process_ParentProcessId_Is_UInt32()
        {
            const string PropertyName = "ParentProcessId";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
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
        public void Win32_Process_PeakPageFileUsage_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "PeakPageFileUsage");
            }
        }

        [TestMethod]
        public void Win32_Process_PeakPageFileUsage_Is_UInt32()
        {
            const string PropertyName = "PeakPageFileUsage";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
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
        public void Win32_Process_PeakVirtualSize_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.UInt64>(msObject, wmiObject, "PeakVirtualSize");
            }
        }

        [TestMethod]
        public void Win32_Process_PeakVirtualSize_Is_UInt64()
        {
            const string PropertyName = "PeakVirtualSize";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<System.UInt64>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.UInt64>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.UInt64 genericValue = wmiObject.GetPropertyValue<System.UInt64>(PropertyName);
            }
        }

        [TestMethod]
        public void Win32_Process_PeakWorkingSetSize_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "PeakWorkingSetSize");
            }
        }

        [TestMethod]
        public void Win32_Process_PeakWorkingSetSize_Is_UInt32()
        {
            const string PropertyName = "PeakWorkingSetSize";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
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
        public void Win32_Process_Priority_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "Priority");
            }
        }

        [TestMethod]
        public void Win32_Process_Priority_Is_UInt32()
        {
            const string PropertyName = "Priority";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
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
        public void Win32_Process_PrivatePageCount_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.UInt64>(msObject, wmiObject, "PrivatePageCount");
            }
        }

        [TestMethod]
        public void Win32_Process_PrivatePageCount_Is_UInt64()
        {
            const string PropertyName = "PrivatePageCount";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<System.UInt64>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.UInt64>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.UInt64 genericValue = wmiObject.GetPropertyValue<System.UInt64>(PropertyName);
            }
        }

        [TestMethod]
        public void Win32_Process_ProcessId_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "ProcessId");
            }
        }

        [TestMethod]
        public void Win32_Process_ProcessId_Is_UInt32()
        {
            const string PropertyName = "ProcessId";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
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
        public void Win32_Process_QuotaNonPagedPoolUsage_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "QuotaNonPagedPoolUsage");
            }
        }

        [TestMethod]
        public void Win32_Process_QuotaNonPagedPoolUsage_Is_UInt32()
        {
            const string PropertyName = "QuotaNonPagedPoolUsage";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
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
        public void Win32_Process_QuotaPagedPoolUsage_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "QuotaPagedPoolUsage");
            }
        }

        [TestMethod]
        public void Win32_Process_QuotaPagedPoolUsage_Is_UInt32()
        {
            const string PropertyName = "QuotaPagedPoolUsage";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
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
        public void Win32_Process_QuotaPeakNonPagedPoolUsage_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "QuotaPeakNonPagedPoolUsage");
            }
        }

        [TestMethod]
        public void Win32_Process_QuotaPeakNonPagedPoolUsage_Is_UInt32()
        {
            const string PropertyName = "QuotaPeakNonPagedPoolUsage";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
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
        public void Win32_Process_QuotaPeakPagedPoolUsage_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "QuotaPeakPagedPoolUsage");
            }
        }

        [TestMethod]
        public void Win32_Process_QuotaPeakPagedPoolUsage_Is_UInt32()
        {
            const string PropertyName = "QuotaPeakPagedPoolUsage";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
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
        public void Win32_Process_ReadOperationCount_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.UInt64>(msObject, wmiObject, "ReadOperationCount");
            }
        }

        [TestMethod]
        public void Win32_Process_ReadOperationCount_Is_UInt64()
        {
            const string PropertyName = "ReadOperationCount";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<System.UInt64>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.UInt64>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.UInt64 genericValue = wmiObject.GetPropertyValue<System.UInt64>(PropertyName);
            }
        }

        [TestMethod]
        public void Win32_Process_ReadTransferCount_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.UInt64>(msObject, wmiObject, "ReadTransferCount");
            }
        }

        [TestMethod]
        public void Win32_Process_ReadTransferCount_Is_UInt64()
        {
            const string PropertyName = "ReadTransferCount";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<System.UInt64>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.UInt64>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.UInt64 genericValue = wmiObject.GetPropertyValue<System.UInt64>(PropertyName);
            }
        }

        [TestMethod]
        public void Win32_Process_SessionId_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "SessionId");
            }
        }

        [TestMethod]
        public void Win32_Process_SessionId_Is_UInt32()
        {
            const string PropertyName = "SessionId";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
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
        public void Win32_Process_ThreadCount_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "ThreadCount");
            }
        }

        [TestMethod]
        public void Win32_Process_ThreadCount_Is_UInt32()
        {
            const string PropertyName = "ThreadCount";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
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
        public void Win32_Process_UserModeTime_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.UInt64>(msObject, wmiObject, "UserModeTime");
            }
        }

        [TestMethod]
        public void Win32_Process_UserModeTime_Is_UInt64()
        {
            const string PropertyName = "UserModeTime";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<System.UInt64>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.UInt64>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.UInt64 genericValue = wmiObject.GetPropertyValue<System.UInt64>(PropertyName);
            }
        }

        [TestMethod]
        public void Win32_Process_VirtualSize_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.UInt64>(msObject, wmiObject, "VirtualSize");
            }
        }

        [TestMethod]
        public void Win32_Process_VirtualSize_Is_UInt64()
        {
            const string PropertyName = "VirtualSize";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<System.UInt64>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.UInt64>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.UInt64 genericValue = wmiObject.GetPropertyValue<System.UInt64>(PropertyName);
            }
        }

        [TestMethod]
        public void Win32_Process_WindowsVersion_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "WindowsVersion");
            }
        }

        [TestMethod]
        public void Win32_Process_WindowsVersion_Is_String()
        {
            const string PropertyName = "WindowsVersion";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
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
        public void Win32_Process_WorkingSetSize_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.UInt64>(msObject, wmiObject, "WorkingSetSize");
            }
        }

        [TestMethod]
        public void Win32_Process_WorkingSetSize_Is_UInt64()
        {
            const string PropertyName = "WorkingSetSize";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<System.UInt64>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.UInt64>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.UInt64 genericValue = wmiObject.GetPropertyValue<System.UInt64>(PropertyName);
            }
        }

        [TestMethod]
        public void Win32_Process_WriteOperationCount_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.UInt64>(msObject, wmiObject, "WriteOperationCount");
            }
        }

        [TestMethod]
        public void Win32_Process_WriteOperationCount_Is_UInt64()
        {
            const string PropertyName = "WriteOperationCount";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<System.UInt64>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.UInt64>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.UInt64 genericValue = wmiObject.GetPropertyValue<System.UInt64>(PropertyName);
            }
        }

        [TestMethod]
        public void Win32_Process_WriteTransferCount_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Process"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                WmiAssert.AreEqual<System.UInt64>(msObject, wmiObject, "WriteTransferCount");
            }
        }

        [TestMethod]
        public void Win32_Process_WriteTransferCount_Is_UInt64()
        {
            const string PropertyName = "WriteTransferCount";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Process"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<System.UInt64>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.UInt64>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.UInt64 genericValue = wmiObject.GetPropertyValue<System.UInt64>(PropertyName);
            }
        }
	}
}