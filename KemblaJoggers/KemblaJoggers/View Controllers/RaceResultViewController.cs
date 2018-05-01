using Foundation;
using System;
using UIKit;
using System.Collections.Generic;
using System.Timers;

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
            var result = new List<raceResult>
            {
                new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },
                new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },new raceResult
                {
                    pos = 1,
                    memID = 1001,
                    name = "John",
                    time = DateTime.Now,
                    date = DateTime.Now
                },

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

            var cell = (RaceResultsCell)tableView.DequeueReusableCell("cell_id",indexPath);
            //ContactClass contactClass = AppData.offlineContactList[indexPath.Row];
            var result = results[indexPath.Row];
            //throw new NotImplementedException();
            cell.UpdateCell(result);
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return results.Count;
        }
    }
    public partial class RaceResultsCell:UITableViewCell
    {
        internal void UpdateCell(raceResult r)
        {
            positionLabel.Text = r.pos.ToString();
            memberIDLabel.Text = r.memID.ToString();
            nameLabel.Text = r.name;
            timeLabel.Text = r.time.ToShortTimeString();
            dateLabel.Text = r.date.ToShortDateString();

        }
    }

}