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
        UIKit.UIView leftView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView rightView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (leftView != null) {
                leftView.Dispose ();
                leftView = null;
            }

            if (rightView != null) {
                rightView.Dispose ();
                rightView = null;
            }
        }
    }
}