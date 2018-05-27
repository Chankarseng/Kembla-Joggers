using Foundation;
using KemblaJoggers.Classes;
using System;
using UIKit;

namespace KemblaJoggers
{
    public partial class ParticipationCell : UITableViewCell
    {
        public ParticipationCell (IntPtr handle) : base (handle)
        {
        }
        internal void updateCell(ContactClass contacts)
        {
            nameLabel.Text = contacts.FirstName + " " + contacts.LastName;
            if (contacts.Age <= 21)
            {
                ageGroupLabel.Text = "<=21";
            }
            else
            {
                ageGroupLabel.Text = ">21";
            }
            raceCountLabel.Text = "10";
        }
    }
}