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

			UIButton startButton, stopButton;
			UISwitch switchEnabled;

			startButton = UIButton.FromType(UIButtonType.RoundedRect);
			startButton.SetImage(UIImage.FromFile("start.png"), UIControlState.Normal);
			startButton.Frame = new CGRect(100, 255, 45, 42);
			startButton.TouchUpInside += (sender, e) =>
			{
				new UIAlertView("Notice"
					, "Start logging time!"
					, null
					, "OK"
					, null).Show();
			};
			stopButton = UIButton.FromType(UIButtonType.Custom);
			stopButton.SetImage(UIImage.FromFile("stop.png"), UIControlState.Normal);
			stopButton.Frame = new CGRect(170, 255, 45, 42);
			stopButton.TouchUpInside += (sender, e) =>
			{
				new UIAlertView("Notice"
					, "Stop logging time!"
					, null
					, "OK"
					, null).Show();
			};


			switchEnabled = new UISwitch(new CGRect(240, 260, 50, 30));
			switchEnabled.ValueChanged += (sender, e) =>
			{
				new UIAlertView("Notice"
					, "This task marks as completed!"
					, null
					, "OK"
					, null).Show();
			};
			switchEnabled.On = true;


			string[] tableItems = new string[] { "/Project/Mobile App I1/High Level Design Document/View Logic/UI experiment/Draft",
				"/Project/Mobile App I1/High Level Design Document/View Logic/UI experiment/Personal Review",
				"/Project/Mobile App I1/High Level Design Document/View Logic/UI experiment/Team Walkthrough",
				"/Project/Mobile App I1/High Level Design Document/View Logic/UI experiment/Refine",
				"/Project/Mobile App I1/High Level Design Document/View Logic/Task2/Publish", 
				"/Project/Mobile App I1/High Level Design Document/View Logic/Task3/Refine", 
				"/Project/Mobile App I1/High Level Design Document/View Logic/Task4/Draft", 
				"/Project/Mobile App I1/High Level Design Document/View Logic/Task3/Publish",
				"/Project/Mobile App I1/High Level Design Document/View Logic/Task3/Publish",
				"/Project/Mobile App I1/High Level Design Document/View Logic/Task3/Publish",
				"/Project/Mobile App I1/High Level Design Document/View Logic/Task3/Publish"};

			RecentTaskTable = new UITableView(new CGRect(25, 300, View.Bounds.Width - 50, View.Bounds.Height - 300 ));
			RecentTaskTable.Source = new TaskTableSource(tableItems,this);

			Add(RecentTaskTable);

		
			View.AddSubview(startButton);
			View.AddSubview(stopButton);
			View.AddSubview(switchEnabled);
			this.Add(ProjectNameLabel);
			this.Add(CurrentTaskLabel);
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