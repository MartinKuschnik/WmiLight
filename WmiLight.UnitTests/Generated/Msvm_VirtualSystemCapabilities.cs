using System.Management;

namespace WmiLight.UnitTests.Generated
{
    [TestClass]
    public class Msvm_VirtualSystemCapabilities
    {
        [TestMethod]
        public void Msvm_VirtualSystemCapabilities_Caption_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "Caption");
            }
        }

        [TestMethod]
        public void Msvm_VirtualSystemCapabilities_Caption_Is_String()
        {
            const string PropertyName = "Caption";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
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
        public void Msvm_VirtualSystemCapabilities_Description_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "Description");
            }
        }

        [TestMethod]
        public void Msvm_VirtualSystemCapabilities_Description_Is_String()
        {
            const string PropertyName = "Description";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
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
        public void Msvm_VirtualSystemCapabilities_ElementName_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "ElementName");
            }
        }

        [TestMethod]
        public void Msvm_VirtualSystemCapabilities_ElementName_Is_String()
        {
            const string PropertyName = "ElementName";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
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
        public void Msvm_VirtualSystemCapabilities_ElementNameEditSupported_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
            {
                WmiAssert.AreEqual<bool>(msObject, wmiObject, "ElementNameEditSupported");
            }
        }

        [TestMethod]
        public void Msvm_VirtualSystemCapabilities_ElementNameEditSupported_Is_Boolean()
        {
            const string PropertyName = "ElementNameEditSupported";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
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
        public void Msvm_VirtualSystemCapabilities_ElementNameMask_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "ElementNameMask");
            }
        }

        [TestMethod]
        public void Msvm_VirtualSystemCapabilities_ElementNameMask_Is_String()
        {
            const string PropertyName = "ElementNameMask";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
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
        public void Msvm_VirtualSystemCapabilities_InstanceID_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "InstanceID");
            }
        }

        [TestMethod]
        public void Msvm_VirtualSystemCapabilities_InstanceID_Is_String()
        {
            const string PropertyName = "InstanceID";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
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
        public void Msvm_VirtualSystemCapabilities_MaxElementNameLen_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
            {
                WmiAssert.AreEqual<ushort>(msObject, wmiObject, "MaxElementNameLen");
            }
        }

        [TestMethod]
        public void Msvm_VirtualSystemCapabilities_MaxElementNameLen_Is_UInt16()
        {
            const string PropertyName = "MaxElementNameLen";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
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
        public void Msvm_VirtualSystemCapabilities_RequestedStatesSupported_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
            {
                WmiAssert.AreEqual<ushort[]>(msObject, wmiObject, "RequestedStatesSupported");
            }
        }

        [TestMethod]
        public void Msvm_VirtualSystemCapabilities_RequestedStatesSupported_Is_UInt16Array()
        {
            const string PropertyName = "RequestedStatesSupported";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
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
    }
}