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
// Generated by IDLImporter from file nsIDOMCSSRule.idl
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
    /// The nsIDOMCSSRule interface is a datatype for a CSS style rule in
    /// the Document Object Model.
    ///
    /// For more information on this interface please see
    /// http://www.w3.org/TR/DOM-Level-2-Style
    /// </summary>
    [ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2938307a-9d70-4b63-8afc-0197e82318ad")]
	public interface nsIDOMCSSRule
	{
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetTypeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCssTextAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCssText);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCssTextAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCssText);
		
		/// <summary>
        /// raises(DOMException) on setting
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSStyleSheet GetParentStyleSheetAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSRule GetParentRuleAttribute();
	}
	
	/// <summary>nsIDOMCSSRuleConsts </summary>
	public class nsIDOMCSSRuleConsts
	{
		
		// <summary>
        // RuleType
        // </summary>
		public const ushort UNKNOWN_RULE = 0;
		
		// 
		public const ushort STYLE_RULE = 1;
		
		// 
		public const ushort CHARSET_RULE = 2;
		
		// 
		public const ushort IMPORT_RULE = 3;
		
		// 
		public const ushort MEDIA_RULE = 4;
		
		// 
		public const ushort FONT_FACE_RULE = 5;
		
		// 
		public const ushort PAGE_RULE = 6;
		
		// 
		public const ushort KEYFRAMES_RULE = 7;
		
		// 
		public const ushort KEYFRAME_RULE = 8;
		
		// <summary>
        // we should remove these two MOZ_* constants.
        // </summary>
		public const ushort MOZ_KEYFRAMES_RULE = 7;
		
		// 
		public const ushort MOZ_KEYFRAME_RULE = 8;
		
		// 
		public const ushort NAMESPACE_RULE = 10;
		
		// 
		public const ushort SUPPORTS_RULE = 12;
		
		// 
		public const ushort FONT_FEATURE_VALUES_RULE = 14;
	}
}
