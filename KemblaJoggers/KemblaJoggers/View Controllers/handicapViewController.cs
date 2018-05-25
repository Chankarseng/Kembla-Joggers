using Foundation;
using System;
using UIKit;
using KemblaJoggers.Classes;
namespace KemblaJoggers
{
    public partial class handicapViewController : UIViewController
    {
        public handicapViewController (IntPtr handle) : base (handle)
        {
        }
        HandicapDataSource handicapDs;
		public override void ViewDidLoad()
		{
            base.ViewDidLoad();
            //PrepareContactFirstList.Prepare();
			handicapDs = new HandicapDataSource(this);
            handicapTimeTableView.Source = handicapDs;
            handicapSearchBar.TextChanged += (sender, e) =>
            {
                //this is the method that is called when the user searches  
                searchTable();
            };
            handicapSearchBar.SelectedScopeButtonIndexChanged += (sender, e) =>
            {
                searchTable();
            };
        }
		private void searchTable()  
		{  
			//perform the search, and refresh the table with the results  
            handicapDs.PerformSearch((int)handicapSearchBar.SelectedScopeButtonIndex, handicapSearchBar.Text);  
            handicapTimeTableView.ReloadData();  
		}  
    }

}