namespace WmiLight
{
    using System;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using WmiLight.Wbem;

    #region Description
    /// <summary>
    /// The <see cref="HResult"/> data type is a 32-bit value is used to describe an error or warning.
    /// </summary>
    /// <remarks>
    ///                                                                                                                                                                                             <para />  
    ///  The HRESULT numbering space has the following internal structure. 
    ///  Any protocol that uses NTSTATUS values on the wire is responsible for stating the order in which the bytes are placed on the wire.
    ///                       1                   2                   3
    ///   0 1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6 7 8 9 0 1
    ///  +-+-+-+-+-+---------------------+-------------------------------+
    ///  |S|R|C|N|r|    Facility         |               Code            |
    ///  +-+-+-+-+-+---------------------+-------------------------------+
    ///                                                                                                                                                                                              <para />                                                                                                                         
    ///  S (1 bit): Severity. If set, indicates a failure result. If clear, indicates a success result.
    ///  R (1 bit): Reserved. If the N bit is clear, this bit MUST be set to 0. If the N bit is set, this bit is defined by the NTSTATUS numbering space.
    ///  C (1 bit): Customer. This bit specifies if the value is customer-defined or Microsoft-defined. The bit is set for customer-defined values and clear for Microsoft-defined values.
    ///  N (1 bit): If set, indicates that the error code is an NTSTATUS value (as specified at http://msdn.microsoft.com/en-us/library/cc231200.aspx), except that this bit is set.
    ///  r (1 bit): Reserved. SHOULD be set to 0.
    ///                                                                                                                                                                                              <para />      
    ///      +-----------------------------------------------------------+
    ///      |   The following HRESULT codes have the X bit set to 1:    |
    ///      +-----------------------------------------------------------+
    ///      |   Name                               | Value              |
    ///      +-----------------------------------------------------------+
    ///      |   TRK_S_OUT_OF_SYNC                  | 0x0DEAD100         |
    ///      |   TRK_VOLUME_NOT_FOUND               | 0x0DEAD102         |
    ///      |   TRK_VOLUME_NOT_OWNED               | 0x0DEAD103         |
    ///      |   TRK_S_NOTIFICATION_QUOTA_EXCEEDED  | 0x0DEAD107         |
    ///      |   TRK_E_NOT_FOUND                    | 0x8DEAD01B         |
    ///      |   TRK_E_VOLUME_QUOTA_EXCEEDED        | 0x8DEAD01C         |
    ///      |   TRK_SERVER_TOO_BUSY                | 0x8DEAD01E         |
    ///      +-----------------------------------------------------------+   
    ///                                                                                                                                                                                              <para />  
    ///  Facility (11 bits): An indicator of the source of the error. New facilities are occasionally added by Microsoft.
    ///                                                                                                                                                                                              <para />  
    ///      +--------------------------------------------------------------------------------------------------------------------------------------+
    ///      |   The following table lists the currently defined facility codes:                                                                    |
    ///      +--------------------------------------------------------------------------------------------------------------------------------------+
    ///      |   Name                               | Value      | Meaning                                                                          |
    ///      +--------------------------------------------------------------------------------------------------------------------------------------+
    ///      |   FACILITY_NULL                      |  1         | The default facility code.                                                       |
    ///      |   FACILITY_RPC                       |  2         | The source of the error code is an RPC subsystem.                                |
    ///      |   FACILITY_DISPATCH                  |  3         | The source of the error code is a COM Dispatch.                                  |
    ///      |   FACILITY_STORAGE                   |  4         | The source of the error code is OLE Storage.                                     |
    ///      |   FACILITY_ITF                       |  5         | The source of the error code is COM/OLE Interface management.                    |
    ///      |   FACILITY_WIN32                     |  6         | This region is reserved to map undecorated error codes into HRESULTs.            |
    ///      |   FACILITY_WINDOWS                   |  7         | The source of the error code is the Windows subsystem.                           |
    ///      |   FACILITY_SECURITY                  |  8         | The source of the error code is the Security API layer.                          |
    ///      |   FACILITY_SSPI                      |  9         | The source of the error code is the Security API layer.                          |
    ///      |   FACILITY_CONTROL                   | 10         | The source of the error code is the control mechanism.                           |
    ///      |   FACILITY_CERT                      | 11         | The source of the error code is a certificate client or server?                  |
    ///      |   FACILITY_INTERNET                  | 12         | The source of the error code is Wininet related.                                 |
    ///      |   FACILITY_MEDIASERVER               | 13         | The source of the error code is the Windows Media Server.                        |
    ///      |   FACILITY_MSMQ                      | 14         | The source of the error code is the Microsoft Message Queue.                     |
    ///      |   FACILITY_SETUPAPI                  | 15         | The source of the error code is the Setup API.                                   |
    ///      |   FACILITY_SCARD                     | 16         | The source of the error code is the Smart-card subsystem.                        |
    ///      |   FACILITY_COMPLUS                   | 17         | The source of the error code is COM+.                                            |
    ///      |   FACILITY_AAF                       | 18         | The source of the error code is the Microsoft agent.                             |
    ///      |   FACILITY_URT                       | 19         | The source of the error code is .NET CLR.                                        |
    ///      |   FACILITY_ACS                       | 20         | The source of the error code is the audit collection service.                    |
    ///      |   FACILITY_DPLAY                     | 21         | The source of the error code is Direct Play.                                     |
    ///      |   FACILITY_UMI                       | 22         | The source of the error code is the ubiquitous memoryintrospection service.      |
    ///      |   FACILITY_SXS                       | 23         | The source of the error code is Side-by-side servicing.                          |
    ///      |   FACILITY_WINDOWS_CE                | 24         | The error code is specific to Windows CE.                                        |
    ///      |   FACILITY_HTTP                      | 25         | The source of the error code is HTTP support.                                    |
    ///      |   FACILITY_USERMODE_COMMONLOG        | 26         | The source of the error code is common Logging support.                          |
    ///      |   FACILITY_USERMODE_FILTER_MANAGER   | 31         | The source of the error code is the user mode filter manager.                    |
    ///      |   FACILITY_BACKGROUNDCOPY            | 32         | The source of the error code is background copy control.                         |
    ///      |   FACILITY_CONFIGURATION             | 33         | The source of the error code is configuration services.                          |
    ///      |   FACILITY_STATE_MANAGEMENT          | 34         | The source of the error code is state management services.                       |
    ///      |   FACILITY_METADIRECTORY             | 35         | The source of the error code is the Microsoft Identity Server.                   |
    ///      |   FACILITY_WINDOWSUPDATE             | 36         | The source of the error code is a Windows update.                                |
    ///      |   FACILITY_DIRECTORYSERVICE          | 37         | The source of the error code is Active Directory.                                |
    ///      |   FACILITY_GRAPHICS                  | 38         | The source of the error code is the graphics drivers.                            |
    ///      |   FACILITY_SHELL                     | 39         | The source of the error code is the user Shell.                                  |
    ///      |   FACILITY_TPM_SERVICES              | 40         | The source of the error code is the Trusted Platform Module services.            |
    ///      |   FACILITY_TPM_SOFTWARE              | 41         | The source of the error code is the Trusted Platform Module applications.        |
    ///      |   FACILITY_PLA                       | 48         | The source of the error code is Performance Logs and Alerts.                     |
    ///      |   FACILITY_FVE                       | 49         | The source of the error code is Full volume encryption.                          |
    ///      |   FACILITY_FWP                       | 50         | The source of the error code is the Firewall Platform.                           |
    ///      |   FACILITY_WINRM                     | 51         | The source of the error code is the Windows Resource Manager.                    |
    ///      |   FACILITY_NDIS                      | 52         | The source of the error code is the Network Driver Interface.                    |
    ///      |   FACILITY_USERMODE_HYPERVISOR       | 53         | The source of the error code is the Usermode Hypervisor components.              |
    ///      |   FACILITY_CMI                       | 54         | The source of the error code is the Configuration Management Infrastructure.     |
    ///      |   FACILITY_USERMODE_VIRTUALIZATION   | 55         | The source of the error code is the user mode virtualization subsystem.          |
    ///      |   FACILITY_USERMODE_VOLMGR           | 56         | The source of the error code is the user mode volume manager.                    |
    ///      |   FACILITY_BCD                       | 57         | The source of the error code is the Boot Configuration Database.                 |
    ///      |   FACILITY_USERMODE_VHD              | 58         | The source of the error code is user mode virtual hard disk support.             |
    ///      |   FACILITY_SDIAG                     | 60         | The source of the error code is System Diagnostics.                              |
    ///      |   FACILITY_WEBSERVICES               | 61         | The source of the error code is the Web Services.                                |
    ///      |   FACILITY_WINDOWS_DEFENDER          | 80         | The source of the error code is a Windows Defender component.                    |
    ///      |   FACILITY_OPC                       | 81         | The source of the error code is the open connectivity service.                   |
    ///      +--------------------------------------------------------------------------------------------------------------------------------------+
    ///                                                                                                                                                                                              <para />  
    ///  Code (2 bytes): The remainder of the error code.
    ///                                                                                                                                                                                              <para />  
    ///  <see url="http://msdn.microsoft.com/en-us/library/cc231198.aspx"/>
    /// </remarks>
    #endregion
    internal struct HResult : IEquatable<HResult>
    {
        #region Fields

        #region Description
        /// <summary>
        /// The value ob the <see cref="HResult"/> as <see cref="Int32"/>.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly int value;

        #endregion

        #region Constructors

        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="HResult"/> struct.
        /// </summary>
        /// <param name="intValue">The value ob the <see cref="HResult"/> as <see cref="Int32"/>.</param>
        #endregion
        public HResult(int intValue)
        {
            this.value = intValue;
        }

        #endregion

        #region Properties

        #region Description
        /// <summary>
        /// Gets a value indicating whether the <see cref="HResult"/> is an error.
        /// </summary>
        #endregion
        public bool Failed
        {
            get
            {
                return this.value < 0;
            }
        }

        #endregion

        #region Methods

        #region Explicit conversions

        #region Description
        /// <summary>
        /// Explicit conversion from <see cref="HResult"/> to <see cref="Exception"/>.
        /// </summary>
        /// <param name="hr">The <see cref="HResult"/> value to convert to <see cref="Exception"/>.</param>
        /// <returns>The <see cref="Exception"/> for the <see cref="HResult"/>.</returns>
        #endregion
        public static implicit operator Exception(HResult hr)
        {
            if (hr.Failed)
            {
                switch (hr)
                {
                    case (int)WbemStatus.WBEM_E_ACCESS_DENIED:
                        return new UnauthorizedAccessException("Access is denied.");

                    case (int)WbemStatus.WBEM_E_OUT_OF_MEMORY:
                        return new OutOfMemoryException("There was not enough memory to complete the operation.");

                    case (int)WbemStatus.WBEM_E_INVALID_PARAMETER:
                        return new InvalidParameterException(new HResultInfo(hr, "A specified parameter is not valid.", WbemStatus.WBEM_E_INVALID_PARAMETER.ToString()));

                    case (int)WbemStatus.WBEM_E_INVALID_NAMESPACE:
                        return new InvalidNamespaceException(new HResultInfo(hr, "The specified namespace did not exist on the server.", WbemStatus.WBEM_E_INVALID_NAMESPACE.ToString()));

                    case (int)WbemStatus.WBEM_E_TRANSPORT_FAILURE:
                        return new TransportFailureException(new HResultInfo(hr, "The remote procedure call (RPC) link between the current process and WMI failed.", WbemStatus.WBEM_E_TRANSPORT_FAILURE.ToString()));

                    case (int)WbemStatus.WBEM_E_LOCAL_CREDENTIALS:
                        return new LocalCredentialsException(new HResultInfo(hr, "Username, password, or authority can only used on a remote connection.", WbemStatus.WBEM_E_LOCAL_CREDENTIALS.ToString()));

                    case (int)WbemStatus.WBEM_E_FAILED:
                        return new WmiException(new HResultInfo(hr, "An unspecified error occurred.", WbemStatus.WBEM_E_FAILED.ToString()));

                    default:
                        return Marshal.GetExceptionForHR(hr.value);
                }
            }

            return null;
        }

        #region Description
        /// <summary>
        /// Explicit conversion from <see cref="HResult"/> to <see cref="Int32"/>.
        /// </summary>
        /// <param name="hr">The <see cref="HResult"/> value to convert to <see cref="Int32"/>.</param>
        /// <returns>The <see cref="Int32"/> value for the <see cref="HResult"/>.</returns>
        #endregion
        public static implicit operator int(HResult hr)
        {
            return hr.value;
        }

        #region Description
        /// <summary>
        /// Explicit conversion from <see cref="Enum"/> to <see cref="HResult"/>.
        /// </summary>
        /// <param name="enum">The <see cref="Enum"/> value to convert to <see cref="HResult"/>.</param>
        /// <returns>The <see cref="HResult"/> for the <see cref="Enum"/>.</returns>
        #endregion
        public static implicit operator HResult(Enum @enum)
        {
            return (HResult)@enum.GetHashCode();
        }

        #region Description
        /// <summary>
        /// Explicit conversion from <see cref="Int32"/> to <see cref="HResult"/>.
        /// </summary>
        /// <param name="intValue">The <see cref="Int32"/> value to convert to <see cref="HResult"/>.</param>
        /// <returns>The <see cref="Int32"/> value as <see cref="HResult"/>.</returns>
        #endregion
        public static implicit operator HResult(int intValue)
        {
            return new HResult(intValue);
        }

        #endregion

        #region == and !=

        #region Description
        /// <summary>
        /// Determines whether the specified <see cref="HResult"/> is equal to the other <see cref="HResult"/>.
        /// </summary>
        /// <param name="x">The one <see cref="HResult"/> to compare.</param>
        /// <param name="y">The other <see cref="HResult"/> to compare.</param>
        /// <returns>true if the specified <see cref="HResult"/> is equal to the other <see cref="HResult"/>; otherwise, false.</returns>
        #endregion
        public static bool operator ==(HResult x, HResult y)
        {
            return x.Equals(y);
        }

        #region Description
        /// <summary>
        /// Determines whether the specified <see cref="HResult"/> is unequal to the other <see cref="HResult"/>.
        /// </summary>
        /// <param name="x">The one <see cref="HResult"/> to compare.</param>
        /// <param name="y">The other <see cref="HResult"/> to compare.</param>
        /// <returns>true if the specified <see cref="HResult"/> is unequal to the other <see cref="HResult"/>; otherwise, false.</returns>
        #endregion
        public static bool operator !=(HResult x, HResult y)
        {
            return !x.Equals(y);
        }

        #region Description
        /// <summary>
        /// Determines whether a <see cref="HResult"/> is equal to a <see cref="Enum"/>.
        /// </summary>
        /// <param name="x">The one <see cref="HResult"/> to compare.</param>
        /// <param name="y">The other <see cref="Enum"/> to compare.</param>
        /// <returns>true if the <see cref="HResult"/> is equal to the <see cref="Enum"/>; otherwise, false.</returns>
        #endregion
        public static bool operator ==(HResult x, Enum y)
        {
            return x.Equals(y);
        }

        #region Description
        /// <summary>
        /// Determines whether a <see cref="HResult"/> is unequal to a <see cref="Enum"/>.
        /// </summary>
        /// <param name="x">The <see cref="HResult"/> to compare.</param>
        /// <param name="y">The <see cref="Enum"/> to compare.</param>
        /// <returns>true if the <see cref="HResult"/> is unequal to the <see cref="Enum"/>; otherwise, false.</returns>
        #endregion
        public static bool operator !=(HResult x, Enum y)
        {
            return !x.Equals(y);
        }

        #endregion

        #region Description
        /// <summary>
        /// Serves as a hash function.
        /// </summary>
        /// <returns>A hash code for the current <see cref="HResult"/>.</returns>
        #endregion
        public override int GetHashCode()
        {
            return this.value;
        }

        #region Description
        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="HResult"/>.
        /// </summary>
        /// <param name="obj">The object to compare with the current <see cref="HResult"/>.</param>
        /// <returns>true if the specified object is equal to the current <see cref="HResult"/>; otherwise, false.</returns>
        #endregion
        public override bool Equals(object obj)
        {
            if (obj != null && (obj is HResult || obj is int || obj is Enum))
            {
                return this.Equals((HResult)(int)obj);
            }

            return false;
        }

        #region Description
        /// <summary>
        /// Determines whether the specified <see cref="HResult"/> is equal to the current <see cref="HResult"/>.
        /// </summary>
        /// <param name="hr">The <see cref="HResult"/> to compare with the current <see cref="HResult"/>.</param>
        /// <returns>true if the specified <see cref="HResult"/> is equal to the current <see cref="HResult"/>; otherwise, false.</returns>
        #endregion
        public bool Equals(HResult hr)
        {
            return this.value == hr.value;
        }

        #region Description
        /// <summary>
        /// Returns a string that represents the current <see cref="HResult"/>.
        /// </summary>
        /// <returns>A string that represents the current <see cref="HResult"/>.</returns>
        #endregion
        public override string ToString()
        {
            if (Enum.IsDefined(typeof(WbemStatus), this.value))
            {
                return ((WbemStatus)value).ToString();
            }
            else
            {
                return string.Format("0x{0:X8}", this.value);
            }
        }

        #region Description
        /// <summary>
        /// throws an exception.
        /// </summary>
        #endregion
        [Obsolete]
        internal void ThrowException()
        {
            if (this.Failed)
            {
                throw (Exception)this;
            }
        }

        #endregion
    }
}
