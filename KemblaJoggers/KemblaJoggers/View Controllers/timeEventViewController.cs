using Foundation;
using System;
using UIKit;
using System.Timers;
using System.Diagnostics;
using Firebase.Core;
using System.Xml;
using CoreGraphics;
using KemblaJoggers.Classes;
namespace KemblaJoggers
{
    public partial class timeEventViewController : UIViewController
    {
        public timeEventViewController (IntPtr handle) : base (handle)
        {
        }
        Stopwatch stopwatch = new Stopwatch();
        Timer stopTimer = new Timer();
        string[] lapTime = new string[1000];

		public override void ViewDidLoad()
		{
            base.ViewDidLoad();
            AppData.index = 0;
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
                    stopwatch.Start();
                    stopTimer.Enabled = true;
                    startButton.SetTitle("Stop", UIControlState.Normal);
                }
                else
                {
                    lapButton.SetTitle("Reset", UIControlState.Normal);
                    stopTimer.Enabled = false;
                    stopwatch.Stop();
                    startButton.SetTitle("Start", UIControlState.Normal);
                }
            };


            lapButton.TouchUpInside += (sender, e) =>
            {
                // lap button title is set to "Lap"
                if (startButton.TitleLabel.Text == "Stop")
                {
                    lapTime[AppData.index] = stopwatch.Elapsed.ToString(@"hh\:mm\:ss\:ff");
                    AppData.currentRaceLapTime = lapTime;
                    AppData.index++;
                    lapTimings.Source = new LapDataSource(AppData.currentRaceLapTime,AppData.index);
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
                    stopwatch.Reset();
                    stopwatch.Stop();
                    lapTimings.Source = null;
                    AppData.index = 0;
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
                timerLabel.Text = stopwatch.Elapsed.ToString(@"hh\:mm\:ss\:ff");
            });
        }
	}
}