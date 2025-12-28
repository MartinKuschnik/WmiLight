namespace WmiLight.UnitTests
{
    [TestClass]
    public class Win32_Product
    {
        /// <summary>
        /// Verifies that a TimeoutException is thrown when the enumerator timeout is too short.
        /// </summary>
        [TestMethod]
        public void Win32_Product_Time_Out_With_Tiny_Timeout()
        {
            Assert.ThrowsException<TimeoutException>(() => {

                using (WmiConnection connection = new WmiConnection())
                {
                    foreach (WmiObject _ in connection.CreateQuery("SELECT * FROM Win32_Product", TimeSpan.FromMilliseconds(100)))
                    {
                        Assert.Fail("Should not reach here due to timeout.");
                    }
                }
            });
        }

        /// <summary>
        /// Verifies that the query completes successfully without a timeout.
        /// </summary>
        [TestMethod]
        public void Win32_Product_Does_Not_Time_Out_Without_Timeout()
        {
            using (WmiConnection connection = new WmiConnection())
            {
                bool productFound = false;

                foreach (WmiObject _ in connection.CreateQuery("SELECT * FROM Win32_Product"))
                {
                    productFound = true;
                    break;
                }

                Assert.IsTrue(productFound, "At least one product should be found.");
            }
        }
    }
}