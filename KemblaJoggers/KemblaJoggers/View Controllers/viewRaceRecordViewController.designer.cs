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
    [Register ("viewRaceRecordViewController")]
    partial class viewRaceRecordViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel courseLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel locationLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton raceRecordChangeButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView RaceRecordTableView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewRaceRecordView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (courseLabel != null) {
                courseLabel.Dispose ();
                courseLabel = null;
            }

            if (locationLabel != null) {
                locationLabel.Dispose ();
                locationLabel = null;
            }

            if (raceRecordChangeButton != null) {
                raceRecordChangeButton.Dispose ();
                raceRecordChangeButton = null;
            }

            if (RaceRecordTableView != null) {
                RaceRecordTableView.Dispose ();
                RaceRecordTableView = null;
            }

            if (viewRaceRecordView != null) {
                viewRaceRecordView.Dispose ();
                viewRaceRecordView = null;
            }
        }
    }
}