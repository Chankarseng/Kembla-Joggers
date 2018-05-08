using Foundation;
using System;
using UIKit;
using Firebase.Core;
using System.Collections.Generic;
using KemblaJoggers.Classes;

namespace KemblaJoggers
{
    public partial class checkResultViewController : UIViewController
    {
        
        public checkResultViewController (IntPtr handle) : base (handle)
        {
        }
        CoursesDataSource CoursesDs;
        private List<CoursesClass> courses = new List<CoursesClass>();
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            PrepareCourseFirstList.Prepare();
            PrepareContactFirstList.Prepare();
            CoursesDs = new CoursesDataSource(this);
            checkResultTableView.Source = CoursesDs;
            // For testing purporses
            dateTextField.Text = DateTime.UtcNow.ToShortDateString();
            categoryTextField.Text = AppData.offlineCourseList[0].CourseName;
            locationTextField.Text = AppData.offlineCourseList[0].LocationName;
            surfaceTypeTextField.Text = AppData.offlineCourseList[0].SurfaceType;
            distanceTextField.Text = AppData.offlineCourseList[0].Distance.ToString();
            unitTextField.Text = AppData.offlineCourseList[0].Units.ToString();
            handicapDetTextField.Text = AppData.offlineCourseList[0].Handicap.ToString();
            handicapFacTextField.Text = "-";
            handicapBufTextField.Text = "-";
            relayTextField.Text = "-";
            numLegsTextField.Text = AppData.offlineCourseList[0].NumberOfLegs.ToString();
        }

        partial void CommitButton_TouchUpInside(UIButton sender)
        {
            UIAlertView alertView = new UIAlertView();
            alertView.Title = "Commit";
            alertView.AddButton("Ok");
            alertView.Message = "Commit success.";
            alertView.Show();
        }
    }
}