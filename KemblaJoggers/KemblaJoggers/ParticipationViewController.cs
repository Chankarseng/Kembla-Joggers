using Foundation;
using System;
using UIKit;
using KemblaJoggers.Classes;
namespace KemblaJoggers
{
    public partial class ParticipationViewController : UIViewController
    {
        public ParticipationViewController (IntPtr handle) : base (handle)
        {
        }
        ParticipationDataSource participationDs;
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            PrepareContactFirstList.Prepare();
            participationDs = new ParticipationDataSource(this);
            participationTableView.Source = participationDs;
        }
    }
}