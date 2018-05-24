using Foundation;
using System;
using UIKit;

namespace KemblaJoggers
{
    public partial class pointScoresViewController : UIViewController
    {
        public pointScoresViewController (IntPtr handle) : base (handle)
        {
        }
		public override void ViewDidLoad()
		{
            base.ViewDidLoad();
		}

        partial void ViewButton_TouchUpInside(UIButton sender)
        {
            rightView.Hidden = false;
            //throw new NotImplementedException();
        }
    }
}