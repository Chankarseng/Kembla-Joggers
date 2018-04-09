using Foundation;
using System;
using UIKit;

namespace KemblaJoggers
{
    public partial class loginController : UIViewController
    {
        UIImage image;
        public loginController (IntPtr handle) : base (handle)
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
            effectImage = image.ApplyLightEffect();
            loginBackgroundImage.Image = effectImage;
        }
	}
}