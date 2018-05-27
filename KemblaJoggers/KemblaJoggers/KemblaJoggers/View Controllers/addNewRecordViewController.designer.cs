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
    [Register ("addNewRecordViewController")]
    partial class addNewRecordViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton addButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton checkButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField courseSearch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField dateSearch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView leftView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField locationSearch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField memberIDSearch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView rightView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField seriesSearch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISegmentedControl surfaceTypeSeg { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField timeSearch { get; set; }

        [Action ("CheckButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CheckButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (addButton != null) {
                addButton.Dispose ();
                addButton = null;
            }

            if (checkButton != null) {
                checkButton.Dispose ();
                checkButton = null;
            }

            if (courseSearch != null) {
                courseSearch.Dispose ();
                courseSearch = null;
            }

            if (dateSearch != null) {
                dateSearch.Dispose ();
                dateSearch = null;
            }

            if (leftView != null) {
                leftView.Dispose ();
                leftView = null;
            }

            if (locationSearch != null) {
                locationSearch.Dispose ();
                locationSearch = null;
            }

            if (memberIDSearch != null) {
                memberIDSearch.Dispose ();
                memberIDSearch = null;
            }

            if (rightView != null) {
                rightView.Dispose ();
                rightView = null;
            }

            if (seriesSearch != null) {
                seriesSearch.Dispose ();
                seriesSearch = null;
            }

            if (surfaceTypeSeg != null) {
                surfaceTypeSeg.Dispose ();
                surfaceTypeSeg = null;
            }

            if (timeSearch != null) {
                timeSearch.Dispose ();
                timeSearch = null;
            }
        }
    }
}