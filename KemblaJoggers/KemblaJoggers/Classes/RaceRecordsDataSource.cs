using System;
using System.Collections.Generic;
using Foundation;
using UIKit;
using KemblaJoggers.Classes;
namespace KemblaJoggers
{
    public class RecordsDataSource : UITableViewSource
    {
        readonly UIViewController raceDataSourceController;
        List<RecordClass> tableItems = new List<RecordClass>();
        protected string cellIdentifier = "raceRecordCellID";
        public RecordsDataSource(UIViewController inputControl)
        {
            raceDataSourceController = inputControl;
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
            var raceC = raceDataSourceController as viewRaceRecordViewController;
            raceC.SetTask(raceC, tableItems[0]);
            return tableItems.Count;
        }
    }
}
