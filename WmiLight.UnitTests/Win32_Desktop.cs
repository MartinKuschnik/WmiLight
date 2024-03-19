using System.Management;

namespace WmiLight.UnitTests
{
	[TestClass]
	public class Win32_Desktop
	{
        [TestMethod]
        public void Win32_Desktop_BorderWidth_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Desktop"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Desktop"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "BorderWidth");
            }
        }

        [TestMethod]
        public void Win32_Desktop_BorderWidth_Is_UInt32()
        {
            const string PropertyName = "BorderWidth";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Desktop"))
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
        public void Win32_Desktop_CursorBlinkRate_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Desktop"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Desktop"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "CursorBlinkRate");
            }
        }

        [TestMethod]
        public void Win32_Desktop_CursorBlinkRate_Is_UInt32()
        {
            const string PropertyName = "CursorBlinkRate";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Desktop"))
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
        public void Win32_Desktop_DragFullWindows_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Desktop"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Desktop"))
            {
                WmiAssert.AreEqual<System.Boolean>(msObject, wmiObject, "DragFullWindows");
            }
        }

        [TestMethod]
        public void Win32_Desktop_DragFullWindows_Is_Boolean()
        {
            const string PropertyName = "DragFullWindows";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Desktop"))
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
        public void Win32_Desktop_IconTitleFaceName_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Desktop"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Desktop"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "IconTitleFaceName");
            }
        }

        [TestMethod]
        public void Win32_Desktop_IconTitleFaceName_Is_String()
        {
            const string PropertyName = "IconTitleFaceName";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Desktop"))
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
        public void Win32_Desktop_IconTitleSize_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Desktop"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Desktop"))
            {
                WmiAssert.AreEqual<System.UInt32>(msObject, wmiObject, "IconTitleSize");
            }
        }

        [TestMethod]
        public void Win32_Desktop_IconTitleSize_Is_UInt32()
        {
            const string PropertyName = "IconTitleSize";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Desktop"))
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
        public void Win32_Desktop_IconTitleWrap_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Desktop"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Desktop"))
            {
                WmiAssert.AreEqual<System.Boolean>(msObject, wmiObject, "IconTitleWrap");
            }
        }

        [TestMethod]
        public void Win32_Desktop_IconTitleWrap_Is_Boolean()
        {
            const string PropertyName = "IconTitleWrap";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Desktop"))
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
        public void Win32_Desktop_Name_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Desktop"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Desktop"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "Name");
            }
        }

        [TestMethod]
        public void Win32_Desktop_Name_Is_String()
        {
            const string PropertyName = "Name";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Desktop"))
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
        public void Win32_Desktop_Pattern_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Desktop"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Desktop"))
            {
                WmiAssert.AreEqual<System.String>(msObject, wmiObject, "Pattern");
            }
        }

        [TestMethod]
        public void Win32_Desktop_Pattern_Is_String()
        {
            const string PropertyName = "Pattern";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Desktop"))
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
        public void Win32_Desktop_ScreenSaverActive_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Desktop"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Desktop"))
            {
                WmiAssert.AreEqual<System.Boolean>(msObject, wmiObject, "ScreenSaverActive");
            }
        }

        [TestMethod]
        public void Win32_Desktop_ScreenSaverActive_Is_Boolean()
        {
            const string PropertyName = "ScreenSaverActive";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Desktop"))
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
        public void Win32_Desktop_WallpaperStretched_Is_Equal_To_System_Management()
        {
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@"root\cimv2", "Win32_Desktop"))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Desktop"))
            {
                WmiAssert.AreEqual<System.Boolean>(msObject, wmiObject, "WallpaperStretched");
            }
        }

        [TestMethod]
        public void Win32_Desktop_WallpaperStretched_Is_Boolean()
        {
            const string PropertyName = "WallpaperStretched";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\cimv2", "Win32_Desktop"))
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