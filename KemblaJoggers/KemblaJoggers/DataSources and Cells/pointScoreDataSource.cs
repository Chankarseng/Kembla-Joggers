using System;
using Foundation;
using UIKit;
using KemblaJoggers.Classes;
using System.Collections.Generic;
using System.Linq;

namespace KemblaJoggers
{
    public class pointScoreDataSource : UITableViewSource
    {
        public pointScoreDataSource()
        {
        }

        string cellIdentifier = "pointscore_id";
        private List<ContactClass> tableItems = new List<ContactClass>();
        private List<ContactClass> searchItems = new List<ContactClass>();
        public pointScoreDataSource(UIViewController inputControl)
        {
            this.tableItems = AppData.offlineContactList;
            this.searchItems = AppData.offlineContactList;
            this.tableItems = this.tableItems.OrderByDescending(x => x.pointScores).ToList();
            this.searchItems = this.searchItems.OrderByDescending(x => x.pointScores).ToList();
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (PointScoresCell)tableView.DequeueReusableCell(cellIdentifier, indexPath);
            var record = searchItems[indexPath.Row];
            cell.updateCell(indexPath.Row + 1, record);
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return searchItems.Count;
        }

        public void searchTable(string searchText)
        {
            searchText = searchText.ToLower();
            this.searchItems = this.tableItems.Where(x => (x.FirstName.ToLower() + x.LastName.ToLower())
                                                     .Contains(searchText)).ToList();
        }
    }
}
