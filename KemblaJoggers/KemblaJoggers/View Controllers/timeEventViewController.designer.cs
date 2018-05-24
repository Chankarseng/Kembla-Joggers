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
    [Register ("timeEventViewController")]
    partial class timeEventViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton doneButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton lapButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView lapTimings { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton startButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel timerLabel { get; set; }

        [Action ("DoneButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void DoneButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (doneButton != null) {
                doneButton.Dispose ();
                doneButton = null;
            }

            if (lapButton != null) {
                lapButton.Dispose ();
                lapButton = null;
            }

            if (lapTimings != null) {
                lapTimings.Dispose ();
                lapTimings = null;
            }

            if (startButton != null) {
                startButton.Dispose ();
                startButton = null;
            }

            if (timerLabel != null) {
                timerLabel.Dispose ();
                timerLabel = null;
            }
        }
    }
}