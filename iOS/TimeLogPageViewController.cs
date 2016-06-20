using System;
using System.Drawing;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace ProcessDashboard.iOS
{
    public partial class TimeLogPageViewController : UITableViewController
    {



        public TimeLogPageViewController (IntPtr handle) : base (handle)
        {
        }

		public override void DidReceiveMemoryWarning()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning();

			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();


			TimelogsTable = new UITableView(View.Bounds, UITableViewStyle.Grouped);
		    TimelogsTable.AutoresizingMask = UIViewAutoresizing.All;
			CreateTableItems();
			Add(TimelogsTable);
		}



		protected void CreateTableItems()
		{
			List<TimelogTableItem> veges = new List<TimelogTableItem>();

			//var lines = File.ReadLines("VegeData2");
			//foreach (var line in lines)
			//{
				//var vege = line.Split(',');
		    var vege1 = new string[] { "2016-06-01",".../View Logic/UI experiment/Personal Review"};
			veges.Add(new TimelogTableItem(vege1[1]) { SubHeading = vege1[0] });

			var vege2 = new string[] { "2016-06-01", ".../View Logic/UI experiment/Team Review" };
			veges.Add(new TimelogTableItem(vege2[1]) { SubHeading = vege2[0] });

			var vege3 = new string[] { "2016-06-01", ".../View Logic/UI experiment/Refine Document" };
			veges.Add(new TimelogTableItem(vege3[1]) { SubHeading = vege3[0] });

			var vege4 = new string[] { "2016-06-02", ".../View Logic/UI experiment/Personal Review" };
			veges.Add(new TimelogTableItem(vege4[1]) { SubHeading = vege4[0] });

			var vege5 = new string[] { "2016-06-02", ".../View Logic/UI experiment/Team Review" };
			veges.Add(new TimelogTableItem(vege5[1]) { SubHeading = vege5[0] });

			var vege6 = new string[] { "2016-06-03", ".../View Logic/UI experiment/Refine Document" };
			veges.Add(new TimelogTableItem(vege6[1]) { SubHeading = vege6[0] });


			//}

			TimelogsTable.Source = new TimelogTableSource(veges, this);

		}


		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			base.PrepareForSegue(segue, sender);

			// set the View Controller that’s powering the screen we’re
			// transitioning to
			if (segue.Identifier == "detailSegue")
			{

				var detailContoller = segue.DestinationViewController as TimelogDetailViewController;
			    var indexPath = (NSIndexPath)sender;
				//detailContoller.Title = this.TimelogsTable [indexPath.Row];
			}

		}

		#region View lifecycle


		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
		}

		public override void ViewDidAppear(bool animated)
		{
			base.ViewDidAppear(animated);
		}

		public override void ViewWillDisappear(bool animated)
		{
			base.ViewWillDisappear(animated);
		}

		public override void ViewDidDisappear(bool animated)
		{
			base.ViewDidDisappear(animated);
		}

		#endregion

	}

}