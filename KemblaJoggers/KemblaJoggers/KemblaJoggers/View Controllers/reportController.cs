using Foundation;
using System;
using UIKit;
using System.Resources;

namespace KemblaJoggers
{
    public partial class reportController : UIViewController
    {
        UIImage image;
        public reportController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            image = UIImage.FromBundle("Background");
            this.NavigationController.NavigationBar.Translucent = true;
            updateImage();
        }
        void updateImage()
        {
            UIImage effectImage = null;
            effectImage = image.ApplyDarkEffect();
            reportBackgroundImage.Image = effectImage;
        }
    }
}