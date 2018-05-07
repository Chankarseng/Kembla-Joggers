using System;
using UIKit;
using KemblaJoggers.Classes;
using Foundation;

namespace KemblaJoggers
{
    public partial class LapDataSource : UITableViewSource
    {
       string[] Laps;
        string CellIdentifier = "TableCell";
        int index;
        public LapDataSource(string[] lapTimes,int i)
        {
            Laps = lapTimes;
            index = i;
        }


        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            //UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
            //string item = Laps[indexPath.Row];

            //---- if there are no cells to reuse, create a new one
            /*if (cell == null)
            { cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier); }
            */

            var cell = (LapCell)tableView.DequeueReusableCell(CellIdentifier, indexPath);
            string record = Laps[indexPath.Row];
            cell.updateCell(indexPath.Row + 1,record);
            return cell;

        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return index;
        }
    }
}

