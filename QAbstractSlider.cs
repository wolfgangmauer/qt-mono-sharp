using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Qt
{
	public abstract class AbstractSlider : Widget
	{
		protected AbstractSlider (IntPtr raw) : base (raw) { }

		[MethodImpl(MethodImplOptions.InternalCall)]
		protected static extern int qt_abstractslider_minimum_get(IntPtr raw);
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected static extern void qt_abstractslider_minimum_set(IntPtr raw, int minimum);
		public int Minimum
		{
			get
			{
				return qt_abstractslider_minimum_get(Handle);
			}
			set
			{
				qt_abstractslider_minimum_set(Handle, value);
			}
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		protected static extern int qt_abstractslider_maximum_get(IntPtr raw);
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected static extern void qt_abstractslider_maximum_set(IntPtr raw, int maximum);
		public int Maximum
		{
			get
			{
				return qt_abstractslider_maximum_get(Handle);
			}
			set
			{
				qt_abstractslider_maximum_set(Handle, value);
			}
		}
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected static extern int qt_abstractslider_singlestep_get(IntPtr raw);
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected static extern void qt_abstractslider_singlestep_set(IntPtr raw, int singestep);
		public int SingleStep
		{
			get
			{
				return qt_abstractslider_singlestep_get(Handle);
			}
			set
			{
				qt_abstractslider_singlestep_set(Handle, value);
			}
		}
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected static extern int qt_abstractslider_pagestep_get(IntPtr raw);
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected static extern void qt_abstractslider_pagestep_set(IntPtr raw, int pagestep);
		public int PageStep
		{
			get
			{
				return qt_abstractslider_pagestep_get(Handle);
			}
			set
			{
				qt_abstractslider_pagestep_set(Handle, value);
			}
		}
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected static extern int qt_abstractslider_value_get(IntPtr raw);
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected static extern void qt_abstractslider_value_set(IntPtr raw, int value);
		public int Value
		{
			get
			{
				return qt_abstractslider_pagestep_get(Handle);
			}
			set
			{
				qt_abstractslider_pagestep_set(Handle, value);
			}
		}
	}
}
