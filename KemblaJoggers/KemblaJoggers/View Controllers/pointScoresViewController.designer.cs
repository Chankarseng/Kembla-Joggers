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
        UIKit.UIView rightView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton viewButton { get; set; }

        [Action ("ViewButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ViewButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (leftView != null) {
                leftView.Dispose ();
                leftView = null;
            }

            if (rightView != null) {
                rightView.Dispose ();
                rightView = null;
            }

            if (viewButton != null) {
                viewButton.Dispose ();
                viewButton = null;
            }
        }
    }
}