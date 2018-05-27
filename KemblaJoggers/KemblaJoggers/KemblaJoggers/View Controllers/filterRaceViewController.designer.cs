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
    [Register ("filterRaceViewController")]
    partial class filterRaceViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField filterCourseTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField filterDateTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField filterLocationTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField filterNameTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView filterRaceController { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView filterRaceTableView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel testlabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (filterCourseTextField != null) {
                filterCourseTextField.Dispose ();
                filterCourseTextField = null;
            }

            if (filterDateTextField != null) {
                filterDateTextField.Dispose ();
                filterDateTextField = null;
            }

            if (filterLocationTextField != null) {
                filterLocationTextField.Dispose ();
                filterLocationTextField = null;
            }

            if (filterNameTextField != null) {
                filterNameTextField.Dispose ();
                filterNameTextField = null;
            }

            if (filterRaceController != null) {
                filterRaceController.Dispose ();
                filterRaceController = null;
            }

            if (filterRaceTableView != null) {
                filterRaceTableView.Dispose ();
                filterRaceTableView = null;
            }

            if (testlabel != null) {
                testlabel.Dispose ();
                testlabel = null;
            }
        }
    }
}