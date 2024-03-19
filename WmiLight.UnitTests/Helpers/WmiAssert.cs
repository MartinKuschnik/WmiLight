using System.Collections;
using System.Management;

namespace WmiLight.UnitTests
{
    internal static class WmiAssert
    {
        internal static void AreEqual<T>(ManagementBaseObject msObject, WmiObject wmiObject, string propertyName)
        {
            if (typeof(T).IsArray)
            {
                CollectionAssert.AreEqual((T)msObject.GetPropertyValue(propertyName) as ICollection, wmiObject.GetPropertyValue<T>(propertyName) as ICollection);
            }
            else
            {
                Assert.AreEqual((T)msObject.GetPropertyValue(propertyName), wmiObject.GetPropertyValue<T>(propertyName));
            }
        }
    }
}
