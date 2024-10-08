﻿using System;
using System.Runtime.CompilerServices;

namespace Qt
{
	public class CommandLinkButton : PushButton
	{
		public CommandLinkButton (IntPtr raw) : base(raw) {}

		[MethodImpl(MethodImplOptions.InternalCall)]
		protected static extern IntPtr qt_commandlinkbutton_new_with_text (PushButton thisObject, string text, IntPtr parent);
		public CommandLinkButton (string text, Widget parent=null)
			: base(IntPtr.Zero)
		{
			if (Raw != IntPtr.Zero)
				throw new ArgumentException ("Raw not null!");
			Raw = qt_commandlinkbutton_new_with_text (this, text, parent != null ? parent.Handle : IntPtr.Zero);
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		protected static extern IntPtr qt_commandlinkbutton_new (PushButton thisObject, IntPtr parent);
		public CommandLinkButton (Widget parent)
			: base(IntPtr.Zero)
		{
			if (Raw != IntPtr.Zero)
				throw new ArgumentException ("Raw not null!");
			Raw = qt_commandlinkbutton_new (this, parent != null ? parent.Handle : IntPtr.Zero);
		}

		[MethodImpl (MethodImplOptions.InternalCall)]
		protected static extern IntPtr qt_commandlinkbutton_sizehint_get (IntPtr raw);
		public new Size SizeHint
		{
			get{ return new Size(qt_commandlinkbutton_sizehint_get(Handle));}
		}
	}
}

