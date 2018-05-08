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
    [Register ("eventViewController")]
    partial class eventViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView eventBackgroundImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView eventView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (eventBackgroundImage != null) {
                eventBackgroundImage.Dispose ();
                eventBackgroundImage = null;
            }

            if (eventView != null) {
                eventView.Dispose ();
                eventView = null;
            }
        }
    }
}