using System.Management;

namespace WmiLight.UnitTests.Generated
{
    [TestClass]
    public class MSFT_Volume
    {
        [TestMethod]
        public void MSFT_Volume_AllocationUnitSize_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                WmiAssert.AreEqual<uint>(msObject, wmiObject, "AllocationUnitSize");
            }
        }

        [TestMethod]
        public void MSFT_Volume_AllocationUnitSize_Is_UInt32()
        {
            const string PropertyName = "AllocationUnitSize";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<uint>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<uint>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                uint genericValue = wmiObject.GetPropertyValue<uint>(PropertyName);
            }
        }

        [TestMethod]
        public void MSFT_Volume_DedupMode_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                WmiAssert.AreEqual<uint>(msObject, wmiObject, "DedupMode");
            }
        }

        [TestMethod]
        public void MSFT_Volume_DedupMode_Is_UInt32()
        {
            const string PropertyName = "DedupMode";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<uint>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<uint>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                uint genericValue = wmiObject.GetPropertyValue<uint>(PropertyName);
            }
        }

        [TestMethod]
        public void MSFT_Volume_DriveType_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                WmiAssert.AreEqual<uint>(msObject, wmiObject, "DriveType");
            }
        }

        [TestMethod]
        public void MSFT_Volume_DriveType_Is_UInt32()
        {
            const string PropertyName = "DriveType";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<uint>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<uint>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                uint genericValue = wmiObject.GetPropertyValue<uint>(PropertyName);
            }
        }

        [TestMethod]
        public void MSFT_Volume_FileSystem_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "FileSystem");
            }
        }

        [TestMethod]
        public void MSFT_Volume_FileSystem_Is_String()
        {
            const string PropertyName = "FileSystem";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<string>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<string>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                string genericValue = wmiObject.GetPropertyValue<string>(PropertyName);
            }
        }

        [TestMethod]
        public void MSFT_Volume_FileSystemLabel_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "FileSystemLabel");
            }
        }

        [TestMethod]
        public void MSFT_Volume_FileSystemLabel_Is_String()
        {
            const string PropertyName = "FileSystemLabel";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<string>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<string>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                string genericValue = wmiObject.GetPropertyValue<string>(PropertyName);
            }
        }

        [TestMethod]
        public void MSFT_Volume_FileSystemType_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                WmiAssert.AreEqual<ushort>(msObject, wmiObject, "FileSystemType");
            }
        }

        [TestMethod]
        public void MSFT_Volume_FileSystemType_Is_UInt16()
        {
            const string PropertyName = "FileSystemType";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<ushort>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<ushort>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                ushort genericValue = wmiObject.GetPropertyValue<ushort>(PropertyName);
            }
        }

        [TestMethod]
        public void MSFT_Volume_HealthStatus_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                WmiAssert.AreEqual<ushort>(msObject, wmiObject, "HealthStatus");
            }
        }

        [TestMethod]
        public void MSFT_Volume_HealthStatus_Is_UInt16()
        {
            const string PropertyName = "HealthStatus";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<ushort>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<ushort>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                ushort genericValue = wmiObject.GetPropertyValue<ushort>(PropertyName);
            }
        }

        [TestMethod]
        public void MSFT_Volume_ObjectId_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "ObjectId");
            }
        }

        [TestMethod]
        public void MSFT_Volume_ObjectId_Is_String()
        {
            const string PropertyName = "ObjectId";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<string>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<string>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                string genericValue = wmiObject.GetPropertyValue<string>(PropertyName);
            }
        }

        [TestMethod]
        public void MSFT_Volume_OperationalStatus_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                WmiAssert.AreEqual<ushort[]>(msObject, wmiObject, "OperationalStatus");
            }
        }

        [TestMethod]
        public void MSFT_Volume_OperationalStatus_Is_UInt16Array()
        {
            const string PropertyName = "OperationalStatus";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<ushort[]>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<ushort[]>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                ushort[] genericValue = wmiObject.GetPropertyValue<ushort[]>(PropertyName);
            }
        }

        [TestMethod]
        public void MSFT_Volume_Path_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "Path");
            }
        }

        [TestMethod]
        public void MSFT_Volume_Path_Is_String()
        {
            const string PropertyName = "Path";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<string>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<string>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                string genericValue = wmiObject.GetPropertyValue<string>(PropertyName);
            }
        }

        [TestMethod]
        public void MSFT_Volume_Size_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                WmiAssert.AreEqual<ulong>(msObject, wmiObject, "Size");
            }
        }

        [TestMethod]
        public void MSFT_Volume_Size_Is_UInt64()
        {
            const string PropertyName = "Size";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<ulong>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<ulong>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                ulong genericValue = wmiObject.GetPropertyValue<ulong>(PropertyName);
            }
        }

        [TestMethod]
        public void MSFT_Volume_SizeRemaining_Is_UInt64()
        {
            const string PropertyName = "SizeRemaining";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<ulong>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<ulong>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                ulong genericValue = wmiObject.GetPropertyValue<ulong>(PropertyName);
            }
        }

        [TestMethod]
        public void MSFT_Volume_UniqueId_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "UniqueId");
            }
        }

        [TestMethod]
        public void MSFT_Volume_UniqueId_Is_String()
        {
            const string PropertyName = "UniqueId";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<string>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<string>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                string genericValue = wmiObject.GetPropertyValue<string>(PropertyName);
            }
        }

        [TestMethod]
        public void MSFT_Volume_DriveLetter_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                WmiAssert.AreEqual<char>(msObject, wmiObject, "DriveLetter");
            }
        }

        [TestMethod]
        public void MSFT_Volume_DriveLetter_Is_Char()
        {
            const string PropertyName = "DriveLetter";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<char>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<char>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                char genericValue = wmiObject.GetPropertyValue<char>(PropertyName);
            }
        }
    }
}