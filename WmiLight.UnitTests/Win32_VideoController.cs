using System.Management;

namespace WmiLight.UnitTests
{
	[TestClass]
	public class Win32_VideoController
	{
        [TestMethod]
        public void Win32_VideoController_AdapterCompatibility_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_VideoController"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "AdapterCompatibility");
            }
        }

        [TestMethod]
        public void Win32_VideoController_AdapterCompatibility_Is_String()
        {
            const string PropertyName = "AdapterCompatibility";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
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
        public void Win32_VideoController_AdapterDACType_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_VideoController"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "AdapterDACType");
            }
        }

        [TestMethod]
        public void Win32_VideoController_AdapterDACType_Is_String()
        {
            const string PropertyName = "AdapterDACType";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
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
        public void Win32_VideoController_AdapterRAM_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_VideoController"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "AdapterRAM");
            }
        }

        [TestMethod]
        public void Win32_VideoController_AdapterRAM_Is_UInt32()
        {
            const string PropertyName = "AdapterRAM";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
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
        public void Win32_VideoController_Availability_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_VideoController"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
            {
                WmiAssert.AreEqual<System.UInt16>(msObject, wmiObject, "Availability");
            }
        }

        [TestMethod]
        public void Win32_VideoController_Availability_Is_UInt16()
        {
            const string PropertyName = "Availability";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
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
        public void Win32_VideoController_Caption_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_VideoController"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "Caption");
            }
        }

        [TestMethod]
        public void Win32_VideoController_Caption_Is_String()
        {
            const string PropertyName = "Caption";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
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
        public void Win32_VideoController_ConfigManagerErrorCode_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_VideoController"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "ConfigManagerErrorCode");
            }
        }

        [TestMethod]
        public void Win32_VideoController_ConfigManagerErrorCode_Is_UInt32()
        {
            const string PropertyName = "ConfigManagerErrorCode";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
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
        public void Win32_VideoController_ConfigManagerUserConfig_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_VideoController"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
            {
                WmiAssert.AreEqual<System.Boolean>(msObject, wmiObject, "ConfigManagerUserConfig");
            }
        }

        [TestMethod]
        public void Win32_VideoController_ConfigManagerUserConfig_Is_Boolean()
        {
            const string PropertyName = "ConfigManagerUserConfig";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<System.Boolean>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.Boolean>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.Boolean genericValue = wmiObject.GetPropertyValue<System.Boolean>(PropertyName);
            }
        }

        [TestMethod]
        public void Win32_VideoController_CreationClassName_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_VideoController"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "CreationClassName");
            }
        }

        [TestMethod]
        public void Win32_VideoController_CreationClassName_Is_String()
        {
            const string PropertyName = "CreationClassName";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
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
        public void Win32_VideoController_Description_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_VideoController"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "Description");
            }
        }

        [TestMethod]
        public void Win32_VideoController_Description_Is_String()
        {
            const string PropertyName = "Description";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
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
        public void Win32_VideoController_DeviceID_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_VideoController"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "DeviceID");
            }
        }

        [TestMethod]
        public void Win32_VideoController_DeviceID_Is_String()
        {
            const string PropertyName = "DeviceID";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
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
        public void Win32_VideoController_DriverDate_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_VideoController"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "DriverDate");
            }
        }

        [TestMethod]
        public void Win32_VideoController_DriverDate_Is_String()
        {
            const string PropertyName = "DriverDate";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
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
        public void Win32_VideoController_DriverVersion_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_VideoController"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "DriverVersion");
            }
        }

        [TestMethod]
        public void Win32_VideoController_DriverVersion_Is_String()
        {
            const string PropertyName = "DriverVersion";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
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
        public void Win32_VideoController_InfFilename_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_VideoController"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "InfFilename");
            }
        }

        [TestMethod]
        public void Win32_VideoController_InfFilename_Is_String()
        {
            const string PropertyName = "InfFilename";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
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
        public void Win32_VideoController_InfSection_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_VideoController"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "InfSection");
            }
        }

        [TestMethod]
        public void Win32_VideoController_InfSection_Is_String()
        {
            const string PropertyName = "InfSection";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
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
        public void Win32_VideoController_InstalledDisplayDrivers_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_VideoController"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "InstalledDisplayDrivers");
            }
        }

        [TestMethod]
        public void Win32_VideoController_InstalledDisplayDrivers_Is_String()
        {
            const string PropertyName = "InstalledDisplayDrivers";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
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
        public void Win32_VideoController_Monochrome_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_VideoController"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
            {
                WmiAssert.AreEqual<System.Boolean>(msObject, wmiObject, "Monochrome");
            }
        }

        [TestMethod]
        public void Win32_VideoController_Monochrome_Is_Boolean()
        {
            const string PropertyName = "Monochrome";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<System.Boolean>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.Boolean>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.Boolean genericValue = wmiObject.GetPropertyValue<System.Boolean>(PropertyName);
            }
        }

        [TestMethod]
        public void Win32_VideoController_Name_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_VideoController"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "Name");
            }
        }

        [TestMethod]
        public void Win32_VideoController_Name_Is_String()
        {
            const string PropertyName = "Name";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
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
        public void Win32_VideoController_PNPDeviceID_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_VideoController"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "PNPDeviceID");
            }
        }

        [TestMethod]
        public void Win32_VideoController_PNPDeviceID_Is_String()
        {
            const string PropertyName = "PNPDeviceID";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
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
        public void Win32_VideoController_Status_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_VideoController"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "Status");
            }
        }

        [TestMethod]
        public void Win32_VideoController_Status_Is_String()
        {
            const string PropertyName = "Status";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
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
        public void Win32_VideoController_SystemCreationClassName_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_VideoController"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "SystemCreationClassName");
            }
        }

        [TestMethod]
        public void Win32_VideoController_SystemCreationClassName_Is_String()
        {
            const string PropertyName = "SystemCreationClassName";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
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
        public void Win32_VideoController_SystemName_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_VideoController"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "SystemName");
            }
        }

        [TestMethod]
        public void Win32_VideoController_SystemName_Is_String()
        {
            const string PropertyName = "SystemName";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
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
        public void Win32_VideoController_VideoArchitecture_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_VideoController"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
            {
                WmiAssert.AreEqual<System.UInt16>(msObject, wmiObject, "VideoArchitecture");
            }
        }

        [TestMethod]
        public void Win32_VideoController_VideoArchitecture_Is_UInt16()
        {
            const string PropertyName = "VideoArchitecture";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
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
        public void Win32_VideoController_VideoMemoryType_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_VideoController"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
            {
                WmiAssert.AreEqual<System.UInt16>(msObject, wmiObject, "VideoMemoryType");
            }
        }

        [TestMethod]
        public void Win32_VideoController_VideoMemoryType_Is_UInt16()
        {
            const string PropertyName = "VideoMemoryType";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
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
        public void Win32_VideoController_VideoProcessor_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_VideoController"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "VideoProcessor");
            }
        }

        [TestMethod]
        public void Win32_VideoController_VideoProcessor_Is_String()
        {
            const string PropertyName = "VideoProcessor";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_VideoController"))
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
	}
}