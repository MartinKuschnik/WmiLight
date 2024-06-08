namespace WmiLight.Wbem
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// Holds the event data for the <see cref="WbemObjectSink.Indicated"/> event.
    /// </summary>
    internal class WbemObjectSinkIndicatedEventArgs : EventArgs
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly WbemClassObject[] objects;

        internal WbemObjectSinkIndicatedEventArgs(WbemClassObject[] objects)
        {
            this.objects = objects;
        }

        internal WbemClassObject[] Objects => objects;
    }
}
