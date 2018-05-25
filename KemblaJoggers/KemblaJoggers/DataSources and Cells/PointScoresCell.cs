using Foundation;
using System;
using UIKit;

namespace KemblaJoggers
{
    public partial class PointScoresCell : UITableViewCell
    {
        public PointScoresCell(IntPtr handle) : base(handle)
        {
        }
        public void updateCell(int Index, ContactClass c)
        {
            placeLabel.Text = Index.ToString();
            nameLabel.Text = c.FirstName + " " + c.LastName;
            pointScoreLabel.Text = c.pointScores.ToString();
        }
    }
}