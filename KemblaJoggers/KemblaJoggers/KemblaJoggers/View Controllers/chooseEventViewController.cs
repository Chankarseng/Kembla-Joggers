using Foundation;
using System;
using System.Collections.Generic;
using UIKit;
using KemblaJoggers.Classes;

namespace KemblaJoggers
{
    public partial class chooseEventViewController : UIViewController
    {
        public chooseEventViewController (IntPtr handle) : base (handle)
        {
            
        }
        public static bool eventLoaded;
        CourseDataSource courseDs;
        LocationDataSource locationDs;
        List<CoursesClass> curCourse;
		public override void ViewDidLoad()
		{
            base.ViewDidLoad();
            AppData.viewcontroller = 1;
            locationDs = new LocationDataSource(this);
            locationTableView.Source = locationDs;
            locationTableView.ReloadData();
            courseTableView.ReloadData();
            if (eventLoaded == true)
            {
                timeEventButton.Hidden = false;
            }
		}

        public void SetTask(chooseEventViewController d, List<CoursesClass> courses)
        {
            curCourse = courses;
            courseDs = new CourseDataSource(this, courses);
            courseTableView.Source = courseDs;
            locationTableView.ReloadData();
            courseTableView.ReloadData();
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);
            eventLoaded = true;
        }

        partial void TimeEventButton_TouchUpInside(UIButton sender)
        {
            PerformSegue("toTimeSegue",this);
        }
    }
}