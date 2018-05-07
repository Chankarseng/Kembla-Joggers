using Foundation;
using System;
using UIKit;

namespace KemblaJoggers
{
    public partial class CheckResultCell : UITableViewCell
    {
        public CheckResultCell (IntPtr handle) : base (handle)
        {
        }
        internal void UpdateCell (ContactClass contact)
        {
            DateTime _time1 = new DateTime(2018, 1, 13, 0, 47, 20, 11);
            positionLabel.Text = "1";
            nameLabel.Text = contact.FirstName + " " + contact.LastName;
            timeLabel.Text = _time1.Hour + ":" + _time1.Minute + ":" + _time1.Second;
        }
    }
}