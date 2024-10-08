﻿using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Qt
{
	public class Label : Frame
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected static extern IntPtr qt_label_new (Label thisObject, IntPtr parent, WindowType f);

		[MethodImpl(MethodImplOptions.InternalCall)]
		protected static extern IntPtr qt_label_new_with_text (Label thisObject, string text, IntPtr parent, WindowType f);

		public Label (string text, Widget parent=null, WindowType f = 0)
			: base(IntPtr.Zero)
		{
			if (Raw != IntPtr.Zero)
				throw new ArgumentException ("Raw not null!");
			Raw = qt_label_new_with_text (this, text, parent != null ? parent.Handle : IntPtr.Zero, f);
		}

		public Label (Widget parent)
			: base(IntPtr.Zero)
		{
			if (Raw != IntPtr.Zero)
				throw new ArgumentException ("Raw not null!");
			Raw = qt_label_new (this, parent != null ? parent.Handle : IntPtr.Zero, 0);
		}

		public Label (Widget parent, WindowType f = 0)
			: base(IntPtr.Zero)
		{
			if (Raw != IntPtr.Zero)
				throw new ArgumentException ("Raw not null!");
			Raw = qt_label_new (this, parent != null ? parent.Handle : IntPtr.Zero, f);
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		protected static extern string qt_label_text_get(IntPtr raw);
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected static extern void qt_label_text_set(IntPtr raw, string text);
		public string Text
		{
			get
			{
				return qt_label_text_get(Handle);
			}
			set
			{
				qt_label_text_set(Handle, value);
			}
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		protected static extern IntPtr qt_label_pixmap_get(IntPtr raw);
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected static extern void qt_label_pixmap_set(IntPtr raw, IntPtr pixmap);
		public Pixmap Pixmap
		{
			get
			{
				var ptr = qt_label_pixmap_get(Handle);
				if (ptr == IntPtr.Zero)
					return null;
				var retVal = new Pixmap (ptr);
				return retVal;
			}
			set
			{
				qt_label_pixmap_set(Handle, value.Handle);
			}
		}

        [MethodImpl(MethodImplOptions.InternalCall)]
        protected static extern Alignment qt_label_alignment_get(IntPtr raw);
        [MethodImpl(MethodImplOptions.InternalCall)]
        protected static extern void qt_label_alignment_set(IntPtr raw, Alignment alignment);
        public Alignment Alignment
        {
            get
            {
                return qt_label_alignment_get(Handle);
            }
            set
            {
                qt_label_alignment_set(Handle, value);
            }
        }

		[MethodImpl(MethodImplOptions.InternalCall)]
		protected static extern TextInteractionFlag qt_label_textinteractionflags_get(IntPtr raw);
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected static extern void qt_label_textinteractionflags_set(IntPtr raw, TextInteractionFlag flag);
		public TextInteractionFlag TextInteractionFlags
		{
			get
			{
				return qt_label_textinteractionflags_get(Handle);
			}
			set
			{
				qt_label_textinteractionflags_set(Handle, value);
			}
		}

        [MethodImpl(MethodImplOptions.InternalCall)]
        protected static extern int qt_label_indent_get(IntPtr raw);
        [MethodImpl(MethodImplOptions.InternalCall)]
        protected static extern void qt_label_indent_set(IntPtr raw, int indent);
        public int Indent
        {
            get
            {
                return qt_label_indent_get(Handle);
            }
            set
            {
                qt_label_indent_set(Handle, value);
            }
        }

		[MethodImpl(MethodImplOptions.InternalCall)]
		protected static extern TextFormat qt_label_textformat_get(IntPtr raw);
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected static extern void qt_label_textformat_set(IntPtr raw, TextFormat format);
		public TextFormat TextFormat
		{
			get
			{
				return qt_label_textformat_get(Handle);
			}
			set
			{
				qt_label_textformat_set(Handle, value);
			}
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		protected static extern bool qt_label_scaledcontents_get(IntPtr raw);
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected static extern void qt_label_scaledcontents_set(IntPtr raw, bool scaled);
		public bool ScaledContents{
			get
			{
				return qt_label_scaledcontents_get(Handle);
			}
			set
			{
				qt_label_scaledcontents_set(Handle, value);
			}
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		protected static extern bool qt_label_wordwrap_get(IntPtr raw);
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected static extern void qt_label_wordwrap_set(IntPtr raw, bool wrap);
		public bool WordWrap{
			get
			{
				return qt_label_wordwrap_get(Handle);
			}
			set
			{
				qt_label_wordwrap_set(Handle, value);
			}
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		protected static extern int qt_label_margin_get(IntPtr raw);
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected static extern void qt_label_margin_set(IntPtr raw, int margin);
		public int Margin{
			get
			{
				return qt_label_margin_get(Handle);
			}
			set
			{
				qt_label_margin_set(Handle, value);
			}
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		protected static extern bool qt_label_clear(IntPtr raw);
		public void Clear()
		{
			qt_label_clear (Handle);
		}
    }
}

