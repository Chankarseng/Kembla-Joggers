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
        UIKit.UIButton raceRecordButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton seriesRecordButton { get; set; }

        [Action ("SeriesRecordButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SeriesRecordButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (raceRecordButton != null) {
                raceRecordButton.Dispose ();
                raceRecordButton = null;
            }

            if (seriesRecordButton != null) {
                seriesRecordButton.Dispose ();
                seriesRecordButton = null;
            }
        }
    }
}