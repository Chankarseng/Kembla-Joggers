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
    [Register ("PointScoresCell")]
    partial class PointScoresCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel nameLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel placeLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel pointScoreLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (nameLabel != null) {
                nameLabel.Dispose ();
                nameLabel = null;
            }

            if (placeLabel != null) {
                placeLabel.Dispose ();
                placeLabel = null;
            }

            if (pointScoreLabel != null) {
                pointScoreLabel.Dispose ();
                pointScoreLabel = null;
            }
        }
    }
}