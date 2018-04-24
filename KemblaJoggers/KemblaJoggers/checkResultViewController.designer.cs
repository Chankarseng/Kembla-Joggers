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
    [Register ("checkResultViewController")]
    partial class checkResultViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView checkResultTableView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView checkResultView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton commitButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (checkResultTableView != null) {
                checkResultTableView.Dispose ();
                checkResultTableView = null;
            }

            if (checkResultView != null) {
                checkResultView.Dispose ();
                checkResultView = null;
            }

            if (commitButton != null) {
                commitButton.Dispose ();
                commitButton = null;
            }
        }
    }
}