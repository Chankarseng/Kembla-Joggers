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
    [Register ("settingController")]
    partial class settingController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView settingBackgroundImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView settingView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton syncButton { get; set; }

        [Action ("SyncButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SyncButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (settingBackgroundImage != null) {
                settingBackgroundImage.Dispose ();
                settingBackgroundImage = null;
            }

            if (settingView != null) {
                settingView.Dispose ();
                settingView = null;
            }

            if (syncButton != null) {
                syncButton.Dispose ();
                syncButton = null;
            }
        }
    }
}