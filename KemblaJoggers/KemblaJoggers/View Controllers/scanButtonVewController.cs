using System;
using UIKit;
using System.Collections;
using System.IO;
using Plugin.Messaging; //for email

namespace KemblaJoggers
{
    public partial class scanButtonVewController : UIViewController
    {
        ArrayList barcode_list = new ArrayList(); //to hold the barcode value

        string E_address = "wkc453@uowmail.edu.au"; //email address

        int count = 1; // using for display counting barcode
        string sending_list = ""; //using for the body of the email

        //for the collect info
        string title = "";
        string event_name = "";
        string location = "";
        string year = "";

        public scanButtonVewController (IntPtr handle) : base (handle)
        {
        }
		public override void ViewDidLoad()
		{
            base.ViewDidLoad();
            posScanButton.TouchUpInside += async (object sender, EventArgs e) =>
            {
                var scanner = new ZXing.Mobile.MobileBarcodeScanner();
                var result = await scanner.Scan();
                if (result != null)
                {
                    UIAlertView alert = new UIAlertView();
                    alert.Title = "Result";
                    alert.AddButton("OK");
                    alert.Message = result.ToString();
                    alert.Show();

                    barcode_list.Add(result.ToString()); //add a barcode
                }
            };

            memScanButton.TouchUpInside += async (object sender, EventArgs e) =>
            {
                var scanner = new ZXing.Mobile.MobileBarcodeScanner();
                var result = await scanner.Scan();
                if (result != null)
                {
                    UIAlertView alert = new UIAlertView();
                    alert.Title = "Result";
                    alert.AddButton("OK");
                    alert.Message = result.ToString();
                    alert.Show();

                    barcode_list.Add(result.ToString()); //add a barcode
                }
            };


            //for the publish button
            doneButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                var emailMessenger = CrossMessaging.Current.EmailMessenger; //for sending email
                var choice = UIAlertController.Create("Send List", "Do you want to send the list out as email?", UIAlertControllerStyle.Alert);

                //let the user choose want to write file or not 
                //if yes
                choice.AddAction(UIAlertAction.Create("Yes", UIAlertActionStyle.Default, (UIAlertAction obj) =>
                {
                    //create alert to get file name
                    var InfoInput = UIAlertController.Create("Details", "Fill in all the info", UIAlertControllerStyle.Alert);

                    //add text input
                    InfoInput.AddTextField(textField => { });
                    InfoInput.AddTextField(textField => { });
                    InfoInput.AddTextField(textField => { });
                    InfoInput.AddTextField(textField => { });

                    //placeholder
                    InfoInput.TextFields[0].Placeholder = "Title";
                    InfoInput.TextFields[1].Placeholder = "Event Name";
                    InfoInput.TextFields[2].Placeholder = "Year";
                    InfoInput.TextFields[3].Placeholder = "Location";

                    //Add Actions to get file name
                    InfoInput.AddAction(UIAlertAction.Create("Send", UIAlertActionStyle.Default, (UIAlertAction obj1) =>
                    {

                        title = InfoInput.TextFields[0].Text; //get the title text from the textfield
                        event_name = InfoInput.TextFields[1].Text; //get the event_name text from the textfield
                        location = InfoInput.TextFields[2].Text; //get the location text from the textfield
                        year = InfoInput.TextFields[3].Text; //get the year text from the textfield


                        if (title != "" && event_name != "" && location != "" && year != "") //to avoid the filename is empty
                        {
                            //write all together for sending to email
                            sending_list = sending_list + "Event Name: " + event_name + '\n'; //for event name
                            sending_list = sending_list + "Location: " + location + '\n'; //for location
                            sending_list = sending_list + "Year: " + year + '\n'; //for year


                            for (int i = 0; i < barcode_list.Count; i++)
                            {
                                sending_list = sending_list + '\n' + count + '\t' + barcode_list[i].ToString();
                                count++;
                            }

                            //publish to email
                            if (emailMessenger.CanSendEmail)
                            {
                                // Alternatively use EmailBuilder fluent interface to construct more complex e-mail with multiple recipients, bcc, attachments etc.
                                var email = new EmailMessageBuilder()
                                    .To("to." + E_address)
                                    .Cc("")
                                    .Bcc(new[] { "" })
                                    .Subject(title)
                                    .Body(sending_list)
                                    .Build();

                                emailMessenger.SendEmail(email);
                            }

                            UIAlertView alert = new UIAlertView();
                            alert.Title = "Notice";
                            alert.AddButton("OK");
                            alert.Message = "All the lists have sent to " + E_address; //successful message
                            alert.Show();

                            sending_list = ""; //clear all the sending list
                            barcode_list.Clear(); //clear the barcode list
                        }
                        else
                        {
                            UIAlertView alert = new UIAlertView();
                            alert.Title = "Warning";
                            alert.AddButton("OK");
                            alert.Message = "Please insert all the info";
                            alert.Show();
                        }
                    }));

                    ShowViewController(InfoInput, null);  //present alert fileNameInput        

                }));

                //if no for the choice
                choice.AddAction(UIAlertAction.Create("No", UIAlertActionStyle.Default, (UIAlertAction obj) =>
                {
                    //nothing happen
                }));

                ShowViewController(choice, null); //present alert choice
            };
		}

        partial void DetailsButton_TouchUpInside(UIButton sender)
        {
            //TODO insert function here to display a uialertcontroller to display the current race details
        }
    }
}