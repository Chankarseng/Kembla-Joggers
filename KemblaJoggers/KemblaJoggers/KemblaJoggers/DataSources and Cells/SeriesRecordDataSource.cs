using System;
using System.Collections.Generic;
using Foundation;
using UIKit;
using KemblaJoggers.Classes;
namespace KemblaJoggers
{
    public class SeriesRecordDataSource : UITableViewSource
    {
        public SeriesRecordDataSource()
        {
        }
        readonly UIViewController seriesDataSourceController;
        List<RecordClass> tableItems = new List<RecordClass>();
        protected string cellIdentifier = "seriesRecordCellID";

        public SeriesRecordDataSource(UIViewController inputControl)
        {
            seriesDataSourceController = inputControl;
            this.tableItems = AppData.offlineRecordList;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (SeriesRecordCell)tableView.DequeueReusableCell(cellIdentifier, indexPath);
            var record = tableItems[indexPath.Row];
            cell.UpdateCell(record);
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            var seriesC = seriesDataSourceController as viewSeriesRecordViewController;
            seriesC.SetTask(seriesC, tableItems[0]);

            return tableItems.Count;
        }
    }
}
