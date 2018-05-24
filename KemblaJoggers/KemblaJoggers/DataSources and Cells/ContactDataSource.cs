using System;
using Foundation;
using UIKit;
using Firebase.Core;
using System.Security.Policy;
using System.Collections.Generic;
using System.Linq;
namespace KemblaJoggers
{
    public class ContactDataSource : UITableViewSource
    {

        /*public ContactDataSource()
        {
        }
        */
        readonly UIViewController contactDataSourceController;
        protected string cellIdentifier = "contactsCell";
        private List<ContactClass> searchItems = new List<ContactClass>();
        private List<ContactClass> tableItems = new List<ContactClass>();
        string[] alphabet = new string[]{ "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};

        // Display index at the side
        public override string[] SectionIndexTitles(UITableView tableView)
        {
            return alphabet;
        }

		/*public override nint NumberOfSections(UITableView tableView)
		{
            return alphabet.Length;
		}*/

		public override string TitleForHeader(UITableView tableView, nint section)
		{
            return alphabet[section];
		}

		public ContactDataSource(UIViewController inputControl)
        {
            contactDataSourceController = inputControl;
            this.tableItems = AppData.offlineContactList;
            this.searchItems = AppData.offlineContactList;
            this.searchItems = this.searchItems.OrderBy(x => x.FirstName).ToList();
        }

        // The value of the cell in the table view
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);
            //ContactClass contactClass = AppData.offlineContactList[indexPath.Row];
            cell.TextLabel.Text = searchItems[indexPath.Row].FirstName + " " + searchItems[indexPath.Row].LastName;
            //throw new NotImplementedException();
            return cell;
        } 

        // The number of rows in each section
        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return searchItems.Count;
            //return AppData.offlineContactList.Count;
            //throw new NotImplementedException();
        }

		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
            //ContactClass thisContact = AppData.offlineContactList[indexPath.Row];
            ContactClass thisContact = searchItems[indexPath.Row];
            var contactC = contactDataSourceController as contactController;
            contactC.SetTask(contactC,thisContact);
            tableView.ReloadData();
		}

        public void PerformSearch(int activeStatus,string searchText)  
        {  
			searchText = searchText.ToLower();  
            if (activeStatus == 0) // All members
            {
                this.searchItems = tableItems.Where(x => x.FirstName.ToLower().Contains(searchText)
                                                    || x.LastName.ToLower().Contains(searchText)).ToList();    
            }
            else if (activeStatus == 1) // Active members
            {
                this.searchItems = tableItems.Where(x => x.FirstName.ToLower().Contains(searchText)
                                                    || x.LastName.ToLower().Contains(searchText) &&
                                                    x.ActiveStatus == true).ToList();
            }
            else if (activeStatus == 2) // Non-Active members
            {
                this.searchItems = tableItems.Where(x => x.FirstName.ToLower().Contains(searchText)
                                                    || x.LastName.ToLower().Contains(searchText) &&
                                                    x.ActiveStatus == false).ToList();   
            }
        }  

        /*public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "TaskSegue")
            { // set in Storyboard
                var navctlr = segue.DestinationViewController as TaskDetailViewController;
                if (navctlr != null)
                {
                    var source = TableView.Source as RootTableSource;
                    var rowPath = TableView.IndexPathForSelectedRow;
                    var item = source.GetItem(rowPath.Row);
                    navctlr.SetTask(this, item); // to be defined on the TaskDetailViewController
                }
            }
        }
*/
	}
}
