using System;
using UIKit;
using KemblaJoggers.Classes;
using Foundation;
using System.Collections.Generic;
using System.Linq;

namespace KemblaJoggers
{
    public class HandicapDataSource : UITableViewSource
    {
        public HandicapDataSource()
        {
        }

        string cellIdentifier = "handicap_id";
        private List<ContactClass> tableItems = new List<ContactClass>();
        private List<ContactClass> searchItems = new List<ContactClass>();
        public HandicapDataSource(UIViewController inputControl)
        {
            //raceDataSourceController = inputControl;
            this.tableItems = AppData.offlineContactList;
            this.searchItems = AppData.offlineContactList;
        }
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (HandicapCell)tableView.DequeueReusableCell(cellIdentifier, indexPath);
            var record = searchItems[indexPath.Row];
            cell.updateCell(record);
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return searchItems.Count;
        }

        public void PerformSearch(int criteria,string searchText)  
        {  
            if (criteria == 0)
			{
                this.searchItems = tableItems.Where(x => (x.ContactID.ToString().Contains(searchText))).ToList();
            }
            else if (criteria == 1)
            {
                this.searchItems = tableItems.Where(x => (x.FirstName.ToLower().Contains(searchText.ToLower())) || 
                                                    (x.LastName.ToLower().Contains(searchText.ToLower()))).ToList();
            }
            else if (criteria == 2)
            {
                this.searchItems = tableItems.Where
                    (x => (x.handicapTime.Hour.ToString() + ":" +  x.handicapTime.Minute.ToString() 
                           + ":" + x.handicapTime.Second.ToString()).Contains(searchText)).ToList();
            }
        }  
    }
}
