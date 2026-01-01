using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WmiLight.UnitTests
{
    [TestClass]
    public class ExceptionTests
    {
        [TestMethod]
        public void InvalidNamespaceException_Is_Thrown()
        {
            InvalidNamespaceException ex = Assert.ThrowsException<InvalidNamespaceException>(() => {

                using (WmiConnection connection = new WmiConnection("INVALID"))
                {
                    connection.Open();
                }
            });

            Assert.AreEqual("INVALID", ex.Namespace, "Query is different.");
        }

        [TestMethod]
        public void InvalidClassException_Is_Thrown()
        {
            Assert.ThrowsException<InvalidClassException>(() => {

                using (WmiConnection connection = new WmiConnection())
                {
                    foreach (WmiObject _ in connection.CreateQuery("SELECT * FROM INVALID_CLASS_123"))
                    {
                        Assert.Fail("Should not reach here.");
                    }
                }
            });
        }

        [TestMethod]
        public void InvalidQueryException_Is_Thrown_Without_A_Query()
        {
            Assert.ThrowsException<InvalidQueryException>(() => {

                using (WmiConnection connection = new WmiConnection())
                {
                    foreach (WmiObject _ in connection.CreateQuery("THIS IS NOT VALID"))
                    {
                        Assert.Fail("Should not reach here.");
                    }
                }
            });

            // no DirectRead -> Query not set 
        }

        [TestMethod]
        public void InvalidQueryException_Is_Thrown_Witt_A_Query()
        {
            InvalidQueryException ex = Assert.ThrowsException<InvalidQueryException>(() => {

                using (WmiConnection connection = new WmiConnection())
                {
                    foreach (WmiObject _ in connection.CreateQuery("THIS IS NOT VALID", EnumeratorBehaviorOption.DirectRead))
                    {
                        Assert.Fail("Should not reach here.");
                    }
                }
            });

            // DirectRead -> Query not set 
            Assert.AreEqual("THIS IS NOT VALID", ex.Query, "Query is different.");
        }

        [TestMethod]
        public void InvalidParameterException_Is_Thrown_For_WBEM_E_INVALID_METHOD_PARAMETERS()
        {
            Assert.ThrowsException<InvalidParameterException>(() => {

                using (WmiConnection connection = new WmiConnection(@"root\Microsoft\Windows\Storage"))
                using (WmiMethod method = connection.GetMethod("MSFT_Volume", "GetSupportedFileSystems"))
                {
                    // Don't set required parameters and try to execute                    
                    connection.ExecuteMethod(method, null, out WmiMethodParameters outParameters);

                    Assert.Fail("Should not reach here.");
                }
            });
        }

        [TestMethod]
        public void InvalidParameterException_Is_Thrown_For_WBEM_E_INVALID_PARAMETER()
        {
            InvalidParameterException ex = Assert.ThrowsException<InvalidParameterException>(() =>
            {
                using (WmiConnection connection = new WmiConnection())
                using (WmiMethod method = connection.GetMethod("Win32_Process", "Create"))
                {
                    // Don't set required parameters and try to execute                    
                    connection.ExecuteMethod(method, null, out WmiMethodParameters outParameters);

                    Assert.Fail("Should not reach here.");
                }
            });
        }
    }
}
