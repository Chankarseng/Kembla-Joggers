using Foundation;
using System;
using UIKit;
using KemblaJoggers.Classes;
using System.Collections.Generic;

namespace KemblaJoggers
{
    public partial class courseManagementChooseViewController : UIViewController
    {
        CourseDataSource courseDs;
        LocationDataSource locationDs;
        List<CoursesClass> curCourse;
        public courseManagementChooseViewController(IntPtr handle) : base(handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            AppData.viewcontroller = 0;
            AppData.chooseCourse = false;
            locationDs = new LocationDataSource(this);
            locationTableView.Source = locationDs;
            locationTableView.ReloadData();
            courseTableView.ReloadData();
        }
        public void SetTask(courseManagementChooseViewController d, List<CoursesClass> courses)
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
            if (AppData.chooseCourse == false)
            {
                NSIndexPath senderIndexPath = (NSIndexPath)sender;
                var itemsViewCtrl = segue.DestinationViewController as courseManagementViewController;
                itemsViewCtrl.curCourse = curCourse[senderIndexPath.Row];
            }
        }

        partial void AddLocationButton_TouchUpInside(UIButton sender)
        {
            //PerformSegue("toLocationSegue", this);
        }
    }
}