namespace WmiLight
{
    using System.Diagnostics;

    #region Description
    /// <summary>
    /// Class to fake fields into the debugger view.
    /// </summary>
    #endregion
    [DebuggerDisplay("{value}", Name = "{name,nq}", Type = "{value.GetType().ToString(),nq}")]
    internal sealed class DebuggerFakeField
    {
        #region Fields
        
        #region Description
        /// <summary>
        /// The name of the field.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly string name;

        #region Description
        /// <summary>
        /// The value ob the field.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        private readonly object value;
        #endregion

        #region Constructors

        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="DebuggerFakeField"/> class.
        /// </summary>
        /// <param name="name">The name of the field.</param>
        /// <param name="value">The value ob the field.</param>
        #endregion
        internal DebuggerFakeField(string name, object value)
        {
            this.name = name;
            this.value = value;
        }

        #endregion
    }
}
