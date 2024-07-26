using System.Management;

namespace WmiLight.UnitTests.Generated
{
    [TestClass]
    public class Msvm_SummaryInformation
    {
        [TestMethod]
        public void Msvm_SummaryInformation_AvailableMemoryBuffer_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            {
                WmiAssert.AreEqual<int>(msObject, wmiObject, "AvailableMemoryBuffer");
            }
        }

        [TestMethod]
        public void Msvm_SummaryInformation_AvailableMemoryBuffer_Is_Int32()
        {
            const string PropertyName = "AvailableMemoryBuffer";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<int>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<int>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                int genericValue = wmiObject.GetPropertyValue<int>(PropertyName);
            }
        }

        [TestMethod]
        public void Msvm_SummaryInformation_ElementName_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "ElementName");
            }
        }

        [TestMethod]
        public void Msvm_SummaryInformation_ElementName_Is_String()
        {
            const string PropertyName = "ElementName";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
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
        public void Msvm_SummaryInformation_EnabledState_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            {
                WmiAssert.AreEqual<ushort>(msObject, wmiObject, "EnabledState");
            }
        }

        [TestMethod]
        public void Msvm_SummaryInformation_EnabledState_Is_UInt16()
        {
            const string PropertyName = "EnabledState";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
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
        public void Msvm_SummaryInformation_EnhancedSessionModeState_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            {
                WmiAssert.AreEqual<ushort>(msObject, wmiObject, "EnhancedSessionModeState");
            }
        }

        [TestMethod]
        public void Msvm_SummaryInformation_EnhancedSessionModeState_Is_UInt16()
        {
            const string PropertyName = "EnhancedSessionModeState";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
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
        public void Msvm_SummaryInformation_HealthState_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            {
                WmiAssert.AreEqual<ushort>(msObject, wmiObject, "HealthState");
            }
        }

        [TestMethod]
        public void Msvm_SummaryInformation_HealthState_Is_UInt16()
        {
            const string PropertyName = "HealthState";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
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
        public void Msvm_SummaryInformation_HostComputerSystemName_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "HostComputerSystemName");
            }
        }

        [TestMethod]
        public void Msvm_SummaryInformation_HostComputerSystemName_Is_String()
        {
            const string PropertyName = "HostComputerSystemName";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
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
        public void Msvm_SummaryInformation_InstanceID_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "InstanceID");
            }
        }

        [TestMethod]
        public void Msvm_SummaryInformation_InstanceID_Is_String()
        {
            const string PropertyName = "InstanceID";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
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
        public void Msvm_SummaryInformation_MemoryAvailable_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            {
                WmiAssert.AreEqual<int>(msObject, wmiObject, "MemoryAvailable");
            }
        }

        [TestMethod]
        public void Msvm_SummaryInformation_MemoryAvailable_Is_Int32()
        {
            const string PropertyName = "MemoryAvailable";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<int>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<int>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                int genericValue = wmiObject.GetPropertyValue<int>(PropertyName);
            }
        }

        [TestMethod]
        public void Msvm_SummaryInformation_Name_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "Name");
            }
        }

        [TestMethod]
        public void Msvm_SummaryInformation_Name_Is_String()
        {
            const string PropertyName = "Name";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
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
        public void Msvm_SummaryInformation_OperationalStatus_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            {
                WmiAssert.AreEqual<ushort[]>(msObject, wmiObject, "OperationalStatus");
            }
        }

        [TestMethod]
        public void Msvm_SummaryInformation_OperationalStatus_Is_UInt16Array()
        {
            const string PropertyName = "OperationalStatus";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
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
        public void Msvm_SummaryInformation_ReplicationHealth_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            {
                WmiAssert.AreEqual<ushort>(msObject, wmiObject, "ReplicationHealth");
            }
        }

        [TestMethod]
        public void Msvm_SummaryInformation_ReplicationHealth_Is_UInt16()
        {
            const string PropertyName = "ReplicationHealth";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
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
        public void Msvm_SummaryInformation_ReplicationHealthEx_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            {
                WmiAssert.AreEqual<ushort[]>(msObject, wmiObject, "ReplicationHealthEx");
            }
        }

        [TestMethod]
        public void Msvm_SummaryInformation_ReplicationHealthEx_Is_UInt16Array()
        {
            const string PropertyName = "ReplicationHealthEx";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
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
        public void Msvm_SummaryInformation_ReplicationMode_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            {
                WmiAssert.AreEqual<ushort>(msObject, wmiObject, "ReplicationMode");
            }
        }

        [TestMethod]
        public void Msvm_SummaryInformation_ReplicationMode_Is_UInt16()
        {
            const string PropertyName = "ReplicationMode";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
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
        public void Msvm_SummaryInformation_ReplicationProviderId_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            {
                WmiAssert.AreEqual<string[]>(msObject, wmiObject, "ReplicationProviderId");
            }
        }

        [TestMethod]
        public void Msvm_SummaryInformation_ReplicationProviderId_Is_StringArray()
        {
            const string PropertyName = "ReplicationProviderId";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
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
        public void Msvm_SummaryInformation_ReplicationState_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            {
                WmiAssert.AreEqual<ushort>(msObject, wmiObject, "ReplicationState");
            }
        }

        [TestMethod]
        public void Msvm_SummaryInformation_ReplicationState_Is_UInt16()
        {
            const string PropertyName = "ReplicationState";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
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
        public void Msvm_SummaryInformation_ReplicationStateEx_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            {
                WmiAssert.AreEqual<ushort[]>(msObject, wmiObject, "ReplicationStateEx");
            }
        }

        [TestMethod]
        public void Msvm_SummaryInformation_ReplicationStateEx_Is_UInt16Array()
        {
            const string PropertyName = "ReplicationStateEx";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
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
        public void Msvm_SummaryInformation_StatusDescriptions_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            {
                WmiAssert.AreEqual<string[]>(msObject, wmiObject, "StatusDescriptions");
            }
        }

        [TestMethod]
        public void Msvm_SummaryInformation_StatusDescriptions_Is_StringArray()
        {
            const string PropertyName = "StatusDescriptions";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
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
        public void Msvm_SummaryInformation_SwapFilesInUse_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            {
                WmiAssert.AreEqual<bool>(msObject, wmiObject, "SwapFilesInUse");
            }
        }

        [TestMethod]
        public void Msvm_SummaryInformation_SwapFilesInUse_Is_Boolean()
        {
            const string PropertyName = "SwapFilesInUse";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
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
        public void Msvm_SummaryInformation_UpTime_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            {
                WmiAssert.AreEqual<ulong>(msObject, wmiObject, "UpTime");
            }
        }

        [TestMethod]
        public void Msvm_SummaryInformation_UpTime_Is_UInt64()
        {
            const string PropertyName = "UpTime";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
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
        public void Msvm_SummaryInformation_VirtualSystemSubType_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "VirtualSystemSubType");
            }
        }

        [TestMethod]
        public void Msvm_SummaryInformation_VirtualSystemSubType_Is_String()
        {
            const string PropertyName = "VirtualSystemSubType";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
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
        public void Msvm_SummaryInformation_CreationTime_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "CreationTime");
            }
        }

        [TestMethod]
        public void Msvm_SummaryInformation_CreationTime_Is_String()
        {
            const string PropertyName = "CreationTime";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
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
        public void Msvm_SummaryInformation_Notes_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "Notes");
            }
        }

        [TestMethod]
        public void Msvm_SummaryInformation_Notes_Is_String()
        {
            const string PropertyName = "Notes";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
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
        public void Msvm_SummaryInformation_NumberOfProcessors_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            {
                WmiAssert.AreEqual<ushort>(msObject, wmiObject, "NumberOfProcessors");
            }
        }

        [TestMethod]
        public void Msvm_SummaryInformation_NumberOfProcessors_Is_UInt16()
        {
            const string PropertyName = "NumberOfProcessors";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
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
        public void Msvm_SummaryInformation_Shielded_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            {
                WmiAssert.AreEqual<bool>(msObject, wmiObject, "Shielded");
            }
        }

        [TestMethod]
        public void Msvm_SummaryInformation_Shielded_Is_Boolean()
        {
            const string PropertyName = "Shielded";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
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
        public void Msvm_SummaryInformation_Version_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "Version");
            }
        }

        [TestMethod]
        public void Msvm_SummaryInformation_Version_Is_String()
        {
            const string PropertyName = "Version";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
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
        public void Msvm_SummaryInformation_VirtualSwitchNames_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            {
                WmiAssert.AreEqual<string[]>(msObject, wmiObject, "VirtualSwitchNames");
            }
        }

        [TestMethod]
        public void Msvm_SummaryInformation_VirtualSwitchNames_Is_StringArray()
        {
            const string PropertyName = "VirtualSwitchNames";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
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
    }
}