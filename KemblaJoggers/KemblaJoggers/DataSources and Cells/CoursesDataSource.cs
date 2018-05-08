using System;
using UIKit;
using KemblaJoggers.Classes;
using Foundation;
using System.Collections.Generic;

namespace KemblaJoggers
{
    public class CoursesDataSource : UITableViewSource
    {
        private List<ContactClass> tableItems = new List<ContactClass>();
        string cellIdentifier = "result_id";

        public CoursesDataSource(UIViewController inputControl)
        {
            this.tableItems = AppData.offlineContactList;
        }
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (CheckResultCell)tableView.DequeueReusableCell(cellIdentifier, indexPath);
            var record = tableItems[indexPath.Row];
            cell.UpdateCell(record);
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return tableItems.Count;
            //throw new NotImplementedException();
        }
    }
}
