// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MacDatabase
{
	[Register ("SubviewTableBinding")]
	partial class SubviewTableBinding
	{
		[Outlet]
		AppKit.NSTableView PeopleTable { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (PeopleTable != null) {
				PeopleTable.Dispose ();
				PeopleTable = null;
			}
		}
	}
}
