using System;
using System.Collections.Generic;
using Foundation;
using UIKit;
namespace KemblaJoggers
{
    public class RaceRecordsDataSource : UITableViewSource
    {
        List<RecordClass> tableItems = new List<RecordClass>();
        protected string cellIdentifier = "raceRecordCellID";
        public RaceRecordsDataSource(UIViewController inputControl)
        {
            this.tableItems = AppData.offlineRecordList;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (RaceRecordCell)tableView.DequeueReusableCell(cellIdentifier, indexPath);
            var record = tableItems[indexPath.Row];
            cell.UpdateCell(record);
            return cell;
            //throw new NotImplementedException();
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return tableItems.Count;
        }
    }
}
