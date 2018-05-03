using Foundation;
using System;
using UIKit;
using System.Resources;
using Xamarin.Auth;

namespace KemblaJoggers
{
    public partial class menuViewController : UIViewController
    {
        UIImage image;

        public menuViewController (IntPtr handle) : base (handle)
        {
        }

		public menuViewController()
		{
		}

		public override void ViewDidLoad()
		{
            base.ViewDidLoad();
            this.NavigationController.NavigationBar.Translucent = true;
            image = UIImage.FromBundle("Background");
            updateImage();
            this.NavigationController.SetNavigationBarHidden(false, false);
            this.NavigationItem.HidesBackButton = true;

             

		}



        void updateImage()
        {
            UIImage effectImage = null;
            effectImage = image.ApplyDarkEffect();
            menuBackgroundImage.Image = effectImage;
        }

        partial void UIButton2250_TouchUpInside(UIButton sender)
        {
            // Transfer
        }
    }
}