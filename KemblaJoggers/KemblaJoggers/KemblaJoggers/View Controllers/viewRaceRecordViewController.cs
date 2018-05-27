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
        public RaceResultClass thisRaceResult;
        RaceRecordsDataSource RecordDs; // Contacts Data source
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            //PrepareRaceRecordFirstList.Prepare();
            RecordDs = new RaceRecordsDataSource(thisRaceResult,this);
            //contactDs = new ContactDataSource(AppData.offlineContactList);
            RaceRecordTableView.Source = RecordDs;

        }
        public void SetTask(viewRaceRecordViewController d, RaceResultClass record)
        {
            locationLabel.Text = record.location_name;
            courseLabel.Text = record.course_name;
        }
    }
}