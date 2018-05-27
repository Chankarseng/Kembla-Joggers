using Foundation;
using System;
using UIKit;
using System.Collections.Generic;
using System.Timers;
using System.Runtime.CompilerServices;
using System.Linq;

namespace KemblaJoggers
{
    public partial class RaceResultViewController : UIViewController
    {
        public RaceResultViewController (IntPtr handle) : base (handle)
        {
        }

        raceResultDataSource raceDs;
		public override void ViewDidLoad()
		{
            base.ViewDidLoad();
            raceDs = new raceResultDataSource(this);
            RaceResultsTableView.Source = raceDs;
		}
	}

    class raceResultDataSource : UITableViewSource
    {
        List<RaceResultClass> results;
        int index = 0;
        int count = 0;
        int i = 0;
        public raceResultDataSource(UIViewController inputctrl)
        {
            results = AppData.offlineRaceResultList;
        }
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            if (results[index].raceTimings.Length - 1 <= i)
            {
                index++;
                i = 0;
            }
            var cell = (RaceResultsCell)tableView.DequeueReusableCell("cell_id", indexPath);
            //ContactClass contactClass = AppData.offlineContactList[indexPath.Row];
            if (index > AppData.offlineRaceResultList.Count - 1 )
            {
                index = AppData.offlineRaceResultList.Count - 1;
            }
            if (index < 0)
            {
                index = 0;
            }
            var result = AppData.offlineRaceResultList[index].raceContacts;
            Console.WriteLine("INDEX " + index);
            Console.WriteLine("INDEX ROW " + indexPath.Row);
            Console.WriteLine("I " + i);
            //throw new NotImplementedException();
            cell.UpdateCell(indexPath.Row + 1,i,results[index],result[i]);


            i++;
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            index = 0;
            count = 0;
            Console.WriteLine(results.Count);
            for (int i = 0; i < results.Count; i++)
            {
                count += results[i].raceTimings.Length;
            }
            Console.WriteLine("COUNT " + count);
            return count;
        }
        // FOR FILTERING TESTING
        /*private void check()
        {
            results = results.Where(x => x.name.ToLower().Equals("john")).ToList();
        }*/
    }
    public partial class RaceResultsCell:UITableViewCell
    {
        internal void UpdateCell(int index,int i,RaceResultClass r,ContactClass c)
        {
            positionLabel.Text = index.ToString();
            memberIDLabel.Text = c.ContactID.ToString();
            nameLabel.Text = c.FirstName + " " + c.LastName;
            timeLabel.Text = r.raceTimings[i];
            dateLabel.Text = r.date.ToShortDateString();

        }
    }

}