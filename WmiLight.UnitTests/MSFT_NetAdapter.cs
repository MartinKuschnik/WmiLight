using System.Management;

namespace WmiLight.UnitTests
{
	[TestClass]
	public class MSFT_NetAdapter
	{
        [TestMethod]
        public void MSFT_NetAdapter_ActiveMaximumTransmissionUnit_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.UInt64>(msObject, wmiObject, "ActiveMaximumTransmissionUnit");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_ActiveMaximumTransmissionUnit_Is_UInt64()
        {
            const string PropertyName = "ActiveMaximumTransmissionUnit";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_AdminLocked_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.Boolean>(msObject, wmiObject, "AdminLocked");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_AdminLocked_Is_Boolean()
        {
            const string PropertyName = "AdminLocked";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_ComponentID_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "ComponentID");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_ComponentID_Is_String()
        {
            const string PropertyName = "ComponentID";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_ConnectorPresent_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.Boolean>(msObject, wmiObject, "ConnectorPresent");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_ConnectorPresent_Is_Boolean()
        {
            const string PropertyName = "ConnectorPresent";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_CreationClassName_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "CreationClassName");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_CreationClassName_Is_String()
        {
            const string PropertyName = "CreationClassName";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_DeviceID_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "DeviceID");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_DeviceID_Is_String()
        {
            const string PropertyName = "DeviceID";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_DeviceName_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "DeviceName");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_DeviceName_Is_String()
        {
            const string PropertyName = "DeviceName";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_DeviceWakeUpEnable_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.Boolean>(msObject, wmiObject, "DeviceWakeUpEnable");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_DeviceWakeUpEnable_Is_Boolean()
        {
            const string PropertyName = "DeviceWakeUpEnable";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_DriverDate_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "DriverDate");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_DriverDate_Is_String()
        {
            const string PropertyName = "DriverDate";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_DriverDateData_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.UInt64>(msObject, wmiObject, "DriverDateData");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_DriverDateData_Is_UInt64()
        {
            const string PropertyName = "DriverDateData";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_DriverDescription_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "DriverDescription");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_DriverDescription_Is_String()
        {
            const string PropertyName = "DriverDescription";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_DriverMajorNdisVersion_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.Byte>(msObject, wmiObject, "DriverMajorNdisVersion");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_DriverMajorNdisVersion_Is_Byte()
        {
            const string PropertyName = "DriverMajorNdisVersion";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<System.Byte>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.Byte>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.Byte genericValue = wmiObject.GetPropertyValue<System.Byte>(PropertyName);
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_DriverMinorNdisVersion_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.Byte>(msObject, wmiObject, "DriverMinorNdisVersion");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_DriverMinorNdisVersion_Is_Byte()
        {
            const string PropertyName = "DriverMinorNdisVersion";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<System.Byte>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.Byte>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.Byte genericValue = wmiObject.GetPropertyValue<System.Byte>(PropertyName);
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_DriverName_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "DriverName");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_DriverName_Is_String()
        {
            const string PropertyName = "DriverName";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_DriverProvider_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "DriverProvider");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_DriverProvider_Is_String()
        {
            const string PropertyName = "DriverProvider";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_DriverVersionString_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "DriverVersionString");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_DriverVersionString_Is_String()
        {
            const string PropertyName = "DriverVersionString";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_EnabledDefault_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.UInt16>(msObject, wmiObject, "EnabledDefault");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_EnabledDefault_Is_UInt16()
        {
            const string PropertyName = "EnabledDefault";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_EnabledState_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.UInt16>(msObject, wmiObject, "EnabledState");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_EnabledState_Is_UInt16()
        {
            const string PropertyName = "EnabledState";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_EndPointInterface_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.Boolean>(msObject, wmiObject, "EndPointInterface");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_EndPointInterface_Is_Boolean()
        {
            const string PropertyName = "EndPointInterface";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_FullDuplex_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.Boolean>(msObject, wmiObject, "FullDuplex");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_FullDuplex_Is_Boolean()
        {
            const string PropertyName = "FullDuplex";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_HardwareInterface_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.Boolean>(msObject, wmiObject, "HardwareInterface");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_HardwareInterface_Is_Boolean()
        {
            const string PropertyName = "HardwareInterface";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_Hidden_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.Boolean>(msObject, wmiObject, "Hidden");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_Hidden_Is_Boolean()
        {
            const string PropertyName = "Hidden";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_HigherLayerInterfaceIndices_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.UInt32[]>(msObject, wmiObject, "HigherLayerInterfaceIndices");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_HigherLayerInterfaceIndices_Is_UInt32Array()
        {
            const string PropertyName = "HigherLayerInterfaceIndices";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<System.UInt32[]>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.UInt32[]>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.UInt32[] genericValue = wmiObject.GetPropertyValue<System.UInt32[]>(PropertyName);
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_IMFilter_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.Boolean>(msObject, wmiObject, "IMFilter");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_IMFilter_Is_Boolean()
        {
            const string PropertyName = "IMFilter";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_InstanceID_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "InstanceID");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_InstanceID_Is_String()
        {
            const string PropertyName = "InstanceID";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_InterfaceAdminStatus_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "InterfaceAdminStatus");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_InterfaceAdminStatus_Is_UInt32()
        {
            const string PropertyName = "InterfaceAdminStatus";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_InterfaceDescription_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "InterfaceDescription");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_InterfaceDescription_Is_String()
        {
            const string PropertyName = "InterfaceDescription";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_InterfaceGuid_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "InterfaceGuid");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_InterfaceGuid_Is_String()
        {
            const string PropertyName = "InterfaceGuid";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_InterfaceIndex_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "InterfaceIndex");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_InterfaceIndex_Is_UInt32()
        {
            const string PropertyName = "InterfaceIndex";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_InterfaceName_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "InterfaceName");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_InterfaceName_Is_String()
        {
            const string PropertyName = "InterfaceName";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_InterfaceOperationalStatus_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "InterfaceOperationalStatus");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_InterfaceOperationalStatus_Is_UInt32()
        {
            const string PropertyName = "InterfaceOperationalStatus";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_InterfaceType_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "InterfaceType");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_InterfaceType_Is_UInt32()
        {
            const string PropertyName = "InterfaceType";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_iSCSIInterface_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.Boolean>(msObject, wmiObject, "iSCSIInterface");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_iSCSIInterface_Is_Boolean()
        {
            const string PropertyName = "iSCSIInterface";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_MajorDriverVersion_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.UInt16>(msObject, wmiObject, "MajorDriverVersion");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_MajorDriverVersion_Is_UInt16()
        {
            const string PropertyName = "MajorDriverVersion";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_MediaConnectState_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "MediaConnectState");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_MediaConnectState_Is_UInt32()
        {
            const string PropertyName = "MediaConnectState";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_MediaDuplexState_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "MediaDuplexState");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_MediaDuplexState_Is_UInt32()
        {
            const string PropertyName = "MediaDuplexState";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_MinorDriverVersion_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.UInt16>(msObject, wmiObject, "MinorDriverVersion");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_MinorDriverVersion_Is_UInt16()
        {
            const string PropertyName = "MinorDriverVersion";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_MtuSize_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "MtuSize");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_MtuSize_Is_UInt32()
        {
            const string PropertyName = "MtuSize";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_Name_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "Name");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_Name_Is_String()
        {
            const string PropertyName = "Name";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_NdisMedium_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "NdisMedium");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_NdisMedium_Is_UInt32()
        {
            const string PropertyName = "NdisMedium";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_NdisPhysicalMedium_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "NdisPhysicalMedium");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_NdisPhysicalMedium_Is_UInt32()
        {
            const string PropertyName = "NdisPhysicalMedium";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_NetLuid_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.UInt64>(msObject, wmiObject, "NetLuid");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_NetLuid_Is_UInt64()
        {
            const string PropertyName = "NetLuid";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_NetLuidIndex_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "NetLuidIndex");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_NetLuidIndex_Is_UInt32()
        {
            const string PropertyName = "NetLuidIndex";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_NetworkAddresses_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.String[]>(msObject, wmiObject, "NetworkAddresses");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_NetworkAddresses_Is_StringArray()
        {
            const string PropertyName = "NetworkAddresses";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<System.String[]>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.String[]>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.String[] genericValue = wmiObject.GetPropertyValue<System.String[]>(PropertyName);
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_NotUserRemovable_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.Boolean>(msObject, wmiObject, "NotUserRemovable");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_NotUserRemovable_Is_Boolean()
        {
            const string PropertyName = "NotUserRemovable";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_OperationalStatusDownDefaultPortNotAuthenticated_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.Boolean>(msObject, wmiObject, "OperationalStatusDownDefaultPortNotAuthenticated");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_OperationalStatusDownDefaultPortNotAuthenticated_Is_Boolean()
        {
            const string PropertyName = "OperationalStatusDownDefaultPortNotAuthenticated";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_OperationalStatusDownInterfacePaused_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.Boolean>(msObject, wmiObject, "OperationalStatusDownInterfacePaused");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_OperationalStatusDownInterfacePaused_Is_Boolean()
        {
            const string PropertyName = "OperationalStatusDownInterfacePaused";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_OperationalStatusDownLowPowerState_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.Boolean>(msObject, wmiObject, "OperationalStatusDownLowPowerState");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_OperationalStatusDownLowPowerState_Is_Boolean()
        {
            const string PropertyName = "OperationalStatusDownLowPowerState";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_OperationalStatusDownMediaDisconnected_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.Boolean>(msObject, wmiObject, "OperationalStatusDownMediaDisconnected");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_OperationalStatusDownMediaDisconnected_Is_Boolean()
        {
            const string PropertyName = "OperationalStatusDownMediaDisconnected";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_PermanentAddress_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "PermanentAddress");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_PermanentAddress_Is_String()
        {
            const string PropertyName = "PermanentAddress";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_PnPDeviceID_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "PnPDeviceID");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_PnPDeviceID_Is_String()
        {
            const string PropertyName = "PnPDeviceID";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_PortNumber_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.UInt16>(msObject, wmiObject, "PortNumber");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_PortNumber_Is_UInt16()
        {
            const string PropertyName = "PortNumber";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_PromiscuousMode_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.Boolean>(msObject, wmiObject, "PromiscuousMode");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_PromiscuousMode_Is_Boolean()
        {
            const string PropertyName = "PromiscuousMode";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_ReceiveLinkSpeed_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.UInt64>(msObject, wmiObject, "ReceiveLinkSpeed");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_ReceiveLinkSpeed_Is_UInt64()
        {
            const string PropertyName = "ReceiveLinkSpeed";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_RequestedState_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.UInt16>(msObject, wmiObject, "RequestedState");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_RequestedState_Is_UInt16()
        {
            const string PropertyName = "RequestedState";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_Speed_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.UInt64>(msObject, wmiObject, "Speed");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_Speed_Is_UInt64()
        {
            const string PropertyName = "Speed";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_State_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "State");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_State_Is_UInt32()
        {
            const string PropertyName = "State";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_SystemCreationClassName_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "SystemCreationClassName");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_SystemCreationClassName_Is_String()
        {
            const string PropertyName = "SystemCreationClassName";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_SystemName_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "SystemName");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_SystemName_Is_String()
        {
            const string PropertyName = "SystemName";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_TransitioningToState_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.UInt16>(msObject, wmiObject, "TransitioningToState");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_TransitioningToState_Is_UInt16()
        {
            const string PropertyName = "TransitioningToState";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_TransmitLinkSpeed_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.UInt64>(msObject, wmiObject, "TransmitLinkSpeed");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_TransmitLinkSpeed_Is_UInt64()
        {
            const string PropertyName = "TransmitLinkSpeed";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_Virtual_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.Boolean>(msObject, wmiObject, "Virtual");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_Virtual_Is_Boolean()
        {
            const string PropertyName = "Virtual";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
        public void MSFT_NetAdapter_WdmInterface_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
            {
                WmiAssert.AreEqual<System.Boolean>(msObject, wmiObject, "WdmInterface");
            }
        }

        [TestMethod]
        public void MSFT_NetAdapter_WdmInterface_Is_Boolean()
        {
            const string PropertyName = "WdmInterface";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "MSFT_NetAdapter"))
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
	}
}