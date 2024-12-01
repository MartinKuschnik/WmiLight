using System;
using System.Diagnostics;
using System.Linq;
using WmiLight.Wbem;

namespace WmiLight
{
    #region Description
    /// <summary>
    /// Represents the in and out parameters of a WMI defined method.
    /// </summary>
    #endregion
    public class WmiMethodParameters : WmiObject
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private WbemClassObject signatur;

        internal WmiMethodParameters(WbemServices wbemServices, WbemClassObject signatur)
            :base(wbemServices, signatur)
        {
            this.signatur = signatur ?? throw new ArgumentNullException(nameof(signatur));
        }

        #region Description
        /// <summary>
        /// Sets the value of a property.
        /// </summary>
        /// <param name="propertyName">The name of the property that should be changed.</param>
        /// <param name="propertyValue">The new property value.</param>
        #endregion
        public void SetPropertyValue(string propertyName, sbyte propertyValue)
        {
            this.signatur.Put(propertyName, propertyValue);
        }

        #region Description
        /// <summary>
        /// Sets the value of a property.
        /// </summary>
        /// <param name="propertyName">The name of the property that should be changed.</param>
        /// <param name="propertyValue">The new property value.</param>
        #endregion
        public void SetPropertyValue(string propertyName, byte propertyValue)
        {
            this.signatur.Put(propertyName, propertyValue);
        }

        #region Description
        /// <summary>
        /// Sets the value of a property.
        /// </summary>
        /// <param name="propertyName">The name of the property that should be changed.</param>
        /// <param name="propertyValue">The new property value.</param>
        #endregion
        public void SetPropertyValue(string propertyName, short propertyValue)
        {
            this.signatur.Put(propertyName, propertyValue);
        }

        #region Description
        /// <summary>
        /// Sets the value of a property.
        /// </summary>
        /// <param name="propertyName">The name of the property that should be changed.</param>
        /// <param name="propertyValue">The new property value.</param>
        #endregion
        public void SetPropertyValue(string propertyName, ushort propertyValue)
        {
            this.signatur.Put(propertyName, propertyValue);
        }

        #region Description
        /// <summary>
        /// Sets the value of a property.
        /// </summary>
        /// <param name="propertyName">The name of the property that should be changed.</param>
        /// <param name="propertyValue">The new property value.</param>
        #endregion
        public void SetPropertyValue(string propertyName, int propertyValue)
        {
            this.signatur.Put(propertyName, propertyValue);
        }

        #region Description
        /// <summary>
        /// Sets the value of a property.
        /// </summary>
        /// <param name="propertyName">The name of the property that should be changed.</param>
        /// <param name="propertyValue">The new property value.</param>
        #endregion
        public void SetPropertyValue(string propertyName, uint propertyValue)
        {
            this.signatur.Put(propertyName, propertyValue);
        }

        #region Description
        /// <summary>
        /// Sets the value of a property.
        /// </summary>
        /// <param name="propertyName">The name of the property that should be changed.</param>
        /// <param name="propertyValue">The new property value.</param>
        #endregion
        public void SetPropertyValue(string propertyName, long propertyValue)
        {
            this.signatur.Put(propertyName, propertyValue);
        }

        #region Description
        /// <summary>
        /// Sets the value of a property.
        /// </summary>
        /// <param name="propertyName">The name of the property that should be changed.</param>
        /// <param name="propertyValue">The new property value.</param>
        #endregion
        public void SetPropertyValue(string propertyName, ulong propertyValue)
        {
            this.signatur.Put(propertyName, propertyValue);
        }

        #region Description
        /// <summary>
        /// Sets the value of a property.
        /// </summary>
        /// <param name="propertyName">The name of the property that should be changed.</param>
        /// <param name="propertyValue">The new property value.</param>
        #endregion
        public void SetPropertyValue(string propertyName, bool propertyValue)
        {
            this.signatur.Put(propertyName, propertyValue);
        }

        #region Description
        /// <summary>
        /// Sets the value of a property.
        /// </summary>
        /// <param name="propertyName">The name of the property that should be changed.</param>
        /// <param name="propertyValue">The new property value.</param>
        #endregion
        public void SetPropertyValue(string propertyName, string propertyValue)
        {
            this.signatur.Put(propertyName, propertyValue);
        }

        public void SetPropertyValue(string propertyName, string[] propertyValue)
        {
            this.signatur.Put(propertyName, propertyValue);
        }

        #region Description
        /// <summary>
        /// Implicit conversion from <see cref="WmiMethodParameters"/> to <see cref="IntPtr"/>.
        /// </summary>
        /// <param name="parameters">The <see cref="WmiMethodParameters"/> value to convert to <see cref="IntPtr"/>.</param>
        /// <returns>The <see cref="IntPtr"/> value as <see cref="WmiMethodParameters"/>.</returns>
        #endregion
        public static implicit operator IntPtr(WmiMethodParameters parameters) => parameters.signatur;
    }
}
