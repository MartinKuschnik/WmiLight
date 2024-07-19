using System.Management;

namespace WmiLight.UnitTests
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
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "Caption");
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
                    Assert.IsInstanceOfType<System.String>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.String>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.String genericValue = wmiObject.GetPropertyValue<System.String>(PropertyName);
            }
        }

        [TestMethod]
        public void Msvm_VirtualSystemCapabilities_Description_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "Description");
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
                    Assert.IsInstanceOfType<System.String>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.String>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.String genericValue = wmiObject.GetPropertyValue<System.String>(PropertyName);
            }
        }

        [TestMethod]
        public void Msvm_VirtualSystemCapabilities_ElementName_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "ElementName");
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
                    Assert.IsInstanceOfType<System.String>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.String>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.String genericValue = wmiObject.GetPropertyValue<System.String>(PropertyName);
            }
        }

        [TestMethod]
        public void Msvm_VirtualSystemCapabilities_ElementNameEditSupported_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
            {
                WmiAssert.AreEqual<System.Boolean>(msObject, wmiObject, "ElementNameEditSupported");
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
                    Assert.IsInstanceOfType<System.Boolean>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.Boolean>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.Boolean genericValue = wmiObject.GetPropertyValue<System.Boolean>(PropertyName);
            }
        }

        [TestMethod]
        public void Msvm_VirtualSystemCapabilities_ElementNameMask_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "ElementNameMask");
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
                    Assert.IsInstanceOfType<System.String>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.String>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.String genericValue = wmiObject.GetPropertyValue<System.String>(PropertyName);
            }
        }

        [TestMethod]
        public void Msvm_VirtualSystemCapabilities_InstanceID_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "InstanceID");
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
                    Assert.IsInstanceOfType<System.String>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.String>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.String genericValue = wmiObject.GetPropertyValue<System.String>(PropertyName);
            }
        }

        [TestMethod]
        public void Msvm_VirtualSystemCapabilities_MaxElementNameLen_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
            {
                WmiAssert.AreEqual<System.UInt16>(msObject, wmiObject, "MaxElementNameLen");
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
                    Assert.IsInstanceOfType<System.UInt16>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.UInt16>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.UInt16 genericValue = wmiObject.GetPropertyValue<System.UInt16>(PropertyName);
            }
        }

        [TestMethod]
        public void Msvm_VirtualSystemCapabilities_RequestedStatesSupported_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_VirtualSystemCapabilities"))
            {
                WmiAssert.AreEqual<System.UInt16[]>(msObject, wmiObject, "RequestedStatesSupported");
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
                    Assert.IsInstanceOfType<System.UInt16[]>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.UInt16[]>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.UInt16[] genericValue = wmiObject.GetPropertyValue<System.UInt16[]>(PropertyName);
            }
        }
	}
}