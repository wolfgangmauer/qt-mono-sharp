using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Qt
{
  public class QScrollBar : AbstractSlider
  {
    protected QScrollBar (IntPtr raw) : base(raw) {}
  
      [MethodImpl(MethodImplOptions.InternalCall)]
      protected static extern IntPtr qt_scrollbar_new (ScrollBar thisObject, IntPtr parent);
      public QScrollBar (Widget parent)
          : base(IntPtr.Zero)
      {
          if (Raw != IntPtr.Zero)
              throw new ArgumentException ("Raw not null!");
          Raw = qt_scrollbar_new (this, parent != null ? parent.Handle : IntPtr.Zero);
      }
  
      [MethodImpl (MethodImplOptions.InternalCall)]
      protected static extern IntPtr qt_scrollbar_sizehint_get (IntPtr raw);
      public new Size SizeHint
      {
          get{ return new Size(qt_scrollbar_sizehint_get(Handle));}
      }
  }
}
