using System.Management;

namespace WmiLight.UnitTests
{
    [TestClass]
    public class Msvm_VirtualSystemCapabilities
    {
        [TestMethod]
        public void Msvm_SummaryInformation_Snapshots_Is_WmiObjectArray()
        {
            const string PropertyName = "Snapshots";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@"root\virtualization\v2", "Msvm_SummaryInformation"))
            {
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<WmiObject[]>(indexerValue, $"{nameof(WmiObject)}[\"{PropertyName}\"] returned an unexpected type.");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<WmiObject[]>(noneGenericValue, $"{nameof(WmiObject)}.{nameof(wmiObject.GetPropertyValue)}(\"{PropertyName}\") returned an unexpected type.");

                WmiObject[] genericValue = wmiObject.GetPropertyValue<WmiObject[]>(PropertyName);
            }
        }

    }
}
