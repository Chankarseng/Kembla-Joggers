using Foundation;
using System;
using UIKit;
using KemblaJoggers.Classes;
using GameKit;
using ContactsUI;
using CoreAnimation;
using System.Security.Cryptography.X509Certificates;

namespace KemblaJoggers
{
    public partial class contactController : UIViewController
    {
void HandlePredicate(ContactClass obj)
        {
        }


        ContactClass currentContact;
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
            changeEditStatus(false);
            changeColor(UIColor.Black);
            ViewDidLayoutSubviews();
            // Self
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
            currentContact = contact;
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
                contactEditButton.SetTitle("Save", UIControlState.Normal);
                changeEditStatus(true);
                changeColor(UIColor.Black);
            }
            // Save mode, revert the text fields to not be changed (Color light gray)
            else if (contactEditButton.TitleLabel.Text == "Save" && contactLoaded == true)
            {
                contactEditButton.SetTitle("Edit", UIControlState.Normal);
                changeEditStatus(false);
                changeColor(UIColor.LightGray);
                var itemIndex = AppData.offlineContactList.FindIndex(p => p.ContactID == currentContact.ContactID);
                //System.Diagnostics.Debug.WriteLine(itemIndex);
                //contactVID.Text = itemIndex.ToString(); // TESTING : to display the index of the contact in the Appdata list
                AppData.offlineContactList.RemoveAt(itemIndex);
                currentContact.ContactID = contactVID.Text.ToString();
                currentContact.FirstName = contactVFirst.Text.ToString();
                currentContact.LastName = contactVLast.Text.ToString();
                currentContact.Email = contactVEmail.Text.ToString();
                currentContact.Address = contactVAddress.Text.ToString();
                currentContact.City = contactVAddress.Text.ToString();
                currentContact.Country = contactVCountry.Text.ToString();
                currentContact.PostCode = Int32.Parse(contactVPost.Text);
                currentContact.Gender = contactVGender.Text.ToString();
                currentContact.Birthday = DateTime.Parse(contactVBirthday.Text);
                currentContact.EmergencyContact = contactVEContact.Text.ToString();
                currentContact.EmergencyNumber = contactVEContactNum.Text.ToString();
                currentContact.MarshalingPreferenceID = Int32.Parse(contactVMarshallID.Text);
                currentContact.MedicalCondition = contactVMedicalCondition.Text.ToString();
                currentContact.DietaryCondition = contactVDietaryCondition.Text.ToString();
                currentContact.FirstAid = Boolean.Parse(contactVFirstAid.Text);
                currentContact.AsterGroupID = Int32.Parse(contactVAsterID.Text);
                currentContact.MemberID = Int32.Parse(contactVMemberID.Text);
                currentContact.ANSWNumber = Int32.Parse(contactVANSWNumber.Text);
                currentContact.LifeMember = Boolean.Parse(contactVLifeMember.Text);
                currentContact.ClubName = contactVClubName.Text.ToString();
                AppData.offlineContactList.Insert(itemIndex,currentContact);
                contactsTableView.ReloadData();
                saveDataToCloud.Save();
            }
            //throw new NotImplementedException();
        }

        private void changeColor(UIColor color)
        {
            contactVID.TextColor = color;
            contactVFirst.TextColor = color;
            contactVLast.TextColor = color;
            contactVEmail.TextColor = color;
            contactVAddress.TextColor = color;
            contactVCity.TextColor = color;
            contactVCountry.TextColor = color;
            contactVPost.TextColor = color;
            contactVGender.TextColor = color;
            contactVBirthday.TextColor = color;
            contactVEContact.TextColor = color;
            contactVEContactNum.TextColor = color;
            contactVMarshallID.TextColor = color;
            contactVMedicalCondition.TextColor = color;
            contactVDietaryCondition.TextColor = color;
            contactVFirstAid.TextColor = color;
            contactVAsterID.TextColor = color;
            contactVMemberID.TextColor = color;
            contactVANSWNumber.TextColor = color;
            contactVLifeMember.TextColor = color;
            contactVClubName.TextColor = color;
        }
        private void changeEditStatus(bool status)
        {
            contactVID.Enabled = status;
            contactVFirst.Enabled = status;
            contactVLast.Enabled = status;
            contactVEmail.Enabled = status;
            contactVAddress.Enabled = status;
            contactVCity.Enabled = status;
            contactVCountry.Enabled = status;
            contactVPost.Enabled = status;
            contactVGender.Enabled = status;
            contactVBirthday.Enabled = status;
            contactVEContact.Enabled = status;
            contactVEContactNum.Enabled = status;
            contactVMarshallID.Enabled = status;
            contactVMedicalCondition.Enabled = status;
            contactVDietaryCondition.Enabled = status;
            contactVFirstAid.Enabled = status;
            contactVAsterID.Enabled = status;
            contactVMemberID.Enabled = status;
            contactVANSWNumber.Enabled = status;
            contactVLifeMember.Enabled = status;
            contactVClubName.Enabled = status;
        }
    }
}