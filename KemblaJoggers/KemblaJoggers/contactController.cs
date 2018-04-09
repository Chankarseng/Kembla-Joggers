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
        public contactController (IntPtr handle) : base (handle)
        {
        }

        ContactDataSource contactDs; // Contacts Data source

		public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Self
            contactDs = new ContactDataSource(this);
            contactsTableView.Source = contactDs;
            PrepareContactFirstList.Prepare();
        }
	}
}