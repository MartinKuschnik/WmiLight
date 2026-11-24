namespace WmiLight.UnitTests
{
    [TestClass]
    public class Win32_SecurityDescriptorHelper
    {
        [TestMethod]
        public void Win32_SecurityDescriptorHelper_SetPropertyValue_ByteArray_Can_Be_Read_Back()
        {
            using (WmiConnection connection = new WmiConnection())
            using (WmiMethod method = connection.GetMethod("Win32_SecurityDescriptorHelper", "BinarySDToSDDL"))
            using (WmiMethodParameters inParams = method.CreateInParameters())
            {
                byte[] bytes = [0x00, 0x01, 0x7F, 0x80, 0xFF];

                inParams.SetPropertyValue("BinarySD", bytes);

                byte[] readBack = inParams.GetPropertyValue<byte[]>("BinarySD");

                CollectionAssert.AreEqual(bytes, readBack, "Round-tripped uint8[] values should match.");
            }
        }

        [TestMethod]
        public void Win32_SecurityDescriptorHelper_SetPropertyValue_WmiObject_Can_Be_Read_Back()
        {
            using (WmiConnection connection = new WmiConnection())
            using (WmiMethod method = connection.GetMethod("Win32_SecurityDescriptorHelper", "Win32SDToSDDL"))
            using (WmiMethodParameters inParams = method.CreateInParameters())
            using (WmiObject descriptor = connection.CreateInstance("Win32_SecurityDescriptor"))
            using (WmiObject owner = connection.CreateInstance("Win32_Trustee"))
            {
                owner.SetPropertyValue("Name", "Everyone");

                descriptor.SetPropertyValue("Owner", owner);

                inParams.SetPropertyValue("Descriptor", descriptor);

                using (WmiObject readBack = inParams.GetPropertyValue<WmiObject>("Descriptor"))
                using (WmiObject readBackOwner = readBack.GetPropertyValue<WmiObject>("Owner"))
                {
                    Assert.AreEqual("Win32_SecurityDescriptor", readBack.Class, "Round-tripped embedded object should keep its class.");
                    Assert.AreEqual("Everyone", readBackOwner.GetPropertyValue<string>("Name"), "Round-tripped embedded object values should match.");
                }
            }
        }
    }
}
