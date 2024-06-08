namespace WmiLight.Wbem
{
    using System;

    internal class WbemUnsecuredApartment : IUnknown
    {
        #region Constructors

        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="WbemUnsecuredApartment"/> class.
        /// </summary>
        #endregion
        public WbemUnsecuredApartment()
            : base(CreateWbemUnsecuredApartment())
        {
        }

        #endregion

        #region Methods

        private static IntPtr CreateWbemUnsecuredApartment()
        {
            IntPtr nativeWbemUnsecuredApartment;

            HResult hResult = NativeMethods.CreateWbemUnsecuredApartment(out nativeWbemUnsecuredApartment);

            if (hResult.Failed)
                throw (Exception)hResult;

            return nativeWbemUnsecuredApartment;
        }

        internal WbemObjectSink CreateObjectSink()
        {
            return new WbemObjectSink(this);
        }

        #endregion
    }
}
