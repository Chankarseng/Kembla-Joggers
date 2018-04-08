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
    [Register ("contactController")]
    partial class contactController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView contactsTableView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField contactVAddress { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField contactVCity { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField contactVCountry { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField contactVEmail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField contactVFirst { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField contactVGender { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField contactVId { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField contactVLast { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField contactVPost { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField contactVState { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (contactsTableView != null) {
                contactsTableView.Dispose ();
                contactsTableView = null;
            }

            if (contactVAddress != null) {
                contactVAddress.Dispose ();
                contactVAddress = null;
            }

            if (contactVCity != null) {
                contactVCity.Dispose ();
                contactVCity = null;
            }

            if (contactVCountry != null) {
                contactVCountry.Dispose ();
                contactVCountry = null;
            }

            if (contactVEmail != null) {
                contactVEmail.Dispose ();
                contactVEmail = null;
            }

            if (contactVFirst != null) {
                contactVFirst.Dispose ();
                contactVFirst = null;
            }

            if (contactVGender != null) {
                contactVGender.Dispose ();
                contactVGender = null;
            }

            if (contactVId != null) {
                contactVId.Dispose ();
                contactVId = null;
            }

            if (contactVLast != null) {
                contactVLast.Dispose ();
                contactVLast = null;
            }

            if (contactVPost != null) {
                contactVPost.Dispose ();
                contactVPost = null;
            }

            if (contactVState != null) {
                contactVState.Dispose ();
                contactVState = null;
            }
        }
    }
}