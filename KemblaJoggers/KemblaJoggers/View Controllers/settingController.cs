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

        partial void SyncButton_TouchUpInside(UIButton sender)
        {
            if (AppData.online == false)
            {
                UIAlertView alertView = new UIAlertView();
                alertView.Title = "Failed to sync";
                alertView.AddButton("Ok");
                alertView.Message = "Please login with TidyHQ to sync";
                alertView.Show();
            }
            else
            {
                ReadWriteDisk.writeContacts();
                ReadWriteDisk.writeCourses();
                ReadWriteDisk.writeLocation();
                ReadWriteDisk.writeRecord();
                ReadWriteDisk.writeRaceResults();
                saveDataToCloud.Save();
                UIAlertView alertView = new UIAlertView();
                alertView.Title = "Sync";
                alertView.AddButton("Ok");
                alertView.Message = "Synching with Firebase completed";
                alertView.Show();
			}
        }
    }
}