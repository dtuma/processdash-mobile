using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace ProcessDashboard.iOS
{
    public partial class ProjectsPageViewController : UITableViewController
    {
        public ProjectsPageViewController (IntPtr handle) : base (handle)
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

			string[] tableItems = new string[] { "/Project/Mobile App I1",
				"/Project/Mobile App I2",
				"/Project/Mobile App I3",
				"/Project/Mobile App I4",
				"/Project/Mobile App I5" };
			
			ProjectsTable = new UITableView(new CGRect(0, 0, View.Bounds.Width, View.Bounds.Height));
			ProjectsTable.Source = new ProjectsTableSource(tableItems);

			Add(ProjectsTable);

			// Perform any additional setup after loading the view, typically from a nib.
		}
	}
    
}