using System;
using UIKit;
using KemblaJoggers.Classes;
using Foundation;
using System.Collections.Generic;

namespace KemblaJoggers
{
    public class checkResultDataSource : UITableViewSource
    {
        public checkResultDataSource()
        {
        }
        string[] lapTime;
        string cellIdentifier = "result_id";
        private List<ContactClass> tableItems = new List<ContactClass>();
        public checkResultDataSource(UIViewController inputControl)
        {
            this.lapTime = AppData.currentRaceLapTime;
            tableItems = AppData.offlineContactList;
        }
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (CheckResultCell)tableView.DequeueReusableCell(cellIdentifier, indexPath);
            var record = new ContactClass();
            if (indexPath.Row < tableItems.Count)
            {
                record = tableItems[indexPath.Row];
			}
            string time = lapTime[indexPath.Row];
            cell.UpdateCell(indexPath.Row + 1,record,time);
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return AppData.index;
            //throw new NotImplementedException();
        }
    }
}
