using System;
using System.Runtime.CompilerServices;

namespace Qt
{
	public class StandardItem
	{
		IntPtr raw;

		public IntPtr Handle { get { return raw; }}

		[MethodImpl (MethodImplOptions.InternalCall)]
		protected static extern IntPtr qt_standarditem_new (string text);
		public StandardItem (string text)
		{
			raw = qt_standarditem_new (text);
		}

		public StandardItem (IntPtr raw)
		{
			raw = raw;
		}

		[MethodImpl (MethodImplOptions.InternalCall)]
		protected static extern string qt_standarditem_text_get (IntPtr handle);
		[MethodImpl (MethodImplOptions.InternalCall)]
		protected static extern void qt_standarditem_text_set (IntPtr handle, string text);
		public string Text
		{
			get { return qt_standarditem_text_get(raw); }
			set { qt_standarditem_text_set(raw, value); }
		}
	}
}

