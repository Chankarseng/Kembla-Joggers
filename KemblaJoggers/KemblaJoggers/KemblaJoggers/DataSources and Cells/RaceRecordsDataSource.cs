using System;
using System.Collections.Generic;
using Foundation;
using UIKit;
using KemblaJoggers.Classes;
namespace KemblaJoggers
{
    public class RaceRecordsDataSource : UITableViewSource
    {
        readonly UIViewController raceDataSourceController;
        RaceResultClass thisRace;
        //List<RecordClass> tableItems = new List<RecordClass>();
        protected string cellIdentifier = "raceRecordCellID";
        public RaceRecordsDataSource(RaceResultClass thisRaceResult,UIViewController inputControl)
        {
            raceDataSourceController = inputControl;
            thisRace = thisRaceResult;
            //this.tableItems = AppData.offlineRecordList;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (RaceRecordCell)tableView.DequeueReusableCell(cellIdentifier, indexPath);
            var record = thisRace.raceContacts[indexPath.Row];
            cell.UpdateCell(indexPath.Row + 1,record,thisRace.raceTimings[indexPath.Row],thisRace.date);
            return cell;
            //throw new NotImplementedException();
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            var raceC = raceDataSourceController as viewRaceRecordViewController;
            raceC.SetTask(raceC, thisRace);
            return thisRace.raceContacts.Count;
        }
    }
}
