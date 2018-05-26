using Foundation;
using System;
using UIKit;
using System.Timers;
using System.Diagnostics;
using Firebase.Core;
using System.Xml;
using CoreGraphics;
using KemblaJoggers.Classes;
using System.Security.Cryptography;

namespace KemblaJoggers
{
    public partial class timeEventViewController : UIViewController
    {
        public timeEventViewController (IntPtr handle) : base (handle)
        {
        }
        Timer stopTimer = new Timer();
        // When race is over
        partial void DoneButton_TouchUpInside(UIButton sender)
        {
            AppData.index = AppData.i;
            AppData.currentRaceLapTime = AppData.lapTime;
            AppData.offlineRaceResultList.Add(new RaceResultClass
            {
                raceid = new Random().Next(0,217431234).ToString(),
                date = DateTime.UtcNow,
                location_name = AppData._curLoc.locationName,
                course_name = AppData._curCourse.CourseName,
                raceContacts = AppData.offlineContactList,
                raceTimings = AppData.currentRaceLapTime
            });
            UIAlertView alertView = new UIAlertView();
            alertView.Title = "Done";
            alertView.AddButton("Ok");
            alertView.Message = "Race time has been saved";
            alertView.Show();
            //throw new NotImplementedException();
        }

        public override void ViewDidLoad()
		{
            base.ViewDidLoad();
            raceNameLabel.Text = AppData._curLoc.locationName + " , " + AppData._curCourse.CourseName;
            timerLabel.Text = AppData.currentTime;
            lapTimings.Source = new LapDataSource(AppData.lapTime, AppData.i);
            startButton.Layer.CornerRadius = 75;
            startButton.Layer.BorderWidth = 2;
            startButton.Layer.BorderColor = UIColor.White.CGColor;
            startButton.Layer.BackgroundColor = UIColor.Red.CGColor;
            lapButton.Layer.CornerRadius = 75;
            lapButton.Layer.BorderWidth = 2;
            lapButton.SetTitleColor(UIColor.DarkGray, UIControlState.Normal);
            lapButton.Layer.BorderColor = UIColor.DarkGray.CGColor;
            lapButton.Layer.BackgroundColor = UIColor.Red.CGColor;
            startButton.ClipsToBounds = true;
            if (AppData.currentTime != "00:00:00:00")
            {
                lapButton.SetTitle("Reset", UIControlState.Normal);
                stopTimer.Enabled = false;
                lapButton.Enabled = true;
                lapButton.SetTitleColor(UIColor.White, UIControlState.Normal);
                lapButton.Layer.BorderColor = UIColor.White.CGColor;
            }
            startButton.TouchUpInside += (sender, e) =>
            {
                if (startButton.TitleLabel.Text == "Start")
                {
                    lapButton.SetTitle("Lap", UIControlState.Normal);
                    lapButton.SetTitleColor(UIColor.White, UIControlState.Normal);
                    lapButton.Layer.BorderColor = UIColor.White.CGColor;
                    lapButton.Enabled = true;
                    stopTimer.Interval = 10;
                    stopTimer.Elapsed += new ElapsedEventHandler(OnElapasedTimer);
                    AppData.stopwatch.Start();
                    stopTimer.Enabled = true;
                    startButton.SetTitle("Stop", UIControlState.Normal);
                }
                else
                {
                    lapButton.SetTitle("Reset", UIControlState.Normal);
                    stopTimer.Enabled = false;
                    AppData.stopwatch.Stop();
                    startButton.SetTitle("Start", UIControlState.Normal);
                }
            };


            lapButton.TouchUpInside += (sender, e) =>
            {
                // lap button title is set to "Lap"
                if (startButton.TitleLabel.Text == "Stop")
                {
                    AppData.lapTime[AppData.i] = AppData.stopwatch.Elapsed.ToString(@"hh\:mm\:ss\:ff");
                    //AppData.currentRaceLapTime = lapTime;
                    AppData.i++;
                    lapTimings.Source = new LapDataSource(AppData.lapTime,AppData.i);
                }
                // lap button title is set to "Reset"
                else if (startButton.TitleLabel.Text == "Start")
                {
                    lapButton.SetTitle("Lap", UIControlState.Normal);
                    lapButton.SetTitleColor(UIColor.DarkGray, UIControlState.Normal);
                    lapButton.Layer.BorderColor = UIColor.DarkGray.CGColor;
                    lapButton.Enabled = false;
                    InvokeOnMainThread(() =>
                    {
                        timerLabel.Text = "00:00:00:00";
                    });
                    AppData.stopwatch.Reset();
                    AppData.stopwatch.Stop();
                    lapTimings.Source = null;
                    AppData.i = 0;
                }
                lapTimings.ReloadData();
                // Take the elapsed time.
                //lapTimings.Source = null;
                //lapTime[index] = stopwatch.Elapsed.ToString(@"hh\:mm\:ss\:ff");
                //index++;
                //lapTimings.Source = new LapDataSource(lapTime);
                //string time = stopwatch.Elapsed.ToString(@"hh\:mm\:ss\:ff");
                // insert time in a new cell in UITableView
            };

		}
        private void OnElapasedTimer(object sender, ElapsedEventArgs e)
        {
            InvokeOnMainThread(() =>
            {
                timerLabel.Text = AppData.stopwatch.Elapsed.ToString(@"hh\:mm\:ss\:ff");
                AppData.currentTime = AppData.stopwatch.Elapsed.ToString(@"hh\:mm\:ss\:ff");
            });
        }
	}
}