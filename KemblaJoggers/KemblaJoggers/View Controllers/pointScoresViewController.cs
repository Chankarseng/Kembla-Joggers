using Foundation;
using System;
using UIKit;

namespace KemblaJoggers
{
    public partial class pointScoresViewController : UIViewController
    {
        public pointScoresViewController (IntPtr handle) : base (handle)
        {
        }
        pointScoreDataSource pointscoreDS;
		public override void ViewDidLoad()
		{
            base.ViewDidLoad();
            pointscoreDS = new pointScoreDataSource(this);
            pointScoreTableView.Source = pointscoreDS;

            pointScoreSearchBar.TextChanged += (sender, e) =>
            {
                searchTable();
            };
		}

        private void searchTable()
        {
            pointscoreDS.searchTable(pointScoreSearchBar.Text);
            pointScoreTableView.ReloadData();
        }

    }
}