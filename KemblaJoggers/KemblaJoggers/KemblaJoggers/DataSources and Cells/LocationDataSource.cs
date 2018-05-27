using System;
using Foundation;
using UIKit;
using KemblaJoggers.Classes;
using System.Collections.Generic;

namespace KemblaJoggers
{
    public class LocationDataSource : UITableViewSource
    {
        public LocationDataSource()
        {
        }

        readonly UIViewController dataSourceController;

        public LocationDataSource(UIViewController inputControl)
        {
            dataSourceController = inputControl;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell("location_id");
            LocationClass thisList = AppData.offlineLocationList[indexPath.Row];
            cell.TextLabel.Text = thisList.locationName;
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return AppData.offlineLocationList.Count;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            //ContactClass thisContact = AppData.offlineContactList[indexPath.Row];
            AppData.curLocIndex = indexPath.Row;
            AppData._curLoc = AppData.offlineLocationList[indexPath.Row];
            List<CoursesClass> thisCourse = AppData.offlineLocationList[indexPath.Row].courses;
            var locationC = dataSourceController as courseManagementChooseViewController;
            if (locationC != null)
            {
                locationC.SetTask(locationC, thisCourse);
            }
            var locationD = dataSourceController as chooseEventViewController;
            if (locationD != null)
            {
				locationD.SetTask(locationD, thisCourse);
            }
            tableView.ReloadData();
        }
    }
}
