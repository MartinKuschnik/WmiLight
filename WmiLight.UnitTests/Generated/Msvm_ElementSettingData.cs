using System.Management;

namespace WmiLight.UnitTests.Generated
{
    [TestClass]
    public class Msvm_ElementSettingData
    {
        [TestMethod]
        public void Msvm_ElementSettingData_IsCurrent_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_ElementSettingData"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_ElementSettingData"))
            {
                WmiAssert.AreEqual<ushort>(msObject, wmiObject, "IsCurrent");
            }
        }

        [TestMethod]
        public void Msvm_ElementSettingData_IsCurrent_Is_UInt16()
        {
            const string PropertyName = "IsCurrent";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_ElementSettingData"))
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
        public void Msvm_ElementSettingData_IsDefault_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_ElementSettingData"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_ElementSettingData"))
            {
                WmiAssert.AreEqual<ushort>(msObject, wmiObject, "IsDefault");
            }
        }

        [TestMethod]
        public void Msvm_ElementSettingData_IsDefault_Is_UInt16()
        {
            const string PropertyName = "IsDefault";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_ElementSettingData"))
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
        public void Msvm_ElementSettingData_IsNext_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_ElementSettingData"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_ElementSettingData"))
            {
                WmiAssert.AreEqual<ushort>(msObject, wmiObject, "IsNext");
            }
        }

        [TestMethod]
        public void Msvm_ElementSettingData_IsNext_Is_UInt16()
        {
            const string PropertyName = "IsNext";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_ElementSettingData"))
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
        public void Msvm_ElementSettingData_ManagedElement_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_ElementSettingData"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_ElementSettingData"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "ManagedElement");
            }
        }

        [TestMethod]
        public void Msvm_ElementSettingData_ManagedElement_Is_String()
        {
            const string PropertyName = "ManagedElement";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_ElementSettingData"))
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
        public void Msvm_ElementSettingData_SettingData_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_ElementSettingData"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_ElementSettingData"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "SettingData");
            }
        }

        [TestMethod]
        public void Msvm_ElementSettingData_SettingData_Is_String()
        {
            const string PropertyName = "SettingData";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_ElementSettingData"))
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
    }
}