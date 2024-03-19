using System.Management;

namespace WmiLight.UnitTests
{
    internal static class WmiHelper
    {
        internal static ManagementBaseObject GetFirstSystemManagementObjects(string path, string @class)
        {
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(path, $"SELECT * FROM {@class}"))
            {
                using (ManagementObjectCollection collection = searcher.Get())
                {
                    using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = collection.GetEnumerator())
                    {
                        enumerator.MoveNext();

                        return enumerator.Current;
                    }
                }
            }
        }
        internal static WmiObject GetFirstWmiLightObjects(string path, string @class)
        {
            using (WmiConnection conncetion = new WmiConnection(path))
            {
                using (WmiObjectEnumerator enumerator = conncetion.ExecuteQuery(new WmiQuery(conncetion, $"SELECT * FROM {@class}")))
                {
                    enumerator.MoveNext();

                    return enumerator.Current;
                }
            }
        }
    }
}
