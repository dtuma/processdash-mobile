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

		    var vege1 = new string[] { "2016-06-01","/ Project / Mobile App I1 / High Level Design Document / View Logic / UI experiment / Personal Review","11:00:02 AM", "3:01"};
			veges.Add(new TimelogTableItem(vege1[1]) { SubHeading = vege1[0], StartTime = vege1[2], Delta = vege1[3]});

			var vege2 = new string[] { "2016-06-01", "/ Project / Mobile App I1 / High Level Design Document / View Logic/ UI experiment / Team Review","3:00:02 PM", "1:20" };
			veges.Add(new TimelogTableItem(vege2[1]) { SubHeading = vege2[0], StartTime = vege2[2], Delta = vege2[3] });

			var vege3 = new string[] { "2016-06-01", "/ Project / Mobile App I1 / High Level Design Document / View Logic / UI experiment / Refine Document","7:00:02 PM", "2:31" };
			veges.Add(new TimelogTableItem(vege3[1]) { SubHeading = vege3[0],StartTime = vege3[2], Delta = vege3[3] });

			var vege4 = new string[] { "2016-06-02", " / Project / Mobile App I1 / High Level Design Document / View Logic / UI experiment / Personal Review","11:20:02 AM", "2:32" };
			veges.Add(new TimelogTableItem(vege4[1]) { SubHeading = vege4[0],StartTime = vege4[2], Delta = vege4[3] });

			var vege5 = new string[] { "2016-06-02", "/ Project / Mobile App I1 / High Level Design Document / View Logic / UI experiment / Team Review","3:00:02 PM", "1:00" };
			veges.Add(new TimelogTableItem(vege5[1]) { SubHeading = vege5[0],StartTime = vege5[2], Delta = vege5[3] });

			var vege6 = new string[] { "2016-06-03", "/ Project / Mobile App I1 / High Level Design Document / View Logic / UI experiment / Refine Document","3:24:02 PM", "1:21" };
			veges.Add(new TimelogTableItem(vege6[1]) { SubHeading = vege6[0],StartTime = vege6[2], Delta = vege6[3] });

			var vege7 = new string[] { "2016-06-04", "/ Project / Mobile App I1 / High Level Design Document / View Logic / UI experiment / Refine Document", "1:30:02 PM", "0:28" };
			veges.Add(new TimelogTableItem(vege6[1]) { SubHeading = vege7[0], StartTime = vege7[2], Delta = vege7[3] });

			var vege8 = new string[] { "2016-06-04", "/ Project / Mobile App I1 / High Level Design Document / View Logic / UI experiment / Refine Document", "11:10:02 PM", "0:31" };
			veges.Add(new TimelogTableItem(vege6[1]) { SubHeading = vege8[0], StartTime = vege8[2], Delta = vege8[3] });

			var vege9 = new string[] { "2016-06-05", "/ Project / Mobile App I1 / High Level Design Document / View Logic / UI experiment / Refine Document", "12:11:02 PM", "0:21" };
			veges.Add(new TimelogTableItem(vege6[1]) { SubHeading = vege9[0], StartTime = vege9[2], Delta = vege9[3] });

			var vege10 = new string[] { "2016-06-06", "/ Project / Mobile App I1 / High Level Design Document / View Logic / UI experiment / Refine Document", "5:11:02 PM", "0:49" };
			veges.Add(new TimelogTableItem(vege6[1]) { SubHeading = vege10[0], StartTime = vege10[2], Delta = vege10[3] });

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


	}

}