using System;
using Foundation;
using UIKit;
using Firebase.Core;
using System.Security.Policy;
using System.Collections.Generic;
using System.Linq;
using KemblaJoggers.Classes;
namespace KemblaJoggers
{
    public class CourseDataSource : UITableViewSource
    {
        public CourseDataSource()
        {
        }
        readonly UIViewController dataSourceController;
        List<CoursesClass> curCourses;
        public CourseDataSource(UIViewController inputControl, List<CoursesClass> courses)
        {
            curCourses = courses;
            dataSourceController = inputControl;
        }


        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell("course_id");
            CoursesClass thisList = curCourses[indexPath.Row];
            cell.TextLabel.Text = thisList.CourseName;
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return curCourses.Count;
        }

		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
            if (AppData.viewcontroller == 0)
            {
                dataSourceController.PerformSegue("toCourseSegue", indexPath);
                AppData.chooseCourse = true;
            }
            else if (AppData.viewcontroller == 1)
            {
                dataSourceController.PerformSegue("toTimeSegue", indexPath);
                AppData._curCourse = curCourses[indexPath.Row];
            }
		}
	}
}
