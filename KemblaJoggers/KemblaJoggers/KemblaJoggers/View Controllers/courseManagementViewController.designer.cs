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
    [Register ("courseManagementViewController")]
    partial class courseManagementViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField courseIDTF { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField distanceTF { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField handicapCTF { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField handicapFTF { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField handicapTF { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField keepRecordTF { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField leg1TF { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField leg2TF { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField leg3TF { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField leg4TF { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField locationTF { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField minAge31TF { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField penaltyTF { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField relayTF { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton saveButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField surfaceTF { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField unitsTF { get; set; }

        [Action ("SaveButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SaveButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (courseIDTF != null) {
                courseIDTF.Dispose ();
                courseIDTF = null;
            }

            if (distanceTF != null) {
                distanceTF.Dispose ();
                distanceTF = null;
            }

            if (handicapCTF != null) {
                handicapCTF.Dispose ();
                handicapCTF = null;
            }

            if (handicapFTF != null) {
                handicapFTF.Dispose ();
                handicapFTF = null;
            }

            if (handicapTF != null) {
                handicapTF.Dispose ();
                handicapTF = null;
            }

            if (keepRecordTF != null) {
                keepRecordTF.Dispose ();
                keepRecordTF = null;
            }

            if (leg1TF != null) {
                leg1TF.Dispose ();
                leg1TF = null;
            }

            if (leg2TF != null) {
                leg2TF.Dispose ();
                leg2TF = null;
            }

            if (leg3TF != null) {
                leg3TF.Dispose ();
                leg3TF = null;
            }

            if (leg4TF != null) {
                leg4TF.Dispose ();
                leg4TF = null;
            }

            if (locationTF != null) {
                locationTF.Dispose ();
                locationTF = null;
            }

            if (minAge31TF != null) {
                minAge31TF.Dispose ();
                minAge31TF = null;
            }

            if (penaltyTF != null) {
                penaltyTF.Dispose ();
                penaltyTF = null;
            }

            if (relayTF != null) {
                relayTF.Dispose ();
                relayTF = null;
            }

            if (saveButton != null) {
                saveButton.Dispose ();
                saveButton = null;
            }

            if (surfaceTF != null) {
                surfaceTF.Dispose ();
                surfaceTF = null;
            }

            if (unitsTF != null) {
                unitsTF.Dispose ();
                unitsTF = null;
            }
        }
    }
}