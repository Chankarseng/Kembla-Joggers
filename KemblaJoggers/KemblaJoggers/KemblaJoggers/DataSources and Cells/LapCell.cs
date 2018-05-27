using Foundation;
using System;
using UIKit;
using KemblaJoggers.Classes;
namespace KemblaJoggers
{
    public partial class LapCell : UITableViewCell
    {
        public LapCell (IntPtr handle) : base (handle)
        {
        }
        internal void updateCell(int standings, string time)
        {
            positionLabel.Text = standings.ToString();
            timeLabel.Text = time;
        }
    }
}