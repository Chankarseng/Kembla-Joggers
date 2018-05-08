using System;
using UIKit;
using KemblaJoggers.Classes;
using System.Collections.Generic;
using Foundation;

namespace KemblaJoggers
{
    public class ParticipationDataSource : UITableViewSource
    {
        public ParticipationDataSource()
        {
        }
        string cellIdentifier = "participation_id";
        private List<ContactClass> tableItems = new List<ContactClass>();
        public ParticipationDataSource(UIViewController inputControl)
        {
            //raceDataSourceController = inputControl;
            this.tableItems = AppData.offlineContactList;
        }
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (ParticipationCell)tableView.DequeueReusableCell(cellIdentifier, indexPath);
            var record = tableItems[indexPath.Row];
            cell.updateCell(record);
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return tableItems.Count;
        }
    }
}
