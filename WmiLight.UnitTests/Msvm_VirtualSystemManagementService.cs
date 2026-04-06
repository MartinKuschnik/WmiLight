namespace WmiLight.UnitTests
{
    [TestClass]
    public class Msvm_VirtualSystemManagementService
    {
        [TestMethod]
        public void GetSummaryInformation_SettingData_ReferenceArray_Can_Be_Read_Back()
        {
            const string WmiNamespace = @"root\virtualization\v2";
            const string WmiClassName = "Msvm_VirtualSystemManagementService";
            const string MethodName = "GetSummaryInformation";
            const string ParameterName = "SettingData";

            using WmiConnection connection = new(WmiNamespace);

            WmiObject instance;

            try
            {
                instance = WmiHelper.GetFirstWmiLightObjects(connection, WmiClassName);
            }
            catch
            {
                Assert.Inconclusive("Hyper-V namespace or class not available.");
                return;
            }

            using (instance)
            using (WmiMethod method = instance.GetMethod(MethodName))
            using (WmiMethodParameters inParams = method.CreateInParameters())
            {
                string[] testPaths = [@"\\server\root\virtualization\v2:Path1", @"\\server\root\virtualization\v2:Path2"];
                inParams.SetPropertyValue(ParameterName, testPaths);

                // Before the fix, this throws NotSupportedException:
                // "CimType 'Reference[]' currently not supported."
                object nonGenericValue = inParams.GetPropertyValue(ParameterName);

                Assert.IsInstanceOfType<string[]>(nonGenericValue, "Non-generic GetPropertyValue should return string[].");

                string[] genericValue = inParams.GetPropertyValue<string[]>(ParameterName);

                CollectionAssert.AreEqual(testPaths, genericValue, "Round-tripped Reference[] values should match.");
            }
        }
    }
}
