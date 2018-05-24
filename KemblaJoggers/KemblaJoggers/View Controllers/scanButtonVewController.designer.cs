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
    [Register ("scanButtonVewController")]
    partial class scanButtonVewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton detailsButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton doneButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton memScanButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton posScanButton { get; set; }

        [Action ("DetailsButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void DetailsButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (detailsButton != null) {
                detailsButton.Dispose ();
                detailsButton = null;
            }

            if (doneButton != null) {
                doneButton.Dispose ();
                doneButton = null;
            }

            if (memScanButton != null) {
                memScanButton.Dispose ();
                memScanButton = null;
            }

            if (posScanButton != null) {
                posScanButton.Dispose ();
                posScanButton = null;
            }
        }
    }
}