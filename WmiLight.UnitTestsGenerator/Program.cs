using System;
using System.Diagnostics;
using System.Management;

namespace WmiLight.UnitTestsGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Output_Folder = Environment.CurrentDirectory;

            Console.WriteLine($"Generating tests at \"{Output_Folder}\"");

            var classes = new List<Tuple<string, string, string[]>>()
            {
                // path, Class, ignored properties
                new Tuple<string, string, string[]>( "root\\cimv2","CIM_Memory", [] ),
                new Tuple<string, string, string[]>( "root\\cimv2","Win32_Battery" , [] ),
                new Tuple<string, string, string[]>( "root\\cimv2","Win32_BIOS" , []),
                new Tuple<string, string, string[]>( "root\\cimv2","Win32_BootConfiguration" , []),
                new Tuple<string, string, string[]>( "root\\cimv2","Win32_COMClass" , []),
                new Tuple<string, string, string[]>( "root\\cimv2","Win32_ComputerSystem" , []),
                new Tuple<string, string, string[]>( "root\\cimv2","Win32_ComputerSystemProduct" , []),
                new Tuple<string, string, string[]>( "root\\cimv2","Win32_Desktop" , []),
                new Tuple<string, string, string[]>( "root\\cimv2","Win32_DiskDrive" , []),
                new Tuple<string, string, string[]>( "root\\cimv2","Win32_Group" , []),
                new Tuple<string, string, string[]>( "root\\cimv2","Win32_Keyboard" , []),
                new Tuple<string, string, string[]>( "root\\cimv2","Win32_NetworkAdapter" , []),
                new Tuple<string, string, string[]>( "root\\cimv2","Win32_NetworkAdapterConfiguration" , []),
                new Tuple<string, string, string[]>( "root\\cimv2","Win32_OperatingSystem" , ["FreePhysicalMemory", "FreeVirtualMemory", "LocalDateTime", "FreeSpaceInPagingFiles", ]),
                new Tuple<string, string, string[]>( "root\\cimv2","Win32_Printer" , []),
                new Tuple<string, string, string[]>( "root\\cimv2","Win32_PhysicalMemory" , []),
                new Tuple<string, string, string[]>( "root\\cimv2","Win32_Process" , ["KernelModeTime"]),
                new Tuple<string, string, string[]>( "root\\cimv2","Win32_Processor" , ["KernelModeTime", "LoadPercentage"]),
                new Tuple<string, string, string[]>( "root\\cimv2","Win32_Registry" , ["KernelModeTime", "LoadPercentage"]),
                new Tuple<string, string, string[]>( "root\\cimv2","Win32_Service" , []),
                new Tuple<string, string, string[]>( "root\\cimv2","Win32_Share" , []),
                new Tuple<string, string, string[]>( "root\\cimv2","Win32_SystemDriver" , []),
                new Tuple<string, string, string[]>( "root\\cimv2","Win32_UserAccount" , []),
                new Tuple<string, string, string[]>( "root\\cimv2","Win32_Volume" , ["FreeSpace"]),
                new Tuple<string, string, string[]>( "root\\cimv2","Win32_VideoController" , []),
                new Tuple<string, string, string[]>( "root\\cimv2","Win32_WinSAT" , []),                

                new Tuple<string, string, string[]>( "root\\StandardCimv2","__Provider" , []),
                new Tuple<string, string, string[]>( "root\\StandardCimv2","CIM_NetworkPort" , []),
                new Tuple<string, string, string[]>( "root\\StandardCimv2","MSFT_NetAdapter" , []),
            };


            foreach ((string WMI_NAMESPACE, string WMI_CLASS, string[] propsToNotCompare) in classes)
            {
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(Output_Folder, $"{WMI_CLASS}.cs")))
                {
                    outputFile.Write($"using System.Management;\r\n\r\nnamespace WmiLight.UnitTests\r\n{{\r\n\t[TestClass]\r\n\tpublic class {WMI_CLASS}\r\n\t{{");

                    ManagementScope scope = new ManagementScope(WMI_NAMESPACE);
                    scope.Connect();

                    ObjectQuery query = new ObjectQuery($"SELECT * FROM {WMI_CLASS}");
                    ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);

                    foreach (var wmiObject in searcher.Get())
                    {
                        foreach (var prop in wmiObject.Properties)
                        {
                            var value = prop.Value;

                            if (value != null)
                            {
                                if (!propsToNotCompare.Contains(prop.Name))
                                {
                                    outputFile.Write(@$"
        [TestMethod]
        public void {WMI_CLASS}_{prop.Name}_Is_Equal_To_System_Management()
        {{
            using (ManagementBaseObject msObject = WmiHelper.GetFirstSystemManagementObjects(@""{WMI_NAMESPACE}"", ""{WMI_CLASS}""))
            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@""{WMI_NAMESPACE}"", ""{WMI_CLASS}""))
            {{
                WmiAssert.AreEqual<{value.GetType()}>(msObject, wmiObject, ""{prop.Name}"");
            }}
        }}
"); 
                                }

                                outputFile.Write(@$"
        [TestMethod]
        public void {WMI_CLASS}_{prop.Name}_Is_{value.GetType().Name.Split('.').Last().Replace("[]", "Array")}()
        {{
            const string PropertyName = ""{prop.Name}"";

            using (WmiObject wmiObject = WmiHelper.GetFirstWmiLightObjects(@""{WMI_NAMESPACE}"", ""{WMI_CLASS}""))
            {{
                object indexerValue = wmiObject[PropertyName];

                if (indexerValue != null)
                    Assert.IsInstanceOfType<{value.GetType()}>(indexerValue, $""{{nameof(WmiObject)}}[\""{{PropertyName}}\""] returned an unexpected type."");

                object noneGenericValue = wmiObject.GetPropertyValue(PropertyName);

                if (noneGenericValue != null)
                    Assert.IsInstanceOfType<{value.GetType()}>(noneGenericValue, $""{{nameof(WmiObject)}}.{{nameof(wmiObject.GetPropertyValue)}}(\""{{PropertyName}}\"") returned an unexpected type."");

                {value.GetType()} genericValue = wmiObject.GetPropertyValue<{value.GetType()}>(PropertyName);
            }}
        }}
");
                            }
                        }

                        break;
                    }

                    outputFile.Write("\t}\r\n}");
                }
            }

        }
    }
}
