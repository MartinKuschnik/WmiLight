namespace WmiLight.Wbem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security;
    using System.Text;
    
    #region Description
    /// <summary>
    /// The <see cref="IWbemServices"/> interface is used by clients and providers to access WMI services. 
    /// The interface is implemented by WMI and WMI providers, and is the primary WMI interface.
    /// </summary>
    /// <remarks><see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392093(v=vs.85).aspx"/></remarks>
    #endregion
    [ComImport]
    [Guid("9556dc99-828c-11cf-a37e-00aa003240c7")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IWbemServices
    {
        #region Description
        /// <summary>
        /// Opens a specific child namespace for operations.
        /// </summary>
        /// <param name="targetNamespace">
        /// Path to the target namespace. For more information, see <see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa389766(v=vs.85).aspx"/>. <para />
        /// This namespace can only be relative to the current namespace associated with the <see cref="IWbemServices"/> interface. This parameter cannot be an absolute path or NULL.
        /// </param>
        /// <param name="flags">
        /// This parameter can be set to 0 to make this a synchronous call.
        /// To make this a semisynchronous call, set <paramref name="flags"/> to <see cref="WbemClassObjectEnumeratorBehaviorOption.ReturnImmediately"/>, and this call will return immediately.
        /// </param>
        /// <param name="ctx">Reserved. This parameter must be NULL.</param>
        /// <param name="workingNamespace">
        /// Receives the object that represents the new namespace context. <para/>
        /// If this parameter is specified, then <paramref name="result"/> must be NULL.
        /// </param>
        /// <param name="result">
        /// Typically NULL. <para />
        /// If not NULL, then <paramref name="workingNamespace"/> must be NULL. <para />
        /// In this case, the parameter receives a pointer to a new <see cref="IWbemCallResult"/> object. <para/>
        /// If the <paramref name="flags"/> parameter is set to <see cref="WbemClassObjectEnumeratorBehaviorOption.ReturnImmediately"/> this call returns immediately. <para />
        /// Then the caller can periodically poll the <see cref="IWbemCallResult.GetResultServices"/> method until the value for the requested namespace becomes available. <para />
        /// This parameter is set to NULL when there is an error and a new object is not returned.
        /// </param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        /// <remarks><see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392112(v=vs.85).aspx"/></remarks>
        #endregion
        [PreserveSig]
        HResult OpenNamespace(
            [In, MarshalAs(UnmanagedType.BStr)] 
            string targetNamespace,
            [In] 
            int flags,
            [In]  
            IWbemContext ctx,
            [Out] 
            out IWbemServices workingNamespace,
            [Out] 
            out IWbemCallResult result);

        #region Description
        /// <summary>
        /// Cancels a currently executing asynchronous call.
        /// </summary>
        /// <param name="sink">The <see cref="IWbemObjectSink"/> implementation provided by the client to any of the asynchronous methods of <see cref="IWbemServices"/>.</param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        /// <remarks><see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392094(v=vs.85).aspx"/></remarks>
        #endregion
        [PreserveSig]
        HResult CancelAsyncCall(
            [In] 
            IWbemObjectSink sink);

        #region Description
        /// <summary>
        /// Allows a caller to obtain a notification handler sink.
        /// </summary>
        /// <param name="flags">Reserved. This parameter must be 0.</param>
        /// <param name="responseHandler">Receives the interface pointer to the notification handler.</param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        /// <remarks><see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392117(v=vs.85).aspx"/></remarks>
        #endregion
        [PreserveSig]
        HResult QueryObjectSink(
            [In] 
            int flags,
            [Out] 
            out IWbemObjectSink responseHandler);

        #region Description
        /// <summary>
        /// Retrieves an object — an instance or class definition.
        /// </summary>
        /// <param name="objectPath">Path of the object to retrieve. If this is NULL, an empty object is returned that can become a new class.</param>
        /// <param name="flags">The behavior of this method.</param>
        /// <param name="ctx">
        /// Typically NULL. <para />
        /// Otherwise, this is a pointer to an <see cref="IWbemContext"/> object that may be used by the provider that is producing the requested class or instance. <para/>
        /// The values in the context object must be specified in the documentation for the provider in question. 
        /// </param>
        /// <param name="outObject">If not NULL, this receives the object, if it is found.</param>
        /// <param name="callResult">
        /// If NULL, this parameter is not used. <para/>
        /// If the <paramref name="flags"/> parameter contains <see cref="WbemClassObjectEnumeratorBehaviorOption.ReturnImmediately"/>, this call returns immediately with <see cref="WbemStatus.WBEM_S_NO_ERROR"/>. <para />
        /// The <paramref name="callResult"/> parameter receives a new <see cref="IWbemCallResult"/> object, which can then be polled to obtain the result using the <see cref="IWbemCallResult.GetCallStatus"/> method. <para/>
        /// The caller can call <see cref="IWbemCallResult.GetResultObject"/> to retrieve the object when it becomes available.
        /// </param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        /// <remarks><see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392109(v=vs.85).aspx"/></remarks>
        #endregion
        [PreserveSig]
        HResult GetObject(
            [In, MarshalAs(UnmanagedType.BStr)] 
            string objectPath,
            [In] 
            int flags,
            [In]  
            IWbemContext ctx,
            [Out] 
            out IWbemClassObject outObject,
            [Out] 
            out IWbemCallResult callResult);

        #region Description
        /// <summary>
        /// Asynchronously retrieves an object — an instance or class definition.
        /// </summary>
        /// <param name="objectPath">
        /// Path of the object to retrieve. For an instance provider, <paramref name="objectPath"/> can be in the following format:<para />
        ///     - Namespace:Class.Key = "Value" <para />
        ///     - Namespace:Class = "Value" <para />
        ///     - Namespace:Class.Key = "Value", Key2 = "Value2" <para />
        /// Specifying the namespace before the class is optional. Object paths without namespaces refer to instances in the current namespace. <para/>
        /// If necessary, you can substitute the single-quotation mark character (') for the double-quotation mark character (") to delimit the start and end of string property types.
        /// </param>
        /// <param name="flags">For more information, see<see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392110(v=vs.85).aspx"/></param>
        /// <param name="ctx">
        /// Typically NULL. <para />
        /// Otherwise, this is a pointer to an <see cref="IWbemContext"/> object that can be used by the provider that produces the requested class or instance.<para />
        /// The values in the context object must be specified in the documentation for the provider in question.
        /// </param>
        /// <param name="responseHandler">
        /// The caller's implementation of <see cref="IWbemObjectSink"/>. <para />
        /// This handler receives the requested object when it becomes available through the <see cref="IWbemObjectSink.Indicate"/> method.
        /// </param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        #endregion
        [PreserveSig]
        HResult GetObjectAsync(
            [In, MarshalAs(UnmanagedType.BStr)] 
            string objectPath,
            [In] 
            int flags,
            [In]  
            IWbemContext ctx,
            [In]  
            IWbemObjectSink responseHandler);

        #region Description
        /// <summary>
        /// Creates or updates a class definition.
        /// </summary>
        /// <param name="wbemClassObject">Must point to a valid class definition.</param>
        /// <param name="flags">For more information, see <see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392113(v=vs.85).aspx"/></param>
        /// <param name="ctx">
        /// Typically NULL. <para />
        /// Otherwise, this is a pointer to an <see cref="IWbemContext"/> object that can be used by the provider that produces the requested class or instance.<para />
        /// The values in the context object must be specified in the documentation for the provider in question.
        /// </param>
        /// <param name="callResult">
        /// If NULL, this parameter is not used. <para/>
        /// If the <paramref name="flags"/> parameter contains <see cref="WbemClassObjectEnumeratorBehaviorOption.ReturnImmediately"/>, this call returns immediately with <see cref="WbemStatus.WBEM_S_NO_ERROR"/>. <para />
        /// The <paramref name="callResult"/> parameter receives a new <see cref="IWbemCallResult"/> object, which can then be polled to obtain the result using the <see cref="IWbemCallResult.GetCallStatus"/> method. <para/>
        /// The caller can call <see cref="IWbemCallResult.GetResultObject"/> to retrieve the object when it becomes available.
        /// </param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        /// <remarks><see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392113(v=vs.85).aspx"/></remarks>
        #endregion
        [PreserveSig]
        HResult PutClass(
            [In]  
            IWbemClassObject wbemClassObject,
            [In] 
            int flags,
            [In] 
            IWbemContext ctx,
            [Out] 
            out IWbemCallResult callResult);

        #region Description
        /// <summary>
        /// Asynchronously creates or updates a class definition.
        /// </summary>
        /// <param name="wbemClassObject">The object containing the class definition.</param>
        /// <param name="flags">For more information, see <see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392114(v=vs.85).aspx"/></param>
        /// <param name="ctx">
        /// Typically NULL. <para />
        /// Otherwise, this is a pointer to an <see cref="IWbemContext"/> object that can be used by the provider that produces the requested class or instance.<para />
        /// The values in the context object must be specified in the documentation for the provider in question.
        /// </param>
        /// <param name="responseHandler">
        /// The caller's implementation of <see cref="IWbemObjectSink"/>. <para />
        /// This handler receives the requested object when it becomes available through the <see cref="IWbemObjectSink.Indicate"/> method.
        /// </param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        /// <remarks><see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392114(v=vs.85).aspx"/></remarks>
        #endregion
        [PreserveSig]
        HResult PutClassAsync(
            [In]  
            IWbemClassObject wbemClassObject,
            [In] 
            int flags,
            [In]  
            IWbemContext ctx,
            [In]  
            IWbemObjectSink responseHandler);

        #region Description
        /// <summary>
        /// Deletes a class.
        /// </summary>
        /// <param name="className">Name of the class targeted for deletion.</param>
        /// <param name="flags">For more information, see <see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392099(v=vs.85).aspx"/></param>
        /// <param name="ctx">
        /// Typically NULL. <para />
        /// Otherwise, this is a pointer to an <see cref="IWbemContext"/> object that can be used by the provider that produces the requested class or instance.<para />
        /// The values in the context object must be specified in the documentation for the provider in question.
        /// </param>        
        /// <param name="callResult">
        /// If NULL, this parameter is not used. <para/>
        /// If the <paramref name="flags"/> parameter contains <see cref="WbemClassObjectEnumeratorBehaviorOption.ReturnImmediately"/>, this call returns immediately with <see cref="WbemStatus.WBEM_S_NO_ERROR"/>. <para />
        /// The <paramref name="callResult"/> parameter receives a new <see cref="IWbemCallResult"/> object, which can then be polled to obtain the result using the <see cref="IWbemCallResult.GetCallStatus"/> method. <para/>
        /// The caller can call <see cref="IWbemCallResult.GetResultObject"/> to retrieve the object when it becomes available.
        /// </param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        /// <remarks><see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392099(v=vs.85).aspx"/></remarks>
        #endregion
        [PreserveSig]
        HResult DeleteClass(
            [In, MarshalAs(UnmanagedType.BStr)] 
            string className,
            [In] 
            int flags,
            [In]  
            IWbemContext ctx,
            [Out] 
            out IWbemCallResult callResult);

        #region Description
        /// <summary>
        /// Deletes a class and receives confirmation asynchronously.
        /// </summary>
        /// <param name="className">Name of the class targeted for deletion.</param>
        /// <param name="flags">For more information, see <see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392100(v=vs.85).aspx"/></param>
        /// <param name="ctx">
        /// Typically NULL. <para />
        /// Otherwise, this is a pointer to an <see cref="IWbemContext"/> object that can be used by the provider that produces the requested class or instance.<para />
        /// The values in the context object must be specified in the documentation for the provider in question.
        /// </param>
        /// <param name="responseHandler">
        /// The caller's implementation of <see cref="IWbemObjectSink"/>. <para />
        /// This handler receives the requested object when it becomes available through the <see cref="IWbemObjectSink.Indicate"/> method.
        /// </param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        /// <remarks><see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392100(v=vs.85).aspx"/></remarks>
        #endregion
        [PreserveSig]
        HResult DeleteClassAsync(
            [In, MarshalAs(UnmanagedType.BStr)] 
            string className,
            [In] 
            int flags,
            [In]  
            IWbemContext ctx,
            [In]  
            IWbemObjectSink responseHandler);

        #region Description
        /// <summary>
        /// Creates a class enumerator.
        /// </summary>
        /// <param name="superclass">
        /// If not NULL or blank, specifies a parent class name. <para />
        /// Only classes that are subclasses of this class are returned in the enumerator. <para />
        /// For more information, see <see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392095(v=vs.85).aspx"/>
        /// </param>
        /// <param name="flags">For more information, see <see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392095(v=vs.85).aspx"/></param>
        /// <param name="ctx">
        /// Typically NULL. <para />
        /// Otherwise, this is a pointer to an <see cref="IWbemContext"/> object that can be used by the provider that produces the requested class or instance.<para />
        /// The values in the context object must be specified in the documentation for the provider in question.
        /// </param>
        /// <param name="enumerator">The enumerator.</param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        /// <remarks><see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392095(v=vs.85).aspx"/></remarks>
        #endregion
        [PreserveSig]
        HResult CreateClassEnum(
            [In, MarshalAs(UnmanagedType.BStr)] 
            string superclass,
            [In] 
            int flags,
            [In] 
            IWbemContext ctx,
            [Out] 
            out IWbemClassObjectEnumerator enumerator);

        #region Description
        /// <summary>
        /// Creates a class enumerator that executes asynchronously.
        /// </summary>
        /// <param name="superclass">
        /// If not NULL or blank, specifies a parent class name. <para />
        /// Only classes that are subclasses of this class are returned in the enumerator. <para />
        /// For more information, see <see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392096(v=vs.85).aspx"/>
        /// </param>
        /// <param name="flags">For more information, see <see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392096(v=vs.85).aspx"/></param>
        /// <param name="ctx">
        /// Typically NULL. <para />
        /// Otherwise, this is a pointer to an <see cref="IWbemContext"/> object that can be used by the provider that produces the requested class or instance.<para />
        /// The values in the context object must be specified in the documentation for the provider in question.
        /// </param>
        /// <param name="responseHandler">
        /// The caller's implementation of <see cref="IWbemObjectSink"/>. <para />
        /// This handler receives the requested object when it becomes available through the <see cref="IWbemObjectSink.Indicate"/> method.
        /// </param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        /// <remarks><see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392096(v=vs.85).aspx"/></remarks>
        #endregion
        [PreserveSig]
        HResult CreateClassEnumAsync(
            [In, MarshalAs(UnmanagedType.BStr)] 
            string superclass,
            [In] 
            int flags,
            [In]  
            IWbemContext ctx,
            [In]  
            IWbemObjectSink responseHandler);

        #region Description
        /// <summary>
        /// Creates or updates an instance of a specific class.
        /// </summary>
        /// <param name="inst">The instance to be written.</param>
        /// <param name="flags">For more information, see <see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392115(v=vs.85).aspx"/></param>
        /// <param name="ctx">
        /// Typically NULL. <para />
        /// Otherwise, this is a pointer to an <see cref="IWbemContext"/> object that can be used by the provider that produces the requested class or instance.<para />
        /// The values in the context object must be specified in the documentation for the provider in question.
        /// </param>
        /// <param name="callResult">
        /// If NULL, this parameter is not used. <para/>
        /// If the <paramref name="flags"/> parameter contains <see cref="WbemClassObjectEnumeratorBehaviorOption.ReturnImmediately"/>, this call returns immediately with <see cref="WbemStatus.WBEM_S_NO_ERROR"/>. <para />
        /// The <paramref name="callResult"/> parameter receives a new <see cref="IWbemCallResult"/> object, which can then be polled to obtain the result using the <see cref="IWbemCallResult.GetCallStatus"/> method. <para/>
        /// The caller can call <see cref="IWbemCallResult.GetResultObject"/> to retrieve the object when it becomes available.
        /// </param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        /// <remarks><see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392115(v=vs.85).aspx"/></remarks>
        #endregion
        [PreserveSig]
        HResult PutInstance(
            [In]  
            IWbemClassObject inst,
            [In] 
            int flags,
            [In]  
            IWbemContext ctx,
            [Out] 
            out IWbemCallResult callResult);

        #region Description
        /// <summary>
        /// Asynchronously creates or updates an instance of a specific class.
        /// </summary>
        /// <param name="inst">The instance to be written.</param>
        /// <param name="flags">For more information, see <see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392116(v=vs.85).aspx"/></param>
        /// <param name="ctx">
        /// Typically NULL. <para />
        /// Otherwise, this is a pointer to an <see cref="IWbemContext"/> object that can be used by the provider that produces the requested class or instance.<para />
        /// The values in the context object must be specified in the documentation for the provider in question.
        /// </param>
        /// <param name="responseHandler">
        /// The caller's implementation of <see cref="IWbemObjectSink"/>. <para />
        /// This handler receives the requested object when it becomes available through the <see cref="IWbemObjectSink.Indicate"/> method.
        /// </param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        /// <remarks><see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392116(v=vs.85).aspx"/></remarks>
        #endregion
        [PreserveSig]
        HResult PutInstanceAsync(
            [In]  
            IWbemClassObject inst,
            [In] 
            int flags,
            [In]  
            IWbemContext ctx,
            [In]  
            IWbemObjectSink responseHandler);

        #region Description
        /// <summary>
        /// Deletes a specific instance of a class.
        /// </summary>
        /// <param name="objectPath">The object path to the instance to be deleted.</param>
        /// <param name="flags">For more information, see <see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392101(v=vs.85).aspx"/></param>
        /// <param name="ctx">
        /// Typically NULL. <para />
        /// Otherwise, this is a pointer to an <see cref="IWbemContext"/> object that can be used by the provider that produces the requested class or instance.<para />
        /// The values in the context object must be specified in the documentation for the provider in question.
        /// </param>
        /// <param name="callResult">
        /// If NULL, this parameter is not used. <para/>
        /// If the <paramref name="flags"/> parameter contains <see cref="WbemClassObjectEnumeratorBehaviorOption.ReturnImmediately"/>, this call returns immediately with <see cref="WbemStatus.WBEM_S_NO_ERROR"/>. <para />
        /// The <paramref name="callResult"/> parameter receives a new <see cref="IWbemCallResult"/> object, which can then be polled to obtain the result using the <see cref="IWbemCallResult.GetCallStatus"/> method. <para/>
        /// The caller can call <see cref="IWbemCallResult.GetResultObject"/> to retrieve the object when it becomes available.
        /// </param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        /// <remarks><see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392101(v=vs.85).aspx"/></remarks>
        #endregion
        [PreserveSig]
        HResult DeleteInstance(
            [In, MarshalAs(UnmanagedType.BStr)] 
            string objectPath,
            [In] 
            int flags,
            [In]  
            IWbemContext ctx,
            [Out] 
            out IWbemCallResult callResult);

        #region Description
        /// <summary>
        /// Deletes an instance and provides confirmation asynchronously.
        /// </summary>
        /// <param name="objectPath">The object path to the instance to be deleted.</param>
        /// <param name="flags">For more information, see <see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392102(v=vs.85).aspx"/></param>
        /// <param name="ctx">
        /// Typically NULL. <para />
        /// Otherwise, this is a pointer to an <see cref="IWbemContext"/> object that can be used by the provider that produces the requested class or instance.<para />
        /// The values in the context object must be specified in the documentation for the provider in question.
        /// </param>
        /// <param name="responseHandler">
        /// The caller's implementation of <see cref="IWbemObjectSink"/>. <para />
        /// This handler receives the requested object when it becomes available through the <see cref="IWbemObjectSink.Indicate"/> method.
        /// </param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        /// <remarks><see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392102(v=vs.85).aspx"/></remarks>
        #endregion
        [PreserveSig]
        HResult DeleteInstanceAsync(
            [In, MarshalAs(UnmanagedType.BStr)] 
            string objectPath,
            [In] 
            int flags,
            [In]  
            IWbemContext ctx,
            [In]  
            IWbemObjectSink responseHandler);

        #region Description
        /// <summary>
        /// Creates an instance enumerator.
        /// </summary>
        /// <param name="filter">The name of the class for which instances are desired.</param>
        /// <param name="flags">For more information, see <see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392097(v=vs.85).aspx"/></param>
        /// <param name="ctx">
        /// Typically NULL. <para />
        /// Otherwise, this is a pointer to an <see cref="IWbemContext"/> object that can be used by the provider that produces the requested class or instance.<para />
        /// The values in the context object must be specified in the documentation for the provider in question.
        /// </param>
        /// <param name="enumerator">The enumerator.</param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        /// <remarks><see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392097(v=vs.85).aspx"/></remarks>
        #endregion
        [PreserveSig]
        HResult CreateInstanceEnum(
            [In, MarshalAs(UnmanagedType.BStr)] 
            string filter,
            [In] 
            int flags,
            [In]  
            IWbemContext ctx,
            [Out] 
            out IWbemClassObjectEnumerator enumerator);

        #region Description
        /// <summary>
        /// Creates an instance enumerator that executes asynchronously.
        /// </summary>
        /// <param name="filter">The name of the class for which instances are desired.</param>
        /// <param name="flags">For more information, see <see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392098(v=vs.85).aspx"/></param>
        /// <param name="ctx">
        /// Typically NULL. <para />
        /// Otherwise, this is a pointer to an <see cref="IWbemContext"/> object that can be used by the provider that produces the requested class or instance.<para />
        /// The values in the context object must be specified in the documentation for the provider in question.
        /// </param>
        /// <param name="responseHandler">
        /// The caller's implementation of <see cref="IWbemObjectSink"/>. <para />
        /// This handler receives the requested object when it becomes available through the <see cref="IWbemObjectSink.Indicate"/> method.
        /// </param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        /// <remarks><see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392098(v=vs.85).aspx"/></remarks>
        #endregion
        [PreserveSig]
        HResult CreateInstanceEnumAsync(
            [In, MarshalAs(UnmanagedType.BStr)] 
            string filter,
            [In] 
            int flags,
            [In] 
            IWbemContext ctx,
            [In] 
            IWbemObjectSink responseHandler);

        #region Description
        /// <summary>
        /// Executes a query to retrieve classes or instances.
        /// </summary>
        /// <param name="queryLanguage">This must be "WQL", the acronym for WMI Query Language.</param>
        /// <param name="query">The text of the query.</param>
        /// <param name="behaviorOption">For more information, see <see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392107(v=vs.85).aspx"/></param>
        /// <param name="ctx">
        /// Typically NULL. <para />
        /// Otherwise, this is a pointer to an <see cref="IWbemContext"/> object that can be used by the provider that produces the requested class or instance.<para />
        /// The values in the context object must be specified in the documentation for the provider in question.
        /// </param>
        /// <param name="enumerator">The enumerator.</param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        /// <remarks><see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392107(v=vs.85).aspx"/></remarks>
        #endregion
        [PreserveSig]
        HResult ExecQuery(
            [In, MarshalAs(UnmanagedType.BStr)] 
            string queryLanguage,
            [In, MarshalAs(UnmanagedType.BStr)] 
            string query,
            [In] 
            WbemClassObjectEnumeratorBehaviorOption behaviorOption,
            [In] 
            IWbemContext ctx,
            [Out] 
            out IWbemClassObjectEnumerator enumerator);

        #region Description
        /// <summary>
        /// Executes a query to retrieve classes or instances asynchronously.
        /// </summary>
        /// <param name="queryLanguage">This must be "WQL", the acronym for WMI Query Language.</param>
        /// <param name="query">The text of the query.</param>
        /// <param name="behaviorOption">For more information, see <see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392108(v=vs.85).aspx"/></param>
        /// <param name="ctx">
        /// Typically NULL. <para />
        /// Otherwise, this is a pointer to an <see cref="IWbemContext"/> object that can be used by the provider that produces the requested class or instance.<para />
        /// The values in the context object must be specified in the documentation for the provider in question.
        /// </param>
        /// <param name="responseHandler">
        /// The caller's implementation of <see cref="IWbemObjectSink"/>. <para />
        /// This handler receives the requested object when it becomes available through the <see cref="IWbemObjectSink.Indicate"/> method.
        /// </param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        /// <remarks><see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392108(v=vs.85).aspx"/></remarks>
        #endregion
        [PreserveSig]
        HResult ExecQueryAsync(
            [In, MarshalAs(UnmanagedType.BStr)] 
            string queryLanguage,
            [In, MarshalAs(UnmanagedType.BStr)] 
            string query,
            [In] 
            WbemClassObjectEnumeratorBehaviorOption behaviorOption,
            [In]  
            IWbemContext ctx,
            [In]  
            IWbemObjectSink responseHandler);

        #region Description
        /// <summary>
        /// Executes a query to receive events.
        /// </summary>
        /// <param name="queryLanguage">This must be "WQL", the acronym for WMI Query Language.</param>
        /// <param name="query">The text of the query.</param>
        /// <param name="behaviorOption">For more information, see <see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392105(v=vs.85).aspx"/></param>
        /// <param name="ctx">
        /// Typically NULL. <para />
        /// Otherwise, this is a pointer to an <see cref="IWbemContext"/> object that can be used by the provider that produces the requested class or instance.<para />
        /// The values in the context object must be specified in the documentation for the provider in question.
        /// </param>
        /// <param name="enumerator">The enumerator.</param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        /// <remarks><see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392105(v=vs.85).aspx"/></remarks>
        #endregion
        [PreserveSig]
        HResult ExecNotificationQuery(
            [In, MarshalAs(UnmanagedType.BStr)] 
            string queryLanguage,
            [In, MarshalAs(UnmanagedType.BStr)] 
            string query,
            [In] 
            WbemClassObjectEnumeratorBehaviorOption behaviorOption,
            [In]  
            IWbemContext ctx,
            [Out] 
            out IWbemClassObjectEnumerator enumerator);

        #region Description
        /// <summary>
        /// Executes a query to receive events asynchronously.
        /// </summary>
        /// <param name="queryLanguage">This must be "WQL", the acronym for WMI Query Language.</param>
        /// <param name="query">The text of the query.</param>
        /// <param name="behaviorOption">For more information, see <see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392106(v=vs.85).aspx"/></param>
        /// <param name="ctx">
        /// Typically NULL. <para />
        /// Otherwise, this is a pointer to an <see cref="IWbemContext"/> object that can be used by the provider that produces the requested class or instance.<para />
        /// The values in the context object must be specified in the documentation for the provider in question.
        /// </param>
        /// <param name="responseHandler">
        /// The caller's implementation of <see cref="IWbemObjectSink"/>. <para />
        /// This handler receives the requested object when it becomes available through the <see cref="IWbemObjectSink.Indicate"/> method.
        /// </param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        /// <remarks><see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392106(v=vs.85).aspx"/></remarks>
        #endregion
        [PreserveSig]
        HResult ExecNotificationQueryAsync(
            [In, MarshalAs(UnmanagedType.BStr)] 
            string queryLanguage,
            [In, MarshalAs(UnmanagedType.BStr)] 
            string query,
            [In] 
            WbemClassObjectEnumeratorBehaviorOption behaviorOption,
            [In]  
            IWbemContext ctx,
            [In]  
            IWbemObjectSink responseHandler);

        #region Description
        /// <summary>
        /// Executes an object method.
        /// </summary>
        /// <param name="objectPath">The object path of the object for which the method is executed.</param>
        /// <param name="methodName">Name of the method for the object.</param>
        /// <param name="flags">For more information, see <see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392103(v=vs.85).aspx"/></param>
        /// <param name="ctx">
        /// Typically NULL. <para />
        /// Otherwise, this is a pointer to an <see cref="IWbemContext"/> object that can be used by the provider that produces the requested class or instance.<para />
        /// The values in the context object must be specified in the documentation for the provider in question.
        /// </param>
        /// <param name="inParams">
        /// Can be NULL if no inbound parameters are required to execute the method.<para />
        /// Otherwise, this points to an <see cref="IWbemClassObject"/> object that contains the properties acting as inbound parameters for the method execution. 
        /// </param>
        /// <param name="outParams">
        /// If not NULL, receives the outbound parameters and return values for the method execution.<para />
        /// The contents of this object are method-specific, and are part of the specification for the provider in question.
        /// </param>
        /// <param name="callResult">
        /// If NULL, this parameter is not used. <para/>
        /// If the <paramref name="flags"/> parameter contains <see cref="WbemClassObjectEnumeratorBehaviorOption.ReturnImmediately"/>, this call returns immediately with <see cref="WbemStatus.WBEM_S_NO_ERROR"/>. <para />
        /// The <paramref name="callResult"/> parameter receives a new <see cref="IWbemCallResult"/> object, which can then be polled to obtain the result using the <see cref="IWbemCallResult.GetCallStatus"/> method. <para/>
        /// The caller can call <see cref="IWbemCallResult.GetResultObject"/> to retrieve the object when it becomes available.
        /// </param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        /// <remarks><see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392103(v=vs.85).aspx"/></remarks>
        #endregion
        [PreserveSig]
        HResult ExecMethod(
            [In, MarshalAs(UnmanagedType.BStr)] 
            string objectPath,
            [In, MarshalAs(UnmanagedType.BStr)] 
            string methodName,
            [In]
            int flags,
            [In]  
            IWbemContext ctx,
            [In]  
            IWbemClassObject inParams,
            [Out] 
            out IWbemClassObject outParams,
            [Out] 
            out IWbemCallResult callResult);

        #region Description
        /// <summary>
        /// Executes an object method asynchronously.
        /// </summary>
        /// <param name="objectPath">The object path of the object for which the method is executed.</param>
        /// <param name="methodName">Name of the method for the object.</param>
        /// <param name="flags">For more information, see <see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392104(v=vs.85).aspx"/></param>
        /// <param name="ctx">
        /// Typically NULL. <para />
        /// Otherwise, this is a pointer to an <see cref="IWbemContext"/> object that can be used by the provider that produces the requested class or instance.<para />
        /// The values in the context object must be specified in the documentation for the provider in question.
        /// </param>
        /// <param name="inParams">
        /// Can be NULL if no inbound parameters are required to execute the method. <para />
        /// Otherwise, this points to an <see cref="IWbemClassObject"/> object that contains the properties acting as inbound parameters for the method execution. 
        /// </param>
        /// <param name="responseHandler">
        /// The caller's implementation of <see cref="IWbemObjectSink"/>. <para />
        /// This handler receives the requested object when it becomes available through the <see cref="IWbemObjectSink.Indicate"/> method.
        /// </param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        /// <remarks><see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392104(v=vs.85).aspx"/></remarks>
        #endregion
        [PreserveSig]
        HResult ExecMethodAsync(
            [In, MarshalAs(UnmanagedType.BStr)] 
            string objectPath,
            [In, MarshalAs(UnmanagedType.BStr)] 
            string methodName,
            [In] 
            int flags,
            [In]  
            IWbemContext ctx,
            [In]  
            IWbemClassObject inParams,
            [In]  
            IWbemObjectSink responseHandler);
    }
}
