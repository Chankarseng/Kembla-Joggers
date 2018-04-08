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
    [Register ("reportController")]
    partial class reportController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView reportBackgroundImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView scrollView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (reportBackgroundImage != null) {
                reportBackgroundImage.Dispose ();
                reportBackgroundImage = null;
            }

            if (scrollView != null) {
                scrollView.Dispose ();
                scrollView = null;
            }
        }
    }
}