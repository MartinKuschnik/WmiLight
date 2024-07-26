using System.Management;

namespace WmiLight.UnitTests.Generated
{
    [TestClass]
    public class Win32_NetworkAdapterConfiguration
    {
        [TestMethod]
        public void Win32_NetworkAdapterConfiguration_Caption_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "Caption");
            }
        }

        [TestMethod]
        public void Win32_NetworkAdapterConfiguration_Caption_Is_String()
        {
            const string PropertyName = "Caption";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
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
        public void Win32_NetworkAdapterConfiguration_Description_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "Description");
            }
        }

        [TestMethod]
        public void Win32_NetworkAdapterConfiguration_Description_Is_String()
        {
            const string PropertyName = "Description";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
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
        public void Win32_NetworkAdapterConfiguration_DHCPEnabled_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            {
                WmiAssert.AreEqual<bool>(msObject, wmiObject, "DHCPEnabled");
            }
        }

        [TestMethod]
        public void Win32_NetworkAdapterConfiguration_DHCPEnabled_Is_Boolean()
        {
            const string PropertyName = "DHCPEnabled";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
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
        public void Win32_NetworkAdapterConfiguration_Index_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            {
                WmiAssert.AreEqual<uint>(msObject, wmiObject, "Index");
            }
        }

        [TestMethod]
        public void Win32_NetworkAdapterConfiguration_Index_Is_UInt32()
        {
            const string PropertyName = "Index";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
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
        public void Win32_NetworkAdapterConfiguration_InterfaceIndex_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            {
                WmiAssert.AreEqual<uint>(msObject, wmiObject, "InterfaceIndex");
            }
        }

        [TestMethod]
        public void Win32_NetworkAdapterConfiguration_InterfaceIndex_Is_UInt32()
        {
            const string PropertyName = "InterfaceIndex";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
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
        public void Win32_NetworkAdapterConfiguration_IPEnabled_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            {
                WmiAssert.AreEqual<bool>(msObject, wmiObject, "IPEnabled");
            }
        }

        [TestMethod]
        public void Win32_NetworkAdapterConfiguration_IPEnabled_Is_Boolean()
        {
            const string PropertyName = "IPEnabled";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
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
        public void Win32_NetworkAdapterConfiguration_ServiceName_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "ServiceName");
            }
        }

        [TestMethod]
        public void Win32_NetworkAdapterConfiguration_ServiceName_Is_String()
        {
            const string PropertyName = "ServiceName";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
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
        public void Win32_NetworkAdapterConfiguration_SettingID_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "SettingID");
            }
        }

        [TestMethod]
        public void Win32_NetworkAdapterConfiguration_SettingID_Is_String()
        {
            const string PropertyName = "SettingID";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
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
        public void Win32_NetworkAdapterConfiguration_DatabasePath_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "DatabasePath");
            }
        }

        [TestMethod]
        public void Win32_NetworkAdapterConfiguration_DatabasePath_Is_String()
        {
            const string PropertyName = "DatabasePath";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
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
        public void Win32_NetworkAdapterConfiguration_DefaultIPGateway_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            {
                WmiAssert.AreEqual<string[]>(msObject, wmiObject, "DefaultIPGateway");
            }
        }

        [TestMethod]
        public void Win32_NetworkAdapterConfiguration_DefaultIPGateway_Is_StringArray()
        {
            const string PropertyName = "DefaultIPGateway";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
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
        public void Win32_NetworkAdapterConfiguration_DHCPLeaseExpires_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "DHCPLeaseExpires");
            }
        }

        [TestMethod]
        public void Win32_NetworkAdapterConfiguration_DHCPLeaseExpires_Is_String()
        {
            const string PropertyName = "DHCPLeaseExpires";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
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
        public void Win32_NetworkAdapterConfiguration_DHCPLeaseObtained_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "DHCPLeaseObtained");
            }
        }

        [TestMethod]
        public void Win32_NetworkAdapterConfiguration_DHCPLeaseObtained_Is_String()
        {
            const string PropertyName = "DHCPLeaseObtained";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
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
        public void Win32_NetworkAdapterConfiguration_DHCPServer_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "DHCPServer");
            }
        }

        [TestMethod]
        public void Win32_NetworkAdapterConfiguration_DHCPServer_Is_String()
        {
            const string PropertyName = "DHCPServer";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
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
        public void Win32_NetworkAdapterConfiguration_DNSDomainSuffixSearchOrder_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            {
                WmiAssert.AreEqual<string[]>(msObject, wmiObject, "DNSDomainSuffixSearchOrder");
            }
        }

        [TestMethod]
        public void Win32_NetworkAdapterConfiguration_DNSDomainSuffixSearchOrder_Is_StringArray()
        {
            const string PropertyName = "DNSDomainSuffixSearchOrder";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
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
        public void Win32_NetworkAdapterConfiguration_DNSEnabledForWINSResolution_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            {
                WmiAssert.AreEqual<bool>(msObject, wmiObject, "DNSEnabledForWINSResolution");
            }
        }

        [TestMethod]
        public void Win32_NetworkAdapterConfiguration_DNSEnabledForWINSResolution_Is_Boolean()
        {
            const string PropertyName = "DNSEnabledForWINSResolution";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
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
        public void Win32_NetworkAdapterConfiguration_DNSHostName_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "DNSHostName");
            }
        }

        [TestMethod]
        public void Win32_NetworkAdapterConfiguration_DNSHostName_Is_String()
        {
            const string PropertyName = "DNSHostName";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
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
        public void Win32_NetworkAdapterConfiguration_DNSServerSearchOrder_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            {
                WmiAssert.AreEqual<string[]>(msObject, wmiObject, "DNSServerSearchOrder");
            }
        }

        [TestMethod]
        public void Win32_NetworkAdapterConfiguration_DNSServerSearchOrder_Is_StringArray()
        {
            const string PropertyName = "DNSServerSearchOrder";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
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
        public void Win32_NetworkAdapterConfiguration_DomainDNSRegistrationEnabled_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            {
                WmiAssert.AreEqual<bool>(msObject, wmiObject, "DomainDNSRegistrationEnabled");
            }
        }

        [TestMethod]
        public void Win32_NetworkAdapterConfiguration_DomainDNSRegistrationEnabled_Is_Boolean()
        {
            const string PropertyName = "DomainDNSRegistrationEnabled";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
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
        public void Win32_NetworkAdapterConfiguration_FullDNSRegistrationEnabled_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            {
                WmiAssert.AreEqual<bool>(msObject, wmiObject, "FullDNSRegistrationEnabled");
            }
        }

        [TestMethod]
        public void Win32_NetworkAdapterConfiguration_FullDNSRegistrationEnabled_Is_Boolean()
        {
            const string PropertyName = "FullDNSRegistrationEnabled";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
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
        public void Win32_NetworkAdapterConfiguration_GatewayCostMetric_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            {
                WmiAssert.AreEqual<ushort[]>(msObject, wmiObject, "GatewayCostMetric");
            }
        }

        [TestMethod]
        public void Win32_NetworkAdapterConfiguration_GatewayCostMetric_Is_UInt16Array()
        {
            const string PropertyName = "GatewayCostMetric";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
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
        public void Win32_NetworkAdapterConfiguration_IPAddress_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            {
                WmiAssert.AreEqual<string[]>(msObject, wmiObject, "IPAddress");
            }
        }

        [TestMethod]
        public void Win32_NetworkAdapterConfiguration_IPAddress_Is_StringArray()
        {
            const string PropertyName = "IPAddress";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
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
        public void Win32_NetworkAdapterConfiguration_IPConnectionMetric_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            {
                WmiAssert.AreEqual<uint>(msObject, wmiObject, "IPConnectionMetric");
            }
        }

        [TestMethod]
        public void Win32_NetworkAdapterConfiguration_IPConnectionMetric_Is_UInt32()
        {
            const string PropertyName = "IPConnectionMetric";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
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
        public void Win32_NetworkAdapterConfiguration_IPFilterSecurityEnabled_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            {
                WmiAssert.AreEqual<bool>(msObject, wmiObject, "IPFilterSecurityEnabled");
            }
        }

        [TestMethod]
        public void Win32_NetworkAdapterConfiguration_IPFilterSecurityEnabled_Is_Boolean()
        {
            const string PropertyName = "IPFilterSecurityEnabled";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
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
        public void Win32_NetworkAdapterConfiguration_IPSecPermitIPProtocols_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            {
                WmiAssert.AreEqual<string[]>(msObject, wmiObject, "IPSecPermitIPProtocols");
            }
        }

        [TestMethod]
        public void Win32_NetworkAdapterConfiguration_IPSecPermitIPProtocols_Is_StringArray()
        {
            const string PropertyName = "IPSecPermitIPProtocols";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
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
        public void Win32_NetworkAdapterConfiguration_IPSecPermitTCPPorts_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            {
                WmiAssert.AreEqual<string[]>(msObject, wmiObject, "IPSecPermitTCPPorts");
            }
        }

        [TestMethod]
        public void Win32_NetworkAdapterConfiguration_IPSecPermitTCPPorts_Is_StringArray()
        {
            const string PropertyName = "IPSecPermitTCPPorts";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
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
        public void Win32_NetworkAdapterConfiguration_IPSecPermitUDPPorts_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            {
                WmiAssert.AreEqual<string[]>(msObject, wmiObject, "IPSecPermitUDPPorts");
            }
        }

        [TestMethod]
        public void Win32_NetworkAdapterConfiguration_IPSecPermitUDPPorts_Is_StringArray()
        {
            const string PropertyName = "IPSecPermitUDPPorts";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
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
        public void Win32_NetworkAdapterConfiguration_IPSubnet_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            {
                WmiAssert.AreEqual<string[]>(msObject, wmiObject, "IPSubnet");
            }
        }

        [TestMethod]
        public void Win32_NetworkAdapterConfiguration_IPSubnet_Is_StringArray()
        {
            const string PropertyName = "IPSubnet";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
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
        public void Win32_NetworkAdapterConfiguration_MACAddress_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "MACAddress");
            }
        }

        [TestMethod]
        public void Win32_NetworkAdapterConfiguration_MACAddress_Is_String()
        {
            const string PropertyName = "MACAddress";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
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
        public void Win32_NetworkAdapterConfiguration_TcpipNetbiosOptions_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            {
                WmiAssert.AreEqual<uint>(msObject, wmiObject, "TcpipNetbiosOptions");
            }
        }

        [TestMethod]
        public void Win32_NetworkAdapterConfiguration_TcpipNetbiosOptions_Is_UInt32()
        {
            const string PropertyName = "TcpipNetbiosOptions";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
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
        public void Win32_NetworkAdapterConfiguration_WINSEnableLMHostsLookup_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            {
                WmiAssert.AreEqual<bool>(msObject, wmiObject, "WINSEnableLMHostsLookup");
            }
        }

        [TestMethod]
        public void Win32_NetworkAdapterConfiguration_WINSEnableLMHostsLookup_Is_Boolean()
        {
            const string PropertyName = "WINSEnableLMHostsLookup";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
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
        public void Win32_NetworkAdapterConfiguration_WINSScopeID_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
            {
                WmiAssert.AreEqual<string>(msObject, wmiObject, "WINSScopeID");
            }
        }

        [TestMethod]
        public void Win32_NetworkAdapterConfiguration_WINSScopeID_Is_String()
        {
            const string PropertyName = "WINSScopeID";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_NetworkAdapterConfiguration"))
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