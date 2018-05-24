using Foundation;
using System;
using UIKit;
using Firebase.Core;
using CoreLocation;
using System.Runtime.CompilerServices;
using MapKit;

namespace KemblaJoggers
{
    public partial class chooseLocationViewController : UIViewController
    {
        UISearchController searchController;

        void HandleCLGeocodeCompletionHandler(CLPlacemark[] placemarks, NSError error)
        {
            var placemark = placemarks[0];
            searchController.SearchBar.Text = placemark.Name;
        }

        bool setLocation = false;
        public chooseLocationViewController (IntPtr handle) : base (handle)
        {
        }
        CLLocationManager locationManager;
		public override void ViewDidLoad()
		{
            base.ViewDidLoad();
            var geocoder = new CLGeocoder();
            locationManager = new CLLocationManager();
            locationManager.RequestWhenInUseAuthorization();
            //locationManager.RequestLocation(); // Only should be called once
            locationMap.ShowsUserLocation = true;
            MKCoordinateRegion region;
            MKCoordinateSpan span;
            region.Center = locationMap.UserLocation.Coordinate;
            span.LatitudeDelta = 0.005;
            span.LongitudeDelta = 0.005;
            region.Span = span;
            locationMap.SetRegion(region, true);

            locationMap.MapType = MKMapType.Standard;
            var searchResultsController = new chooseLocationResultViewController(locationMap);

            var searchUpdater = new SearchResultsUpdator();
            searchUpdater.UpdateSearchResults += searchResultsController.Search;

            //add the search controller
            searchController = new UISearchController(searchResultsController)
            {
                SearchResultsUpdater = searchUpdater
            };

            searchController.SearchBar.SizeToFit();
            searchController.SearchBar.SearchBarStyle = UISearchBarStyle.Prominent;
            searchController.SearchBar.Placeholder = "Enter a search query";
            searchController.HidesNavigationBarDuringPresentation = false;
            NavigationItem.TitleView = searchController.SearchBar;
            DefinesPresentationContext = true;


            // When the user wants to choose the location manually
            locationMap.RegionChanged += (sender,e) => 
            {
                if (setLocation == true)
                {            
                    var coordinate = locationMap.CenterCoordinate;
                    var coor = new CLLocation(coordinate.Latitude,coordinate.Longitude);
                    geocoder.ReverseGeocodeLocation(coor, HandleCLGeocodeCompletionHandler);
				}
            };

		}


        public class SearchResultsUpdator : UISearchResultsUpdating
        {
            public event Action<string> UpdateSearchResults = delegate { };

            public override void UpdateSearchResultsForSearchController(UISearchController searchController)
            {
                this.UpdateSearchResults(searchController.SearchBar.Text);
            }
        }



        partial void SetLocationButton_TouchUpInside(UIButton sender)
        {
            searchController.ResignFirstResponder();
            // If the user is not setting new location
            if (setLocation == false)
            {
                setLocationButton.SetTitle("Done", UIControlState.Normal);
                locationImage.Hidden = false;
            }
            // If the user is done setting the location
            else
            {
                setLocationButton.SetTitle("Set Location", UIControlState.Normal);
                locationImage.Hidden = true;
            }
            setLocation = !setLocation;
        }

        partial void ZoomToUserButton_TouchUpInside(UIButton sender)
        {
            searchController.ResignFirstResponder();
            MKCoordinateRegion region;
            MKCoordinateSpan span;
            region.Center = locationMap.UserLocation.Coordinate;
            span.LatitudeDelta = 0.005;
            span.LongitudeDelta = 0.005;
            region.Span = span;
            locationMap.SetRegion(region, true);
        }

        public override void DidReceiveMemoryWarning()
		{
            base.DidReceiveMemoryWarning();
		}


	}
}