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
        }
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (HandicapCell)tableView.DequeueReusableCell(cellIdentifier, indexPath);
            var record = tableItems[indexPath.Row];
            cell.updateCell(record);
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return tableItems.Count;
        }

        public void PerformSearch(string searchText)  
        {  
            searchText = searchText.ToLower();
            this.searchItems = tableItems.Where(x => x.FirstName.ToLower().Contains(searchText)).ToList();  
        }  
    }
}
