namespace WmiLight.Wbem
{
    using System;
    using System.Collections.Generic;

    #region Description
    /// <summary>
    /// Static class with extension methods for the <see cref="WmiLight.Wbem.IWbemClassObject"/> interface.
    /// </summary>
    #endregion
    internal static class IWbemClassObjectExtensions
    {
        #region Description
        /// <summary>
        /// Gets the names of all properties in the object.
        /// </summary>
        /// <param name="this">The <see cref="IWbemClassObject"/> object which will be used to execute the method.</param>
        /// <param name="flags">Combination of flags. (see <see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa391447(v=vs.85).aspx"/>)</param>
        /// <returns>The names of all properties.</returns>
        #endregion
        internal static IEnumerable<string> GetNames(this IWbemClassObject @this, WbemConditionFlag flags = WbemConditionFlag.WBEM_FLAG_NONSYSTEM_ONLY)
        {
            string[] names = null;
            HResult hr = @this.GetNames(null, flags, null, out names);

            if (hr.Failed)
            {
                throw (Exception)hr;                    
            }

            return names;
        }
        
        #region Description
        /// <summary>
        /// Gets a particular property value.
        /// </summary>
        /// <param name="this">The <see cref="IWbemClassObject"/> object which will be used to execute the method.</param>
        /// <param name="propertyName">Name of the desired property.</param>
        /// <returns>The correct type and value for the qualifier.</returns>
        #endregion
        internal static object Get(this IWbemClassObject @this, string propertyName)
        {
            object value;
            CimType type;
            int flavor;

            HResult hresult = @this.Get(propertyName, 0, out value, out type, out flavor);

            if (hresult.Failed)
            {
                throw (Exception)hresult;
            }

            return value == DBNull.Value ? null : value;
        }
    }
}