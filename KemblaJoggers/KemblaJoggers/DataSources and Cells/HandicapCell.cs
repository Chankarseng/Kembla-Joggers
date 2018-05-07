using Foundation;
using KemblaJoggers.Classes;
using System;
using UIKit;
namespace KemblaJoggers
{
    public partial class HandicapCell : UITableViewCell
    {
        public HandicapCell(IntPtr handle) : base(handle)
        {
        }
        internal void updateCell(ContactClass contacts)
        {
            memberLabel.Text = contacts.ContactID.ToString();
            nameLabel.Text = contacts.FirstName + " " + contacts.LastName;
            DateTime time = new DateTime(10,10,10,0,10,0);
            handicapTimeLabel.Text = time.Hour + ":" + time.Minute + ":" + time.Second;
            
        }
    }
}
