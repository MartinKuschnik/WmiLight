namespace WmiLight.UnitTests
{
    [TestClass]
    public class Win32_PnPEntity
    {
        [TestMethod]
        public void Win32_PnPEntity_GetDeviceProperties_Can_Be_Called_With_String_Array_Parameter()
        {
            using (WmiConnection conncetion = new WmiConnection())
            {
                using (WmiMethod method = conncetion.GetMethod("Win32_PnPEntity", "GetDeviceProperties"))
                {
                    foreach (WmiObject pnpEntity in conncetion.CreateQuery("SELECT * FROM Win32_PnPEntity"))
                    {
                        uint result = pnpEntity.ExecuteMethod<uint>(method, out WmiMethodParameters outParameters);

                        Assert.AreEqual(0u, outParameters.GetPropertyValue<uint>("ReturnValue"));
                        Assert.AreEqual(result, outParameters.GetPropertyValue<uint>("ReturnValue"));

                        WmiObject[] allDeviceProperties = outParameters.GetPropertyValue<WmiObject[]>("deviceProperties");

                        if (allDeviceProperties.Length > 2)
                        {
                            WmiMethodParameters inParameters = method.CreateInParameters();

                            inParameters.SetPropertyValue("devicePropertyKeys", allDeviceProperties.Take(2).Select(x => x.GetPropertyValue<string>("KeyName")).ToArray());

                            result = pnpEntity.ExecuteMethod<uint>(method, inParameters, out outParameters);

                            Assert.AreEqual(0u, outParameters.GetPropertyValue<uint>("ReturnValue"));
                            Assert.AreEqual(result, outParameters.GetPropertyValue<uint>("ReturnValue"));

                            WmiObject[] requestedDeviceProperties = outParameters.GetPropertyValue<WmiObject[]>("deviceProperties");

                            // 2 properties expected
                            Assert.AreEqual(2, requestedDeviceProperties.Length);

                            return;
                        }
                    }

                    // if no matching Win32_PnPEntity found
                    Assert.Inconclusive();
                }
            }
        }

        [TestMethod]
        public void Win32_PnPEntity_GetDeviceProperties_Can_Be_Called_Null_Parameter()
        {
            using (WmiConnection conncetion = new WmiConnection())
            {
                using (WmiMethod method = conncetion.GetMethod("Win32_PnPEntity", "GetDeviceProperties"))
                {
                    foreach (WmiObject pnpEntity in conncetion.CreateQuery("SELECT * FROM Win32_PnPEntity"))
                    {
                        WmiMethodParameters inParameters = method.CreateInParameters();

                        inParameters.SetPropertyValue("devicePropertyKeys", null as string[]);

                        uint result = pnpEntity.ExecuteMethod<uint>(method, inParameters, out WmiMethodParameters outParameters);

                        Assert.AreEqual(0u, outParameters.GetPropertyValue<uint>("ReturnValue"));
                        Assert.AreEqual(result, outParameters.GetPropertyValue<uint>("ReturnValue"));

                        WmiObject[] allDeviceProperties = outParameters.GetPropertyValue<WmiObject[]>("deviceProperties");

                        Assert.IsTrue(allDeviceProperties.Length > 0);

                        // Test done!
                        return;
                    }

                    // if no matching Win32_PnPEntity found
                    Assert.Inconclusive();
                }
            }
        }
    }
}