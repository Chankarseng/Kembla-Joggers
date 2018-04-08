using System;
using Foundation;
using UIKit;
using Firebase.Core;
using System.Security.Policy;
namespace KemblaJoggers
{
    public class ContactDataSource : UITableViewSource
    {

        /*public ContactDataSource()
        {
        }
        */
        readonly UIViewController contactDataSourceController;

        public ContactDataSource(UIViewController inputControl)
        {
            contactDataSourceController = inputControl;
        }

        // The value of the cell in the table view
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell("contactsCell");
            ContactClass contactClass = AppData.offlineContactList[indexPath.Row];
            cell.TextLabel.Text = contactClass.FirstName;
            //throw new NotImplementedException();
            return cell;
        } 

        // The number of rows in each section
        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return AppData.offlineContactList.Count;
            //throw new NotImplementedException();
        }

		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
            ContactClass thisContact = AppData.offlineContactList[indexPath.Row];
            tableView.ReloadData();
		}

	}
}
