using System.Management;

namespace WmiLight.UnitTests
{
	[TestClass]
	public class Win32_ComputerSystemProduct
	{
        [TestMethod]
        public void Win32_ComputerSystemProduct_Caption_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_ComputerSystemProduct"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_ComputerSystemProduct"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "Caption");
            }
        }

        [TestMethod]
        public void Win32_ComputerSystemProduct_Caption_Is_String()
        {
            const string PropertyName = "Caption";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_ComputerSystemProduct"))
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
        public void Win32_ComputerSystemProduct_Description_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_ComputerSystemProduct"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_ComputerSystemProduct"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "Description");
            }
        }

        [TestMethod]
        public void Win32_ComputerSystemProduct_Description_Is_String()
        {
            const string PropertyName = "Description";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_ComputerSystemProduct"))
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
        public void Win32_ComputerSystemProduct_IdentifyingNumber_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_ComputerSystemProduct"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_ComputerSystemProduct"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "IdentifyingNumber");
            }
        }

        [TestMethod]
        public void Win32_ComputerSystemProduct_IdentifyingNumber_Is_String()
        {
            const string PropertyName = "IdentifyingNumber";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_ComputerSystemProduct"))
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
        public void Win32_ComputerSystemProduct_Name_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_ComputerSystemProduct"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_ComputerSystemProduct"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "Name");
            }
        }

        [TestMethod]
        public void Win32_ComputerSystemProduct_Name_Is_String()
        {
            const string PropertyName = "Name";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_ComputerSystemProduct"))
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
        public void Win32_ComputerSystemProduct_UUID_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_ComputerSystemProduct"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_ComputerSystemProduct"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "UUID");
            }
        }

        [TestMethod]
        public void Win32_ComputerSystemProduct_UUID_Is_String()
        {
            const string PropertyName = "UUID";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_ComputerSystemProduct"))
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
        public void Win32_ComputerSystemProduct_Vendor_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_ComputerSystemProduct"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_ComputerSystemProduct"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "Vendor");
            }
        }

        [TestMethod]
        public void Win32_ComputerSystemProduct_Vendor_Is_String()
        {
            const string PropertyName = "Vendor";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_ComputerSystemProduct"))
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
        public void Win32_ComputerSystemProduct_Version_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_ComputerSystemProduct"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_ComputerSystemProduct"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "Version");
            }
        }

        [TestMethod]
        public void Win32_ComputerSystemProduct_Version_Is_String()
        {
            const string PropertyName = "Version";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_ComputerSystemProduct"))
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