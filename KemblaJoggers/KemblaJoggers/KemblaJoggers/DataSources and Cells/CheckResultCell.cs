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
        internal void UpdateCell (int standings,ContactClass contact,string time)
        {
            positionLabel.Text = standings.ToString();
            nameLabel.Text = contact.FirstName + " " + contact.LastName;
            timeLabel.Text = time;
        }
    }
}