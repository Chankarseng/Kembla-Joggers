using Foundation;
using System;
using UIKit;
using KemblaJoggers.Classes;
namespace KemblaJoggers
{
    public partial class viewSeriesRecordViewController : UIViewController
    {
        public viewSeriesRecordViewController (IntPtr handle) : base (handle)
        {
        }
        SeriesRecordDataSource RecordDs; // Contacts Data source
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            PrepareRaceRecordFirstList.Prepare();
            RecordDs = new SeriesRecordDataSource(this);
            //contactDs = new ContactDataSource(AppData.offlineContactList);
            seriesRecordTableView.Source = RecordDs;

        }

    }
}