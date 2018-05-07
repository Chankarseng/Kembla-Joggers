using Foundation;
using System;
using UIKit;
using KemblaJoggers.Classes;
using GameKit;
using ContactsUI;
using CoreAnimation;

namespace KemblaJoggers
{
    public partial class contactController : UIViewController
    {
        //ContactDataSource thisContact;
        public contactController (IntPtr handle) : base (handle)
        {
        }
        bool contactLoaded = false;
        ContactDataSource contactDs; // Contacts Data source
		public override void ViewDidLayoutSubviews()
		{
            base.ViewDidLayoutSubviews();
		}

		public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            contactVID.TextColor = UIColor.LightGray;
            contactVFirst.TextColor = UIColor.LightGray;
            contactVLast.TextColor = UIColor.LightGray;
            contactVEmail.TextColor = UIColor.LightGray;
            contactVAddress.TextColor = UIColor.LightGray;
            contactVCity.TextColor = UIColor.LightGray;
            contactVCountry.TextColor = UIColor.LightGray;
            contactVPost.TextColor = UIColor.LightGray;
            contactVGender.TextColor = UIColor.LightGray;
            contactVBirthday.TextColor = UIColor.LightGray;
            contactVEContact.TextColor = UIColor.LightGray;
            contactVEContactNum.TextColor = UIColor.LightGray;
            contactVMarshallID.TextColor = UIColor.LightGray;
            contactVMedicalCondition.TextColor = UIColor.LightGray;
            contactVDietaryCondition.TextColor = UIColor.LightGray;
            contactVFirstAid.TextColor = UIColor.LightGray;
            contactVAsterID.TextColor = UIColor.LightGray;
            contactVMemberID.TextColor = UIColor.LightGray;
            contactVANSWNumber.TextColor = UIColor.LightGray;
            contactVLifeMember.TextColor = UIColor.LightGray;
            contactVClubName.TextColor = UIColor.LightGray;
            ViewDidLayoutSubviews();
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
            contactSearchBar.SelectedScopeButtonIndexChanged += (sender, e) =>
            {
                searchTable();
            };
  
        }

        private void searchTable()  
        {  
            //perform the search, and refresh the table with the results  
            contactDs.PerformSearch((int)contactSearchBar.SelectedScopeButtonIndex, contactSearchBar.Text);  
            contactsTableView.ReloadData();  
        }  

        // this will be called before the view is displayed
        public void SetTask(contactController d, ContactClass contact)
        {
            contactLoaded = true;
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
            contactVMarshallID.Text = contact.MarshalingPreferenceID.ToString();
            contactVMedicalCondition.Text = contact.MedicalCondition;
            contactVDietaryCondition.Text = contact.DietaryCondition;
            contactVFirstAid.Text = contact.FirstAid.ToString();
            contactVAsterID.Text = contact.AsterGroupID.ToString();
            contactVMemberID.Text = contact.MemberID.ToString();
            contactVANSWNumber.Text = contact.ANSWNumber.ToString();
            contactVLifeMember.Text = contact.LifeMember.ToString();
            contactVClubName.Text = contact.ClubName;
            
        }

        // TODO
        // Create a function that detects touch presses for edit button, to enable the text field
        partial void ContactEditButton_TouchUpInside(UIButton sender)
        {
            // Save mode, change text field to editable (Color black)
            if (contactEditButton.TitleLabel.Text == "Edit" && contactLoaded == true)
            {
                contactEditButton.SetTitle("Save",UIControlState.Normal);
                contactVID.Enabled = true;
                contactVFirst.Enabled = true;
                contactVLast.Enabled = true;
                contactVEmail.Enabled = true;
                contactVAddress.Enabled = true;
                contactVCity.Enabled = true;
                contactVCountry.Enabled = true;
                contactVPost.Enabled = true;
                contactVGender.Enabled = true;
                contactVBirthday.Enabled = true;
                contactVEContact.Enabled = true;
                contactVEContactNum.Enabled = true;
                contactVMarshallID.Enabled = true;
                contactVMedicalCondition.Enabled = true;
                contactVDietaryCondition.Enabled = true;
                contactVFirstAid.Enabled = true;
                contactVAsterID.Enabled = true;
                contactVMemberID.Enabled = true;
                contactVANSWNumber.Enabled = true;
                contactVLifeMember.Enabled = true;
                contactVClubName.Enabled = true;
                contactVID.TextColor = UIColor.Black;
                contactVFirst.TextColor = UIColor.Black;
                contactVLast.TextColor = UIColor.Black;
                contactVEmail.TextColor = UIColor.Black;
                contactVAddress.TextColor = UIColor.Black;
                contactVCity.TextColor = UIColor.Black;
                contactVCountry.TextColor = UIColor.Black;
                contactVPost.TextColor = UIColor.Black;
                contactVGender.TextColor = UIColor.Black;
                contactVBirthday.TextColor = UIColor.Black;
                contactVEContact.TextColor = UIColor.Black;
                contactVEContactNum.TextColor = UIColor.Black;
                contactVMarshallID.TextColor = UIColor.Black;
                contactVMedicalCondition.TextColor = UIColor.Black;
                contactVDietaryCondition.TextColor = UIColor.Black;
                contactVFirstAid.TextColor = UIColor.Black;
                contactVAsterID.TextColor = UIColor.Black;
                contactVMemberID.TextColor = UIColor.Black;
                contactVANSWNumber.TextColor = UIColor.Black;
                contactVLifeMember.TextColor = UIColor.Black;
                contactVClubName.TextColor = UIColor.Black;
            }
            // Save mode, revert the text fields to not be changed (Color light gray)
            else if (contactEditButton.TitleLabel.Text == "Save" && contactLoaded == true)
            {
                contactEditButton.SetTitle("Edit", UIControlState.Normal);
                contactVID.Enabled = false;
                contactVFirst.Enabled = false;
                contactVLast.Enabled = false;
                contactVEmail.Enabled = false;
                contactVAddress.Enabled = false;
                contactVCity.Enabled = false;
                contactVCountry.Enabled = false;
                contactVPost.Enabled = false;
                contactVGender.Enabled = false;
                contactVBirthday.Enabled = false;
                contactVEContact.Enabled = false;
                contactVEContactNum.Enabled = false;
                contactVMarshallID.Enabled = false;
                contactVMedicalCondition.Enabled = false;
                contactVDietaryCondition.Enabled = false;
                contactVFirstAid.Enabled = false;
                contactVAsterID.Enabled = false;
                contactVMemberID.Enabled = false;
                contactVANSWNumber.Enabled = false;
                contactVLifeMember.Enabled = false;
                contactVClubName.Enabled = false;
                contactVID.TextColor = UIColor.LightGray;
                contactVFirst.TextColor = UIColor.LightGray;
                contactVLast.TextColor = UIColor.LightGray;
                contactVEmail.TextColor = UIColor.LightGray;
                contactVAddress.TextColor = UIColor.LightGray;
                contactVCity.TextColor = UIColor.LightGray;
                contactVCountry.TextColor = UIColor.LightGray;
                contactVPost.TextColor = UIColor.LightGray;
                contactVGender.TextColor = UIColor.LightGray;
                contactVBirthday.TextColor = UIColor.LightGray;
                contactVEContact.TextColor = UIColor.LightGray;
                contactVEContactNum.TextColor = UIColor.LightGray;
                contactVMarshallID.TextColor = UIColor.LightGray;
                contactVMedicalCondition.TextColor = UIColor.LightGray;
                contactVDietaryCondition.TextColor = UIColor.LightGray;
                contactVFirstAid.TextColor = UIColor.LightGray;
                contactVAsterID.TextColor = UIColor.LightGray;
                contactVMemberID.TextColor = UIColor.LightGray;
                contactVANSWNumber.TextColor = UIColor.LightGray;
                contactVLifeMember.TextColor = UIColor.LightGray;
                contactVClubName.TextColor = UIColor.LightGray;
            }
            //throw new NotImplementedException();
        }
    }
}