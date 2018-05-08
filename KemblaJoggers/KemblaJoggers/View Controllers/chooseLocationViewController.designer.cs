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
    [Register ("chooseLocationViewController")]
    partial class chooseLocationViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField addressTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView locationImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        MapKit.MKMapView locationMap { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton setLocationButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton zoomToUserButton { get; set; }

        [Action ("SetLocationButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SetLocationButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("ZoomToUserButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ZoomToUserButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (addressTextField != null) {
                addressTextField.Dispose ();
                addressTextField = null;
            }

            if (locationImage != null) {
                locationImage.Dispose ();
                locationImage = null;
            }

            if (locationMap != null) {
                locationMap.Dispose ();
                locationMap = null;
            }

            if (setLocationButton != null) {
                setLocationButton.Dispose ();
                setLocationButton = null;
            }

            if (zoomToUserButton != null) {
                zoomToUserButton.Dispose ();
                zoomToUserButton = null;
            }
        }
    }
}