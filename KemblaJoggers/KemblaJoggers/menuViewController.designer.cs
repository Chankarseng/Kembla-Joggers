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
    [Register ("menuViewController")]
    partial class menuViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView menuBackgroundImage { get; set; }

        [Action ("UIButton2250_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton2250_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (menuBackgroundImage != null) {
                menuBackgroundImage.Dispose ();
                menuBackgroundImage = null;
            }
        }
    }
}