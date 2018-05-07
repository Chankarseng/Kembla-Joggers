using System;
using Foundation;
using UIKit;
using System.Collections.Generic;
using KemblaJoggers.Classes;

namespace KemblaJoggers
{
    /*public class RaceResultDataSource:UITableViewSource
    {
        readonly UIViewController raceResultDataSourceController;
        List<RaceResult> tableItems = new List<RaceResult>();
        protected string cellIdentifier = "";

        public RaceResultDataSource(UIViewController inputControl)
        {
            raceResultDataSourceController = inputControl;
            this.tableItems = AppData.offlineRaceResultList;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (RaceRecordCell)tableView.DequeueReusableCell(cellIdentifier, indexPath);
            var record = tableItems[indexPath.Row];
            cell.UpdateCell(record);
            return cell;        
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {

            var raceC = raceResultDataSourceController as RaceResultViewController;
            raceC.SetTask(raceC, tableItems[0]);
            return tableItems.Count;        
        }
    }*/
}
