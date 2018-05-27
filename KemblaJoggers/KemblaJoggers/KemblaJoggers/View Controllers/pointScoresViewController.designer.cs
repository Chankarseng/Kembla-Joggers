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
    [Register ("pointScoresViewController")]
    partial class pointScoresViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISearchBar pointScoreSearchBar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView pointScoreTableView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (pointScoreSearchBar != null) {
                pointScoreSearchBar.Dispose ();
                pointScoreSearchBar = null;
            }

            if (pointScoreTableView != null) {
                pointScoreTableView.Dispose ();
                pointScoreTableView = null;
            }
        }
    }
}