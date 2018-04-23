using Foundation;
using System;
using UIKit;
using KemblaJoggers.Classes;
using GameKit;
using ContactsUI;

namespace KemblaJoggers
{
    public partial class contactController : UIViewController
    {
        //ContactDataSource thisContact;
        public contactController (IntPtr handle) : base (handle)
        {
        }

        ContactDataSource contactDs; // Contacts Data source

		public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Self
            PrepareContactFirstList.Prepare();
            contactDs = new ContactDataSource(this);
            //contactDs = new ContactDataSource(AppData.offlineContactList);
            contactsTableView.Source = contactDs;
            contactSearchBar.TextChanged += (sender, e) =>  
            {  
                //this is the method that is called when the user searches  
                searchTable();  
            };  
  
        }

        private void searchTable()  
        {  
            //perform the search, and refresh the table with the results  
            contactDs.PerformSearch(contactSearchBar.Text);  
            contactsTableView.ReloadData();  
        }  

        // this will be called before the view is displayed
        public void SetTask(contactController d, ContactClass contact)
        {
            contactVID.Text = contact.ContactID;
            contactVFirst.Text = contact.FirstName;
            contactVLast.Text = contact.LastName;
            contactVEmail.Text = contact.Email;
            contactVAddress.Text = contact.Address;
            contactVCity.Text = contact.City;
            contactVCountry.Text = contact.Country;
            contactVPost.Text = contact.PostCode.ToString();
            contactVGender.Text = contact.Gender;
            contactVBirthday.Text = contact.Birthday.ToString();
            contactVEContact.Text = contact.EmergencyContact;
            contactVEContactNum.Text = contact.EmergencyNumber;

        }

        // TODO
        // Create a function that detects touch presses for edit button, to enable the text field
	}
}