using Foundation;
using System;
using UIKit;

namespace KemblaJoggers
{
    public partial class eventViewController : UIViewController
    {
        UIImage image;
        public eventViewController(IntPtr handle) : base(handle)
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
            eventBackgroundImage.Image = effectImage;
        }
    }
}