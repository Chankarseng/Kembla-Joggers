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
    [Register ("courseManagementChooseViewController")]
    partial class courseManagementChooseViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton addLocationButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView courseTableView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView locationTableView { get; set; }

        [Action ("AddLocationButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void AddLocationButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (addLocationButton != null) {
                addLocationButton.Dispose ();
                addLocationButton = null;
            }

            if (courseTableView != null) {
                courseTableView.Dispose ();
                courseTableView = null;
            }

            if (locationTableView != null) {
                locationTableView.Dispose ();
                locationTableView = null;
            }
        }
    }
}