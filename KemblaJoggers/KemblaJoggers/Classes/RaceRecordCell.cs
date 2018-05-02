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

        internal void UpdateCell(RecordClass record)
        {
            positionLabel.Text = record.Line.ToString();
            ageGroupLabel.Text = record.AgeGroup;
            nameLabel.Text = record.FirstName + " " + record.LastName;
            timeLabel.Text = record.Time.ToShortTimeString();
            dateLabel.Text = record.Date.ToShortDateString();
        }
    }
}