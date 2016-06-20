using Foundation;
using System;
using UIKit;
using CoreGraphics;

namespace ProcessDashboard.iOS
{
    public partial class HomePageViewController : UIViewController
    {
		public HomePageViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var ProjectNameLabel = new UILabel(new CGRect(30, 100, 300, 40))
			{
				Text = "/Project/Mobile App I1",
				Font = UIFont.SystemFontOfSize(16),
				TextColor = UIColor.Black,
				TextAlignment = UITextAlignment.Center,
				BackgroundColor = UIColor.LightGray,
				Lines = 0,
				LineBreakMode = UILineBreakMode.WordWrap,
			};

			// 
			var CurrentTaskLabel = new UILabel(new CGRect(30, 160, 100, 20))
			{
				Text = "Current Task:",
				Font = UIFont.SystemFontOfSize(12),
				TextColor = UIColor.Black,
				TextAlignment = UITextAlignment.Left,
				//BackgroundColor = UIColor.LightGray,
			};

			var startLabel = new UILabel(new CGRect(200, 160, 30, 20))
			{
				Text = "Start",
				Font = UIFont.SystemFontOfSize(12),
				TextColor = UIColor.Blue,
				//TextAlignment = UITextAlignment.Left,
				//BackgroundColor = UIColor.LightGray,
			};



			var stopLabel = new UILabel(new CGRect(230, 160, 30, 20))
			{
				Text = "Stop",
				Font = UIFont.SystemFontOfSize(12),
				TextColor = UIColor.Blue,
				//TextAlignment = UITextAlignment.Left,
				//BackgroundColor = UIColor.LightGray,
			};

			var checkLabel = new UILabel(new CGRect(260, 160, 30, 20))
			{
				Text = "Check",
				Font = UIFont.SystemFontOfSize(12),
				TextColor = UIColor.Blue,
				//TextAlignment = UITextAlignment.Left,
				//BackgroundColor = UIColor.LightGray,
			};

			//startButton = UIButton.FromType(UIButtonType.RoundedRect);
			//startButton.SetTitle("Start", UIControlState.Normal);
			//startButton.SetImage(UIImage.FromFile("start.png"), UIControlState.Normal);

			//var stopButton = new UIButton(new CGRect(250, 160, 300, 20));
			//stopButton = UIButton.FromType(UIButtonType.RoundedRect);
			//stopButton.SetTitle("Stop", UIControlState.Normal);
			//	//.SetImage(UIImage.FromFile("stop.png"), UIControlState.Normal);

			//var checkButton = new UIButton(new CGRect(300, 160, 300, 20));
			//checkButton = UIButton.FromType(UIButtonType.RoundedRect);
			//checkButton.SetTitle("Check", UIControlState.Normal);
			//	//.SetImage(UIImage.FromFile("check.png"), UIControlState.Normal);


			var CurrentTaskNameLabel = new UILabel(new CGRect(30, 190, 300, 60))
			{
				Text = "/Project/Mobile App I1/High Level Design Document/View Logic/UI experiment/Team Walkthrough",
				Font = UIFont.SystemFontOfSize(13),
				TextColor = UIColor.Black,
				TextAlignment = UITextAlignment.Center,
				BackgroundColor = UIColor.LightGray,
				Lines = 0,
				LineBreakMode = UILineBreakMode.WordWrap,
			};


			string[] tableItems = new string[] { "/Project/Mobile App I1/High Level Design Document/View Logic/UI experiment/Draft",
				"/Project/Mobile App I1/High Level Design Document/View Logic/UI experiment/Personal Review",
				"/Project/Mobile App I1/High Level Design Document/View Logic/UI experiment/Team Walkthrough",
				"/Project/Mobile App I1/High Level Design Document/View Logic/UI experiment/Refine",
				"/Project/Mobile App I1/High Level Design Document/View Logic/Task2/Publish", 
				"/Project/Mobile App I1/High Level Design Document/View Logic/Task3/Refine", 
				"/Project/Mobile App I1/High Level Design Document/View Logic/Task4/Draft", 
				"/Project/Mobile App I1/High Level Design Document/View Logic/Task3/Publish" };

			RecentTaskTable = new UITableView(new CGRect(0, 250, View.Bounds.Width, View.Bounds.Height));
			RecentTaskTable.Source = new TaskTableSource(tableItems,this);

			Add(RecentTaskTable);


			this.Add(ProjectNameLabel);
			this.Add(CurrentTaskLabel);
			this.Add(startLabel);
			this.Add(stopLabel);
			this.Add(checkLabel);
			this.Add(CurrentTaskNameLabel);


		}

		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			base.PrepareForSegue(segue, sender);

			// set the View Controller that’s powering the screen we’re
			// transitioning to
			if (segue.Identifier == "TaskDetailSegue")
			{
				var detailContoller = segue.DestinationViewController as TaskDetailViewController;
				var indexPath = (NSIndexPath)sender;
			}

		}
    }
}