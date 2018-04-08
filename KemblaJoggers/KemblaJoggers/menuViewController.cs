using Foundation;
using System;
using UIKit;
using System.Resources;

namespace KemblaJoggers
{
    public partial class menuViewController : UIViewController
    {
        UIImage image;

        public menuViewController (IntPtr handle) : base (handle)
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
            menuBackgroundImage.Image = effectImage;
        }
	}
}