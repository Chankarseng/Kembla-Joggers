using Foundation;
using System;
using UIKit;

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

        partial void ViewRaceRecordButton_TouchUpInside(UIButton sender)
        {
            UIAlertController alertController;
            alertController = UIAlertController.Create("test", "test", UIAlertControllerStyle.Alert);
            alertController.AddTextField((field) =>
            {
                field.Placeholder = "test name";
            });
            UIAlertAction saveAction;
            saveAction = UIAlertAction.Create("Save", UIAlertActionStyle.Default,action=> testAction());
            alertController.AddAction(saveAction);
            alertController.AddAction(UIAlertAction.Create("Cancel", UIAlertActionStyle.Cancel, null));
            PresentViewController(alertController, true, null);
        }
        void testAction()
        {
            this.PerformSegue("viewRaceSegue", this);
        }

        void testAction1()
        {
            this.PerformSegue("viewSeriesSegue", this);
        }

        partial void ViewSeriesRecordButton_TouchUpInside(UIButton sender)
        {
            UIAlertController alertController;
            alertController = UIAlertController.Create("test", "test", UIAlertControllerStyle.Alert);
            alertController.AddTextField((field) =>
            {
                field.Placeholder = "test name";
            });
            UIAlertAction saveAction;
            saveAction = UIAlertAction.Create("Save", UIAlertActionStyle.Default, action => testAction1());
            alertController.AddAction(saveAction);
            alertController.AddAction(UIAlertAction.Create("Cancel", UIAlertActionStyle.Cancel, null));
            PresentViewController(alertController, true, null);
        }
    }
}