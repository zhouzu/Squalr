// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIWebProgressListener.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;


    /// <summary>
    /// The nsIWebProgressListener interface is implemented by clients wishing to
    /// listen in on the progress associated with the loading of asynchronous
    /// requests in the context of a nsIWebProgress instance as well as any child
    /// nsIWebProgress instances.  nsIWebProgress.idl describes the parent-child
    /// relationship of nsIWebProgress instances.
    /// </summary>
    [ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a0cda7e4-c6ca-11e0-b6a5-001320257da5")]
	public interface nsIWebProgressListener
	{
		
		/// <summary>
        /// Notification indicating the state has changed for one of the requests
        /// associated with aWebProgress.
        ///
        /// @param aWebProgress
        /// The nsIWebProgress instance that fired the notification
        /// @param aRequest
        /// The nsIRequest that has changed state.
        /// @param aStateFlags
        /// Flags indicating the new state.  This value is a combination of one
        /// of the State Transition Flags and one or more of the State Type
        /// Flags defined above.  Any undefined bits are reserved for future
        /// use.
        /// @param aStatus
        /// Error status code associated with the state change.  This parameter
        /// should be ignored unless aStateFlags includes the STATE_STOP bit.
        /// The status code indicates success or failure of the request
        /// associated with the state change.  NOTE: aStatus may be a success
        /// code even for server generated errors, such as the HTTP 404 error.
        /// In such cases, the request itself should be queried for extended
        /// error information (e.g., for HTTP requests see nsIHttpChannel).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnStateChange([MarshalAs(UnmanagedType.Interface)] nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, uint aStateFlags, int aStatus);
		
		/// <summary>
        /// Notification that the progress has changed for one of the requests
        /// associated with aWebProgress.  Progress totals are reset to zero when all
        /// requests in aWebProgress complete (corresponding to onStateChange being
        /// called with aStateFlags including the STATE_STOP and STATE_IS_WINDOW
        /// flags).
        ///
        /// @param aWebProgress
        /// The nsIWebProgress instance that fired the notification.
        /// @param aRequest
        /// The nsIRequest that has new progress.
        /// @param aCurSelfProgress
        /// The current progress for aRequest.
        /// @param aMaxSelfProgress
        /// The maximum progress for aRequest.
        /// @param aCurTotalProgress
        /// The current progress for all requests associated with aWebProgress.
        /// @param aMaxTotalProgress
        /// The total progress for all requests associated with aWebProgress.
        ///
        /// NOTE: If any progress value is unknown, or if its value would exceed the
        /// maximum value of type long, then its value is replaced with -1.
        ///
        /// NOTE: If the object also implements nsIWebProgressListener2 and the caller
        /// knows about that interface, this function will not be called. Instead,
        /// nsIWebProgressListener2::onProgressChange64 will be called.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnProgressChange([MarshalAs(UnmanagedType.Interface)] nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, int aCurSelfProgress, int aMaxSelfProgress, int aCurTotalProgress, int aMaxTotalProgress);
		
		/// <summary>
        /// Called when the location of the window being watched changes.  This is not
        /// when a load is requested, but rather once it is verified that the load is
        /// going to occur in the given window.  For instance, a load that starts in a
        /// window might send progress and status messages for the new site, but it
        /// will not send the onLocationChange until we are sure that we are loading
        /// this new page here.
        ///
        /// @param aWebProgress
        /// The nsIWebProgress instance that fired the notification.
        /// @param aRequest
        /// The associated nsIRequest.  This may be null in some cases.
        /// @param aLocation
        /// The URI of the location that is being loaded.
        /// @param aFlags
        /// This is a value which explains the situation or the reason why
        /// the location has changed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnLocationChange([MarshalAs(UnmanagedType.Interface)] nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsIURI aLocation, uint aFlags);
		
		/// <summary>
        /// Notification that the status of a request has changed.  The status message
        /// is intended to be displayed to the user (e.g., in the status bar of the
        /// browser).
        ///
        /// @param aWebProgress
        /// The nsIWebProgress instance that fired the notification.
        /// @param aRequest
        /// The nsIRequest that has new status.
        /// @param aStatus
        /// This value is not an error code.  Instead, it is a numeric value
        /// that indicates the current status of the request.  This interface
        /// does not define the set of possible status codes.  NOTE: Some
        /// status values are defined by nsITransport and nsISocketTransport.
        /// @param aMessage
        /// Localized text corresponding to aStatus.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnStatusChange([MarshalAs(UnmanagedType.Interface)] nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, int aStatus, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aMessage);
		
		/// <summary>
        /// Notification called for security progress.  This method will be called on
        /// security transitions (eg HTTP -> HTTPS, HTTPS -> HTTP, FOO -> HTTPS) and
        /// after document load completion.  It might also be called if an error
        /// occurs during network loading.
        ///
        /// @param aWebProgress
        /// The nsIWebProgress instance that fired the notification.
        /// @param aRequest
        /// The nsIRequest that has new security state.
        /// @param aState
        /// A value composed of the Security State Flags and the Security
        /// Strength Flags listed above.  Any undefined bits are reserved for
        /// future use.
        ///
        /// NOTE: These notifications will only occur if a security package is
        /// installed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnSecurityChange([MarshalAs(UnmanagedType.Interface)] nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, uint aState);
	}
	
	/// <summary>nsIWebProgressListenerConsts </summary>
	public class nsIWebProgressListenerConsts
	{
		
		// <summary>
        // State Transition Flags
        //
        // These flags indicate the various states that requests may transition
        // through as they are being loaded.  These flags are mutually exclusive.
        //
        // For any given request, onStateChange is called once with the STATE_START
        // flag, zero or more times with the STATE_TRANSFERRING flag or once with the
        // STATE_REDIRECTING flag, and then finally once with the STATE_STOP flag.
        // NOTE: For document requests, a second STATE_STOP is generated (see the
        // description of STATE_IS_WINDOW for more details).
        //
        // STATE_START
        // This flag indicates the start of a request.  This flag is set when a
        // request is initiated.  The request is complete when onStateChange is
        // called for the same request with the STATE_STOP flag set.
        //
        // STATE_REDIRECTING
        // This flag indicates that a request is being redirected.  The request
        // passed to onStateChange is the request that is being redirected.  When a
        // redirect occurs, a new request is generated automatically to process the
        // new request.  Expect a corresponding STATE_START event for the new
        // request, and a STATE_STOP for the redirected request.
        //
        // STATE_TRANSFERRING
        // This flag indicates that data for a request is being transferred to an
        // end consumer.  This flag indicates that the request has been targeted,
        // and that the user may start seeing content corresponding to the request.
        //
        // STATE_NEGOTIATING
        // This flag is not used.
        //
        // STATE_STOP
        // This flag indicates the completion of a request.  The aStatus parameter
        // to onStateChange indicates the final status of the request.
        // </summary>
		public const ulong STATE_START = 0x00000001;
		
		// 
		public const ulong STATE_REDIRECTING = 0x00000002;
		
		// 
		public const ulong STATE_TRANSFERRING = 0x00000004;
		
		// 
		public const ulong STATE_NEGOTIATING = 0x00000008;
		
		// 
		public const ulong STATE_STOP = 0x00000010;
		
		// <summary>
        // State Type Flags
        //
        // These flags further describe the entity for which the state transition is
        // occuring.  These flags are NOT mutually exclusive (i.e., an onStateChange
        // event may indicate some combination of these flags).
        //
        // STATE_IS_REQUEST
        // This flag indicates that the state transition is for a request, which
        // includes but is not limited to document requests.  (See below for a
        // description of document requests.)  Other types of requests, such as
        // requests for inline content (e.g., images and stylesheets) are
        // considered normal requests.
        //
        // STATE_IS_DOCUMENT
        // This flag indicates that the state transition is for a document request.
        // This flag is set in addition to STATE_IS_REQUEST.  A document request
        // supports the nsIChannel interface and its loadFlags attribute includes
        // the nsIChannel::LOAD_DOCUMENT_URI flag.
        //
        // A document request does not complete until all requests associated with
        // the loading of its corresponding document have completed.  This includes
        // other document requests (e.g., corresponding to HTML <iframe> elements).
        // The document corresponding to a document request is available via the
        // DOMWindow attribute of onStateChange's aWebProgress parameter.
        //
        // STATE_IS_NETWORK
        // This flag indicates that the state transition corresponds to the start
        // or stop of activity in the indicated nsIWebProgress instance.  This flag
        // is accompanied by either STATE_START or STATE_STOP, and it may be
        // combined with other State Type Flags.
        //
        // Unlike STATE_IS_WINDOW, this flag is only set when activity within the
        // nsIWebProgress instance being observed starts or stops.  If activity
        // only occurs in a child nsIWebProgress instance, then this flag will be
        // set to indicate the start and stop of that activity.
        //
        // For example, in the case of navigation within a single frame of a HTML
        // frameset, a nsIWebProgressListener instance attached to the
        // nsIWebProgress of the frameset window will receive onStateChange calls
        // with the STATE_IS_NETWORK flag set to indicate the start and stop of
        // said navigation.  In other words, an observer of an outer window can
        // determine when activity, that may be constrained to a child window or
        // set of child windows, starts and stops.
        //
        // STATE_IS_WINDOW
        // This flag indicates that the state transition corresponds to the start
        // or stop of activity in the indicated nsIWebProgress instance.  This flag
        // is accompanied by either STATE_START or STATE_STOP, and it may be
        // combined with other State Type Flags.
        //
        // This flag is similar to STATE_IS_DOCUMENT.  However, when a document
        // request completes, two onStateChange calls with STATE_STOP are
        // generated.  The document request is passed as aRequest to both calls.
        // The first has STATE_IS_REQUEST and STATE_IS_DOCUMENT set, and the second
        // has the STATE_IS_WINDOW flag set (and possibly the STATE_IS_NETWORK flag
        // set as well -- see above for a description of when the STATE_IS_NETWORK
        // flag may be set).  This second STATE_STOP event may be useful as a way
        // to partition the work that occurs when a document request completes.
        // </summary>
		public const ulong STATE_IS_REQUEST = 0x00010000;
		
		// 
		public const ulong STATE_IS_DOCUMENT = 0x00020000;
		
		// 
		public const ulong STATE_IS_NETWORK = 0x00040000;
		
		// 
		public const ulong STATE_IS_WINDOW = 0x00080000;
		
		// <summary>
        // State Modifier Flags
        //
        // These flags further describe the transition which is occuring.  These
        // flags are NOT mutually exclusive (i.e., an onStateChange event may
        // indicate some combination of these flags).
        //
        // STATE_RESTORING
        // This flag indicates that the state transition corresponds to the start
        // or stop of activity for restoring a previously-rendered presentation.
        // As such, there is no actual network activity associated with this
        // request, and any modifications made to the document or presentation
        // when it was originally loaded will still be present.
        // </summary>
		public const ulong STATE_RESTORING = 0x01000000;
		
		// <summary>
        // State Security Flags
        //
        // These flags describe the security state reported by a call to the
        // onSecurityChange method.  These flags are mutually exclusive.
        //
        // STATE_IS_INSECURE
        // This flag indicates that the data corresponding to the request
        // was received over an insecure channel.
        //
        // STATE_IS_BROKEN
        // This flag indicates an unknown security state.  This may mean that the
        // request is being loaded as part of a page in which some content was
        // received over an insecure channel.
        //
        // STATE_IS_SECURE
        // This flag indicates that the data corresponding to the request was
        // received over a secure channel.  The degree of security is expressed by
        // STATE_SECURE_HIGH, STATE_SECURE_MED, or STATE_SECURE_LOW.
        // </summary>
		public const ulong STATE_IS_INSECURE = 0x00000004;
		
		// 
		public const ulong STATE_IS_BROKEN = 0x00000001;
		
		// 
		public const ulong STATE_IS_SECURE = 0x00000002;
		
		// <summary>
        // Mixed active content flags
        //
        // May be set in addition to the State Security Flags, to indicate that
        // mixed active content has been encountered.
        //
        // STATE_BLOCKED_MIXED_ACTIVE_CONTENT
        // Mixed active content has been blocked from loading.
        //
        // STATE_LOADED_MIXED_ACTIVE_CONTENT
        // Mixed active content has been loaded. State should be STATE_IS_BROKEN.
        // </summary>
		public const ulong STATE_BLOCKED_MIXED_ACTIVE_CONTENT = 0x00000010;
		
		// 
		public const ulong STATE_LOADED_MIXED_ACTIVE_CONTENT = 0x00000020;
		
		// <summary>
        // Mixed display content flags
        //
        // May be set in addition to the State Security Flags, to indicate that
        // mixed display content has been encountered.
        //
        // STATE_BLOCKED_MIXED_DISPLAY_CONTENT
        // Mixed display content has been blocked from loading.
        //
        // STATE_LOADED_MIXED_DISPLAY_CONTENT
        // Mixed display content has been loaded. State should be STATE_IS_BROKEN.
        // </summary>
		public const ulong STATE_BLOCKED_MIXED_DISPLAY_CONTENT = 0x00000100;
		
		// 
		public const ulong STATE_LOADED_MIXED_DISPLAY_CONTENT = 0x00000200;
		
		// <summary>
        // Security Strength Flags
        //
        // These flags describe the security strength and accompany STATE_IS_SECURE
        // in a call to the onSecurityChange method.  These flags are mutually
        // exclusive.
        //
        // These flags are not meant to provide a precise description of data
        // transfer security.  These are instead intended as a rough indicator that
        // may be used to, for example, color code a security indicator or otherwise
        // provide basic data transfer security feedback to the user.
        //
        // STATE_SECURE_HIGH
        // This flag indicates a high degree of security.
        //
        // STATE_SECURE_MED
        // This flag indicates a medium degree of security.
        //
        // STATE_SECURE_LOW
        // This flag indicates a low degree of security.
        // </summary>
		public const ulong STATE_SECURE_HIGH = 0x00040000;
		
		// 
		public const ulong STATE_SECURE_MED = 0x00010000;
		
		// 
		public const ulong STATE_SECURE_LOW = 0x00020000;
		
		// <summary>
        // State bits for EV == Extended Validation == High Assurance
        //
        // These flags describe the level of identity verification
        // in a call to the onSecurityChange method.
        //
        // STATE_IDENTITY_EV_TOPLEVEL
        // The topmost document uses an EV cert.
        // NOTE: Available since Gecko 1.9
        // </summary>
		public const ulong STATE_IDENTITY_EV_TOPLEVEL = 0x00100000;
		
		// <summary>
        // Flags for onLocationChange
        //
        // LOCATION_CHANGE_SAME_DOCUMENT
        // This flag is on when |aWebProgress| did not load a new document.
        // For example, the location change is due to an anchor scroll or a
        // pushState/popState/replaceState.
        //
        // LOCATION_CHANGE_ERROR_PAGE
        // This flag is on when |aWebProgress| redirected from the requested
        // contents to an internal page to show error status, such as
        // <about:neterror>, <about:certerror> and so on.
        //
        // Generally speaking, |aURI| and |aRequest| are the original data. DOM
        // |window.location.href| is also the original location, while
        // |document.documentURI| is the redirected location. Sometimes |aURI| is
        // <about:blank> and |aRequest| is null when the original data does not
        //   +   remain.
        //
        // |aWebProgress| does NOT set this flag when it did not try to load a new
        // document. In this case, it should set LOCATION_CHANGE_SAME_DOCUMENT.
        // </summary>
		public const ulong LOCATION_CHANGE_SAME_DOCUMENT = 0x00000001;
		
		// 
		public const ulong LOCATION_CHANGE_ERROR_PAGE = 0x00000002;
	}
}
