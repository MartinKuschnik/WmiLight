using System.Management;

namespace WmiLight.UnitTests
{
	[TestClass]
	public class __Provider
	{
        [TestMethod]
        public void __Provider_CLSID_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "__Provider"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "__Provider"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "CLSID");
            }
        }

        [TestMethod]
        public void __Provider_CLSID_Is_String()
        {
            const string PropertyName = "CLSID";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "__Provider"))
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
        public void __Provider_HostingModel_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "__Provider"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "__Provider"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "HostingModel");
            }
        }

        [TestMethod]
        public void __Provider_HostingModel_Is_String()
        {
            const string PropertyName = "HostingModel";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "__Provider"))
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
        public void __Provider_ImpersonationLevel_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "__Provider"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "__Provider"))
            {
                WmiAssert.AreEqual<System.Int32>(msObject, wmiObject, "ImpersonationLevel");
            }
        }

        [TestMethod]
        public void __Provider_ImpersonationLevel_Is_Int32()
        {
            const string PropertyName = "ImpersonationLevel";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "__Provider"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<System.Int32>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.Int32>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.Int32 genericValue = wmiObject.GetPropertyValue<System.Int32>(PropertyName);
            }
        }

        [TestMethod]
        public void __Provider_InitializationReentrancy_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "__Provider"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "__Provider"))
            {
                WmiAssert.AreEqual<System.Int32>(msObject, wmiObject, "InitializationReentrancy");
            }
        }

        [TestMethod]
        public void __Provider_InitializationReentrancy_Is_Int32()
        {
            const string PropertyName = "InitializationReentrancy";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "__Provider"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<System.Int32>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<System.Int32>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                System.Int32 genericValue = wmiObject.GetPropertyValue<System.Int32>(PropertyName);
            }
        }

        [TestMethod]
        public void __Provider_Name_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "__Provider"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "__Provider"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "Name");
            }
        }

        [TestMethod]
        public void __Provider_Name_Is_String()
        {
            const string PropertyName = "Name";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "__Provider"))
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
        public void __Provider_PerLocaleInitialization_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "__Provider"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "__Provider"))
            {
                WmiAssert.AreEqual<System.Boolean>(msObject, wmiObject, "PerLocaleInitialization");
            }
        }

        [TestMethod]
        public void __Provider_PerLocaleInitialization_Is_Boolean()
        {
            const string PropertyName = "PerLocaleInitialization";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "__Provider"))
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
        public void __Provider_PerUserInitialization_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "__Provider"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "__Provider"))
            {
                WmiAssert.AreEqual<System.Boolean>(msObject, wmiObject, "PerUserInitialization");
            }
        }

        [TestMethod]
        public void __Provider_PerUserInitialization_Is_Boolean()
        {
            const string PropertyName = "PerUserInitialization";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "__Provider"))
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
        public void __Provider_Pure_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "__Provider"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "__Provider"))
            {
                WmiAssert.AreEqual<System.Boolean>(msObject, wmiObject, "Pure");
            }
        }

        [TestMethod]
        public void __Provider_Pure_Is_Boolean()
        {
            const string PropertyName = "Pure";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "__Provider"))
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
        public void __Provider_Version_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\StandardCimv2", "__Provider"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "__Provider"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "Version");
            }
        }

        [TestMethod]
        public void __Provider_Version_Is_UInt32()
        {
            const string PropertyName = "Version";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\StandardCimv2", "__Provider"))
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