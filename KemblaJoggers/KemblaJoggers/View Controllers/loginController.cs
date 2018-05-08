using Foundation;
using System;
using UIKit;
using Xamarin.Auth;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Globalization;

namespace KemblaJoggers
{
    public partial class loginController : UIViewController
    {
        UIImage image;
        //Account account;
        //AccountStore store;
        public loginController (IntPtr handle) : base (handle)
        {
        }
		public override void ViewDidLoad()
		{
            CultureInfo cultureInfo = new CultureInfo("en-AU");
            CultureInfo.CurrentCulture = cultureInfo;
            base.ViewDidLoad();
            if (NavigationController != null)
            {
				this.NavigationController.SetNavigationBarHidden(true, true);
            }
            image = UIImage.FromBundle("Background");
            updateImage();
            //accounts = AccountStore.Create().FindAccountsForService("TidyHq");
		}

        partial void LoginButton_TouchUpInside(UIButton sender)
        {
            /*var auth = new OAuth2Authenticator(clientId: "750aa6d449c1c1d58dafb00eacc374f169793c26345ed56794d51dfb2da4f61f",
                                               scope: "",
                                               authorizeUrl: new Uri("https://accounts.tidyhq.com/oauth/authorize"),
                                               redirectUrl: new Uri("https://dart.tidyhq.com/"));
            */
            //auth.Completed += Auth_Completed;
            //var ui = auth.GetUI();
            //PresentViewController(ui, true, null);
        }

        private async void Auth_Completed(object sender, AuthenticatorCompletedEventArgs e) {
            if (e.IsAuthenticated) {  
                var request = new OAuth2Request("GET", new Uri("https://api.tidyhq.com/v1/contacts"), null, e.Account);  
                var response = await request.GetResponseAsync();  

                if (response != null)
                {
                    string userJson = response.GetResponseText();
                    Console.WriteLine(userJson);
                    UIAlertView alert = new UIAlertView();
                    alert.Title = "Display";
                    alert.AddButton("OK");
                    alert.Message = userJson; //get back the value
                    alert.Show();

                }

                // delete previous TidyHq login authorizaitons details
               // if(accounts != null){
                //    AccountStore.Delete(e.Account, "TidyHq");
                //}

                // create new login authorization details (meaning new token and session time)
               // store.Save(e.Account, "TidyHq");

            }  
            DismissViewController(true, null);
            //var controller = Storyboard.InstantiateViewController("menuViewController") as menuViewController;
            //this.NavigationController.PresentViewController(controller, true, null);
            //var controller = Storyboard.InstantiateViewController("menu_id") as menuViewController;
            //this.NavigationController.PresentViewController(controller, true, null);
            //PerformSegue("segue_id", (Foundation.NSObject)sender);
        }

		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
            base.PrepareForSegue(segue, sender);
		}

		public override void DidReceiveMemoryWarning() {  
            base.DidReceiveMemoryWarning();  
            // Release any cached data, images, etc that aren't in use.  
        }  

       void updateImage()
        {
            UIImage effectImage = null;
            effectImage = image.ApplyLightEffect();
            loginBackgroundImage.Image = effectImage;
        }


	}
}