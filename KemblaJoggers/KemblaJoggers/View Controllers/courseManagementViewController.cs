using Foundation;
using System;
using UIKit;
using KemblaJoggers.Classes;
using System.Collections.Generic;

namespace KemblaJoggers
{
    public partial class courseManagementViewController : UIViewController
    {
        
        public courseManagementViewController(IntPtr handle) : base(handle)
        {
        }
        public CoursesClass curCourse;
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            AppData.chooseCourse = false;
            setText(curCourse);
        }

        public void setText(CoursesClass curCourse)
        {
            courseIDTF.Text = curCourse.Uid;
            courseIDTF.Enabled = false;
            locationTF.Text = curCourse.LocationName;
            surfaceTF.Text = curCourse.SurfaceType;
            distanceTF.Text = curCourse.Distance.ToString();
            unitsTF.Text = curCourse.Units;
            handicapTF.Text = curCourse.Handicap.ToString();
            handicapFTF.Text = curCourse.HandicapBuffer;
            handicapCTF.Text = curCourse.HandicapCutOff;
            //penaltyTF.Text = curLoc.penalty;
            relayTF.Text = curCourse.IsRelay.ToString();
            //leg1TF.Text = curLoc.
            //leg2TF.Text = 
            //leg3TF.Text = 
            //leg4TF.Text = 
            //keepRecordTF.Text = curLoc.
            if (curCourse.MinAge > 31)
            {
                minAge31TF.Text = "True";
            }
            else
            {
                minAge31TF.Text = "False";
            }
        }
        partial void SaveButton_TouchUpInside(UIButton sender)
        {
            var itemIndex = AppData.offlineLocationList[AppData.curLocIndex].courses.FindIndex(p => p.Uid == curCourse.Uid);
            AppData.offlineLocationList[AppData.curLocIndex].courses.RemoveAt(itemIndex);
            curCourse.LocationName = locationTF.Text;
            curCourse.SurfaceType = surfaceTF.Text.ToString();
            curCourse.Distance = Int32.Parse(distanceTF.Text);
            curCourse.Units = unitsTF.Text.ToString();
            curCourse.Handicap = bool.Parse(handicapTF.Text);
            curCourse.HandicapBuffer = handicapFTF.Text.ToString();
            curCourse.HandicapCutOff = handicapCTF.Text.ToString();
            curCourse.IsRelay = bool.Parse(relayTF.Text);
            AppData.offlineLocationList[AppData.curLocIndex].courses.Insert(itemIndex, curCourse);
            UIAlertController alertController;
            alertController = UIAlertController.Create("Saved", "Successfully saved", UIAlertControllerStyle.Alert);
            alertController.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Cancel, null));
            PresentViewController(alertController, true, null);
        }
    }
}