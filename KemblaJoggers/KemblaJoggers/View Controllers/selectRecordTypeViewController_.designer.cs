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
    [Register ("selectRecordTypeViewController")]
    partial class selectRecordTypeViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton viewRaceRecordButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton viewSeriesRecordButton { get; set; }

        [Action ("ViewRaceRecordButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ViewRaceRecordButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("ViewSeriesRecordButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ViewSeriesRecordButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (viewRaceRecordButton != null) {
                viewRaceRecordButton.Dispose ();
                viewRaceRecordButton = null;
            }

            if (viewSeriesRecordButton != null) {
                viewSeriesRecordButton.Dispose ();
                viewSeriesRecordButton = null;
            }
        }
    }
}