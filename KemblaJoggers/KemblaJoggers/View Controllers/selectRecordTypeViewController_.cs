using Foundation;
using System;
using UIKit;
using System.Linq;

namespace KemblaJoggers
{
    public partial class selectRecordTypeViewController : UIViewController
    {
        public selectRecordTypeViewController (IntPtr handle) : base (handle)
        {
        }
		public override void ViewDidLoad()
		{
            base.ViewDidLoad();
		}
        RaceResultClass filteredResult;
        UIAlertController alertController1;
        UIAlertController alertController2;
        bool left;
        //int index;
        partial void ViewRaceRecordButton_TouchUpInside(UIButton sender)
        {
            left = true;
            alertController1 = UIAlertController.Create("Race Record", null, UIAlertControllerStyle.Alert);
            alertController1.AddTextField((field) =>
            {
                field.Placeholder = "Location";
            });
            alertController1.AddTextField((field) =>
            {
                field.Placeholder = "Course";
            });
            UIAlertAction saveAction;
            saveAction = UIAlertAction.Create("Filter", UIAlertActionStyle.Default,action=> filterRace());
            alertController1.AddAction(saveAction);
            alertController1.AddAction(UIAlertAction.Create("Cancel", UIAlertActionStyle.Cancel, null));
            PresentViewController(alertController1, true, null);
        }

		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
            base.PrepareForSegue(segue, sender);
            if (left == true)
            {
                var itemCtrl = segue.DestinationViewController as viewRaceRecordViewController;
                itemCtrl.thisRaceResult = filteredResult;
            }
            else
            {
                    
            }
		}

		void filterRace()
        {
            filteredResult = AppData.offlineRaceResultList.Find
                                    (x => x.location.locationName.ToLower().Contains(alertController1.TextFields[0].Text.ToLower())
                                     && x.currentCourse.CourseName.ToLower().Contains(alertController1.TextFields[1].Text.ToLower()));
            if (filteredResult != null)
            {
				this.PerformSegue("viewRaceSegue", this);
            }
            else
            {
                UIAlertController alertController;
                alertController = UIAlertController.Create("Race Record not found.", null, UIAlertControllerStyle.Alert);
                alertController.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Cancel, null));
                PresentViewController(alertController, true, null);
            }
        }




        void filterSeries()
        {
            filteredResult = AppData.offlineRaceResultList.Find
                                    (x => x.date.Year.ToString() == (alertController2.TextFields[0].Text));
            if (filteredResult != null)
            {
                this.PerformSegue("viewSeriesSegue", this);
            }
            else
            {
                UIAlertController alertController;
                alertController = UIAlertController.Create("Series record not found.", null, UIAlertControllerStyle.Alert);
                alertController.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Cancel, null));
                PresentViewController(alertController, true, null);
            }
        }

        partial void ViewSeriesRecordButton_TouchUpInside(UIButton sender)
        {
            left = false;
            alertController2 = UIAlertController.Create("Series Record", null, UIAlertControllerStyle.Alert);
            alertController2.AddTextField((field) =>
            {
                field.Placeholder = "Year";
            });
            alertController2.AddTextField((field) =>
            {
                field.Placeholder = "Series";
            });
            UIAlertAction saveAction;
            saveAction = UIAlertAction.Create("Filter", UIAlertActionStyle.Default, action => filterSeries());
            alertController2.AddAction(saveAction);
            alertController2.AddAction(UIAlertAction.Create("Cancel", UIAlertActionStyle.Cancel, null));
            PresentViewController(alertController2, true, null);
        }


        // Add new record
        partial void AddNewRecordButton_TouchUpInside(UIButton sender)
        {
            //throw new NotImplementedException();
        }
    }
}