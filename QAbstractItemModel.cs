using System;

namespace Qt
{
	public abstract class AbstractItemModel : Object
	{
		protected AbstractItemModel (IntPtr raw) : base (raw) { }
  		protected virtual object data(ModelIndex index, int role = Qt.DisplayRole);
	}
}

