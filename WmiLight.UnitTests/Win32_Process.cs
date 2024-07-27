﻿namespace WmiLight.UnitTests
{
    [TestClass]
    public class Win32_Process
    {
        [TestMethod]
        public void Win32_Process_GetOwner_Can_Be_Called()
        {
            using (WmiConnection conncetion = new WmiConnection())
            {
                using (WmiMethod method = conncetion.GetMethod("Win32_Process", "GetOwner"))
                {
                    using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(conncetion, "Win32_Process"))
                    {
                        uint result = wmiObject.ExecuteMethod<uint>(method, out WmiMethodParameters outParameters);

                        Assert.AreEqual(result, outParameters.GetPropertyValue<uint>("ReturnValue"));
                    }
                }
            }
        }
    }
}