using System.Management;

namespace WmiLight.UnitTests
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
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "AllocationUnitSize");
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
                    Assert.IsInstanceOfType<System.UInt32>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.UInt32>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.UInt32 genericValue = wmiObject.GetPropertyValue<System.UInt32>(PropertyName);
            }
        }

        [TestMethod]
        public void MSFT_Volume_DedupMode_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "DedupMode");
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
                    Assert.IsInstanceOfType<System.UInt32>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.UInt32>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.UInt32 genericValue = wmiObject.GetPropertyValue<System.UInt32>(PropertyName);
            }
        }

        [TestMethod]
        public void MSFT_Volume_DriveType_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "DriveType");
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
                    Assert.IsInstanceOfType<System.UInt32>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.UInt32>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.UInt32 genericValue = wmiObject.GetPropertyValue<System.UInt32>(PropertyName);
            }
        }

        [TestMethod]
        public void MSFT_Volume_FileSystem_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "FileSystem");
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
                    Assert.IsInstanceOfType<System.String>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.String>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.String genericValue = wmiObject.GetPropertyValue<System.String>(PropertyName);
            }
        }

        [TestMethod]
        public void MSFT_Volume_FileSystemLabel_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "FileSystemLabel");
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
                    Assert.IsInstanceOfType<System.String>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.String>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.String genericValue = wmiObject.GetPropertyValue<System.String>(PropertyName);
            }
        }

        [TestMethod]
        public void MSFT_Volume_FileSystemType_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                WmiAssert.AreEqual<System.UInt16>(msObject, wmiObject, "FileSystemType");
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
                    Assert.IsInstanceOfType<System.UInt16>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.UInt16>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.UInt16 genericValue = wmiObject.GetPropertyValue<System.UInt16>(PropertyName);
            }
        }

        [TestMethod]
        public void MSFT_Volume_HealthStatus_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                WmiAssert.AreEqual<System.UInt16>(msObject, wmiObject, "HealthStatus");
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
                    Assert.IsInstanceOfType<System.UInt16>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.UInt16>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.UInt16 genericValue = wmiObject.GetPropertyValue<System.UInt16>(PropertyName);
            }
        }

        [TestMethod]
        public void MSFT_Volume_ObjectId_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "ObjectId");
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
                    Assert.IsInstanceOfType<System.String>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.String>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.String genericValue = wmiObject.GetPropertyValue<System.String>(PropertyName);
            }
        }

        [TestMethod]
        public void MSFT_Volume_OperationalStatus_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                WmiAssert.AreEqual<System.UInt16[]>(msObject, wmiObject, "OperationalStatus");
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
                    Assert.IsInstanceOfType<System.UInt16[]>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.UInt16[]>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.UInt16[] genericValue = wmiObject.GetPropertyValue<System.UInt16[]>(PropertyName);
            }
        }

        [TestMethod]
        public void MSFT_Volume_Path_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "Path");
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
                    Assert.IsInstanceOfType<System.String>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.String>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.String genericValue = wmiObject.GetPropertyValue<System.String>(PropertyName);
            }
        }

        [TestMethod]
        public void MSFT_Volume_Size_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                WmiAssert.AreEqual<System.UInt64>(msObject, wmiObject, "Size");
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
                    Assert.IsInstanceOfType<System.UInt64>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.UInt64>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.UInt64 genericValue = wmiObject.GetPropertyValue<System.UInt64>(PropertyName);
            }
        }

        [TestMethod]
        public void MSFT_Volume_SizeRemaining_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                WmiAssert.AreEqual<System.UInt64>(msObject, wmiObject, "SizeRemaining");
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
                    Assert.IsInstanceOfType<System.UInt64>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.UInt64>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.UInt64 genericValue = wmiObject.GetPropertyValue<System.UInt64>(PropertyName);
            }
        }

        [TestMethod]
        public void MSFT_Volume_UniqueId_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "UniqueId");
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
                    Assert.IsInstanceOfType<System.String>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.String>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.String genericValue = wmiObject.GetPropertyValue<System.String>(PropertyName);
            }
        }

        [TestMethod]
        public void MSFT_Volume_DriveLetter_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\Microsoft\Windows\Storage", "MSFT_Volume"))
            {
                WmiAssert.AreEqual<System.Char>(msObject, wmiObject, "DriveLetter");
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
                    Assert.IsInstanceOfType<System.Char>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.Char>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.Char genericValue = wmiObject.GetPropertyValue<System.Char>(PropertyName);
            }
        }
	}
}