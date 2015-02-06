namespace WmiLight
{
    using System;

    #region Description
    /// <summary>
    /// The attribute to select a enum as stock of <see cref="HResult"/>s.
    /// </summary>
    #endregion
    [AttributeUsage(AttributeTargets.Enum, AllowMultiple = false)]
    internal class HResultAttribute : Attribute
    {
    }
}
