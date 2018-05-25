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
    [Register ("chooseEventViewController")]
    partial class chooseEventViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView courseTableView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField dateTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView locationTableView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton timeEventButton { get; set; }

        [Action ("TimeEventButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void TimeEventButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (courseTableView != null) {
                courseTableView.Dispose ();
                courseTableView = null;
            }

            if (dateTextField != null) {
                dateTextField.Dispose ();
                dateTextField = null;
            }

            if (locationTableView != null) {
                locationTableView.Dispose ();
                locationTableView = null;
            }

            if (timeEventButton != null) {
                timeEventButton.Dispose ();
                timeEventButton = null;
            }
        }
    }
}