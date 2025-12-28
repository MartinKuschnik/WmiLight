namespace WmiLight.UnitTests
{
    [TestClass]
    public class Win32_Product
    {
        [TestMethod]
        public void Win32_Product_Timeouts_With_Tiny_Timeout()
        {
            Assert.ThrowsException<TimeoutException>(() => {

                using (WmiConnection conncetion = new WmiConnection())
                {
                    foreach (WmiObject process in conncetion.CreateQuery("SELECT * FROM Win32_Product", TimeSpan.FromMilliseconds(100)))
                    {
                        Assert.Fail();
                    }
                }
            });
        }

        [TestMethod]
        public void Win32_Product_Does_Not_Timeouts_Without_Timeout()
        {
            using (WmiConnection conncetion = new WmiConnection())
            {
                foreach (WmiObject process in conncetion.CreateQuery("SELECT * FROM Win32_Product"))
                {
                    return; // success
                }
            }
        }
    }
}