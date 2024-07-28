namespace WmiLight
{
    using System;
    using WmiLight.Wbem;

    /// <summary>
    /// A subscription for a wmi event notifications.
    /// </summary>
    public class WmiEventSubscription : IDisposable
    {
        #region Fields

        private readonly WbemServices service;

        private readonly WbemObjectSink objectSink;

        private readonly Action<WmiObject> callback;

        #endregion

        #region Constructors

        internal WmiEventSubscription(WbemServices service, WbemObjectSink objectSink, Action<WmiObject> callback)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
            this.objectSink = objectSink ?? throw new ArgumentNullException(nameof(objectSink));
            this.callback = callback ?? throw new ArgumentNullException(nameof(callback));

            this.objectSink.Indicated += this.OnObjectSinkIndicated;
        } 

        #endregion

        #region Methods

        private void OnObjectSinkIndicated(object sender, WbemObjectSinkIndicatedEventArgs e)
        {
            for (int i = 0; i < e.Objects.Length; i++)
                this.callback.Invoke(new WmiObject(this.service, e.Objects[i]));
        }

        /// <inheritdoc />
        public void Dispose()
        {
            using (this.objectSink)
            {
                this.objectSink.Indicated -= this.OnObjectSinkIndicated;

                this.service.CancelAsyncCall(this.objectSink); 
            }
        } 

        #endregion
    }
}
