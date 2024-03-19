using System.Management;

namespace WmiLight.UnitTests
{
	[TestClass]
	public class Win32_SystemDriver
	{
        [TestMethod]
        public void Win32_SystemDriver_AcceptPause_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_SystemDriver"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
            {
                WmiAssert.AreEqual<System.Boolean>(msObject, wmiObject, "AcceptPause");
            }
        }

        [TestMethod]
        public void Win32_SystemDriver_AcceptPause_Is_Boolean()
        {
            const string PropertyName = "AcceptPause";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
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
        public void Win32_SystemDriver_AcceptStop_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_SystemDriver"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
            {
                WmiAssert.AreEqual<System.Boolean>(msObject, wmiObject, "AcceptStop");
            }
        }

        [TestMethod]
        public void Win32_SystemDriver_AcceptStop_Is_Boolean()
        {
            const string PropertyName = "AcceptStop";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
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
        public void Win32_SystemDriver_Caption_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_SystemDriver"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "Caption");
            }
        }

        [TestMethod]
        public void Win32_SystemDriver_Caption_Is_String()
        {
            const string PropertyName = "Caption";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
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
        public void Win32_SystemDriver_CreationClassName_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_SystemDriver"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "CreationClassName");
            }
        }

        [TestMethod]
        public void Win32_SystemDriver_CreationClassName_Is_String()
        {
            const string PropertyName = "CreationClassName";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
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
        public void Win32_SystemDriver_Description_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_SystemDriver"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "Description");
            }
        }

        [TestMethod]
        public void Win32_SystemDriver_Description_Is_String()
        {
            const string PropertyName = "Description";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
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
        public void Win32_SystemDriver_DesktopInteract_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_SystemDriver"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
            {
                WmiAssert.AreEqual<System.Boolean>(msObject, wmiObject, "DesktopInteract");
            }
        }

        [TestMethod]
        public void Win32_SystemDriver_DesktopInteract_Is_Boolean()
        {
            const string PropertyName = "DesktopInteract";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
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
        public void Win32_SystemDriver_DisplayName_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_SystemDriver"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "DisplayName");
            }
        }

        [TestMethod]
        public void Win32_SystemDriver_DisplayName_Is_String()
        {
            const string PropertyName = "DisplayName";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
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
        public void Win32_SystemDriver_ErrorControl_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_SystemDriver"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "ErrorControl");
            }
        }

        [TestMethod]
        public void Win32_SystemDriver_ErrorControl_Is_String()
        {
            const string PropertyName = "ErrorControl";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
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
        public void Win32_SystemDriver_ExitCode_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_SystemDriver"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "ExitCode");
            }
        }

        [TestMethod]
        public void Win32_SystemDriver_ExitCode_Is_UInt32()
        {
            const string PropertyName = "ExitCode";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
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
        public void Win32_SystemDriver_Name_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_SystemDriver"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "Name");
            }
        }

        [TestMethod]
        public void Win32_SystemDriver_Name_Is_String()
        {
            const string PropertyName = "Name";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
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
        public void Win32_SystemDriver_PathName_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_SystemDriver"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "PathName");
            }
        }

        [TestMethod]
        public void Win32_SystemDriver_PathName_Is_String()
        {
            const string PropertyName = "PathName";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
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
        public void Win32_SystemDriver_ServiceSpecificExitCode_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_SystemDriver"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "ServiceSpecificExitCode");
            }
        }

        [TestMethod]
        public void Win32_SystemDriver_ServiceSpecificExitCode_Is_UInt32()
        {
            const string PropertyName = "ServiceSpecificExitCode";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
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
        public void Win32_SystemDriver_ServiceType_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_SystemDriver"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "ServiceType");
            }
        }

        [TestMethod]
        public void Win32_SystemDriver_ServiceType_Is_String()
        {
            const string PropertyName = "ServiceType";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
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
        public void Win32_SystemDriver_Started_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_SystemDriver"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
            {
                WmiAssert.AreEqual<System.Boolean>(msObject, wmiObject, "Started");
            }
        }

        [TestMethod]
        public void Win32_SystemDriver_Started_Is_Boolean()
        {
            const string PropertyName = "Started";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
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
        public void Win32_SystemDriver_StartMode_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_SystemDriver"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "StartMode");
            }
        }

        [TestMethod]
        public void Win32_SystemDriver_StartMode_Is_String()
        {
            const string PropertyName = "StartMode";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
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
        public void Win32_SystemDriver_StartName_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_SystemDriver"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "StartName");
            }
        }

        [TestMethod]
        public void Win32_SystemDriver_StartName_Is_String()
        {
            const string PropertyName = "StartName";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
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
        public void Win32_SystemDriver_State_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_SystemDriver"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "State");
            }
        }

        [TestMethod]
        public void Win32_SystemDriver_State_Is_String()
        {
            const string PropertyName = "State";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
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
        public void Win32_SystemDriver_Status_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_SystemDriver"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "Status");
            }
        }

        [TestMethod]
        public void Win32_SystemDriver_Status_Is_String()
        {
            const string PropertyName = "Status";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
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
        public void Win32_SystemDriver_SystemCreationClassName_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_SystemDriver"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "SystemCreationClassName");
            }
        }

        [TestMethod]
        public void Win32_SystemDriver_SystemCreationClassName_Is_String()
        {
            const string PropertyName = "SystemCreationClassName";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
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
        public void Win32_SystemDriver_SystemName_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_SystemDriver"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "SystemName");
            }
        }

        [TestMethod]
        public void Win32_SystemDriver_SystemName_Is_String()
        {
            const string PropertyName = "SystemName";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
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
        public void Win32_SystemDriver_TagId_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_SystemDriver"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "TagId");
            }
        }

        [TestMethod]
        public void Win32_SystemDriver_TagId_Is_UInt32()
        {
            const string PropertyName = "TagId";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_SystemDriver"))
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
	}
}