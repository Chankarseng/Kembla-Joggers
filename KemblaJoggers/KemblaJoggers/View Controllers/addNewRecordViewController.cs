using Foundation;
using System;
using UIKit;

namespace KemblaJoggers
{
    public partial class addNewRecordViewController : UIViewController
    {
        public addNewRecordViewController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        partial void CheckButton_TouchUpInside(UIButton sender)
        {
            rightView.Hidden = false;
        }
    }
}