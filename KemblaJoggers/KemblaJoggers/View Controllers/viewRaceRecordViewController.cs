using Foundation;
using System;
using UIKit;
using KemblaJoggers.Classes;

namespace KemblaJoggers
{
    public partial class viewRaceRecordViewController : UIViewController
    {
        public viewRaceRecordViewController (IntPtr handle) : base (handle)
        {
        }
        RaceRecordsDataSource RecordDs; // Contacts Data source
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            PrepareRaceRecordFirstList.Prepare();
            RecordDs = new RaceRecordsDataSource(this);
            //contactDs = new ContactDataSource(AppData.offlineContactList);
            RaceRecordTableView.Source = RecordDs;

        }
        public void SetTask(viewRaceRecordViewController d, RecordClass record)
        {
            locationLabel.Text = record.Location;
            courseLabel.Text = record.CourseID.ToString();
        }
    }
}