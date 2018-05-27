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
    [Register ("checkResultViewController")]
    partial class checkResultViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField categoryTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView checkResultTableView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView checkResultView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton commitButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField dateTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField distanceTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField handicapBufTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField handicapDetTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField handicapFacTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField locationTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField numLegsTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField relayTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton resultEditButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField surfaceTypeTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField unitTextField { get; set; }

        [Action ("CommitButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CommitButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("ResultEditButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ResultEditButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (categoryTextField != null) {
                categoryTextField.Dispose ();
                categoryTextField = null;
            }

            if (checkResultTableView != null) {
                checkResultTableView.Dispose ();
                checkResultTableView = null;
            }

            if (checkResultView != null) {
                checkResultView.Dispose ();
                checkResultView = null;
            }

            if (commitButton != null) {
                commitButton.Dispose ();
                commitButton = null;
            }

            if (dateTextField != null) {
                dateTextField.Dispose ();
                dateTextField = null;
            }

            if (distanceTextField != null) {
                distanceTextField.Dispose ();
                distanceTextField = null;
            }

            if (handicapBufTextField != null) {
                handicapBufTextField.Dispose ();
                handicapBufTextField = null;
            }

            if (handicapDetTextField != null) {
                handicapDetTextField.Dispose ();
                handicapDetTextField = null;
            }

            if (handicapFacTextField != null) {
                handicapFacTextField.Dispose ();
                handicapFacTextField = null;
            }

            if (locationTextField != null) {
                locationTextField.Dispose ();
                locationTextField = null;
            }

            if (numLegsTextField != null) {
                numLegsTextField.Dispose ();
                numLegsTextField = null;
            }

            if (relayTextField != null) {
                relayTextField.Dispose ();
                relayTextField = null;
            }

            if (resultEditButton != null) {
                resultEditButton.Dispose ();
                resultEditButton = null;
            }

            if (surfaceTypeTextField != null) {
                surfaceTypeTextField.Dispose ();
                surfaceTypeTextField = null;
            }

            if (unitTextField != null) {
                unitTextField.Dispose ();
                unitTextField = null;
            }
        }
    }
}