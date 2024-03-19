using System.Collections;
using System.Management;

namespace WmiLight.UnitTests
{
    internal static class WmiAssert
    {
        internal static void AreEqual<T>(ManagementBaseObject msObject, WmiObject wmiObject, string propertyName)
        {
            object msValue = msObject.GetPropertyValue(propertyName);
            object wmiValue = wmiObject.GetPropertyValue(propertyName);

            if (msValue == null || wmiValue == null)
            {
                Assert.AreEqual(msValue, wmiValue);
            }
            else if (typeof(T).IsArray)
            {
                CollectionAssert.AreEqual(msValue as ICollection, wmiValue as ICollection);
            }
            else
            {
                Assert.AreEqual(msValue, wmiValue);
            }
        }
    }
}
