using CoreGraphics;
using Foundation;
using System;
using System.Drawing;
using UIKit;

namespace KemblaJoggers
{
    public partial class filterRaceViewController : UIViewController
    {
        filterRaceDataSource filterDs; // Contacts Data source
        public filterRaceViewController(IntPtr handle) : base(handle)
        {
        }
        UIDatePicker dpRangeDate = new UIDatePicker(RectangleF.Empty);
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            filterDs = new filterRaceDataSource(this);
            string[] tableItems = new string[] { "Winter", "Summer", "Track", "Relay" };
            filterRaceTableView.Source = new filterRaceDataSource(tableItems);

            // For Year textfield picker
            UIToolbar toolBar = new UIToolbar(new CGRect(0, 0, 320, 44));
            UIBarButtonItem flexibleSpaceLeft = new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace, null, null);
            UIBarButtonItem doneButton = new UIBarButtonItem("OK", UIBarButtonItemStyle.Done, this, new ObjCRuntime.Selector("DoneAction"));
            UIBarButtonItem[] list = new UIBarButtonItem[] { flexibleSpaceLeft, doneButton };
            toolBar.SetItems(list, false);


            dpRangeDate.Mode = UIDatePickerMode.Date;
            dpRangeDate.MaximumDate = NSDate.Now;
            dpRangeDate.TimeZone = NSTimeZone.LocalTimeZone;
            dpRangeDate.UserInteractionEnabled = true;
            //rangeDateActSheet.AddSubview(dpRangeDate);

            /*UIPickerView pickerView = new UIPickerView(new CGRect(0, 44, 320, 216));
            pickerView.Model = new PeopleModel(filterYearTextField);
            pickerView.Delegate = pickerView.Delegate;
            pickerView.ShowSelectionIndicator = false;*/

            filterDateTextField.InputAccessoryView = toolBar;
            filterDateTextField.InputView = dpRangeDate;
        }

        [Export("DoneAction")]
        private void DoneAction()
        {
            Console.WriteLine("Your Action!");
            filterDateTextField.ResignFirstResponder();
            NSDateFormatter dateFormat = new NSDateFormatter();
            dateFormat.DateFormat = "dd-MM-yyyy";
            filterDateTextField.Text = dateFormat.ToString(dpRangeDate.Date);
        }


        /*public class PeopleModel : UIPickerViewModel
        {
            public string[] names = new string[] {
                "Amy Burns",
                "Kevin Mullins",
                "Craig Dunn",
                "Joel Martinez",
                "Charles Petzold",
                "David Britch",
                "Mark McLemore",
                "Tom Opegenorth",
                "Joseph Hill",
                "Miguel De Icaza"
            };

            private UITextField personLabel;

            public PeopleModel(UITextField personLabel)
            {
                this.personLabel = personLabel;
            }

            public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
            {
                return names.Length;
            }

            public override string GetTitle(UIPickerView pickerView, nint row, nint component)
            {
                if (component == 0)
                    return names[row];
                else
                    return row.ToString();
            }

            public override void Selected(UIPickerView pickerView, nint row, nint component)
            {

                personLabel.Text = $"This person is: {names[pickerView.SelectedRowInComponent(0)]},\n they are number {pickerView.SelectedRowInComponent(1)}";
            }

            public override nfloat GetComponentWidth(UIPickerView picker, nint component)
            {
                if (component == 0)
                    return 240f;
                else
                    return 40f;
            }

            public override nfloat GetRowHeight(UIPickerView picker, nint component)
            {
                return 40f;
            }
        }*/
    }
}