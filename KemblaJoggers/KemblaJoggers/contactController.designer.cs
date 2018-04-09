// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace KemblaJoggers
{
    [Register ("contactController")]
    partial class contactController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView contactsTableView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (contactsTableView != null) {
                contactsTableView.Dispose ();
                contactsTableView = null;
            }
        }
    }
}