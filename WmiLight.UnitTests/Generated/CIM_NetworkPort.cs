using System.Management;

namespace WmiLight.UnitTests.Generated
{
    [TestClass]
    public class CIM_NetworkPort
    {
        [TestMethod]
        public void CIM_NetworkPort_ActiveMaximumTransmissionUnit_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<ulong>(msObject, wmiObject, "ActiveMaximumTransmissionUnit");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_ActiveMaximumTransmissionUnit_Is_UInt64()
        {
            const string PropertyName = "ActiveMaximumTransmissionUnit";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_AdminLocked_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<bool>(msObject, wmiObject, "AdminLocked");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_AdminLocked_Is_Boolean()
        {
            const string PropertyName = "AdminLocked";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<bool>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<bool>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                bool genericValue = wmiObject.GetPropertyValue<bool>(PropertyName);
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_ComponentID_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "ComponentID");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_ComponentID_Is_String()
        {
            const string PropertyName = "ComponentID";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_ConnectorPresent_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<bool>(msObject, wmiObject, "ConnectorPresent");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_ConnectorPresent_Is_Boolean()
        {
            const string PropertyName = "ConnectorPresent";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<bool>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<bool>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                bool genericValue = wmiObject.GetPropertyValue<bool>(PropertyName);
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_CreationClassName_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "CreationClassName");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_CreationClassName_Is_String()
        {
            const string PropertyName = "CreationClassName";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_DeviceID_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "DeviceID");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_DeviceID_Is_String()
        {
            const string PropertyName = "DeviceID";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_DeviceName_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "DeviceName");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_DeviceName_Is_String()
        {
            const string PropertyName = "DeviceName";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_DeviceWakeUpEnable_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<bool>(msObject, wmiObject, "DeviceWakeUpEnable");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_DeviceWakeUpEnable_Is_Boolean()
        {
            const string PropertyName = "DeviceWakeUpEnable";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<bool>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<bool>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                bool genericValue = wmiObject.GetPropertyValue<bool>(PropertyName);
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_DriverDate_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "DriverDate");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_DriverDate_Is_String()
        {
            const string PropertyName = "DriverDate";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_DriverDateData_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<ulong>(msObject, wmiObject, "DriverDateData");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_DriverDateData_Is_UInt64()
        {
            const string PropertyName = "DriverDateData";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_DriverDescription_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "DriverDescription");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_DriverDescription_Is_String()
        {
            const string PropertyName = "DriverDescription";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_DriverMajorNdisVersion_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<byte>(msObject, wmiObject, "DriverMajorNdisVersion");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_DriverMajorNdisVersion_Is_Byte()
        {
            const string PropertyName = "DriverMajorNdisVersion";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<byte>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<byte>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                byte genericValue = wmiObject.GetPropertyValue<byte>(PropertyName);
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_DriverMinorNdisVersion_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<byte>(msObject, wmiObject, "DriverMinorNdisVersion");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_DriverMinorNdisVersion_Is_Byte()
        {
            const string PropertyName = "DriverMinorNdisVersion";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<byte>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<byte>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                byte genericValue = wmiObject.GetPropertyValue<byte>(PropertyName);
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_DriverName_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "DriverName");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_DriverName_Is_String()
        {
            const string PropertyName = "DriverName";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_DriverProvider_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "DriverProvider");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_DriverProvider_Is_String()
        {
            const string PropertyName = "DriverProvider";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_DriverVersionString_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "DriverVersionString");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_DriverVersionString_Is_String()
        {
            const string PropertyName = "DriverVersionString";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_EnabledDefault_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<ushort>(msObject, wmiObject, "EnabledDefault");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_EnabledDefault_Is_UInt16()
        {
            const string PropertyName = "EnabledDefault";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_EnabledState_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<ushort>(msObject, wmiObject, "EnabledState");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_EnabledState_Is_UInt16()
        {
            const string PropertyName = "EnabledState";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_EndPointInterface_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<bool>(msObject, wmiObject, "EndPointInterface");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_EndPointInterface_Is_Boolean()
        {
            const string PropertyName = "EndPointInterface";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<bool>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<bool>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                bool genericValue = wmiObject.GetPropertyValue<bool>(PropertyName);
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_FullDuplex_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<bool>(msObject, wmiObject, "FullDuplex");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_FullDuplex_Is_Boolean()
        {
            const string PropertyName = "FullDuplex";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<bool>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<bool>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                bool genericValue = wmiObject.GetPropertyValue<bool>(PropertyName);
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_HardwareInterface_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<bool>(msObject, wmiObject, "HardwareInterface");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_HardwareInterface_Is_Boolean()
        {
            const string PropertyName = "HardwareInterface";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<bool>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<bool>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                bool genericValue = wmiObject.GetPropertyValue<bool>(PropertyName);
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_Hidden_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<bool>(msObject, wmiObject, "Hidden");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_Hidden_Is_Boolean()
        {
            const string PropertyName = "Hidden";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<bool>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<bool>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                bool genericValue = wmiObject.GetPropertyValue<bool>(PropertyName);
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_HigherLayerInterfaceIndices_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<uint[]>(msObject, wmiObject, "HigherLayerInterfaceIndices");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_HigherLayerInterfaceIndices_Is_UInt32Array()
        {
            const string PropertyName = "HigherLayerInterfaceIndices";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<uint[]>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<uint[]>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                uint[] genericValue = wmiObject.GetPropertyValue<uint[]>(PropertyName);
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_IMFilter_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<bool>(msObject, wmiObject, "IMFilter");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_IMFilter_Is_Boolean()
        {
            const string PropertyName = "IMFilter";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<bool>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<bool>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                bool genericValue = wmiObject.GetPropertyValue<bool>(PropertyName);
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_InstanceID_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "InstanceID");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_InstanceID_Is_String()
        {
            const string PropertyName = "InstanceID";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_InterfaceAdminStatus_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<uint>(msObject, wmiObject, "InterfaceAdminStatus");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_InterfaceAdminStatus_Is_UInt32()
        {
            const string PropertyName = "InterfaceAdminStatus";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_InterfaceDescription_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "InterfaceDescription");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_InterfaceDescription_Is_String()
        {
            const string PropertyName = "InterfaceDescription";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_InterfaceGuid_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "InterfaceGuid");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_InterfaceGuid_Is_String()
        {
            const string PropertyName = "InterfaceGuid";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_InterfaceIndex_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<uint>(msObject, wmiObject, "InterfaceIndex");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_InterfaceIndex_Is_UInt32()
        {
            const string PropertyName = "InterfaceIndex";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_InterfaceName_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "InterfaceName");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_InterfaceName_Is_String()
        {
            const string PropertyName = "InterfaceName";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_InterfaceOperationalStatus_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<uint>(msObject, wmiObject, "InterfaceOperationalStatus");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_InterfaceOperationalStatus_Is_UInt32()
        {
            const string PropertyName = "InterfaceOperationalStatus";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_InterfaceType_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<uint>(msObject, wmiObject, "InterfaceType");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_InterfaceType_Is_UInt32()
        {
            const string PropertyName = "InterfaceType";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_iSCSIInterface_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<bool>(msObject, wmiObject, "iSCSIInterface");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_iSCSIInterface_Is_Boolean()
        {
            const string PropertyName = "iSCSIInterface";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<bool>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<bool>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                bool genericValue = wmiObject.GetPropertyValue<bool>(PropertyName);
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_MajorDriverVersion_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<ushort>(msObject, wmiObject, "MajorDriverVersion");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_MajorDriverVersion_Is_UInt16()
        {
            const string PropertyName = "MajorDriverVersion";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_MediaConnectState_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<uint>(msObject, wmiObject, "MediaConnectState");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_MediaConnectState_Is_UInt32()
        {
            const string PropertyName = "MediaConnectState";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_MediaDuplexState_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<uint>(msObject, wmiObject, "MediaDuplexState");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_MediaDuplexState_Is_UInt32()
        {
            const string PropertyName = "MediaDuplexState";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_MinorDriverVersion_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<ushort>(msObject, wmiObject, "MinorDriverVersion");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_MinorDriverVersion_Is_UInt16()
        {
            const string PropertyName = "MinorDriverVersion";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_MtuSize_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<uint>(msObject, wmiObject, "MtuSize");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_MtuSize_Is_UInt32()
        {
            const string PropertyName = "MtuSize";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_Name_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "Name");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_Name_Is_String()
        {
            const string PropertyName = "Name";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_NdisMedium_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<uint>(msObject, wmiObject, "NdisMedium");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_NdisMedium_Is_UInt32()
        {
            const string PropertyName = "NdisMedium";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_NdisPhysicalMedium_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<uint>(msObject, wmiObject, "NdisPhysicalMedium");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_NdisPhysicalMedium_Is_UInt32()
        {
            const string PropertyName = "NdisPhysicalMedium";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_NetLuid_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<ulong>(msObject, wmiObject, "NetLuid");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_NetLuid_Is_UInt64()
        {
            const string PropertyName = "NetLuid";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_NetLuidIndex_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<uint>(msObject, wmiObject, "NetLuidIndex");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_NetLuidIndex_Is_UInt32()
        {
            const string PropertyName = "NetLuidIndex";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_NetworkAddresses_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<string[]>(msObject, wmiObject, "NetworkAddresses");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_NetworkAddresses_Is_StringArray()
        {
            const string PropertyName = "NetworkAddresses";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<string[]>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<string[]>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                string[] genericValue = wmiObject.GetPropertyValue<string[]>(PropertyName);
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_NotUserRemovable_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<bool>(msObject, wmiObject, "NotUserRemovable");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_NotUserRemovable_Is_Boolean()
        {
            const string PropertyName = "NotUserRemovable";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<bool>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<bool>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                bool genericValue = wmiObject.GetPropertyValue<bool>(PropertyName);
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_OperationalStatusDownDefaultPortNotAuthenticated_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<bool>(msObject, wmiObject, "OperationalStatusDownDefaultPortNotAuthenticated");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_OperationalStatusDownDefaultPortNotAuthenticated_Is_Boolean()
        {
            const string PropertyName = "OperationalStatusDownDefaultPortNotAuthenticated";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<bool>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<bool>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                bool genericValue = wmiObject.GetPropertyValue<bool>(PropertyName);
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_OperationalStatusDownInterfacePaused_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<bool>(msObject, wmiObject, "OperationalStatusDownInterfacePaused");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_OperationalStatusDownInterfacePaused_Is_Boolean()
        {
            const string PropertyName = "OperationalStatusDownInterfacePaused";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<bool>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<bool>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                bool genericValue = wmiObject.GetPropertyValue<bool>(PropertyName);
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_OperationalStatusDownLowPowerState_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<bool>(msObject, wmiObject, "OperationalStatusDownLowPowerState");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_OperationalStatusDownLowPowerState_Is_Boolean()
        {
            const string PropertyName = "OperationalStatusDownLowPowerState";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<bool>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<bool>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                bool genericValue = wmiObject.GetPropertyValue<bool>(PropertyName);
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_OperationalStatusDownMediaDisconnected_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<bool>(msObject, wmiObject, "OperationalStatusDownMediaDisconnected");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_OperationalStatusDownMediaDisconnected_Is_Boolean()
        {
            const string PropertyName = "OperationalStatusDownMediaDisconnected";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<bool>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<bool>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                bool genericValue = wmiObject.GetPropertyValue<bool>(PropertyName);
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_PermanentAddress_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "PermanentAddress");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_PermanentAddress_Is_String()
        {
            const string PropertyName = "PermanentAddress";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_PnPDeviceID_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "PnPDeviceID");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_PnPDeviceID_Is_String()
        {
            const string PropertyName = "PnPDeviceID";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_PortNumber_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<ushort>(msObject, wmiObject, "PortNumber");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_PortNumber_Is_UInt16()
        {
            const string PropertyName = "PortNumber";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_PromiscuousMode_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<bool>(msObject, wmiObject, "PromiscuousMode");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_PromiscuousMode_Is_Boolean()
        {
            const string PropertyName = "PromiscuousMode";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<bool>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<bool>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                bool genericValue = wmiObject.GetPropertyValue<bool>(PropertyName);
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_ReceiveLinkSpeed_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<ulong>(msObject, wmiObject, "ReceiveLinkSpeed");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_ReceiveLinkSpeed_Is_UInt64()
        {
            const string PropertyName = "ReceiveLinkSpeed";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_RequestedState_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<ushort>(msObject, wmiObject, "RequestedState");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_RequestedState_Is_UInt16()
        {
            const string PropertyName = "RequestedState";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_Speed_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<ulong>(msObject, wmiObject, "Speed");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_Speed_Is_UInt64()
        {
            const string PropertyName = "Speed";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_State_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<uint>(msObject, wmiObject, "State");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_State_Is_UInt32()
        {
            const string PropertyName = "State";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_SystemCreationClassName_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "SystemCreationClassName");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_SystemCreationClassName_Is_String()
        {
            const string PropertyName = "SystemCreationClassName";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_SystemName_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "SystemName");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_SystemName_Is_String()
        {
            const string PropertyName = "SystemName";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_TransitioningToState_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<ushort>(msObject, wmiObject, "TransitioningToState");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_TransitioningToState_Is_UInt16()
        {
            const string PropertyName = "TransitioningToState";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_TransmitLinkSpeed_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<ulong>(msObject, wmiObject, "TransmitLinkSpeed");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_TransmitLinkSpeed_Is_UInt64()
        {
            const string PropertyName = "TransmitLinkSpeed";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
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
        public void CIM_NetworkPort_Virtual_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<bool>(msObject, wmiObject, "Virtual");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_Virtual_Is_Boolean()
        {
            const string PropertyName = "Virtual";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<bool>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<bool>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                bool genericValue = wmiObject.GetPropertyValue<bool>(PropertyName);
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_WdmInterface_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                WmiAssert.AreEqual<bool>(msObject, wmiObject, "WdmInterface");
            }
        }

        [TestMethod]
        public void CIM_NetworkPort_WdmInterface_Is_Boolean()
        {
            const string PropertyName = "WdmInterface";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "CIM_NetworkPort"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<bool>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<bool>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                bool genericValue = wmiObject.GetPropertyValue<bool>(PropertyName);
            }
        }
    }
}