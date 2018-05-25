using Foundation;
using System;
using UIKit;
using Firebase.Core;
using System.Collections.Generic;
using KemblaJoggers.Classes;
using CoreImage;

namespace KemblaJoggers
{
    public partial class checkResultViewController : UIViewController
    {
        
        public checkResultViewController (IntPtr handle) : base (handle)
        {
        }
        checkResultDataSource resultDs;
        private List<CoursesClass> courses = new List<CoursesClass>();
        
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            //PrepareCourseFirstList.Prepare();
            //PrepareContactFirstList.Prepare();
            resultDs = new checkResultDataSource(this);
            checkResultTableView.Source = resultDs;
            // For testing purporses
            dateTextField.Text = DateTime.UtcNow.ToShortDateString();
            if (AppData._curCourse != null)
            {
                categoryTextField.Text = AppData._curCourse.CourseName;
                locationTextField.Text = AppData._curCourse.LocationName;
                surfaceTypeTextField.Text = AppData._curCourse.SurfaceType;
                distanceTextField.Text = AppData._curCourse.Distance.ToString();
                unitTextField.Text = AppData._curCourse.Units;
                handicapDetTextField.Text = AppData._curCourse.Handicap.ToString();
                handicapFacTextField.Text = AppData._curCourse.HandicapCutOff;
                handicapBufTextField.Text = AppData._curCourse.HandicapBuffer;
                relayTextField.Text = AppData._curCourse.IsRelay.ToString();
                numLegsTextField.Text = AppData._curCourse.NumberOfLegs.ToString();
            }
            /*categoryTextField.Text = AppData.offlineCourseList[0].CourseName;
            locationTextField.Text = AppData.offlineCourseList[0].LocationName;
            surfaceTypeTextField.Text = AppData.offlineCourseList[0].SurfaceType;
            distanceTextField.Text = AppData.offlineCourseList[0].Distance.ToString();
            unitTextField.Text = AppData.offlineCourseList[0].Units.ToString();
            handicapDetTextField.Text = AppData.offlineCourseList[0].Handicap.ToString();
            handicapFacTextField.Text = "-";
            handicapBufTextField.Text = "-";
            relayTextField.Text = "-";
            numLegsTextField.Text = AppData.offlineCourseList[0].NumberOfLegs.ToString();*/
            changeColor(UIColor.LightGray);
        }

        partial void CommitButton_TouchUpInside(UIButton sender)
        {
            UIAlertView alertView = new UIAlertView();
            alertView.Title = "Commit";
            alertView.AddButton("Ok");
            alertView.Message = "Commit success.";
            alertView.Show();
        }

        partial void ResultEditButton_TouchUpInside(UIButton sender)
        {
            if (resultEditButton.TitleLabel.Text == "Edit")
            {
                resultEditButton.SetTitle("Save",UIControlState.Normal);
                changeColor(UIColor.Black);
                changeEditStatus(true);
            }
            else if (resultEditButton.TitleLabel.Text == "Save")
            {
                resultEditButton.SetTitle("Edit", UIControlState.Normal);
                changeColor(UIColor.LightGray);
                changeEditStatus(false);
            }
        }
        private void changeColor(UIColor color)
        {
            dateTextField.TextColor = color;
            categoryTextField.TextColor = color;
            locationTextField.TextColor = color;
            surfaceTypeTextField.TextColor = color;
            distanceTextField.TextColor = color;
            unitTextField.TextColor = color;
            handicapDetTextField.TextColor = color;
            handicapFacTextField.TextColor = color;
            handicapBufTextField.TextColor = color;
            relayTextField.TextColor = color;
            numLegsTextField.TextColor = color;
        }
        private void changeEditStatus(bool status)
        {
            dateTextField.Enabled = status;
            categoryTextField.Enabled = status;
            locationTextField.Enabled = status;
            surfaceTypeTextField.Enabled = status;
            distanceTextField.Enabled = status;
            unitTextField.Enabled = status;
            handicapDetTextField.Enabled = status;
            handicapFacTextField.Enabled = status;
            handicapBufTextField.Enabled = status;
            relayTextField.Enabled = status;
            numLegsTextField.Enabled = status;
        }
    }
}