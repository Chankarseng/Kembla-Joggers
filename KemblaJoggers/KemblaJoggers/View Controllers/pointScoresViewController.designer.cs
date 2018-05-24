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
        UIKit.UIView leftView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISearchBar pointScoreSearchBar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField pointScoreTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView rightView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField seriesTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton viewButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField yearTextField { get; set; }

        [Action ("ViewButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ViewButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (leftView != null) {
                leftView.Dispose ();
                leftView = null;
            }

            if (pointScoreSearchBar != null) {
                pointScoreSearchBar.Dispose ();
                pointScoreSearchBar = null;
            }

            if (pointScoreTextField != null) {
                pointScoreTextField.Dispose ();
                pointScoreTextField = null;
            }

            if (rightView != null) {
                rightView.Dispose ();
                rightView = null;
            }

            if (seriesTextField != null) {
                seriesTextField.Dispose ();
                seriesTextField = null;
            }

            if (viewButton != null) {
                viewButton.Dispose ();
                viewButton = null;
            }

            if (yearTextField != null) {
                yearTextField.Dispose ();
                yearTextField = null;
            }
        }
    }
}