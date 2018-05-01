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
        RecordsDataSource RecordDs; // Contacts Data source
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            PrepareRaceRecordFirstList.Prepare();
            RecordDs = new RecordsDataSource(this);
            //contactDs = new ContactDataSource(AppData.offlineContactList);
            RaceRecordTableView.Source = RecordDs;

        }

    }
}