using Foundation;
using System;
using UIKit;
using System.Collections.Generic;
using System.Timers;
using System.Runtime.CompilerServices;
using System.Linq;

namespace KemblaJoggers
{
    class raceResult
    {
        public int pos { get; set; }
        public int memID { get; set; }
        public string name { get; set; }
        public DateTime time { get; set; }
        public DateTime date { get; set; }
    }
    public partial class RaceResultViewController : UIViewController
    {
        public RaceResultViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
            base.ViewDidLoad();
            DateTime _time1 = new DateTime(2018,1,13,0,47,20,11);
            DateTime _time2 = new DateTime(2018, 1, 13, 0, 50, 38, 11);
            DateTime _time3 = new DateTime(2018, 1, 13, 1, 01, 17, 11);
            DateTime _time4 = new DateTime(2018, 1, 13, 1, 06, 23, 11);
            DateTime _time5 = new DateTime(2018, 1, 13, 1, 10, 57, 11);
            var result = new List<raceResult>
            {
                new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = _time1,
                    date = DateTime.Now
                },
                new raceResult
                {
                    pos = 2,
                    memID = 1002,
                    name = "William",
                    time = _time2,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 3,
                    memID = 1003,
                    name = "Alvin",
                    time = _time3,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 4,
                    memID = 1004,
                    name = "Micahel",
                    time = _time4,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 5,
                    memID = 1005,
                    name = "Simon",
                    time = _time5,
                    date = DateTime.Now
                }

            };
            RaceResultsTableView.Source = new employeeTVS(result);
		}
	}

    class employeeTVS : UITableViewSource
    {
        List<raceResult> results;
        public employeeTVS(List<raceResult> r)
        {
            this.results = r;
        }
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {

            var cell = (RaceResultsCell)tableView.DequeueReusableCell("cell_id", indexPath);
            //ContactClass contactClass = AppData.offlineContactList[indexPath.Row];
            var result = results[indexPath.Row];
            //throw new NotImplementedException();
            cell.UpdateCell(result);
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            check();
            return results.Count;
        }
        // FOR FILTERING TESTING
        private void check()
        {
            results = results.Where(x => x.name.ToLower().Equals("john")).ToList();
        }
    }
    public partial class RaceResultsCell:UITableViewCell
    {
        internal void UpdateCell(raceResult r)
        {
            positionLabel.Text = r.pos.ToString();
            memberIDLabel.Text = r.memID.ToString();
            nameLabel.Text = r.name;
            timeLabel.Text = r.time.Hour.ToString() + ":" + r.time.Minute.ToString() + ":" + r.time.Second.ToString();
            dateLabel.Text = r.date.ToShortDateString();

        }
    }

}