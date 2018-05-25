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
    [Register ("ParticipationCell")]
    partial class ParticipationCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ageGroupLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel nameLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel raceCountLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ageGroupLabel != null) {
                ageGroupLabel.Dispose ();
                ageGroupLabel = null;
            }

            if (nameLabel != null) {
                nameLabel.Dispose ();
                nameLabel = null;
            }

            if (raceCountLabel != null) {
                raceCountLabel.Dispose ();
                raceCountLabel = null;
            }
        }
    }
}