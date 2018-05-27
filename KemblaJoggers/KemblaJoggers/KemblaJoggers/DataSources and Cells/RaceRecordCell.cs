using Foundation;
using KemblaJoggers.Classes;
using System;
using UIKit;

namespace KemblaJoggers
{
    public partial class RaceRecordCell : UITableViewCell
    {
        public RaceRecordCell(IntPtr handle) : base(handle)
        {
        }

        internal void UpdateCell(int Index,ContactClass record,string Time,DateTime date)
        {
            positionLabel.Text = Index.ToString();
            ageGroupLabel.Text = record.Age.ToString();
            nameLabel.Text = record.FirstName + " " + record.LastName;
            timeLabel.Text = Time;
            dateLabel.Text = date.ToShortDateString();
        }
    }
}