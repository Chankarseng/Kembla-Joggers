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
    [Register ("handicapViewController")]
    partial class handicapViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISearchBar handicapSearchBar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView handicapTimeTableView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView handicapView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISearchDisplayController searchDisplayController { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (handicapSearchBar != null) {
                handicapSearchBar.Dispose ();
                handicapSearchBar = null;
            }

            if (handicapTimeTableView != null) {
                handicapTimeTableView.Dispose ();
                handicapTimeTableView = null;
            }

            if (handicapView != null) {
                handicapView.Dispose ();
                handicapView = null;
            }

            if (searchDisplayController != null) {
                searchDisplayController.Dispose ();
                searchDisplayController = null;
            }
        }
    }
}