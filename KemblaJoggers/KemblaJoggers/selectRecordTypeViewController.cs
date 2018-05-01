using Foundation;
using System;
using UIKit;

namespace KemblaJoggers
{
    public partial class selectRecordTypeViewController : UIViewController
    {
        public selectRecordTypeViewController (IntPtr handle) : base (handle)
        {
        }

        partial void SeriesRecordButton_TouchUpInside(UIButton sender)
        {
            UIAlertController loginAlert = UIAlertController.Create("Login Online",
                                                                    "Please enter your email and password",
                                                                    UIAlertControllerStyle.Alert);

            loginAlert.AddTextField((field) =>
            {
                field.Font = UIFont.SystemFontOfSize(22);
                field.Placeholder = "Email";
                field.KeyboardType = UIKeyboardType.EmailAddress;
                field.TextAlignment = UITextAlignment.Center;
            });

            loginAlert.AddTextField((field) =>
            {
                field.Font = UIFont.SystemFontOfSize(22);
                field.Placeholder = "Password";
                field.SecureTextEntry = true;
                field.TextAlignment = UITextAlignment.Center;
            });


            UIAlertAction loginAction;
            loginAction = UIAlertAction.Create("Login",
                                              UIAlertActionStyle.Default,null);

            loginAlert.AddAction(loginAction);

            loginAlert.AddAction(UIAlertAction.Create("Cancel", UIAlertActionStyle.Destructive, null));

           
         
        }

    }
}