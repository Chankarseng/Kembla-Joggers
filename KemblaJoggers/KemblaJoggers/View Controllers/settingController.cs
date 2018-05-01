using Foundation;
using System;
using UIKit;

namespace KemblaJoggers
{
    public partial class settingController : UIViewController
    {
        UIImage image;
        public settingController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            image = UIImage.FromBundle("Background");
            updateImage();
        }
        void updateImage()
        {
            UIImage effectImage = null;
            effectImage = image.ApplyDarkEffect();
            settingBackgroundImage.Image = effectImage;
        }
    }
}