using Foundation;
using System;
using UIKit;
using KemblaJoggers.Classes;
namespace KemblaJoggers
{
    public partial class handicapViewController : UIViewController
    {
        public handicapViewController (IntPtr handle) : base (handle)
        {
        }
        HandicapDataSource handicapDs;
		public override void ViewDidLoad()
		{
            base.ViewDidLoad();
            DateTime _time1 = new DateTime(2018, 1, 13, 0, 47, 20, 11);
            DateTime _time2 = new DateTime(2018, 1, 14, 0, 50, 38, 11);
            DateTime _time3 = new DateTime(2018, 1, 15, 1, 01, 17, 11);
            DateTime _time4 = new DateTime(2018, 1, 16, 1, 06, 23, 11);
            DateTime _time5 = new DateTime(2018, 1, 17, 1, 10, 57, 11);
            DateTime[] time = new DateTime[5];
            time[0] = _time1;
            time[1] = _time2;
            time[2] = _time3;
            time[3] = _time4;
            time[4] = _time5;
            handicapDateTableView.Source = new TableSource(time);
            //PrepareContactFirstList.Prepare();
			handicapDs = new HandicapDataSource(this);
            handicapTimeTableView.Source = handicapDs;
            handicapSearchBar.TextChanged += (sender, e) =>
            {
                //this is the method that is called when the user searches  
                searchTable();
            };
            handicapSearchBar.SelectedScopeButtonIndexChanged += (sender, e) =>
            {
                searchTable();
            };
        }
		private void searchTable()  
		{  
			//perform the search, and refresh the table with the results  
            handicapDs.PerformSearch((int)handicapSearchBar.SelectedScopeButtonIndex, handicapSearchBar.Text);  
            handicapTimeTableView.ReloadData();  
		}  
    }


    public class TableSource : UITableViewSource
    {

        DateTime[] TableItems;
        string CellIdentifier = "date_id";

        public TableSource(DateTime[] items)
        {
            TableItems = items;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return TableItems.Length;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
            DateTime item = TableItems[indexPath.Row];

            //---- if there are no cells to reuse, create a new one
            if (cell == null)
            { cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier); }

            cell.TextLabel.Text = item.ToShortDateString();

            return cell;
        }
    }

}