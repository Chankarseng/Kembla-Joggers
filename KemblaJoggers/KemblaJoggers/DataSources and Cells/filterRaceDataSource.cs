using System;
using Foundation;
using UIKit;
using AudioUnit;
namespace KemblaJoggers
{
    public class filterRaceDataSource : UITableViewSource
    {

        readonly UIViewController filterRaceDS;
        string CellIdentifier = "filterRaceCell";
        string[] TableItems;
        public filterRaceDataSource(string[] items)
        {
            TableItems = items;
        }

        public filterRaceDataSource(UIViewController inputControl)
        {
            filterRaceDS = inputControl;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return TableItems.Length;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
            string item = TableItems[indexPath.Row];
            cell.Accessory = UITableViewCellAccessory.None;
            //---- if there are no cells to reuse, create a new one
            if (cell == null)
            { cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier); }

            cell.TextLabel.Text = item;

            return cell;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.CellAt(indexPath);
            cell.Accessory = UITableViewCellAccessory.Checkmark;
        }

		public override void RowDeselected(UITableView tableView, NSIndexPath indexPath)
		{
            UITableViewCell deselectedCell = tableView.CellAt(indexPath);
            deselectedCell.Accessory = UITableViewCellAccessory.None;
		}
	}
}
