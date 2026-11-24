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
    }
}
