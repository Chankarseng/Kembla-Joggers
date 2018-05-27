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
    [Register ("viewSeriesRecordViewController")]
    partial class viewSeriesRecordViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel seriesLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton seriesRecordChangeButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView seriesRecordTableView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewSeriesRecordView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel yearLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (seriesLabel != null) {
                seriesLabel.Dispose ();
                seriesLabel = null;
            }

            if (seriesRecordChangeButton != null) {
                seriesRecordChangeButton.Dispose ();
                seriesRecordChangeButton = null;
            }

            if (seriesRecordTableView != null) {
                seriesRecordTableView.Dispose ();
                seriesRecordTableView = null;
            }

            if (viewSeriesRecordView != null) {
                viewSeriesRecordView.Dispose ();
                viewSeriesRecordView = null;
            }

            if (yearLabel != null) {
                yearLabel.Dispose ();
                yearLabel = null;
            }
        }
    }
}